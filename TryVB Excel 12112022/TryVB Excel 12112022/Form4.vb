Public Class Redeem
    'disable windows X exit from Form
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Dim Pos As Point

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, MyBase.Click
        Dim sCnt As Integer = DataGridView1.SelectedRows.Count
        If sCnt <> 0 Then
            Dim result1 As DialogResult = MessageBox.Show("There are still Selected Item(s) on the form-Exit Anyway? (Reply NO and Click Redeem Selected to record the selection  or YES to ignore the selection)",
               "Important Question",
               MessageBoxButtons.YesNo)
            If result1 = DialogResult.No Then
                Exit Sub
            End If
        End If


        'do logic here to update the selected items in the grid and in List 
        ' 01/19/2023 this alread done in update routine!!
        '        DataGridView1.ClearSelection()
        '        giftList.Clear()
        '        Dim dgc As Integer = DataGridView1.Rows.Count
        '       For i As Integer = 0 To DataGridView1.Rows.Count - 2  '01192023 this count = 2 but only 1 allow user to add rows = T
        '        With giftWork
        '        .certNumber = DataGridView1.Rows(i).Cells(0).Value
        '        .certRange = DataGridView1.Rows(i).Cells(1).Value
        '       .dSold = DataGridView1.Rows(i).Cells(2).Value
        '        .soldTo = DataGridView1.Rows(i).Cells(3).Value
        '        .dRedeemed = DataGridView1.Rows(i).Cells(4).Value
        '        .notes = DataGridView1.Rows(i).Cells(5).Value
        '        .fut1 = DataGridView1.Rows(i).Cells(6).Value
        '        .fut2 = DataGridView1.Rows(i).Cells(7).Value
        '        giftList.Add(giftWork)
        ''            End With
        '        Next
        Dim box = New frmMenu()
        Me.Close()
        box.Show()

    End Sub

    Private Sub Redeem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("Redeem Module")
        roundCorners(Me)
        RoundButton(btnRedeem)
        RoundButton(Button1)
        txtDRedem.Text = todayIs
        'DataGridView1.AllowUserToAddRows = False
        showGrid()


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
            If giftCert.certNumber <> 900000 Then '01/19/2023 don't show EOF record on datagrid
                DataGridView1.Rows.Add(x)
            End If


            'End With
        Next
        DataGridView1.ClearSelection()  'this sets the row count to 1 not 0
    End Sub

    Private Sub btnRedeem_Click(sender As Object, e As EventArgs) Handles btnRedeem.Click
        Dim aList As New List(Of Integer)


        aList.Clear()
        Dim sCnt As Integer = DataGridView1.SelectedRows.Count
        ' MsgBox("Selected count=" & sCnt)
        If sCnt = 0 Then
            MessageBox.Show("Nothing Selected-Try Again!", "Certificate Redeem")
            'MsgBox("Nothing Selected-Try Again!")
            DataGridView1.ClearSelection()
            Exit Sub
        End If
        btnRedeem.Visible = False
        Dtp1.Visible = False
        changesMade = True
        Dim trsAry As New List(Of Integer)
        Dim selS As String
        Dim trsCnt As Integer

        trsCnt = sCnt
        'MsgBox("Selected Cnt=" & trsCnt)
        selS = "Selected+"
        Dim s As Integer
        For s = 0 To trsCnt - 1
            trsAry.Add(DataGridView1.SelectedRows(s).Index)
            selS = selS & " " & trsAry(s) & ","
        Next
        'MsgBox(selS)
        'DataGridView1.ClearSelection()
        'Exit Sub

        Dim iRowIndex As Integer, nextIndex As Integer, rowCount As Integer
        rowCount = sCnt
        For i As Integer = 0 To rowCount - 1
            nextIndex = trsAry(i)
            DataGridView1.Rows(nextIndex).Cells(4).Value = todayIs
            giftWork = giftList(nextIndex)
            giftWork.dRedeemed = todayIs
            giftList(nextIndex) = giftWork

        Next
        DataGridView1.ClearSelection()
        txtCert.Text = ""
        btnRedeem.Visible = True 'Ian:03/15/2023


    End Sub

    '    Private Sub txtCert_TextChanged(sender As Object, e As EventArgs) Handles txtCert.TextChanged
    '   If txtCert.TextLength < 6 Then Exit Sub
    '   Call txtCert_KeyUp()
    '    End Sub
    Private Sub txtCert_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        DataGridView1.ClearSelection()

        For Row As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(Row).Cells(0).Value.ToString.Substring(0, txtCert.Text.Length) = txtCert.Text Then
                DataGridView1.Rows(Row).Selected = True
                Exit Sub
            End If
        Next
        Dim tcLng As Integer = txtCert.Text.Length
        Dim tclRem As Integer = 6 - tcLng
        Dim tclPrt As String
        If tclRem = 0 Then
            MessageBox.Show(tclPrt & " Not on File", "Certificate Redeem")

        Else
            tclPrt = txtCert.Text
            For i = 0 To tclRem - 1
                tclPrt = tclPrt & "."
            Next
            MessageBox.Show(tclPrt & " Not on File", "Certificate Redeem")

            'MsgBox(tclPrt & " Not on File")
        End If


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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If DataGridView1.SelectedRows.Count = 0 Then
            DataGridView1.ClearSelection()
        End If

    End Sub

    Private Sub PBMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized

    End Sub



    Private Sub PBMin_Click_1(sender As Object, e As EventArgs) Handles PBMin.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub txtCert_TextChanged(sender As Object, e As EventArgs) Handles txtCert.TextChanged
        If txtCert.TextLength < 6 Then Exit Sub
        DataGridView1.ClearSelection()
        For Row As Integer = 0 To DataGridView1.Rows.Count - 1  ' 01192023 was 1, * in next col ??1 allow user to add row = T/F
            If DataGridView1.Rows(Row).Cells(0).Value.ToString.Substring(0, txtCert.Text.Length) = txtCert.Text Then
                DataGridView1.Rows(Row).Selected = True
                Exit Sub
            End If
        Next
        Dim tcLng As Integer = txtCert.Text.Length
        Dim tclRem As Integer = 6 - tcLng
        Dim tclPrt As String
        If tclRem = 0 Then
            MsgBox(txtCert.Text & " Not on File")
        Else
            tclPrt = txtCert.Text
            For i = 0 To tclRem - 1
                tclPrt = tclPrt & "."
            Next
            MessageBox.Show(tclPrt & " Not on File", "Certificate Redeem")

            'MsgBox(tclPrt & " Not on File")
        End If

    End Sub

    Private Sub txtCert_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCert.KeyDown
        If e.KeyCode = Keys.Enter Then
            MsgBox("enter key pressd ")
        End If

    End Sub

    Private Sub txtDRedem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDRedem.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            Dtp1.Visible = False
            txtDRedem.Select()
        Else
            Dtp1.Visible = True
        End If

    End Sub

    Private Sub txtDRedem_MouseClick(sender As Object, e As MouseEventArgs) Handles txtDRedem.MouseClick
        Dtp1.Value = Today
        Dtp1.Visible = True

    End Sub

    Private Sub Dtp1_CloseUp(sender As Object, e As EventArgs) Handles Dtp1.CloseUp
        txtDRedem.Text = Dtp1.Value.ToString("MM/dd/yyyy")
        todayIs = txtDRedem.Text
        Dtp1.Visible = False
        Application.DoEvents()
        'txtSoldTo.Select() 'txtSoldTo

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Dtp1_ValueChanged(sender As Object, e As EventArgs) Handles Dtp1.ValueChanged

    End Sub
End Class