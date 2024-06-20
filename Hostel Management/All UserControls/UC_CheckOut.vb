Imports System.Security.Cryptography.X509Certificates
Imports Hostel_Management.HostelManagement

Public Class UC_CheckOut

    Dim fn As New myFunction
    Dim query As String

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        ' Check if the pressed key is not a letter and not a control character (e.g., backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancel the key press event
            e.Handled = True
        End If
    End Sub

    Private Sub UC_CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "  SELECT 
                            Stu.cId,
                            Stu.cname,
                            Stu.mobile,
                            Stu.clgEmail,
                            Stu.gender,
                            Stu.dob,
                            Stu.idproof,
                            Stu.address,
                            Stu.joindate,
                            Rms.roomNo,
                            Rms.roomType,
                            Rms.bed,
                            Rms.price 
                    FROM
                            Student Stu
                    INNER Join 
                            Rooms Rms ON Stu.roomId = Rms.roomId 
                    WHERE
                            checkout_status = 'No'"

        Dim ds As DataSet = fn.GetData(query)
        gridViewCheckout.DataSource = ds.Tables(0)
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        query = "  SELECT 
                            Stu.cId,
                            Stu.cname,
                            Stu.mobile,
                            Stu.clgEmail,
                            Stu.gender,
                            Stu.dob,
                            Stu.idproof,
                            Stu.address,
                            Stu.joindate,
                            Rms.roomNo,
                            Rms.roomType,
                            Rms.bed,
                            Rms.price 
                    FROM
                            Student Stu
                    INNER Join 
                            Rooms Rms ON Stu.roomId = Rms.roomId 
                    WHERE
                            cname like '" + txtName.Text + "%' and checkout_status = 'No' "

        Dim ds As DataSet = fn.GetData(query)
        gridViewCheckout.DataSource = ds.Tables(0)

    End Sub

    Dim id As Integer
    Private Sub gridViewCheckout_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridViewCheckout.CellContentClick
        If gridViewCheckout.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> Nothing Then
            id = Integer.Parse(gridViewCheckout.Rows(e.RowIndex).Cells(0).Value.ToString)
            txtSname.Text = gridViewCheckout.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtRoom.Text = gridViewCheckout.Rows(e.RowIndex).Cells(9).Value.ToString()
        End If
    End Sub

    Private Sub btnCkeckOut_Click(sender As Object, e As EventArgs) Handles btnCkeckOut.Click
        If txtSname.Text <> "" Then
            If MessageBox.Show("Are you sure you want to check out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Dim Sdate As String = txtCheckOutDate.Text
                query = "UPDATE 
                            Student set checkout_status = 'Yes', 
                            checkout_date = '" + Sdate + "' 
                        WHERE 
                            cId = '" + id.ToString() + "'
                        UPDATE 
                            Rooms SET currentOccupancy = currentOccupancy - 1," &
                            "booked = 'No' " &
                            "WHERE roomNo = '" + txtRoom.Text + "'"
                fn.SetData(query, "Succesfully Cheked Out.")
                UC_CheckOut_Load(Me, Nothing) 'to reload the page
                clearAll()
            End If
        Else
            MessageBox.Show("Select the student you want to checkout.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub clearAll()
        txtName.Clear()
        txtSname.Clear()
        txtRoom.Clear()
        txtCheckOutDate.ResetText()
    End Sub


End Class
