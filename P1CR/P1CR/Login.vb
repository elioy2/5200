Public Class Login
    'Declaración de variables públicas
    Dim p As Integer = 0
    Dim sqlStr2 As String


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Variables
        Dim table As New DataTable
        Dim sqlStr As String
        Dim userv As String
        Dim passv As String
        Dim statusv As Integer
        'Query para seleccionar datos del usuario
        sqlStr = "Select  USERID, password, status, FIRST_NAME, LAST_NAME from S_EMP where USERID='" + txtuser.Text + "'"
        Try
            'Declaro connection string
            Dim connectionString As String = oradb
            'Data adapter que ejecutará el query
            Dim dataAdapter As New Oracle.ManagedDataAccess.Client.OracleDataAdapter(sqlStr, connectionString)
            'Paso el data adapter al command builder
            Dim commandbuilder As New Oracle.ManagedDataAccess.Client.OracleCommandBuilder(dataAdapter)
            'Lleno datatable con datos del data adapter
            dataAdapter.Fill(table)



            'Si el usuario existe y tiene menos de 3 intentos ejecuto
            If table.Rows.Count > 0 And p <= 3 Then
                'Asigno el usuario, password, status y nombre a variables
                userv = table.Rows(0).ItemArray(0).ToString()
                passv = table.Rows(0).ItemArray(1).ToString()
                statusv = table.Rows(0).ItemArray(2)
                user = table.Rows(0).ItemArray(3).ToString() & " " & table.Rows(0).ItemArray(4).ToString()

                'Si el usuario existe ejecuto
                If txtuser.Text = userv Then
                    'Si el usuario esta activo ejecuto
                    If statusv = "1" Then
                        'Le añado un intento al usuario
                        p += 1
                        'Si la contraseña es la correcta ejectuo y muestro que el login fue exitoso
                        If txtpass.Text = passv Then
                            MessageBox.Show("¡Login exitoso!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MainForm.Show()
                            Me.Close()

                        Else
                            'Si la contraseña está incorrecta, devolver error
                            MessageBox.Show("Contraseña incorrecta")
                        End If
                    Else
                        'Si status = 0, devolver error
                        MessageBox.Show("Esta cuenta se encuentra inactiva")
                    End If
                Else
                    'Si el usuario no existe, devolver error
                    MessageBox.Show("Este usuario no existe")
                End If

            Else

                MessageBox.Show("Este usuario no existe =(")
            End If

            'Si el usuario llega a sus 3 intentos, desactivo la cuenta
            If p = 3 Then
                Dim conn As New Oracle.ManagedDataAccess.Client.OracleConnection(oradb)
                conn.Open()
                Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.Connection = conn
                cmd.CommandText = "UPDATE S_EMP SET STATUS = 0 WHERE USERID ='" + txtuser.Text + "'"
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                conn.Dispose()
                MessageBox.Show("Ha sobrepasado los intentos permitidos, su cuenta ha sido desactivada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            End If
        Catch ex As DataException
            MessageBox.Show("La base de datos no se encuentra disponible")
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'Cerrar
        Me.Close()
    End Sub

End Class
