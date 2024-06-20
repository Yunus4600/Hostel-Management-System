Imports System.Security.Cryptography
Imports Hostel_Management.HostelManagement

Public Class Feedback

    Dim fn As New myFunction
    Dim query As String
    Dim sid As Integer
    Dim q1 As String = Form1.Sid



    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click

        If txtfeedback.Text <> "" Then
            Dim feedback As String = txtfeedback.Text


            Try
                ' Retrieve the cId of the student based on the provided email

                query = "SELECT cId,clgEmail FROM Student where cId = '" + q1.ToString() + "'"

                Dim ds As DataSet = fn.GetData(query)
                If ds.Tables(0).Rows.Count > 0 Then
                    ' Check if there are rows in the result set
                    sid = Integer.Parse(ds.Tables(0).Rows(0)("cId").ToString())
                End If

                If ds.Tables(0).Rows.Count <> 0 Then
                    query = "Update Student 
                              SET feedback = '" + feedback + "'
                              WHERE cId = '" + q1.ToString() + "' "

                    fn.SetData(query, "Feedback posted successfully!")
                Else
                    MessageBox.Show("Wrong Email!")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Textbox cannot be empty.")
        End If

        Me.Close()
    End Sub


End Class