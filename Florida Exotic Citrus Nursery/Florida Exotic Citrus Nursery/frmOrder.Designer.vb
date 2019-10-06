<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Me.components = New System.ComponentModel.Container()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblOptional = New System.Windows.Forms.Label()
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.rbKeyL = New System.Windows.Forms.RadioButton()
        Me.rbMeyerL = New System.Windows.Forms.RadioButton()
        Me.rbPersianL = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbQuantity = New System.Windows.Forms.TextBox()
        Me.chkbDelivery = New System.Windows.Forms.CheckBox()
        Me.chkbPlanting = New System.Windows.Forms.CheckBox()
        Me.grpCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.txtbState = New System.Windows.Forms.TextBox()
        Me.txtbLastN = New System.Windows.Forms.TextBox()
        Me.mskZip = New System.Windows.Forms.MaskedTextBox()
        Me.mskPhoneNum = New System.Windows.Forms.MaskedTextBox()
        Me.txtbAddress = New System.Windows.Forms.TextBox()
        Me.txtbFirstN = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblLastN = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhoneNum = New System.Windows.Forms.Label()
        Me.lblFirstN = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpCustomerInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(372, 349)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(70, 20)
        Me.lblQuantity.TabIndex = 1
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblOptional
        '
        Me.lblOptional.AutoSize = True
        Me.lblOptional.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptional.Location = New System.Drawing.Point(547, 349)
        Me.lblOptional.Name = "lblOptional"
        Me.lblOptional.Size = New System.Drawing.Size(128, 20)
        Me.lblOptional.TabIndex = 2
        Me.lblOptional.Text = "Optional Services:"
        '
        'lblInstruct
        '
        Me.lblInstruct.AutoSize = True
        Me.lblInstruct.BackColor = System.Drawing.Color.Transparent
        Me.lblInstruct.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct.Location = New System.Drawing.Point(9, 89)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(254, 23)
        Me.lblInstruct.TabIndex = 4
        Me.lblInstruct.Text = "Please fill out the form below."
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'rbKeyL
        '
        Me.rbKeyL.AutoSize = True
        Me.rbKeyL.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbKeyL.Location = New System.Drawing.Point(6, 30)
        Me.rbKeyL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbKeyL.Name = "rbKeyL"
        Me.rbKeyL.Size = New System.Drawing.Size(90, 24)
        Me.rbKeyL.TabIndex = 5
        Me.rbKeyL.TabStop = True
        Me.rbKeyL.Text = "Key Lime"
        Me.rbKeyL.UseVisualStyleBackColor = True
        '
        'rbMeyerL
        '
        Me.rbMeyerL.AutoSize = True
        Me.rbMeyerL.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMeyerL.Location = New System.Drawing.Point(6, 94)
        Me.rbMeyerL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbMeyerL.Name = "rbMeyerL"
        Me.rbMeyerL.Size = New System.Drawing.Size(108, 24)
        Me.rbMeyerL.TabIndex = 6
        Me.rbMeyerL.TabStop = True
        Me.rbMeyerL.Text = "Meyer Lime"
        Me.rbMeyerL.UseVisualStyleBackColor = True
        '
        'rbPersianL
        '
        Me.rbPersianL.AutoSize = True
        Me.rbPersianL.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPersianL.Location = New System.Drawing.Point(6, 61)
        Me.rbPersianL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbPersianL.Name = "rbPersianL"
        Me.rbPersianL.Size = New System.Drawing.Size(115, 24)
        Me.rbPersianL.TabIndex = 7
        Me.rbPersianL.TabStop = True
        Me.rbPersianL.Text = "Persian Lime"
        Me.rbPersianL.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "$15.95 per tree"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(163, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "$13.95 per tree"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(163, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "$12.95 per tree"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbPersianL)
        Me.GroupBox1.Controls.Add(Me.rbMeyerL)
        Me.GroupBox1.Controls.Add(Me.rbKeyL)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 342)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(290, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a tree:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(372, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Limit 5 per person."
        '
        'txtbQuantity
        '
        Me.txtbQuantity.Location = New System.Drawing.Point(376, 372)
        Me.txtbQuantity.MaxLength = 1
        Me.txtbQuantity.Name = "txtbQuantity"
        Me.txtbQuantity.Size = New System.Drawing.Size(133, 25)
        Me.txtbQuantity.TabIndex = 12
        Me.txtbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkbDelivery
        '
        Me.chkbDelivery.AutoSize = True
        Me.chkbDelivery.Location = New System.Drawing.Point(556, 381)
        Me.chkbDelivery.Name = "chkbDelivery"
        Me.chkbDelivery.Size = New System.Drawing.Size(127, 24)
        Me.chkbDelivery.TabIndex = 13
        Me.chkbDelivery.Text = "Delivery  ($10)"
        Me.chkbDelivery.UseVisualStyleBackColor = True
        '
        'chkbPlanting
        '
        Me.chkbPlanting.AutoSize = True
        Me.chkbPlanting.Location = New System.Drawing.Point(556, 411)
        Me.chkbPlanting.Name = "chkbPlanting"
        Me.chkbPlanting.Size = New System.Drawing.Size(174, 24)
        Me.chkbPlanting.TabIndex = 14
        Me.chkbPlanting.Text = "Planting ($8 per tree)"
        Me.chkbPlanting.UseVisualStyleBackColor = True
        '
        'grpCustomerInfo
        '
        Me.grpCustomerInfo.Controls.Add(Me.txtbState)
        Me.grpCustomerInfo.Controls.Add(Me.txtbLastN)
        Me.grpCustomerInfo.Controls.Add(Me.mskZip)
        Me.grpCustomerInfo.Controls.Add(Me.mskPhoneNum)
        Me.grpCustomerInfo.Controls.Add(Me.txtbAddress)
        Me.grpCustomerInfo.Controls.Add(Me.txtbFirstN)
        Me.grpCustomerInfo.Controls.Add(Me.lblZip)
        Me.grpCustomerInfo.Controls.Add(Me.lblState)
        Me.grpCustomerInfo.Controls.Add(Me.lblLastN)
        Me.grpCustomerInfo.Controls.Add(Me.lblAddress)
        Me.grpCustomerInfo.Controls.Add(Me.lblPhoneNum)
        Me.grpCustomerInfo.Controls.Add(Me.lblFirstN)
        Me.grpCustomerInfo.Location = New System.Drawing.Point(19, 136)
        Me.grpCustomerInfo.Name = "grpCustomerInfo"
        Me.grpCustomerInfo.Size = New System.Drawing.Size(518, 173)
        Me.grpCustomerInfo.TabIndex = 16
        Me.grpCustomerInfo.TabStop = False
        Me.grpCustomerInfo.Text = "Customer Information"
        '
        'txtbState
        '
        Me.txtbState.Location = New System.Drawing.Point(212, 125)
        Me.txtbState.MaxLength = 50
        Me.txtbState.Name = "txtbState"
        Me.txtbState.Size = New System.Drawing.Size(132, 25)
        Me.txtbState.TabIndex = 13
        '
        'txtbLastN
        '
        Me.txtbLastN.Location = New System.Drawing.Point(212, 57)
        Me.txtbLastN.Name = "txtbLastN"
        Me.txtbLastN.Size = New System.Drawing.Size(132, 25)
        Me.txtbLastN.TabIndex = 12
        '
        'mskZip
        '
        Me.mskZip.Location = New System.Drawing.Point(379, 125)
        Me.mskZip.Mask = "00000-9999"
        Me.mskZip.Name = "mskZip"
        Me.mskZip.Size = New System.Drawing.Size(118, 25)
        Me.mskZip.TabIndex = 11
        Me.mskZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mskPhoneNum
        '
        Me.mskPhoneNum.Location = New System.Drawing.Point(379, 57)
        Me.mskPhoneNum.Mask = "(999) 000-0000"
        Me.mskPhoneNum.Name = "mskPhoneNum"
        Me.mskPhoneNum.Size = New System.Drawing.Size(118, 25)
        Me.mskPhoneNum.TabIndex = 10
        Me.mskPhoneNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbAddress
        '
        Me.txtbAddress.Location = New System.Drawing.Point(22, 125)
        Me.txtbAddress.MaxLength = 50
        Me.txtbAddress.Name = "txtbAddress"
        Me.txtbAddress.Size = New System.Drawing.Size(156, 25)
        Me.txtbAddress.TabIndex = 9
        '
        'txtbFirstN
        '
        Me.txtbFirstN.Location = New System.Drawing.Point(22, 57)
        Me.txtbFirstN.Name = "txtbFirstN"
        Me.txtbFirstN.Size = New System.Drawing.Size(156, 25)
        Me.txtbFirstN.TabIndex = 6
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(375, 102)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(34, 20)
        Me.lblZip.TabIndex = 5
        Me.lblZip.Text = "Zip:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(208, 102)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(46, 20)
        Me.lblState.TabIndex = 4
        Me.lblState.Text = "State:"
        '
        'lblLastN
        '
        Me.lblLastN.AutoSize = True
        Me.lblLastN.Location = New System.Drawing.Point(208, 34)
        Me.lblLastN.Name = "lblLastN"
        Me.lblLastN.Size = New System.Drawing.Size(82, 20)
        Me.lblLastN.TabIndex = 3
        Me.lblLastN.Text = "Last Name:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(21, 102)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(65, 20)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address:"
        '
        'lblPhoneNum
        '
        Me.lblPhoneNum.AutoSize = True
        Me.lblPhoneNum.Location = New System.Drawing.Point(375, 34)
        Me.lblPhoneNum.Name = "lblPhoneNum"
        Me.lblPhoneNum.Size = New System.Drawing.Size(115, 20)
        Me.lblPhoneNum.TabIndex = 1
        Me.lblPhoneNum.Text = "Phone Number:"
        '
        'lblFirstN
        '
        Me.lblFirstN.AutoSize = True
        Me.lblFirstN.Location = New System.Drawing.Point(21, 34)
        Me.lblFirstN.Name = "lblFirstN"
        Me.lblFirstN.Size = New System.Drawing.Size(83, 20)
        Me.lblFirstN.TabIndex = 0
        Me.lblFirstN.Text = "First Name:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.OliveDrab
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSubmit.Location = New System.Drawing.Point(116, 511)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(134, 50)
        Me.btnSubmit.TabIndex = 17
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Location = New System.Drawing.Point(308, 511)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(134, 50)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Brown
        Me.btnExit.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Location = New System.Drawing.Point(500, 511)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 50)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(180, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(336, 32)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Florida Exotic Citrus Nursery "
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(740, 585)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.grpCustomerInfo)
        Me.Controls.Add(Me.chkbPlanting)
        Me.Controls.Add(Me.chkbDelivery)
        Me.Controls.Add(Me.txtbQuantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblInstruct)
        Me.Controls.Add(Me.lblOptional)
        Me.Controls.Add(Me.lblQuantity)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmOrder"
        Me.Text = "Order"
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpCustomerInfo.ResumeLayout(False)
        Me.grpCustomerInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblOptional As Label
    Friend WithEvents lblInstruct As Label
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents rbPersianL As RadioButton
    Friend WithEvents rbMeyerL As RadioButton
    Friend WithEvents rbKeyL As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbQuantity As TextBox
    Friend WithEvents grpCustomerInfo As GroupBox
    Friend WithEvents txtbFirstN As TextBox
    Friend WithEvents lblZip As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblLastN As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents lblFirstN As Label
    Friend WithEvents chkbPlanting As CheckBox
    Friend WithEvents chkbDelivery As CheckBox
    Friend WithEvents mskZip As MaskedTextBox
    Friend WithEvents mskPhoneNum As MaskedTextBox
    Friend WithEvents txtbAddress As TextBox
    Friend WithEvents txtbLastN As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtbState As TextBox
End Class
