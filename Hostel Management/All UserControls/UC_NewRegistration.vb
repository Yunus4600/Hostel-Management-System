Imports Hostel_Management.HostelManagement
Imports System.Text.RegularExpressions


Public Class UC_NewRegistration

    Dim fn As New myFunction
    Dim query As String


    Public Sub setComboBox(query As String, combo As ComboBox)
        Dim sdr As SqlDataReader = fn.getForCombo(query)
        While sdr.Read()
            For i As Integer = 0 To sdr.FieldCount - 1
                combo.Items.Add(sdr.GetString(i))
            Next i
        End While
        sdr.Close()
    End Sub


    Private Sub txtRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtRoom.SelectedIndexChanged
        txtRoomNo.Items.Clear()
        txtPrice.Clear()
        query = "select roomNo from Rooms where RTRIM(LTRIM(bed)) = '" + txtbed.Text + "' And RTRIM(LTRIM(roomType)) = '" + txtRoom.Text + "'and RTRIM(LTRIM(booked)) = 'No' "
        setComboBox(query, txtRoomNo)
    End Sub

    Private Sub txtbed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtbed.SelectedIndexChanged
        If txtbed.SelectedIndex = 1 OrElse txtbed.SelectedIndex = 2 Then
        Else
            txtRoom.SelectedIndex = -1
            txtRoomNo.Items.Clear()
            txtPrice.Clear()
        End If
    End Sub



    Dim rid As Integer
    Private Sub txtRoomNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtRoomNo.SelectedIndexChanged
        query = "Select price, roomId from Rooms where roomNo = '" + txtRoomNo.Text + "';"
        Dim ds As DataSet = fn.GetData(query)
        txtPrice.Text = ds.Tables(0).Rows(0)(0).ToString()
        rid = Integer.Parse(ds.Tables(0).Rows(0)(1).ToString())
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        ' Check if the pressed key is not a letter and not a control character (e.g., backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancel the key press event
            e.Handled = True
        End If
    End Sub
    Private Sub txtMobileNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMobileNo.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private suffixAppended As Boolean = False
    Private Sub txtClgEmail_Click(sender As Object, e As EventArgs) Handles txtClgEmail.Click
        If Not suffixAppended Then
            txtClgEmail.Text &= "@kristujayanti.com"
            suffixAppended = True
        End If
    End Sub



    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click

        If txtName.Text <> "" AndAlso txtMobileNo.Text <> "" AndAlso txtClgEmail.Text <> "" AndAlso txtGender.Text <> "" AndAlso txtDob.Text <> "" AndAlso txtIdProof.Text <> "" AndAlso txtAddress.Text <> "" AndAlso txtJoiningDate.Text <> "" AndAlso txtPrice.Text <> "" AndAlso txtStuPassword.Text <> "" Then

            If txtMobileNo.Text < 10 Then
                MessageBox.Show("INVALID NUMBER")
            End If
            Dim query As String = "SELECT booked FROM Rooms WHERE roomNo = '" & txtRoomNo.Text & "'"
            Dim ds As DataSet = fn.GetData(query)

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                Dim bookedStatus As String = ds.Tables(0).Rows(0)("booked").ToString()

                If bookedStatus = "Yes" Then
                    MessageBox.Show("Room no :" + txtRoomNo.Text + " has been fully occupied.", "Room Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    Dim name As String = txtName.Text
                    Dim mobile As Long = Long.Parse(txtMobileNo.Text)
                    Dim email As String = txtClgEmail.Text
                    Dim gender As String = txtGender.Text
                    Dim dob As String = txtDob.Text
                    Dim idproof As String = txtIdProof.Text
                    Dim address As String = txtAddress.Text
                    Dim joindate As String = txtJoiningDate.Text
                    Dim password As String = txtStuPassword.Text


                    query = "Insert into Student (cname, mobile, clgEmail, gender, dob, idproof, address, joindate, roomId,Stu_Password) values ('" + name + "','" + mobile.ToString() + "' ,'" + email + "' , '" + gender + "', '" + dob + "','" + idproof + "', '" + address + "', '" + joindate + "', '" + rid.ToString() + "','" + password + "') UPDATE Rooms SET currentOccupancy = currentOccupancy + 1, " &
                         "booked = CASE " &
                         "WHEN bed = 'single' AND currentOccupancy = 0 THEN 'Yes' " &
                         "WHEN bed = 'double' AND currentOccupancy = 1 THEN 'Yes' " &
                         "WHEN bed = 'triple' AND currentOccupancy = 2 THEN 'Yes' " &
                         "ELSE 'No' " &
                         "END " &
                         "WHERE roomNo = '" + txtRoomNo.Text + "'"

                    fn.SetData(query, "Student have been enrolled and Room no " + txtRoomNo.Text + " has been allotted.")
                    ClearAll()
                End If

            Else
                MessageBox.Show("Room not found.", "Room Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Public Sub ClearAll()
        txtName.Clear()
        txtMobileNo.Clear()
        txtClgEmail.Clear()
        txtDob.ResetText()
        txtGender.SelectedIndex = -1
        txtIdProof.Clear()
        txtAddress.Clear()
        txtJoiningDate.ResetText()
        txtbed.SelectedIndex = -1
        txtRoom.SelectedIndex = -1
        txtRoomNo.Items.Clear()
        txtPrice.Clear()
        txtStuPassword.Clear()
    End Sub


End Class



