<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.btnSale = New System.Windows.Forms.Button()
        Me.btnRedeem = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblSale = New System.Windows.Forms.Label()
        Me.lblRedeem = New System.Windows.Forms.Label()
        Me.lblReports = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.PBMin = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.LblVer = New System.Windows.Forms.Label()
        CType(Me.PBMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSale
        '
        Me.btnSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSale.Location = New System.Drawing.Point(188, 269)
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(290, 62)
        Me.btnSale.TabIndex = 1
        Me.btnSale.Text = "Sale"
        Me.btnSale.UseVisualStyleBackColor = True
        Me.btnSale.Visible = False
        '
        'btnRedeem
        '
        Me.btnRedeem.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRedeem.Location = New System.Drawing.Point(188, 372)
        Me.btnRedeem.Name = "btnRedeem"
        Me.btnRedeem.Size = New System.Drawing.Size(290, 62)
        Me.btnRedeem.TabIndex = 2
        Me.btnRedeem.Text = "Redeem"
        Me.btnRedeem.UseVisualStyleBackColor = True
        Me.btnRedeem.Visible = False
        '
        'btnReports
        '
        Me.btnReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(188, 475)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(290, 62)
        Me.btnReports.TabIndex = 3
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        Me.btnReports.Visible = False
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(188, 578)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(290, 62)
        Me.btnHome.TabIndex = 4
        Me.btnHome.Text = "Exit Program"
        Me.btnHome.UseVisualStyleBackColor = True
        Me.btnHome.Visible = False
        '
        'lblSale
        '
        Me.lblSale.AutoSize = True
        Me.lblSale.BackColor = System.Drawing.Color.Transparent
        Me.lblSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSale.Location = New System.Drawing.Point(484, 292)
        Me.lblSale.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSale.Name = "lblSale"
        Me.lblSale.Size = New System.Drawing.Size(353, 29)
        Me.lblSale.TabIndex = 5
        Me.lblSale.Text = "Record Sales of Gift Certificates"
        '
        'lblRedeem
        '
        Me.lblRedeem.AutoSize = True
        Me.lblRedeem.BackColor = System.Drawing.Color.Transparent
        Me.lblRedeem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRedeem.Location = New System.Drawing.Point(484, 395)
        Me.lblRedeem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRedeem.Name = "lblRedeem"
        Me.lblRedeem.Size = New System.Drawing.Size(345, 29)
        Me.lblRedeem.TabIndex = 6
        Me.lblRedeem.Text = "Record Redeemed Certificates"
        '
        'lblReports
        '
        Me.lblReports.AutoSize = True
        Me.lblReports.BackColor = System.Drawing.Color.Transparent
        Me.lblReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReports.Location = New System.Drawing.Point(484, 498)
        Me.lblReports.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReports.Name = "lblReports"
        Me.lblReports.Size = New System.Drawing.Size(301, 29)
        Me.lblReports.TabIndex = 7
        Me.lblReports.Text = "Gift Certificate File Reports"
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.Transparent
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(484, 602)
        Me.lblExit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(230, 29)
        Me.lblExit.TabIndex = 8
        Me.lblExit.Text = "Record File and Exit"
        '
        'PBMin
        '
        Me.PBMin.BackColor = System.Drawing.Color.Transparent
        Me.PBMin.BackgroundImage = CType(resources.GetObject("PBMin.BackgroundImage"), System.Drawing.Image)
        Me.PBMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBMin.Location = New System.Drawing.Point(972, 18)
        Me.PBMin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PBMin.Name = "PBMin"
        Me.PBMin.Size = New System.Drawing.Size(34, 33)
        Me.PBMin.TabIndex = 9
        Me.PBMin.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.LblVer)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PBMin)
        Me.Panel1.Controls.Add(Me.lblExit)
        Me.Panel1.Controls.Add(Me.lblReports)
        Me.Panel1.Controls.Add(Me.lblRedeem)
        Me.Panel1.Controls.Add(Me.lblSale)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.btnReports)
        Me.Panel1.Controls.Add(Me.btnRedeem)
        Me.Panel1.Controls.Add(Me.btnSale)
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1029, 751)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(486, 395)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Loading Gift Certificate.xlsx  File"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(392, 369)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 98)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'LblVer
        '
        Me.LblVer.AutoSize = True
        Me.LblVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVer.Location = New System.Drawing.Point(850, 641)
        Me.LblVer.Name = "LblVer"
        Me.LblVer.Size = New System.Drawing.Size(0, 15)
        Me.LblVer.TabIndex = 12
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gift Certificate Tracking Main Menu"
        CType(Me.PBMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSale As Button
    Friend WithEvents btnRedeem As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents lblSale As Label
    Friend WithEvents lblRedeem As Label
    Friend WithEvents lblReports As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents PBMin As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LblVer As Label
End Class
