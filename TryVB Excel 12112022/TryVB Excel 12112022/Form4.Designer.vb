<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Redeem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Redeem))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRedeem = New System.Windows.Forms.Button()
        Me.PBMin = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCert = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDRedem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dtp1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PBMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(909, 634)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 58)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRedeem
        '
        Me.btnRedeem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRedeem.Location = New System.Drawing.Point(16, 634)
        Me.btnRedeem.Name = "btnRedeem"
        Me.btnRedeem.Size = New System.Drawing.Size(282, 58)
        Me.btnRedeem.TabIndex = 3
        Me.btnRedeem.Text = "Redeem Selected Items"
        Me.btnRedeem.UseVisualStyleBackColor = True
        '
        'PBMin
        '
        Me.PBMin.BackColor = System.Drawing.Color.Transparent
        Me.PBMin.BackgroundImage = CType(resources.GetObject("PBMin.BackgroundImage"), System.Drawing.Image)
        Me.PBMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBMin.InitialImage = CType(resources.GetObject("PBMin.InitialImage"), System.Drawing.Image)
        Me.PBMin.Location = New System.Drawing.Point(1064, 18)
        Me.PBMin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PBMin.Name = "PBMin"
        Me.PBMin.Size = New System.Drawing.Size(34, 33)
        Me.PBMin.TabIndex = 10
        Me.PBMin.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DataGridView1.Location = New System.Drawing.Point(4, 108)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(1094, 514)
        Me.DataGridView1.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "Certificate Nr."
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 134
        '
        'Column2
        '
        Me.Column2.HeaderText = "Range"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 133
        '
        'Column4
        '
        Me.Column4.HeaderText = "Date Sold"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 134
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sold To"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 134
        '
        'Column6
        '
        Me.Column6.HeaderText = "Date Redeemed"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 133
        '
        'Column7
        '
        Me.Column7.HeaderText = "Notes"
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 134
        '
        'Column8
        '
        Me.Column8.HeaderText = "Future(1)"
        Me.Column8.MinimumWidth = 8
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 133
        '
        'Column9
        '
        Me.Column9.HeaderText = "Future(2)"
        Me.Column9.MinimumWidth = 8
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 134
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Certificate Number:"
        '
        'txtCert
        '
        Me.txtCert.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCert.Location = New System.Drawing.Point(248, 12)
        Me.txtCert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCert.Name = "txtCert"
        Me.txtCert.Size = New System.Drawing.Size(79, 35)
        Me.txtCert.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.txtDRedem)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Dtp1)
        Me.Panel1.Controls.Add(Me.txtCert)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.PBMin)
        Me.Panel1.Controls.Add(Me.btnRedeem)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(3, -5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1114, 732)
        Me.Panel1.TabIndex = 4
        '
        'txtDRedem
        '
        Me.txtDRedem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDRedem.Location = New System.Drawing.Point(216, 67)
        Me.txtDRedem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDRedem.Name = "txtDRedem"
        Me.txtDRedem.Size = New System.Drawing.Size(111, 35)
        Me.txtDRedem.TabIndex = 106
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 29)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Date Redeemed:"
        '
        'Dtp1
        '
        Me.Dtp1.AllowDrop = True
        Me.Dtp1.CustomFormat = "MM/dd/yyyy"
        Me.Dtp1.Location = New System.Drawing.Point(216, 112)
        Me.Dtp1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dtp1.Name = "Dtp1"
        Me.Dtp1.Size = New System.Drawing.Size(290, 26)
        Me.Dtp1.TabIndex = 104
        Me.Dtp1.Value = New Date(2023, 1, 27, 0, 0, 0, 0)
        Me.Dtp1.Visible = False
        '
        'Redeem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1114, 723)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Redeem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cafe duMonde Gift Certificate Redeem"
        CType(Me.PBMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnRedeem As Button
    Friend WithEvents PBMin As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCert As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Dtp1 As DateTimePicker
    Friend WithEvents txtDRedem As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
