Public Class forgot_pasword
    Private connectionString As String = "Data source = LAPTOP-L9851DE1\SQLEXPRESS;database=HostelManagementDB;integrated security=TRUE"

    Public Function FetchDOBFromStudentTable(ByVal phoneNumber As String) As DateTime
        Dim dob As String = Date.MinValue

        ' Create connection
        Using connection As New SqlConnection(connectionString)
            ' Open connection
            connection.Open()

            ' Create SQL command
            Dim query As String = "SELECT dob FROM Student WHERE mobile = @PhoneNumber"
            Using command As New SqlCommand(query, connection)
                ' Add parameter
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber)

                ' Execute SQL command
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Read DOB from result
                        dob = reader.GetString(0)
                    End If
                End Using
            End Using
        End Using

        Return dob
    End Function

    Public Function CompareDOBWithDateTimePicker(ByVal dobFromDatabase As DateTime, ByVal dateTimePickerValue As DateTime) As Boolean
        ' Compare the DOB from the database with the value from the DateTimePicker
        Return dobFromDatabase.Date = dateTimePickerValue.Date
    End Function
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim phoneNumber As String = Guna2TextBox1.Text

        ' Example date from DateTimePicker
        Dim dateTimePickerValue As String = Guna2DateTimePicker1.Value.Date

        ' Fetch DOB from student table using phone number
        Dim dobFromDatabase As DateTime = FetchDOBFromStudentTable(phoneNumber)

        ' Compare DOB from database with DateTimePicker value
        Dim isDOBMatch As Boolean = CompareDOBWithDateTimePicker(dobFromDatabase, dateTimePickerValue)

        If isDOBMatch Then
            If Guna2TextBox2.Text = Guna2TextBox3.Text Then
                Try
                    Using connection As New SqlConnection(connectionString)
                        ' Open connection
                        connection.Open()

                        ' Create SQL command
                        Dim query As String = "UPDATE Student SET Stu_Password = @NewPassword WHERE mobile = @MobileNumber"
                        Using command As New SqlCommand(query, connection)
                            ' Add parameters
                            command.Parameters.AddWithValue("@NewPassword", Guna2TextBox3.Text)
                            command.Parameters.AddWithValue("@MobileNumber", Guna2TextBox1.Text)

                            ' Execute SQL command
                            command.ExecuteNonQuery()
                        End Using
                    End Using
                    MessageBox.Show("Password updated successfully")
                    Me.Hide()

                Catch ex As Exception
                    MessageBox.Show("Error occurred: " & ex.Message)
                End Try

            Else
                MessageBox.Show("Both the enetered passwords should match")
            End If
        Else
            MessageBox.Show("DOB does not match with the entered Students Phone No.!")
        End If
    End Sub
End Class