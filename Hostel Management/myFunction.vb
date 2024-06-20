Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text



Namespace HostelManagement
    Public Class myFunction
        Public Function GetConnection() As SqlConnection
            Dim con As New SqlConnection With {
                .ConnectionString = "Data source = LAPTOP-L9851DE1\SQLEXPRESS;database=HostelManagementDB;integrated security=TRUE"
            }
            Return con
        End Function

        Public Function GetData(query As String) As DataSet 'This Fn is to GetData from Database 

            Dim con As SqlConnection = GetConnection()
            Dim cmd As New SqlCommand With {
                .Connection = con,
                .CommandText = query
            }

            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()

            da.Fill(ds)
            Return ds
        End Function

        Public Sub SetData(query As String, message As String) 'This fn is to insert, delete & update datbase
            Dim con As SqlConnection = GetConnection()
            Dim cmd As New SqlCommand()
            cmd.Connection = con
            con.Open()
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Sub

        Public Function getForCombo(query As String) As SqlDataReader
            Dim con As SqlConnection = GetConnection()
            Dim cmd As New SqlCommand()
            con.Open()
            cmd = New SqlCommand(query, con)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            Return sdr
        End Function

    End Class

End Namespace