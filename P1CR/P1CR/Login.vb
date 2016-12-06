Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        MainForm.Show()
        Dim table As New DataTable
        Dim sqlStr As String
        sqlStr = "Select * FROM S_EMP"
        Dim connectionString As String = oradb
        Dim dataAdapter As New Oracle.ManagedDataAccess.Client.OracleDataAdapter(sqlStr, connectionString)
        Dim commandBuilder As New Oracle.ManagedDataAccess.Client.OracleCommandBuilder(dataAdapter)
        dataAdapter.Fill(table)
        dataAdapter.Dispose()
        'DataGridView1.DataSource = table
        'LAPTOP-ND4K7KG8 conn string = 
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
