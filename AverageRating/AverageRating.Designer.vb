<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AverageRating
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AverageRating))
        Me.pbxLogo2 = New System.Windows.Forms.PictureBox()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.lblHotel = New System.Windows.Forms.Label()
        Me.grpColor = New System.Windows.Forms.GroupBox()
        Me.rbGreen = New System.Windows.Forms.RadioButton()
        Me.rbPurple = New System.Windows.Forms.RadioButton()
        Me.rbBlue = New System.Windows.Forms.RadioButton()
        Me.rbRed = New System.Windows.Forms.RadioButton()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLiveDate = New System.Windows.Forms.Label()
        Me.lblLiveTime = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.lblTv = New System.Windows.Forms.Label()
        Me.lblParking = New System.Windows.Forms.Label()
        Me.lblPool = New System.Windows.Forms.Label()
        Me.grpServices = New System.Windows.Forms.GroupBox()
        Me.txtInternet = New System.Windows.Forms.TextBox()
        Me.txtPool = New System.Windows.Forms.TextBox()
        Me.txtParking = New System.Windows.Forms.TextBox()
        Me.lblInternet = New System.Windows.Forms.Label()
        Me.txtTv = New System.Windows.Forms.TextBox()
        Me.txtService = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.pbxLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpColor.SuspendLayout()
        Me.grpServices.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxLogo2
        '
        Me.pbxLogo2.Image = CType(resources.GetObject("pbxLogo2.Image"), System.Drawing.Image)
        Me.pbxLogo2.Location = New System.Drawing.Point(12, 12)
        Me.pbxLogo2.Name = "pbxLogo2"
        Me.pbxLogo2.Size = New System.Drawing.Size(124, 80)
        Me.pbxLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo2.TabIndex = 0
        Me.pbxLogo2.TabStop = False
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(458, 12)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(124, 80)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 1
        Me.pbxLogo.TabStop = False
        '
        'lblHotel
        '
        Me.lblHotel.Font = New System.Drawing.Font("Vivaldi", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHotel.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblHotel.Location = New System.Drawing.Point(142, 12)
        Me.lblHotel.Name = "lblHotel"
        Me.lblHotel.Size = New System.Drawing.Size(310, 80)
        Me.lblHotel.TabIndex = 15
        Me.lblHotel.Text = "Ice Wolf Hotel"
        Me.lblHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpColor
        '
        Me.grpColor.Controls.Add(Me.rbGreen)
        Me.grpColor.Controls.Add(Me.rbPurple)
        Me.grpColor.Controls.Add(Me.rbBlue)
        Me.grpColor.Controls.Add(Me.rbRed)
        Me.grpColor.Location = New System.Drawing.Point(438, 140)
        Me.grpColor.Name = "grpColor"
        Me.grpColor.Size = New System.Drawing.Size(117, 155)
        Me.grpColor.TabIndex = 5
        Me.grpColor.TabStop = False
        Me.grpColor.Text = "Change color"
        '
        'rbGreen
        '
        Me.rbGreen.AutoSize = True
        Me.rbGreen.Location = New System.Drawing.Point(20, 119)
        Me.rbGreen.Name = "rbGreen"
        Me.rbGreen.Size = New System.Drawing.Size(54, 17)
        Me.rbGreen.TabIndex = 23
        Me.rbGreen.TabStop = True
        Me.rbGreen.Text = "Green"
        Me.rbGreen.UseVisualStyleBackColor = True
        '
        'rbPurple
        '
        Me.rbPurple.AutoSize = True
        Me.rbPurple.Location = New System.Drawing.Point(20, 89)
        Me.rbPurple.Name = "rbPurple"
        Me.rbPurple.Size = New System.Drawing.Size(55, 17)
        Me.rbPurple.TabIndex = 22
        Me.rbPurple.TabStop = True
        Me.rbPurple.Text = "Purple"
        Me.rbPurple.UseVisualStyleBackColor = True
        '
        'rbBlue
        '
        Me.rbBlue.AutoSize = True
        Me.rbBlue.Location = New System.Drawing.Point(20, 30)
        Me.rbBlue.Name = "rbBlue"
        Me.rbBlue.Size = New System.Drawing.Size(46, 17)
        Me.rbBlue.TabIndex = 21
        Me.rbBlue.TabStop = True
        Me.rbBlue.Text = "Blue"
        Me.rbBlue.UseVisualStyleBackColor = True
        '
        'rbRed
        '
        Me.rbRed.AutoSize = True
        Me.rbRed.Location = New System.Drawing.Point(20, 60)
        Me.rbRed.Name = "rbRed"
        Me.rbRed.Size = New System.Drawing.Size(45, 17)
        Me.rbRed.TabIndex = 4
        Me.rbRed.TabStop = True
        Me.rbRed.Text = "Red"
        Me.rbRed.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(485, 411)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(91, 13)
        Me.lblName.TabIndex = 19
        Me.lblName.Text = "Brian Nicewander"
        '
        'lblLiveDate
        '
        Me.lblLiveDate.AutoSize = True
        Me.lblLiveDate.Location = New System.Drawing.Point(12, 411)
        Me.lblLiveDate.Name = "lblLiveDate"
        Me.lblLiveDate.Size = New System.Drawing.Size(30, 13)
        Me.lblLiveDate.TabIndex = 17
        Me.lblLiveDate.Text = "Date"
        '
        'lblLiveTime
        '
        Me.lblLiveTime.AutoSize = True
        Me.lblLiveTime.Location = New System.Drawing.Point(168, 411)
        Me.lblLiveTime.Name = "lblLiveTime"
        Me.lblLiveTime.Size = New System.Drawing.Size(30, 13)
        Me.lblLiveTime.TabIndex = 18
        Me.lblLiveTime.Text = "Time"
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblService.Location = New System.Drawing.Point(6, 23)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(77, 13)
        Me.lblService.TabIndex = 8
        Me.lblService.Text = "Room Service:"
        '
        'lblTv
        '
        Me.lblTv.AutoSize = True
        Me.lblTv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTv.Location = New System.Drawing.Point(6, 64)
        Me.lblTv.Name = "lblTv"
        Me.lblTv.Size = New System.Drawing.Size(66, 13)
        Me.lblTv.TabIndex = 9
        Me.lblTv.Text = "TV Charges:"
        '
        'lblParking
        '
        Me.lblParking.AutoSize = True
        Me.lblParking.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParking.Location = New System.Drawing.Point(6, 103)
        Me.lblParking.Name = "lblParking"
        Me.lblParking.Size = New System.Drawing.Size(46, 13)
        Me.lblParking.TabIndex = 10
        Me.lblParking.Text = "Parking:"
        '
        'lblPool
        '
        Me.lblPool.AutoSize = True
        Me.lblPool.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPool.Location = New System.Drawing.Point(6, 142)
        Me.lblPool.Name = "lblPool"
        Me.lblPool.Size = New System.Drawing.Size(31, 13)
        Me.lblPool.TabIndex = 11
        Me.lblPool.Text = "Pool:"
        '
        'grpServices
        '
        Me.grpServices.Controls.Add(Me.txtInternet)
        Me.grpServices.Controls.Add(Me.txtPool)
        Me.grpServices.Controls.Add(Me.txtParking)
        Me.grpServices.Controls.Add(Me.lblInternet)
        Me.grpServices.Controls.Add(Me.txtTv)
        Me.grpServices.Controls.Add(Me.lblPool)
        Me.grpServices.Controls.Add(Me.txtService)
        Me.grpServices.Controls.Add(Me.lblService)
        Me.grpServices.Controls.Add(Me.lblParking)
        Me.grpServices.Controls.Add(Me.lblTv)
        Me.grpServices.Location = New System.Drawing.Point(15, 140)
        Me.grpServices.Name = "grpServices"
        Me.grpServices.Size = New System.Drawing.Size(138, 222)
        Me.grpServices.TabIndex = 1
        Me.grpServices.TabStop = False
        Me.grpServices.Text = "Services"
        '
        'txtInternet
        '
        Me.txtInternet.Location = New System.Drawing.Point(6, 197)
        Me.txtInternet.Name = "txtInternet"
        Me.txtInternet.Size = New System.Drawing.Size(100, 20)
        Me.txtInternet.TabIndex = 4
        '
        'txtPool
        '
        Me.txtPool.Location = New System.Drawing.Point(6, 158)
        Me.txtPool.Name = "txtPool"
        Me.txtPool.Size = New System.Drawing.Size(100, 20)
        Me.txtPool.TabIndex = 3
        '
        'txtParking
        '
        Me.txtParking.Location = New System.Drawing.Point(6, 119)
        Me.txtParking.Name = "txtParking"
        Me.txtParking.Size = New System.Drawing.Size(100, 20)
        Me.txtParking.TabIndex = 2
        '
        'lblInternet
        '
        Me.lblInternet.AutoSize = True
        Me.lblInternet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInternet.Location = New System.Drawing.Point(6, 181)
        Me.lblInternet.Name = "lblInternet"
        Me.lblInternet.Size = New System.Drawing.Size(46, 13)
        Me.lblInternet.TabIndex = 12
        Me.lblInternet.Text = "Internet:"
        '
        'txtTv
        '
        Me.txtTv.Location = New System.Drawing.Point(6, 80)
        Me.txtTv.Name = "txtTv"
        Me.txtTv.Size = New System.Drawing.Size(100, 20)
        Me.txtTv.TabIndex = 1
        '
        'txtService
        '
        Me.txtService.Location = New System.Drawing.Point(6, 41)
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(100, 20)
        Me.txtService.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(234, 92)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(121, 18)
        Me.lblTitle.TabIndex = 16
        Me.lblTitle.Text = "Average Rating"
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(237, 233)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(102, 23)
        Me.btnAverage.TabIndex = 2
        Me.btnAverage.Text = "&Calculate Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(205, 177)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(167, 24)
        Me.lblAverage.TabIndex = 14
        Me.lblAverage.Text = "Average Results"
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(248, 321)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 453)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(612, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'AverageRating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 475)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpServices)
        Me.Controls.Add(Me.lblLiveTime)
        Me.Controls.Add(Me.lblLiveDate)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.grpColor)
        Me.Controls.Add(Me.lblHotel)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.pbxLogo2)
        Me.Name = "AverageRating"
        Me.Text = "Average Rating"
        CType(Me.pbxLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpColor.ResumeLayout(False)
        Me.grpColor.PerformLayout()
        Me.grpServices.ResumeLayout(False)
        Me.grpServices.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxLogo2 As PictureBox
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents lblHotel As Label
    Friend WithEvents grpColor As GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblLiveDate As Label
    Friend WithEvents lblLiveTime As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblTv As Label
    Friend WithEvents lblParking As Label
    Friend WithEvents lblPool As Label
    Friend WithEvents grpServices As GroupBox
    Friend WithEvents txtService As TextBox
    Friend WithEvents txtTv As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnAverage As Button
    Friend WithEvents lblAverage As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents txtInternet As TextBox
    Friend WithEvents txtPool As TextBox
    Friend WithEvents txtParking As TextBox
    Friend WithEvents lblInternet As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents rbGreen As RadioButton
    Friend WithEvents rbPurple As RadioButton
    Friend WithEvents rbBlue As RadioButton
    Friend WithEvents rbRed As RadioButton
End Class
