Imports Hostel_Management.HostelManagement

Public Class UC_StudentDetails_

    Dim fn As New myFunction
    Dim query As String

    Private Sub txtSearchBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSearchBy.SelectedIndexChanged
        If txtSearchBy.SelectedIndex = 0 Then
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
                            Stu.checkout_date,
                            Rms.roomNo,
                            Rms.roomType,
                            Rms.bed,
                            Rms.price 
                    FROM
                            Student Stu
                    INNER Join 
                            Rooms Rms ON Stu.roomId = Rms.roomId "
            getRecords(query)

        ElseIf txtSearchBy.SelectedIndex = 1 Then
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
                            Stu.checkout_date,
                            Rms.roomNo,
                            Rms.roomType,
                            Rms.bed,
                            Rms.price 
                    FROM
                            Student Stu
                    INNER Join 
                            Rooms Rms ON Stu.roomId = Rms.roomId
                    WHERE
                           checkout_date is null "
            getRecords(query)

        ElseIf txtSearchBy.SelectedIndex = 2 Then
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
                            Stu.checkout_date,
                            Rms.roomNo,
                            Rms.roomType,
                            Rms.bed,
                            Rms.price 
                    FROM
                            Student Stu
                    INNER Join 
                            Rooms Rms ON Stu.roomId = Rms.roomId
                    WHERE
                           checkout_date is not null "
            getRecords(query)
        End If
    End Sub

    Private Sub getRecords(query As String)
        Dim ds As DataSet = fn.GetData(query)
        gridViewDetails.DataSource = ds.Tables(0)
    End Sub


End Class
