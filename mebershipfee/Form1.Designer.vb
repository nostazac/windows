<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdOneTimePurchase = New System.Windows.Forms.RadioButton()
        Me.rdYearly = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkCloudBackup = New System.Windows.Forms.CheckBox()
        Me.chkOn_site = New System.Windows.Forms.CheckBox()
        Me.chkTechSupport = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblOptionalCost = New System.Windows.Forms.Label()
        Me.lblSoftwareCost = New System.Windows.Forms.Label()
        Me.label23 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdOneTimePurchase)
        Me.GroupBox1.Controls.Add(Me.rdYearly)
        Me.GroupBox1.Location = New System.Drawing.Point(109, 39)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(303, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Licensing Options"
        '
        'rdOneTimePurchase
        '
        Me.rdOneTimePurchase.AutoSize = True
        Me.rdOneTimePurchase.Location = New System.Drawing.Point(36, 80)
        Me.rdOneTimePurchase.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdOneTimePurchase.Name = "rdOneTimePurchase"
        Me.rdOneTimePurchase.Size = New System.Drawing.Size(155, 19)
        Me.rdOneTimePurchase.TabIndex = 1
        Me.rdOneTimePurchase.TabStop = True
        Me.rdOneTimePurchase.Text = "One-Time Purchase "
        Me.rdOneTimePurchase.UseVisualStyleBackColor = True
        '
        'rdYearly
        '
        Me.rdYearly.AutoSize = True
        Me.rdYearly.Location = New System.Drawing.Point(36, 40)
        Me.rdYearly.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdYearly.Name = "rdYearly"
        Me.rdYearly.Size = New System.Drawing.Size(120, 19)
        Me.rdYearly.TabIndex = 0
        Me.rdYearly.TabStop = True
        Me.rdYearly.Text = "Yearly License"
        Me.rdYearly.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCloudBackup)
        Me.GroupBox2.Controls.Add(Me.chkOn_site)
        Me.GroupBox2.Controls.Add(Me.chkTechSupport)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(569, 39)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(332, 155)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Optional features(yearly)"
        '
        'chkCloudBackup
        '
        Me.chkCloudBackup.AutoSize = True
        Me.chkCloudBackup.Location = New System.Drawing.Point(8, 128)
        Me.chkCloudBackup.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkCloudBackup.Name = "chkCloudBackup"
        Me.chkCloudBackup.Size = New System.Drawing.Size(115, 19)
        Me.chkCloudBackup.TabIndex = 2
        Me.chkCloudBackup.Text = "Cloud Backup"
        Me.chkCloudBackup.UseVisualStyleBackColor = True
        '
        'chkOn_site
        '
        Me.chkOn_site.AutoSize = True
        Me.chkOn_site.Location = New System.Drawing.Point(8, 81)
        Me.chkOn_site.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkOn_site.Name = "chkOn_site"
        Me.chkOn_site.Size = New System.Drawing.Size(137, 19)
        Me.chkOn_site.TabIndex = 1
        Me.chkOn_site.Text = "One-site Training"
        Me.chkOn_site.UseVisualStyleBackColor = True
        '
        'chkTechSupport
        '
        Me.chkTechSupport.AutoSize = True
        Me.chkTechSupport.Location = New System.Drawing.Point(8, 40)
        Me.chkTechSupport.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkTechSupport.Name = "chkTechSupport"
        Me.chkTechSupport.Size = New System.Drawing.Size(195, 19)
        Me.chkTechSupport.TabIndex = 0
        Me.chkTechSupport.Text = "Level-3 Technical Support"
        Me.chkTechSupport.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblOptionalCost)
        Me.GroupBox3.Controls.Add(Me.lblSoftwareCost)
        Me.GroupBox3.Controls.Add(Me.label23)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(332, 231)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(416, 122)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'lblOptionalCost
        '
        Me.lblOptionalCost.AutoSize = True
        Me.lblOptionalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptionalCost.Location = New System.Drawing.Point(272, 80)
        Me.lblOptionalCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOptionalCost.Name = "lblOptionalCost"
        Me.lblOptionalCost.Size = New System.Drawing.Size(78, 17)
        Me.lblOptionalCost.TabIndex = 3
        Me.lblOptionalCost.Text = "                       "
        '
        'lblSoftwareCost
        '
        Me.lblSoftwareCost.AutoSize = True
        Me.lblSoftwareCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSoftwareCost.Location = New System.Drawing.Point(272, 42)
        Me.lblSoftwareCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSoftwareCost.Name = "lblSoftwareCost"
        Me.lblSoftwareCost.Size = New System.Drawing.Size(78, 17)
        Me.lblSoftwareCost.TabIndex = 2
        Me.lblSoftwareCost.Text = "                       "
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Location = New System.Drawing.Point(24, 82)
        Me.label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(167, 15)
        Me.label23.TabIndex = 1
        Me.label23.Text = "Cost of Optional features"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cost Of Software Licensing"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(211, 424)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 27)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(495, 424)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 27)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(772, 424)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 27)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1021, 517)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdOneTimePurchase As System.Windows.Forms.RadioButton
    Friend WithEvents rdYearly As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCloudBackup As System.Windows.Forms.CheckBox
    Friend WithEvents chkOn_site As System.Windows.Forms.CheckBox
    Friend WithEvents chkTechSupport As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblOptionalCost As System.Windows.Forms.Label
    Friend WithEvents lblSoftwareCost As System.Windows.Forms.Label
    Friend WithEvents label23 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
