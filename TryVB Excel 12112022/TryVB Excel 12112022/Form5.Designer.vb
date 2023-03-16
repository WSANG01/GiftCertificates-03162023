<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.certNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.certRange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dSold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.soldTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dRedeemed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fut1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fut2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBMin = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PBMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.certNumber, Me.certRange, Me.dSold, Me.soldTo, Me.dRedeemed, Me.notes, Me.fut1, Me.fut2})
        Me.DataGridView1.Location = New System.Drawing.Point(22, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1072, 606)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.Visible = False
        '
        'certNumber
        '
        Me.certNumber.HeaderText = "Certificate Nr."
        Me.certNumber.MinimumWidth = 8
        Me.certNumber.Name = "certNumber"
        '
        'certRange
        '
        Me.certRange.HeaderText = "Range"
        Me.certRange.MinimumWidth = 8
        Me.certRange.Name = "certRange"
        '
        'dSold
        '
        Me.dSold.HeaderText = "Date Sold"
        Me.dSold.MinimumWidth = 8
        Me.dSold.Name = "dSold"
        '
        'soldTo
        '
        Me.soldTo.HeaderText = "Sold To"
        Me.soldTo.MinimumWidth = 8
        Me.soldTo.Name = "soldTo"
        '
        'dRedeemed
        '
        Me.dRedeemed.HeaderText = "Date Redeemed"
        Me.dRedeemed.MinimumWidth = 8
        Me.dRedeemed.Name = "dRedeemed"
        '
        'notes
        '
        Me.notes.HeaderText = "Notes"
        Me.notes.MinimumWidth = 8
        Me.notes.Name = "notes"
        '
        'fut1
        '
        Me.fut1.HeaderText = "Future(1)"
        Me.fut1.MinimumWidth = 8
        Me.fut1.Name = "fut1"
        '
        'fut2
        '
        Me.fut2.HeaderText = "Future(2)"
        Me.fut2.MinimumWidth = 8
        Me.fut2.Name = "fut2"
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(918, 692)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(177, 43)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PBMin)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1130, 765)
        Me.Panel1.TabIndex = 2
        '
        'PBMin
        '
        Me.PBMin.BackColor = System.Drawing.Color.Transparent
        Me.PBMin.BackgroundImage = CType(resources.GetObject("PBMin.BackgroundImage"), System.Drawing.Image)
        Me.PBMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBMin.Location = New System.Drawing.Point(1065, 18)
        Me.PBMin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PBMin.Name = "PBMin"
        Me.PBMin.Size = New System.Drawing.Size(34, 33)
        Me.PBMin.TabIndex = 105
        Me.PBMin.TabStop = False
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1120, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cafe duMonde Gift Certificate Reports"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PBMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents certNumber As DataGridViewTextBoxColumn
    Friend WithEvents certRange As DataGridViewTextBoxColumn
    Friend WithEvents dSold As DataGridViewTextBoxColumn
    Friend WithEvents soldTo As DataGridViewTextBoxColumn
    Friend WithEvents dRedeemed As DataGridViewTextBoxColumn
    Friend WithEvents notes As DataGridViewTextBoxColumn
    Friend WithEvents fut1 As DataGridViewTextBoxColumn
    Friend WithEvents fut2 As DataGridViewTextBoxColumn
    Friend WithEvents btnHome As Button
    Public WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBMin As PictureBox
End Class
