'Importar modulos del driver de Oracle
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types
Module Modulo1
    'Connection string
    Public Const oradb = "DATA SOURCE=localhost:1521/xe;PASSWORD=05c28r92;USER ID=ELCARLOS"
    'Variable donde se almacena el usuario activo
    Public user As String
End Module
