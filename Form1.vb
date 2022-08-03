Public Class Form1
    '192145476
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '1.2.1 
        cmbRetirementAge.Items.Add("55")
        cmbRetirementAge.Items.Add("60")
        cmbRetirementAge.Items.Add("65")
        '1.2.2
        cmbRetirementAge.SelectedIndex = 0
        cmbRetirementAge.Focus()
    End Sub
    '1.3
    Public Function CalcPaymentPeriod(ByVal intRetirementAge As Integer, ByVal intCurrentAge As Integer)

        Dim NPer As Integer
        NPer = (intRetirementAge - intCurrentAge) * 12
        Return NPer

    End Function
    '1.5.3
    Public Function MonthlyInterestRate(ByRef InterestRate)

        Dim Rate As Decimal
        Rate = InterestRate / 100 / 12
        Return Rate

    End Function

    Public Function PaymentPerMonth(ByVal MonthlyPayment)

        Dim PMT As Integer
        PMT = MonthlyPayment
        Return PMT

    End Function
    '1.4
    Public Function CalcFutureValue(ByVal PMT As Integer, ByVal NPer As Integer, ByVal Rate As Decimal)

        Dim FV As Decimal
        FV = PMT * ((1 + Rate) ^ NPer - 1) / Rate

        Return "The future value is: " & FV.ToString("R###,###,###,##")

    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        cmbRetirementAge.SelectedIndex = 0
        cmbRetirementAge.Focus()
        txtAge.Clear()
        txtInterestRate.Clear()
        txtMonthlyPayment.Clear()
        lblDisplay.Text = ""

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim intRetirementAg As Integer = cmbRetirementAge.SelectedItem()
        Dim intAge As Integer = txtAge.Text
        Dim intMonthlyPayment As Decimal = txtMonthlyPayment.Text
        Dim decInterestRate As Decimal = txtInterestRate.Text

        Dim Nper = CalcPaymentPeriod(intRetirementAg, intAge)
        Dim Rate = MonthlyInterestRate(decInterestRate)
        Dim PMT = PaymentPerMonth(intMonthlyPayment)


        lblDisplay.Text = CalcFutureValue(PMT, Nper, Rate)

    End Sub

    Private Sub lblDisplay_Click(sender As Object, e As EventArgs) Handles lblDisplay.Click

    End Sub
End Class
