Imports System.Runtime.CompilerServices
Imports Hostel_Management.HostelManagement

Public Class UC_AddRoom
    Dim fn As New myFunction()
    Dim query As String

    Private Sub UC_AddRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from Rooms"
        Dim ds As DataSet = fn.GetData(query)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        If txtRoomNo.Text <> "" AndAlso txtType.Text <> "" AndAlso txtBed.Text <> "" AndAlso txtPrice.Text <> "" Then
            Dim roomno = txtRoomNo.Text
            Dim type = txtType.Text
            Dim bed = txtBed.Text

            Dim price As Long
            Try
                price = Long.Parse(txtPrice.Text)
            Catch ex As FormatException
                MessageBox.Show("Price must be a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Exit the method if parsing fails
            End Try

            ' Check if the roomNo already exists
            Dim queryCount = "SELECT COUNT(*) FROM Rooms WHERE roomNo = '" & roomno & "'"
            Dim existingRoomCount As Integer = 0
            Try
                Dim ds As DataSet = fn.GetData(queryCount)
                If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                    existingRoomCount = Convert.ToInt32(ds.Tables(0).Rows(0)(0))
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred while checking roomNo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Exit the method if an error occurs
            End Try


            If existingRoomCount > 0 Then
                MessageBox.Show("Room number already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Exit the method if roomNo already exists
            End If

            Dim query = "INSERT INTO Rooms(roomNo, roomType, bed, price) VALUES ('" & roomno & "', '" & type & "','" & bed & "'," & price.ToString() & ")"

            Try
                fn.SetData(query, "Room Added successfully.") ' Insert values into the database

                UC_AddRoom_Load(Me, Nothing) ' Reload the page to show the added value 
                ClearAll()
            Catch ex As Exception
                MessageBox.Show("An error occurred while adding the room: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Public Sub ClearAll()
        txtRoomNo.Clear()
        txtType.SelectedIndex = -1
        txtBed.SelectedIndex = -1
        txtPrice.Clear()
    End Sub


    Private Sub UC_AddRoom_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        ClearAll()
    End Sub

    Private Sub UC_AddRoom_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        UC_AddRoom_Load(Me, Nothing)
    End Sub


End Class
