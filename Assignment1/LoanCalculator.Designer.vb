<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoanCalculator))
        Me.grpLoanDetails = New System.Windows.Forms.GroupBox()
        Me.cxbFirstHome = New System.Windows.Forms.CheckBox()
        Me.cmbRepaymentYears = New System.Windows.Forms.ComboBox()
        Me.cmbAnnualInterest = New System.Windows.Forms.ComboBox()
        Me.txtLoanAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.rdoReserve = New System.Windows.Forms.RadioButton()
        Me.rdoActiveDuty = New System.Windows.Forms.RadioButton()
        Me.rdoVeteran = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstExtraServices = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRateUsed = New System.Windows.Forms.TextBox()
        Me.txtTotalInterest = New System.Windows.Forms.TextBox()
        Me.txtTotalPayments = New System.Windows.Forms.TextBox()
        Me.txtMonthlyPayment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.picInfo = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpLoanDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.picInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpLoanDetails
        '
        Me.grpLoanDetails.Controls.Add(Me.cxbFirstHome)
        Me.grpLoanDetails.Controls.Add(Me.cmbRepaymentYears)
        Me.grpLoanDetails.Controls.Add(Me.cmbAnnualInterest)
        Me.grpLoanDetails.Controls.Add(Me.txtLoanAmount)
        Me.grpLoanDetails.Controls.Add(Me.Label3)
        Me.grpLoanDetails.Controls.Add(Me.Label2)
        Me.grpLoanDetails.Controls.Add(Me.Label1)
        Me.grpLoanDetails.Controls.Add(Me.GroupBox1)
        Me.grpLoanDetails.Location = New System.Drawing.Point(24, 23)
        Me.grpLoanDetails.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.grpLoanDetails.Name = "grpLoanDetails"
        Me.grpLoanDetails.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.grpLoanDetails.Size = New System.Drawing.Size(510, 462)
        Me.grpLoanDetails.TabIndex = 0
        Me.grpLoanDetails.TabStop = False
        Me.grpLoanDetails.Text = "Loan details..."
        '
        'cxbFirstHome
        '
        Me.cxbFirstHome.AutoSize = True
        Me.cxbFirstHome.Location = New System.Drawing.Point(306, 212)
        Me.cxbFirstHome.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cxbFirstHome.Name = "cxbFirstHome"
        Me.cxbFirstHome.Size = New System.Drawing.Size(210, 29)
        Me.cxbFirstHome.TabIndex = 7
        Me.cxbFirstHome.Text = "First Home Buyer"
        Me.cxbFirstHome.UseVisualStyleBackColor = True
        '
        'cmbRepaymentYears
        '
        Me.cmbRepaymentYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRepaymentYears.FormattingEnabled = True
        Me.cmbRepaymentYears.Location = New System.Drawing.Point(226, 160)
        Me.cmbRepaymentYears.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmbRepaymentYears.Name = "cmbRepaymentYears"
        Me.cmbRepaymentYears.Size = New System.Drawing.Size(238, 33)
        Me.cmbRepaymentYears.TabIndex = 6
        '
        'cmbAnnualInterest
        '
        Me.cmbAnnualInterest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnnualInterest.FormattingEnabled = True
        Me.cmbAnnualInterest.Items.AddRange(New Object() {"4", "4.25", "4.5", "4.75", "5", "5.25", "5.5", "5.75", "6", "6.25", "6.5", "6.75", "7", "7.25", "7.5", "7.75", "8"})
        Me.cmbAnnualInterest.Location = New System.Drawing.Point(226, 108)
        Me.cmbAnnualInterest.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmbAnnualInterest.Name = "cmbAnnualInterest"
        Me.cmbAnnualInterest.Size = New System.Drawing.Size(238, 33)
        Me.cmbAnnualInterest.TabIndex = 5
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.Location = New System.Drawing.Point(226, 58)
        Me.txtLoanAmount.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(238, 31)
        Me.txtLoanAmount.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Repayment Years:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Annual Interest %:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Loan Amount:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoNone)
        Me.GroupBox1.Controls.Add(Me.rdoReserve)
        Me.GroupBox1.Controls.Add(Me.rdoActiveDuty)
        Me.GroupBox1.Controls.Add(Me.rdoVeteran)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 256)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(480, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Armed Services Personnel..."
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Checked = True
        Me.rdoNone.Location = New System.Drawing.Point(152, 81)
        Me.rdoNone.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(94, 29)
        Me.rdoNone.TabIndex = 0
        Me.rdoNone.TabStop = True
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'rdoReserve
        '
        Me.rdoReserve.AutoSize = True
        Me.rdoReserve.Location = New System.Drawing.Point(10, 81)
        Me.rdoReserve.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rdoReserve.Name = "rdoReserve"
        Me.rdoReserve.Size = New System.Drawing.Size(123, 29)
        Me.rdoReserve.TabIndex = 3
        Me.rdoReserve.Text = "Reserve"
        Me.rdoReserve.UseVisualStyleBackColor = True
        '
        'rdoActiveDuty
        '
        Me.rdoActiveDuty.AutoSize = True
        Me.rdoActiveDuty.Location = New System.Drawing.Point(150, 37)
        Me.rdoActiveDuty.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rdoActiveDuty.Name = "rdoActiveDuty"
        Me.rdoActiveDuty.Size = New System.Drawing.Size(152, 29)
        Me.rdoActiveDuty.TabIndex = 2
        Me.rdoActiveDuty.Text = "Active Duty"
        Me.rdoActiveDuty.UseVisualStyleBackColor = True
        '
        'rdoVeteran
        '
        Me.rdoVeteran.AutoSize = True
        Me.rdoVeteran.Location = New System.Drawing.Point(12, 37)
        Me.rdoVeteran.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rdoVeteran.Name = "rdoVeteran"
        Me.rdoVeteran.Size = New System.Drawing.Size(118, 29)
        Me.rdoVeteran.TabIndex = 1
        Me.rdoVeteran.Text = "Veteran"
        Me.rdoVeteran.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstExtraServices)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(546, 23)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(400, 462)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Extra Services..."
        '
        'lstExtraServices
        '
        Me.lstExtraServices.FormattingEnabled = True
        Me.lstExtraServices.ItemHeight = 25
        Me.lstExtraServices.Items.AddRange(New Object() {"Insurance -O ", "One payment grace -F ", "2-day late payment -F ", "Face to face transactions -S ", "Frequent borower benefits -F ", "Saturday visits -S ", "Hotel discount -O ", "Face to face consultations -S ", "Phone reminders -S ", "Online reversals -F ", "GST waiver -F "})
        Me.lstExtraServices.Location = New System.Drawing.Point(12, 165)
        Me.lstExtraServices.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstExtraServices.Name = "lstExtraServices"
        Me.lstExtraServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstExtraServices.Size = New System.Drawing.Size(372, 279)
        Me.lstExtraServices.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(268, 69)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Use Ctrl/Shift to select multiple items"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 31)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(304, 71)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Use Ctrl/Shift to select multiple items"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtRateUsed)
        Me.GroupBox3.Controls.Add(Me.txtTotalInterest)
        Me.GroupBox3.Controls.Add(Me.txtTotalPayments)
        Me.GroupBox3.Controls.Add(Me.txtMonthlyPayment)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(958, 23)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox3.Size = New System.Drawing.Size(400, 462)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Information..."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 288)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 25)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Rate Used"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 213)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 25)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Total Interest"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 138)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Total Payments"
        '
        'txtRateUsed
        '
        Me.txtRateUsed.Enabled = False
        Me.txtRateUsed.Location = New System.Drawing.Point(24, 319)
        Me.txtRateUsed.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtRateUsed.Name = "txtRateUsed"
        Me.txtRateUsed.Size = New System.Drawing.Size(196, 31)
        Me.txtRateUsed.TabIndex = 4
        '
        'txtTotalInterest
        '
        Me.txtTotalInterest.Enabled = False
        Me.txtTotalInterest.Location = New System.Drawing.Point(24, 244)
        Me.txtTotalInterest.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTotalInterest.Name = "txtTotalInterest"
        Me.txtTotalInterest.Size = New System.Drawing.Size(196, 31)
        Me.txtTotalInterest.TabIndex = 3
        '
        'txtTotalPayments
        '
        Me.txtTotalPayments.Enabled = False
        Me.txtTotalPayments.Location = New System.Drawing.Point(24, 169)
        Me.txtTotalPayments.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTotalPayments.Name = "txtTotalPayments"
        Me.txtTotalPayments.Size = New System.Drawing.Size(196, 31)
        Me.txtTotalPayments.TabIndex = 2
        '
        'txtMonthlyPayment
        '
        Me.txtMonthlyPayment.Enabled = False
        Me.txtMonthlyPayment.Location = New System.Drawing.Point(24, 94)
        Me.txtMonthlyPayment.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtMonthlyPayment.Name = "txtMonthlyPayment"
        Me.txtMonthlyPayment.Size = New System.Drawing.Size(196, 31)
        Me.txtMonthlyPayment.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 63)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Monthly Payment"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(1370, 235)
        Me.btnCompute.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(216, 71)
        Me.btnCompute.TabIndex = 3
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'picInfo
        '
        Me.picInfo.Image = CType(resources.GetObject("picInfo.Image"), System.Drawing.Image)
        Me.picInfo.Location = New System.Drawing.Point(1370, 33)
        Me.picInfo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picInfo.Name = "picInfo"
        Me.picInfo.Size = New System.Drawing.Size(216, 190)
        Me.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picInfo.TabIndex = 6
        Me.picInfo.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(1370, 317)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(216, 71)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(1370, 400)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(216, 71)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'LoanCalculator
        '
        Me.AcceptButton = Me.btnCompute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1604, 513)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.picInfo)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpLoanDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.Name = "LoanCalculator"
        Me.Text = "Loans R Us Loan Calculator"
        Me.grpLoanDetails.ResumeLayout(False)
        Me.grpLoanDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.picInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpLoanDetails As System.Windows.Forms.GroupBox
    Friend WithEvents cxbFirstHome As System.Windows.Forms.CheckBox
    Friend WithEvents cmbRepaymentYears As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAnnualInterest As System.Windows.Forms.ComboBox
    Friend WithEvents txtLoanAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoNone As System.Windows.Forms.RadioButton
    Friend WithEvents rdoReserve As System.Windows.Forms.RadioButton
    Friend WithEvents rdoActiveDuty As System.Windows.Forms.RadioButton
    Friend WithEvents rdoVeteran As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstExtraServices As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRateUsed As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalInterest As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPayments As System.Windows.Forms.TextBox
    Friend WithEvents txtMonthlyPayment As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents picInfo As System.Windows.Forms.PictureBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
End Class
