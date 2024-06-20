Imports System.Security.Cryptography
Imports System.Security.Cryptography.Xml
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Hostel_Management.HostelManagement

Public Class Form1




    Dim fn As New myFunction
    Dim query As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        query = "Select Username,password from Admin where Username = '" + txtUsername.Text + "' And password = '" + txtPassword.Text + "' "
        Dim ds As DataSet = fn.GetData(query)

        If ds.Tables(0).Rows.Count <> 0 Then
            LabelError.Visible = False
            Dim dash As New Dashboard()
            Me.Hide()
            dash.Show()
            txtUsername.Clear()
            txtPassword.Clear()
        Else
            LabelError.Text = "Wrong Email or Password!"
            LabelError.Visible = True
            txtUsername.Clear()
            txtPassword.Clear()
        End If


    End Sub


    Public Shared Sid As String = -1
    Private Sub btnStudentLogin_Click(sender As Object, e As EventArgs) Handles btnStudentLogin.Click

        query = "Select cId,clgEmail,Stu_Password from Student where clgEmail = '" + txtStuEmail.Text + "' And Stu_Password = '" + txtStuPassword.Text + "' "

        Dim ds As DataSet = fn.GetData(query)
        If ds.Tables(0).Rows.Count > 0 Then
            ' Check if there are rows in the result set
            Sid = Integer.Parse(ds.Tables(0).Rows(0)("cId").ToString())
        End If

        If ds.Tables(0).Rows.Count <> 0 Then
            LabelError.Visible = False
            Dim ds1 As New StudentDashboard()
            Me.Hide()
            ds1.Show()
            txtStuEmail.Clear()
            txtStuPassword.Clear()
        Else
            LabelError.Visible = True
            txtStuEmail.Clear()
            txtStuPassword.Clear()
        End If

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub



    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        LabelStudent.Visible = True
        txtStuEmail.Visible = True
        txtStuPassword.Visible = True
        btnStudentLogin.Visible = True
        btnStudent.Visible = False

        btnAdmin.Show()
        LabelAdmin.Hide()
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Hide()
        txtPassword.Hide()
        btnLogin.Hide()
        LabelError.Hide()
        LinkLabel1.Show()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click

        btnAdmin.Hide()
        LabelAdmin.Show()
        txtUsername.Show()
        txtPassword.Show()
        btnLogin.Show()
        LabelError.Hide()
        LinkLabel1.Hide()

        txtStuEmail.Clear()
        txtStuPassword.Clear()
        LabelStudent.Visible = False
        txtStuEmail.Visible = False
        txtStuPassword.Visible = False
        btnStudentLogin.Visible = False
        btnStudent.Visible = True

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        forgot_pasword.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel1.Hide()
    End Sub



End Class
