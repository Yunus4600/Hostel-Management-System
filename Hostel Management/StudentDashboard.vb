Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Hostel_Management.HostelManagement

Public Class StudentDashboard

    Dim fn As New myFunction
    Dim query As String
    Dim q1 As String = Form1.Sid


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub StudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "SELECT 
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
                            stu.checkout_status,
                            Rms.roomNo,
                            Rms.roomType,
                            Rms.bed,
                            Rms.price 
                    FROM
                            Student Stu
                    INNER Join 
                            Rooms Rms ON Stu.roomId = Rms.roomId 
                    where cId = '" + q1.ToString() + "' "
        Dim ds As DataSet = fn.GetData(query)
        GridView1.DataSource = ds.Tables(0)

        LabelID.Text = Integer.Parse(GridView1.Rows(0).Cells(0).Value.ToString())
        LabelName.Text = GridView1.Rows(0).Cells(1).Value.ToString()
        LabelMobile.Text = GridView1.Rows(0).Cells(2).Value.ToString()
        LabelEmail.Text = GridView1.Rows(0).Cells(3).Value.ToString()
        LabelGender.Text = GridView1.Rows(0).Cells(4).Value.ToString()
        LabelDOB.Text = GridView1.Rows(0).Cells(5).Value.ToString()
        LabelIDproof.Text = GridView1.Rows(0).Cells(6).Value.ToString()
        LabelAddress.Text = GridView1.Rows(0).Cells(7).Value.ToString()
        LabelJoiningDate.Text = GridView1.Rows(0).Cells(8).Value.ToString()
        LabelCkoutStatus.Text = GridView1.Rows(0).Cells(10).Value.ToString()
        Label30.Text = GridView1.Rows(0).Cells(9).Value.ToString()
        LabelRoomNo.Text = GridView1.Rows(0).Cells(11).Value.ToString()
        LabelRoomType.Text = GridView1.Rows(0).Cells(12).Value.ToString()
        LabelbedType.Text = GridView1.Rows(0).Cells(13).Value.ToString()
        LabelPrice.Text = GridView1.Rows(0).Cells(14).Value.ToString()


    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        Feedback.Show()
        Feedback.BringToFront()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Public ReadOnly Property Label As String
        Get
            Return LabelEmail.Text ' Replace Label1 with the actual name of your label
        End Get
    End Property


End Class