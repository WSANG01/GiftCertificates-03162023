Public Class Sales
    Dim box = New Reports()
    'disable windows X exit from Form
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
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        RoundButton(btnRecord)
        RoundButton(btnExit)

        txtDSold.Text = todayIs
        setNext()
        lblNext.Text = nextCert
        ' MsgBox("Sales")
        Dtp1.Format = DateTimePickerFormat.Custom
        Dtp1.CustomFormat = "MM/dd/yyyy"
        Dtp1.Value = Today
    End Sub
    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Call doRecord
    End Sub
    Private Sub doRecord()

        'verify not already on file
        'certNumber
        'certRange
        'dSold
        'soldTo
        'dRedeemed
        'notes
        'fut1
        'fut2
        btnRecord.Visible = False
        If txtCertNr.Text.Length < 6 Then
            MessageBox.Show("Certificate Number less that 6 digits-reenter", "Gift Certificate Sale")
            ' MsgBox("Certificate Number less that 6 digits-reenter")
            If txtSoldTo.Text <> "" Then
                btnRecord.Visible = True
            End If
            txtCertNr.Select()
            Exit Sub
        End If

        If txtCertNr.Text = "" Then
            MessageBox.Show("Certificate Number Missing-reenter", "Gift Certificate Sale")
            'MsgBox("Certificate Number Missing-Reenter")
            If txtSoldTo.Text <> "" Then
                btnRecord.Visible = True
            End If

            txtCertNr.Select()
            Exit Sub
        End If
        If txtDSold.Text = "" Then
            MessageBox.Show("Date Sold MIssing-reenter", "Gift Certificate Sale")
            If txtSoldTo.Text <> "" Then
                btnRecord.Visible = True
            End If
            txtDSold.Select()
            Exit Sub
            Dim validDate As Boolean = verValidDate(txtDSold.Text)
            If validDate = False Then
                MessageBox.Show("Invalid Date Format:" & txtDSold.Text & "-reenter", "Gift Certificate Sale")
            End If
        End If
        If txtSoldTo.Text = "" Then
            MessageBox.Show("Sold To Missing-reenter", "Gift Certificate Sale")
            txtSoldTo.Select()
            Exit Sub
        End If
        If txtCertRange.Text <> "" Then
            Call rangeSale()
            setNext()
            lblNext.Text = nextCert

            resetVis()
            Exit Sub
        End If
        txtCertRange.Text = "0"
        btnRecord.Visible = False

        btnExit.Visible = False
        ' need to add to giftList 1st
        'verify not duplicate or "insert-(less than last existing Cert nr)
        Dim gwork As AddType
        gwork.certNumber = txtCertNr.Text
        gwork.certRange = txtCertRange.Text
        gwork.dSold = txtDSold.Text
        gwork.soldTo = txtSoldTo.Text
        gwork.dRedeemed = ""     'txtDRedeem.Text
        gwork.notes = txtNotes.Text
        Dim dgIn As Boolean = cklocInList(gwork.certNumber)
        Dim isIn As Boolean = findInList(gwork.certNumber)
        If dgIn = True Then
            If gwork.certNumber = lastCert Or isIn = True Then
                MessageBox.Show("Certificate Number:" & gwork.certNumber & " Already on File-reenter", "Gift Certificate Sale")
                resetVis()
                Exit Sub
            Else
                '******************do an insert here
                'MsgBox("Need to do INSERT!")
                insItem(gwork)
                resetVis()
                setNext()
                lblNext.Text = nextCert

                Exit Sub
            End If
        End If
        giftList.Add(gwork)
        changesMade = True
        '        box.DataGridView1.Rows.Add(txtCertNr.Text, txtCertRange.Text, txtDSold.Text, txtSoldTo.Text, txtDRedeem.Text, txtNotes.Text)
        lblAdded.Visible = True
        lblAdded.Text = txtCertNr.Text & " Added"
        Application.DoEvents()
        msWait30(1)
        resetVis()
        setNext()
        lblNext.Text = nextCert

    End Sub
    Private Sub resetVis()
        lblAdded.Visible = False
        txtCertNr.Text = ""
        txtCertRange.Text = ""
        txtDSold.Text = todayIs

        txtSoldTo.Text = ""
        ' txtDRedeem.Text = ""
        txtNotes.Text = ""
        txtCertNr.Select()

        btnRecord.Visible = False
        btnExit.Visible = True

    End Sub
    Private Sub rangeinsItems(gwork As AddType)  '
        'giftWork is input. make sure inough room to insert
        'MsgBox("IN Cert:" & gwork.certNumber & "Rstart:" & rangeStart & "Rend:" & rangeEnd & "ICnt:" & rangeCnt)
        'rangeStart = Convert.ToInt32(txtCertNr.Text)
        'rangeEnd = Convert.ToInt32(txtCertRange.Text)
        'rangeCnt = rangeEnd - rangeStart
        Dim fCert As Integer = gwork.certNumber
        Dim lastRCert As Integer = fCert + rangeCnt

        Dim riwork As AddType
        riwork = giftWork
        For i As Integer = 0 To giftList.Count - 1
            riwork = giftList(i)
            If fCert = riwork.certNumber Then
                MessageBox.Show("Starting Certificate Nr:" & fCert & " Already on file", "Gift Certificate Sale")
                resetVis()
                Exit Sub
            End If
            If fCert < riwork.certNumber Then
                giftAfter = i   'row of 1s item after the insertions
                nextCert = riwork.certNumber 'cert after ins
                giftBefore = i - 1
                'verify last cert in range fits before cert after insert


                If lastRCert < nextCert Then
                    'perform the insertion
                    ' MsgBox("Insertion Fits")
                    insItem(gwork)
                    Exit Sub
                End If
                MessageBox.Show("Certificate Range Overlaps Existing Gift Certificate Nr(s)", "Gift Certificate Sale")
                resetVis()
                Exit Sub

            End If
        Next
        MessageBox.Show("Internal Error:F3116", "Gift Certificate Sale")
        resetVis()
        Exit Sub

    End Sub
    Private Sub insItem(gwork As AddType)
        Dim moveRows As Integer, cwork As Integer
        cwork = gwork.certNumber
        lastListRow = giftList.Count - 1
        Dim rowCert As String
        For i As Integer = 0 To giftList.Count - 1
            giftCert = giftList(i)
            rowCert = giftCert.certNumber
            If cwork < rowCert Then
                startIns = rowCert
                moveRows = lastListRow - i + 1
                ' MsgBox("Start Ins:" & startIns & " End Ins:" & lastCert & " Nr to Ins:" & moveRows)
                ' save rows below insertion point
                Dim bList As New List(Of AddType)
                Dim nRow As Integer = i
                Do While moveRows > 0
                    giftWork = giftList(nRow)
                    bList.Add(giftWork)
                    changesMade = True
                    moveRows -= 1
                    giftList.RemoveAt(nRow) 'clear from insertion point
                Loop
                'add insertion item(S)
                If gwork.certRange >= 0 Then
                    'add the range here
                    addRange(gwork)
                Else
                    '*********************check for range insertion here after verify it fits
                    giftList.Add(gwork)

                    changesMade = True
                End If

                'replace(add) bList items
                For y As Integer = 0 To bList.Count - 1
                    giftWork = bList(y)
                    giftList.Add(giftWork)
                Next
                Exit Sub
            End If
        Next


    End Sub

    Private Sub rangeSale()
        rangeStart = Convert.ToInt32(txtCertNr.Text)
        rangeCnt = Convert.ToInt32(txtCertRange.Text)
        '**change range to nr of certs in range-not last cert nr in range
        rangeEnd = rangeStart + rangeCnt - 1
        rangeCnt -= 1

        If rangeEnd <= rangeStart Then
            MessageBox.Show("Invalid Range Number or Certificate Number", "Gift Certificate Sale")
            '            MsgBox("Invalid Range Number or Certificate Number")
            txtCertRange.Select()
            Exit Sub
        End If
        'Using Range as the Last certificate nr in range, not the nr of certs in the range(?)
        Dim gwork As AddType
        gwork.certNumber = txtCertNr.Text
        gwork.certRange = txtCertRange.Text
        gwork.dSold = txtDSold.Text
        gwork.soldTo = txtSoldTo.Text
        gwork.dRedeemed = ""    'txtDRedeem.Text
        gwork.notes = txtNotes.Text
        '            giftList.Add(gwork)
        'check if inserting a range
        'verify not duplicate or "insert-(less than last existing Cert nr)
        Dim dgIn As Boolean = cklocInList(gwork.certNumber)
        Dim isIn As Boolean = findInList(gwork.certNumber)
        If dgIn = True Then
            If gwork.certNumber = lastCert Or isIn = True Then
                MessageBox.Show("Gift Certificate Already on File-Renter", "Gift Certificate Sale")
                '                MsgBox("Start Gift Certificate Already on File-Renter")
                resetVis()
                Exit Sub
            End If
            'Be sure not a duplicate start certificate nr
            '
            rangeinsItems(gwork)
            setNext()
            lblNext.Text = nextCert
            resetVis()
            Exit Sub
        End If
        addRange(gwork)
        setNext()
        lblNext.Text = nextCert
    End Sub

    Private Sub addRange(gwork As AddType)

        Dim rangeCon As String
        For x As Integer = 0 To rangeCnt
            btnRecord.Visible = False

            btnExit.Visible = False
            rangeCon = rangeStart.ToString("00000")

            '            box.DataGridView1.Rows.Add(rangeCon, txtCertRange.Text, txtDSold.Text, txtSoldTo.Text, txtDRedeem.Text, txtNotes.Text)
            giftList.Add(gwork)
            setNext()

            lblNext.Text = nextCert
            changesMade = True
            lblAdded.Visible = True
            lblAdded.Text = rangeCon & " Added"
            Application.DoEvents()
            msWait30(1)
            rangeStart += 1
            gwork.certNumber = rangeStart
            gwork.certRange = 0
        Next
        lblAdded.Visible = False
        txtCertNr.Text = ""
        txtCertRange.Text = ""
        txtDSold.Text = todayIs

        txtSoldTo.Text = ""
        'txtDRedeem.Text = ""
        txtNotes.Text = ""
        txtCertNr.Select()

        btnRecord.Visible = True
        btnExit.Visible = True


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If txtCertNr.Text <> "" Then
            Dim result1 As DialogResult = MessageBox.Show("Data is still on the form-Exit Anyway?",
               "Important Question",
               MessageBoxButtons.YesNo)
            If result1 = DialogResult.No Then
                Exit Sub
            End If
        End If
        Dim currentTime As System.DateTime = System.DateTime.Now

        todayIs = Format(currentTime, "MM/dd/yyyy")

        Dim box = New frmMenu()
        Me.Close()
        box.Show()
    End Sub

    Private Sub txtCertNr_TextChanged(sender As Object, e As EventArgs) Handles txtCertNr.TextChanged
        If txtCertNr.Text.Length >= 6 Then txtCertRange.Focus()
    End Sub

    Private Sub txtCertRange_TextChanged(sender As Object, e As EventArgs) Handles txtCertRange.TextChanged
        If txtCertRange.Text.Length >= 6 Then txtDSold.Focus()

    End Sub

    'Private Sub txtDSold_TextChanged(sender As Object, e As EventArgs) Handles txtDSold.TextChanged
    '   txtSoldTo.Select()

    'End Sub

    Private Sub txtSoldTo_TextChanged(sender As Object, e As EventArgs) Handles txtSoldTo.TextChanged
        btnRecord.Visible = True
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

    Private Sub ckNext_CheckedChanged(sender As Object, e As EventArgs) Handles ckNext.CheckedChanged
        txtCertNr.Text = lblNext.Text
        txtCertRange.Select()
        ckNext.Checked = False
    End Sub

    Private Sub txtCertRange_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCertRange.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Or e.KeyCode = Keys.Tab Then
            Dtp1.Visible = True
            txtDSold.Select()
        End If
    End Sub

    Private Sub txtDSold_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDSold.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            Dtp1.Visible = False
            txtSoldTo.Select()
        End If

    End Sub

    Private Sub txtNotes_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNotes.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            btnRecord.Select()
        End If

    End Sub

    Private Sub txtSoldTo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSoldTo.KeyDown
        If txtSoldTo.Text = "" Then Exit Sub

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            txtNotes.Select()
        End If

    End Sub

    Private Sub txtCertNr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCertNr.KeyDown
        If txtCertNr.Text <> "" Then Exit Sub
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Or e.KeyCode = Keys.Tab Then
            txtCertNr.Text = nextCert
        End If




    End Sub



    Private Sub txtDSold_MouseDown(sender As Object, e As MouseEventArgs) Handles txtDSold.MouseDown
        '   If Dtp1.Visible = True Then
        '   Dtp1.Visible = False
        '   Else
        '  Dtp1.Visible = True
        '  End If
    End Sub


    Private Sub Dtp1_CloseUp(sender As Object, e As EventArgs) Handles Dtp1.CloseUp
        txtDSold.Text = Dtp1.Value.ToString("MM/dd/yyyy")
        todayIs = txtDSold.Text
        ' Dtp1.Visible = False
        Application.DoEvents()
        txtSoldTo.Select() 'txtSoldTo
    End Sub

    Private Sub txtDSold_TextChanged(sender As Object, e As EventArgs) Handles txtDSold.TextChanged

    End Sub
    'This logic thanks to TinTnMn dated 25 Feb 2013
    Friend Class FocusChangedArg
        Inherits EventArgs
        Public LastControlWithFocus As Control
        Public Sub New(ByVal Last As Control)
            LastControlWithFocus = Last
        End Sub
    End Class

    Private LastActiveControl As Control = Me
    Friend Event FocusChanged As EventHandler(Of FocusChangedArg)

    Protected Overrides Sub UpdateDefaultButton()
        RaiseEvent FocusChanged(Me, New FocusChangedArg(LastActiveControl))
        LastActiveControl = Me.ActiveControl ' Store this for the next time Focus changes
    End Sub

    Private Sub Form1_FocusChanged(ByVal sender As Object,
     ByVal e As FocusChangedArg) Handles Me.FocusChanged
        If txtDSold.Name = ActiveControl.Name Or
            Dtp1.Name = ActiveControl.Name Then
            Dtp1.Visible = True
        Else
            Dtp1.Visible = False
        End If

    End Sub

    Private Sub PBMin_Click(sender As Object, e As EventArgs) Handles PBMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnRecord_KeyDown(sender As Object, e As KeyEventArgs) Handles btnRecord.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Or e.KeyCode = Keys.Tab Then
            doRecord()
        End If
    End Sub
    'Thanks TinTnMn
End Class