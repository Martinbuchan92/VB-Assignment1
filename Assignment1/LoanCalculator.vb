'Name:      Martin Buchan
'Date:      23/08/2017
'Listing:   Cert IV Programming VB.NET Assignment
'Purpose:   Calculate Loan details from users inputs

'Main Loan Calculator class
Public Class LoanCalculator
    Const OTHER As Integer = 500
    Const FINANCE As Integer = 500
    Const SERVICE As Integer = 200
    Const VETERAN As Double = 0.75
    Const ACTIVEDUTY As Double = 1.25
    Const RESERVE As Double = 0.25
    Const NONE As Double = 0.0
    Const FIRSTHOME As Double = 1.0

    'Opens the About Us dialog when the image is clicked
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picInfo.Click
        Dim AboutUs As New AboutUs()
        AboutUs.ShowDialog()
    End Sub

    'adds content to the Repayment Years comboBox item when form loads
    Private Sub LoanCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loanYears = 10

        Do While loanYears <= 30
            cmbRepaymentYears.Items.Add(loanYears)
            loanYears += 5
        Loop

        cmbAnnualInterest.SelectedIndex = 0
        cmbRepaymentYears.SelectedIndex = 0

    End Sub

    'Calculates the loan repayments and handles the 'compute' button click event
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        If Not CheckInput() Then
            Exit Sub
        End If

        Dim loanAmount = CDbl(txtLoanAmount.Text)
        Dim interestPrcnt = CDbl(cmbAnnualInterest.SelectedItem)
        Dim loanLength = CDbl(cmbRepaymentYears.SelectedItem)
        Dim firstHomeDiscount = CalcFirstHomeDiscount()
        Dim aspDiscount = CalcAspDiscount()
        Dim extraServices = CalcExtraServices()

        Dim numPayments = loanLength * 12
        Dim rate = interestPrcnt - aspDiscount - firstHomeDiscount

        Dim monthlyPayment = Pmt((rate / 100) / 12, numPayments, -loanAmount, 0, 0) + (extraServices / 12)
        Dim totalPayment = numPayments * monthlyPayment
        Dim totalInterest = totalPayment - loanAmount

        txtMonthlyPayment.Text = monthlyPayment.ToString("C")
        txtTotalPayments.Text = CDbl(totalPayment).ToString("C")
        txtTotalInterest.Text = CDbl(totalInterest).ToString("C")
        txtRateUsed.Text = rate

    End Sub

    'Checks that there is an input in the main input fields
    Private Function CheckInput() As Boolean
        If txtLoanAmount.Text = "" Then
            MessageBox.Show("Please Enter Loan Amount", "Important Message", MessageBoxButtons.OK)
            txtLoanAmount.Select()
            Return False
        End If
        Return True

    End Function

    'returns the FirstHome Discount if applicable
    Private Function CalcFirstHomeDiscount() As Integer
        Dim firstHomeDiscount = 0

        If cxbFirstHome.Checked = True Then
            firstHomeDiscount = FIRSTHOME
        End If

        Return firstHomeDiscount
    End Function

    'Calculates and returns the Armed Services Personel Discount if eligable
    Private Function CalcAspDiscount() As Double
        Dim aspDiscount = 0.0

        If cmbRepaymentYears.Text >= 20 Then

            If rdoVeteran.Checked = True Then
                aspDiscount = VETERAN
            ElseIf rdoActiveDuty.Checked = True Then
                aspDiscount = ACTIVEDUTY
            ElseIf rdoReserve.Checked = True Then
                aspDiscount = RESERVE
            ElseIf rdoNone.Checked = True Then
                aspDiscount = NONE
            End If

        End If

        Return aspDiscount
    End Function

    'Calculates and returns the cost of extra services required
    Private Function CalcExtraServices() As Double
        Dim indx = 0
        Dim extraServices = 0

        For i = 0 To lstExtraServices.Items.Count - 1

            If lstExtraServices.GetSelected(i) Then
                If i = 0 Or i = 6 Then
                    extraServices += OTHER
                ElseIf i = 1 Or i = 2 Or i = 4 Or i = 9 Or i = 10 Then
                    extraServices += FINANCE
                ElseIf i = 3 Or i = 5 Or i = 7 Or i = 8 Then
                    extraServices += SERVICE
                End If
            End If
        Next

        Return extraServices
    End Function

    'Resets inputs
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtLoanAmount.Text = ""
        cmbAnnualInterest.SelectedIndex = 0
        cmbRepaymentYears.SelectedIndex = 0
        cxbFirstHome.Checked = False
        rdoNone.Checked = True
        lstExtraServices.ClearSelected()
        txtMonthlyPayment.Text = ""
        txtTotalPayments.Text = ""
        txtTotalInterest.Text = ""
        txtRateUsed.Text = ""

    End Sub

    'Closes program when close button is clicked
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class