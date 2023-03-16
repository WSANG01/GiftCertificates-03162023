<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCertRange = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDSold = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSoldTo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.lblAdded = New System.Windows.Forms.Label()
        Me.txtCertNr = New System.Windows.Forms.TextBox()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblNext = New System.Windows.Forms.Label()
        Me.ckNext = New System.Windows.Forms.CheckBox()
        Me.Dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBMin = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PBMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(549, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(182, 45)
        Me.btnExit.TabIndex = 99
        Me.btnExit.Text = "Home"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Certificate Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Range Count"
        '
        'txtCertRange
        '
        Me.txtCertRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCertRange.Location = New System.Drawing.Point(286, 200)
        Me.txtCertRange.MaxLength = 6
        Me.txtCertRange.Name = "txtCertRange"
        Me.txtCertRange.Size = New System.Drawing.Size(103, 35)
        Me.txtCertRange.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(156, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date Sold"
        '
        'txtDSold
        '
        Me.txtDSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDSold.Location = New System.Drawing.Point(286, 255)
        Me.txtDSold.MaxLength = 10
        Me.txtDSold.Name = "txtDSold"
        Me.txtDSold.Size = New System.Drawing.Size(144, 35)
        Me.txtDSold.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(168, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sold To"
        '
        'txtSoldTo
        '
        Me.txtSoldTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoldTo.Location = New System.Drawing.Point(286, 309)
        Me.txtSoldTo.MaxLength = 30
        Me.txtSoldTo.Name = "txtSoldTo"
        Me.txtSoldTo.Size = New System.Drawing.Size(444, 35)
        Me.txtSoldTo.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(76, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date Redeemed"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(177, 423)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Notes"
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(286, 423)
        Me.txtNotes.MaxLength = 30
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(444, 35)
        Me.txtNotes.TabIndex = 12
        '
        'btnRecord
        '
        Me.btnRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecord.Location = New System.Drawing.Point(66, 480)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(188, 45)
        Me.btnRecord.TabIndex = 98
        Me.btnRecord.Text = "Record Sale(s)"
        Me.btnRecord.UseVisualStyleBackColor = True
        Me.btnRecord.Visible = False
        '
        'lblAdded
        '
        Me.lblAdded.AutoSize = True
        Me.lblAdded.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdded.Location = New System.Drawing.Point(87, 408)
        Me.lblAdded.Name = "lblAdded"
        Me.lblAdded.Size = New System.Drawing.Size(0, 29)
        Me.lblAdded.TabIndex = 14
        Me.lblAdded.Visible = False
        '
        'txtCertNr
        '
        Me.txtCertNr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCertNr.Location = New System.Drawing.Point(286, 142)
        Me.txtCertNr.MaxLength = 6
        Me.txtCertNr.Name = "txtCertNr"
        Me.txtCertNr.Size = New System.Drawing.Size(103, 35)
        Me.txtCertNr.TabIndex = 2
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.BackColor = System.Drawing.Color.Transparent
        Me.lblLast.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.Location = New System.Drawing.Point(454, 154)
        Me.lblLast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(219, 23)
        Me.lblLast.TabIndex = 100
        Me.lblLast.Text = "Next Available Cert. Nr.:"
        '
        'lblNext
        '
        Me.lblNext.AutoSize = True
        Me.lblNext.BackColor = System.Drawing.Color.Transparent
        Me.lblNext.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNext.Location = New System.Drawing.Point(675, 154)
        Me.lblNext.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNext.Name = "lblNext"
        Me.lblNext.Size = New System.Drawing.Size(76, 23)
        Me.lblNext.TabIndex = 101
        Me.lblNext.Text = "123456"
        '
        'ckNext
        '
        Me.ckNext.AutoSize = True
        Me.ckNext.BackColor = System.Drawing.Color.Transparent
        Me.ckNext.Location = New System.Drawing.Point(438, 157)
        Me.ckNext.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ckNext.Name = "ckNext"
        Me.ckNext.Size = New System.Drawing.Size(22, 21)
        Me.ckNext.TabIndex = 102
        Me.ckNext.UseVisualStyleBackColor = False
        '
        'Dtp1
        '
        Me.Dtp1.AllowDrop = True
        Me.Dtp1.CustomFormat = "MM/dd/yyyy"
        Me.Dtp1.Location = New System.Drawing.Point(438, 258)
        Me.Dtp1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dtp1.Name = "Dtp1"
        Me.Dtp1.Size = New System.Drawing.Size(152, 26)
        Me.Dtp1.TabIndex = 103
        Me.Dtp1.Value = New Date(2023, 1, 17, 0, 0, 0, 0)
        Me.Dtp1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PBMin)
        Me.Panel1.Controls.Add(Me.Dtp1)
        Me.Panel1.Controls.Add(Me.ckNext)
        Me.Panel1.Controls.Add(Me.lblNext)
        Me.Panel1.Controls.Add(Me.lblLast)
        Me.Panel1.Controls.Add(Me.txtCertNr)
        Me.Panel1.Controls.Add(Me.lblAdded)
        Me.Panel1.Controls.Add(Me.btnRecord)
        Me.Panel1.Controls.Add(Me.txtNotes)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtSoldTo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtDSold)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtCertRange)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 540)
        Me.Panel1.TabIndex = 104
        '
        'PBMin
        '
        Me.PBMin.BackColor = System.Drawing.Color.Transparent
        Me.PBMin.BackgroundImage = CType(resources.GetObject("PBMin.BackgroundImage"), System.Drawing.Image)
        Me.PBMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBMin.Location = New System.Drawing.Point(747, 18)
        Me.PBMin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PBMin.Name = "PBMin"
        Me.PBMin.Size = New System.Drawing.Size(34, 33)
        Me.PBMin.TabIndex = 104
        Me.PBMin.TabStop = False
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 537)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cafe duMonde Gift Certificates Sales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCertRange As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDSold As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSoldTo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnRecord As Button
    Friend WithEvents lblAdded As Label
    Friend WithEvents txtCertNr As TextBox
    Friend WithEvents lblLast As Label
    Friend WithEvents lblNext As Label
    Friend WithEvents ckNext As CheckBox
    Friend WithEvents Dtp1 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBMin As PictureBox
End Class
