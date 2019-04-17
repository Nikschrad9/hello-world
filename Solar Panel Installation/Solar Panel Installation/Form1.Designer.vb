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
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpInstallation = New System.Windows.Forms.GroupBox()
        Me.chkExpress = New System.Windows.Forms.CheckBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.txtNumOfPanels = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpCharges = New System.Windows.Forms.GroupBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.lblAddPanels = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblBaseCharge = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCostumerInformation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInstallation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInstallationOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInstallationCharges = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblVerify = New System.Windows.Forms.Label()
        Me.grpInfo.SuspendLayout()
        Me.grpInstallation.SuspendLayout()
        Me.grpCharges.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInfo
        '
        Me.grpInfo.BackColor = System.Drawing.SystemColors.Control
        Me.grpInfo.Controls.Add(Me.txtPhone)
        Me.grpInfo.Controls.Add(Me.Label3)
        Me.grpInfo.Controls.Add(Me.txtLastName)
        Me.grpInfo.Controls.Add(Me.txtFirstName)
        Me.grpInfo.Controls.Add(Me.Label2)
        Me.grpInfo.Controls.Add(Me.Label1)
        Me.grpInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfo.Location = New System.Drawing.Point(12, 55)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(607, 169)
        Me.grpInfo.TabIndex = 0
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Customer Information"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(372, 101)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(218, 26)
        Me.txtPhone.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(368, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Phone:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(129, 101)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(207, 26)
        Me.txtLastName.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(129, 48)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(207, 26)
        Me.txtFirstName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'grpInstallation
        '
        Me.grpInstallation.BackColor = System.Drawing.SystemColors.Control
        Me.grpInstallation.Controls.Add(Me.lblVerify)
        Me.grpInstallation.Controls.Add(Me.chkExpress)
        Me.grpInstallation.Controls.Add(Me.btnCalc)
        Me.grpInstallation.Controls.Add(Me.txtDeposit)
        Me.grpInstallation.Controls.Add(Me.txtNumOfPanels)
        Me.grpInstallation.Controls.Add(Me.Label5)
        Me.grpInstallation.Controls.Add(Me.Label4)
        Me.grpInstallation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInstallation.Location = New System.Drawing.Point(12, 241)
        Me.grpInstallation.Name = "grpInstallation"
        Me.grpInstallation.Size = New System.Drawing.Size(607, 169)
        Me.grpInstallation.TabIndex = 1
        Me.grpInstallation.TabStop = False
        Me.grpInstallation.Text = "Installation Options"
        Me.grpInstallation.Visible = False
        '
        'chkExpress
        '
        Me.chkExpress.AutoSize = True
        Me.chkExpress.Location = New System.Drawing.Point(37, 130)
        Me.chkExpress.Name = "chkExpress"
        Me.chkExpress.Size = New System.Drawing.Size(203, 24)
        Me.chkExpress.TabIndex = 4
        Me.chkExpress.Text = "Express Installation (5%)"
        Me.chkExpress.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(386, 40)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(166, 70)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Check for Errors"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(177, 84)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(100, 26)
        Me.txtDeposit.TabIndex = 3
        '
        'txtNumOfPanels
        '
        Me.txtNumOfPanels.Location = New System.Drawing.Point(177, 43)
        Me.txtNumOfPanels.Name = "txtNumOfPanels"
        Me.txtNumOfPanels.Size = New System.Drawing.Size(100, 26)
        Me.txtNumOfPanels.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Deposit amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Number of panels:"
        '
        'grpCharges
        '
        Me.grpCharges.BackColor = System.Drawing.SystemColors.Control
        Me.grpCharges.Controls.Add(Me.lblBalance)
        Me.grpCharges.Controls.Add(Me.lblDeposit)
        Me.grpCharges.Controls.Add(Me.lblAddPanels)
        Me.grpCharges.Controls.Add(Me.lblTotalCost)
        Me.grpCharges.Controls.Add(Me.lblBaseCharge)
        Me.grpCharges.Controls.Add(Me.Label10)
        Me.grpCharges.Controls.Add(Me.Label9)
        Me.grpCharges.Controls.Add(Me.Label8)
        Me.grpCharges.Controls.Add(Me.Label7)
        Me.grpCharges.Controls.Add(Me.Label6)
        Me.grpCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCharges.Location = New System.Drawing.Point(12, 429)
        Me.grpCharges.Name = "grpCharges"
        Me.grpCharges.Size = New System.Drawing.Size(607, 310)
        Me.grpCharges.TabIndex = 3
        Me.grpCharges.TabStop = False
        Me.grpCharges.Text = "Charges"
        Me.grpCharges.Visible = False
        '
        'lblBalance
        '
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBalance.Location = New System.Drawing.Point(249, 253)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(87, 31)
        Me.lblBalance.TabIndex = 9
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDeposit
        '
        Me.lblDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDeposit.Location = New System.Drawing.Point(249, 199)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(87, 31)
        Me.lblDeposit.TabIndex = 8
        Me.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddPanels
        '
        Me.lblAddPanels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddPanels.Location = New System.Drawing.Point(249, 91)
        Me.lblAddPanels.Name = "lblAddPanels"
        Me.lblAddPanels.Size = New System.Drawing.Size(87, 31)
        Me.lblAddPanels.TabIndex = 7
        Me.lblAddPanels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCost.Location = New System.Drawing.Point(249, 145)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(87, 31)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBaseCharge
        '
        Me.lblBaseCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBaseCharge.Location = New System.Drawing.Point(249, 37)
        Me.lblBaseCharge.Name = "lblBaseCharge"
        Me.lblBaseCharge.Size = New System.Drawing.Size(87, 31)
        Me.lblBaseCharge.TabIndex = 5
        Me.lblBaseCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(130, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Balance due:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(106, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Deposit amount:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(150, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total cost:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(98, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Additional panels:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Base charge for 2 panels:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuCustomer, Me.mnuInstallation})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(631, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileClear, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileClear
        '
        Me.mnuFileClear.Name = "mnuFileClear"
        Me.mnuFileClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuFileClear.Text = "Clear"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuCustomer
        '
        Me.mnuCustomer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCostumerInformation})
        Me.mnuCustomer.Name = "mnuCustomer"
        Me.mnuCustomer.Size = New System.Drawing.Size(71, 20)
        Me.mnuCustomer.Text = "Customer"
        '
        'mnuCostumerInformation
        '
        Me.mnuCostumerInformation.Name = "mnuCostumerInformation"
        Me.mnuCostumerInformation.Size = New System.Drawing.Size(137, 22)
        Me.mnuCostumerInformation.Text = "Information"
        '
        'mnuInstallation
        '
        Me.mnuInstallation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInstallationOptions, Me.mnuInstallationCharges})
        Me.mnuInstallation.Name = "mnuInstallation"
        Me.mnuInstallation.Size = New System.Drawing.Size(77, 20)
        Me.mnuInstallation.Text = "Installation"
        '
        'mnuInstallationOptions
        '
        Me.mnuInstallationOptions.Name = "mnuInstallationOptions"
        Me.mnuInstallationOptions.Size = New System.Drawing.Size(152, 22)
        Me.mnuInstallationOptions.Text = "Options"
        '
        'mnuInstallationCharges
        '
        Me.mnuInstallationCharges.Enabled = False
        Me.mnuInstallationCharges.Name = "mnuInstallationCharges"
        Me.mnuInstallationCharges.Size = New System.Drawing.Size(152, 22)
        Me.mnuInstallationCharges.Text = "Charges"
        '
        'lblVerify
        '
        Me.lblVerify.AutoSize = True
        Me.lblVerify.Location = New System.Drawing.Point(368, 130)
        Me.lblVerify.Name = "lblVerify"
        Me.lblVerify.Size = New System.Drawing.Size(196, 20)
        Me.lblVerify.TabIndex = 5
        Me.lblVerify.Text = "Installation options verified"
        Me.lblVerify.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(631, 749)
        Me.Controls.Add(Me.grpCharges)
        Me.Controls.Add(Me.grpInstallation)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Solar Panel Installation"
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.grpInstallation.ResumeLayout(False)
        Me.grpInstallation.PerformLayout()
        Me.grpCharges.ResumeLayout(False)
        Me.grpCharges.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpInstallation As GroupBox
    Friend WithEvents chkExpress As CheckBox
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents txtNumOfPanels As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents grpCharges As GroupBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblDeposit As Label
    Friend WithEvents lblAddPanels As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblBaseCharge As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileClear As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuCustomer As ToolStripMenuItem
    Friend WithEvents mnuCostumerInformation As ToolStripMenuItem
    Friend WithEvents mnuInstallation As ToolStripMenuItem
    Friend WithEvents mnuInstallationOptions As ToolStripMenuItem
    Friend WithEvents mnuInstallationCharges As ToolStripMenuItem
    Friend WithEvents lblVerify As Label
End Class
