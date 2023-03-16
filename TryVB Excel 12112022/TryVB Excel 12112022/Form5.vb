Public Class Reports
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Dim Pos As Point

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        RoundButton(btnHome)

        Call showGrid()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        DataGridView1.SelectAll()
        DataGridView1.ClearSelection()
        DataGridView1.Visible = False
        Dim box = New frmMenu()
        Me.Close()
        box.Show()

    End Sub
    Private Sub showGrid()
        Dim y As Integer
        Dim huh As Integer
        Dim localList As AddType
        DataGridView1.Visible = True
        DataGridView1.Rows.Clear()
        'gridRow = 1
        huh = giftList.Count
        'gridRow = 1
        For y = 0 To giftList.Count - 1
            giftCert = giftList(y)
            localList = giftList(y)
            'With giftCert
            Dim x As String() = {giftCert.certNumber, giftCert.certRange, giftCert.dSold, giftCert.soldTo, giftCert.dRedeemed, giftCert.notes, giftCert.fut1, giftCert.fut2}
            If giftCert.certNumber <> 900000 Then  '01/19/2023
                DataGridView1.Rows.Add(x)
            End If

            'End With
        Next
        For i = 0 To DataGridView1.Columns.Count - 1
            DataGridView1.Columns(i).ReadOnly = True
        Next

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
        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
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


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        '        DataGridView1.SelectAll()
        DataGridView1.ClearSelection()

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        DataGridView1.ClearSelection()

    End Sub

    Private Sub PBMin_Click(sender As Object, e As EventArgs) Handles PBMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class