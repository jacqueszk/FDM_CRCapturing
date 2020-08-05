Imports System.Data.SqlClient

Module TunnelStatus

    Public str As String = GetConString()
    Public con As New SqlConnection(str)
    Public cmd As SqlCommand
    Public cmd2 As SqlCommand
    Public da As SqlDataAdapter
    Public da2 As SqlDataAdapter
    Public ds As DataSet
    Public bs As BindingSource
    Public qry As String
    Public qry2 As String

    Public Function GetConString() As String
        Return "Data Source=dat-ser-sql-01.petragroup.local;" &
                       "Initial Catalog=BussImprovement;" &
                       "User ID=BussI;" &
                       "Password=BussI;" &
                       "Trusted_Connection=No;"

    End Function


End Module
