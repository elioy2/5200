Public Class Login

    Dim p As Integer = 0
    Dim sqlStr2 As String
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim table As New DataTable
        Dim sqlStr As String
        Dim userv As String
        Dim passv As String

        sqlStr = "Select  USERID, password from S_EMP where USERID='" + txtuser.Text.Trim + "'"
        Dim connectionString As String = oradb
        'Dim connectionString As New Oracle.ManagedDataAccess.Client.OracleConnection(oradb)
        'connectionString.Open()
        Dim dataAdapter As New Oracle.ManagedDataAccess.Client.OracleDataAdapter(sqlStr, connectionString)
        Dim commandbuilder As New Oracle.ManagedDataAccess.Client.OracleCommandBuilder(dataAdapter)
        dataAdapter.Fill(table)



        If table.Rows.Count > 0 And p <= 3 Then
            userv = table.Rows(0).ItemArray(0).ToString()
            passv = table.Rows(0).ItemArray(1).ToString()

            'Validar los 3 intentos


            If txtpass.Text = passv And txtuser.Text = userv Then
                MessageBox.Show("SE fue por el 2")
                MainForm.Show()
            Else
                p += 1
                MessageBox.Show("Tas en la soquiiii")
            End If

        Else

            p += 1
            MessageBox.Show("Tas en la soquiiii")
        End If

        If p = 3 Then
            Dim conn As New Oracle.ManagedDataAccess.Client.OracleConnection
            conn.ConnectionString = "DATA SOURCE=LAPTOP-ND4K7KG8:1521/xe;PASSWORD=asdf;USER ID=ELCARLOS"
            conn.Open()


            Dim da As Oracle.ManagedDataAccess.Client.OracleDataAdapter = New Oracle.ManagedDataAccess.Client.OracleDataAdapter
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE S_EMP SET STATUS = 0 WHERE USERID ='" + txtuser.Text + "'"
            da.UpdateCommand = cmd
            da.Dispose()
            conn.Close()
            MessageBox.Show("Bye")
            Me.Close()
        End If
        'DataGridView1.DataSource = table
        'LAPTOP-ND4K7KG8 conn string = 
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
