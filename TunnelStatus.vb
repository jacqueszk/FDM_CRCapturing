Imports System.Data.SqlClient

Module TunnelStatus

    Public str As String = GetConString()
    Public con As New SqlConnection(str)

    Public cmd As SqlCommand
    Public cmd2 As SqlCommand
    Public cmd3 As SqlCommand
    Public cmd4 As SqlCommand
    Public cmd5 As SqlCommand

    Public da As SqlDataAdapter
    Public da2 As SqlDataAdapter
    Public da3 As SqlDataAdapter
    Public da4 As SqlDataAdapter
    Public da5 As SqlDataAdapter

    Public ds As DataSet
    Public ds2 As DataSet
    Public ds3 As DataSet
    Public ds5 As DataSet

    Public bs As BindingSource

    Public qry As String
    Public qry2 As String
    Public qry3 As String
    Public qry4 As String
    Public qry5 As String

    Public Function GetConString() As String
        Return "Data Source=dat-ser-sql-01.petragroup.local;" &
                       "Initial Catalog=BussImprovement;" &
                       "User ID=BussI;" &
                       "Password=BussI;" &
                       "Trusted_Connection=No;"

    End Function

End Module
