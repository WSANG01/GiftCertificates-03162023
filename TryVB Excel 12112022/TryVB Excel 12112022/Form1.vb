Imports System.ComponentModel
Imports System.Deployment.Application
Imports System.Globalization
'frmMenu Form1
'Sales Form3
'Redeem Form4
'Reports Form5
'Summary Form2
Public Class frmMenu
    Dim MyVersion As String = "1.0.3  01/27/2023"
    Private Declare Function SetSysColors Lib "user32.dll" (ByVal one As Integer, ByRef element As Integer, ByRef color As Integer) As Boolean

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub frmMenuLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        LblVer.Text = MyVersion
        Me.Hide()
        roundCorners(Me)
        RoundButton(btnSale)
        RoundButton(btnRedeem)
        RoundButton(btnReports)
        RoundButton(btnHome)
        Me.Show()
        If alreadyLoaded = False Then
            PictureBox1.ImageLocation = "C:\Gift Certificates\Documents\gifgit.gif"
            ' Call LoadGiftFile()   01/19/2023 wasn't showing process .gif file while loading
            alreadyLoaded = True
            BackgroundWorker1.RunWorkerAsync()
            Dim currentTime As System.DateTime = System.DateTime.Now
            todayIs = Format(currentTime, "MM/dd/yyyy")
        Else
            Application.DoEvents()
            PictureBox1.Visible = False
            Label1.Visible = False
            btnSale.Visible = True
            btnRedeem.Visible = True
            btnReports.Visible = True
            btnHome.Visible = True

        End If
        '01/19/2023 cklocInList(999999)


    End Sub

    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.DarkBlue
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Arial", 14)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btnSale.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btn.Region = New Region(Raduis)
    End Sub

    Private Sub roundCorners(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.Cyan


        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)

    End Sub

    Private Sub btnSale_Click(sender As Object, e As EventArgs) Handles btnSale.Click
        Dim box = New Sales()
        Me.Hide()
        box.Show()

    End Sub

    Private Sub btnRedeem_Click(sender As Object, e As EventArgs) Handles btnRedeem.Click
        Dim box = New Redeem()
        Me.Hide()
        box.Show()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        PictureBox1.ImageLocation = "C:\Gift Certificates\Documents\gifgit.gif"

        '        Show()

        Dim box = New Summary

        If changesMade = False Then
            'Do summary displays here?
            SumSame()
            Me.Hide()
            box.ShowDialog()

            Me.Close()
            End
        End If
        PictureBox1.Visible = True
        Label1.Text = "Recording Gift Certificates .xlsx File"
        Label1.Visible = True
        BackgroundWorker2.RunWorkerAsync()
        While alreadyLoaded = True
            Application.DoEvents()
        End While
        'Do summary displays here?
        'Do summary displays here?
        Me.Hide()
        '       Dim box = New Form2
        box.ShowDialog()
        Application.DoEvents()


        Me.Close()
        End

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim box = New Reports()
        Me.Hide()
        box.Show()

    End Sub





    Private Sub PBMin_Click(sender As Object, e As EventArgs) Handles PBMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'read in the .xlsx file here
        LoadGiftFile()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Application.DoEvents()

        PictureBox1.Visible = False
        Label1.Visible = False
        PictureBox1.Visible = False
        Label1.Visible = False
        btnSale.Visible = True
        btnRedeem.Visible = True
        btnReports.Visible = True
        btnHome.Visible = True

    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork

        reGenExcel()


    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        Application.DoEvents()
        alreadyLoaded = False

    End Sub

    '    Private Sub PBMax_Click(sender As Object, e As EventArgs) Handles PBMax.Click
    '   Me.WindowState = FormWindowState.Maximized
    '   End Sub
End Class