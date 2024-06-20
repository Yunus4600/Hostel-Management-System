Imports Hostel_Management.HostelManagement

Public Class UC_feedback

    Dim fn As New myFunction
    Dim query As String



    Private Sub UC_feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "Select clgEmail,feedback from Student where feedback is not null"
        Dim ds As DataSet = fn.GetData(query)
        Guna2DataGridView1.DataSource = ds.Tables(0)
    End Sub


    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        If Guna2DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> Nothing Then
            txtEmail.Text = Guna2DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtFeedback.Text = Guna2DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If
    End Sub
End Class
