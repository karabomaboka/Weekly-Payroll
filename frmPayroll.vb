Public Class frmPayroll

  Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
    Dim empName As String = ""   'Name of employee
    Dim hrWage As Decimal        'Hourly wage
    Dim hrsWorked As Decimal     'Hours worked this week
    Dim allowances As Integer    'Number of withholding allowances for employee
    Dim prevPay As Decimal       'Total pay for year excluding this week
    Dim mStatus As String = ""   'Marital status: S for Single; M for Married
    Dim pay As Decimal           'This week's pay before taxes
    Dim totalPay As Decimal      'Total pay for year including this week
    Dim ficaTax As Decimal       'FICA tax for this week
    Dim fedTax As Decimal        'Federal income tax withheld this week
    Dim check As Decimal         'Paycheck this week (take-home pay)
    'Verify and obtain data, compute payroll, display results
    If Not DataOK() Then
      Dim msg As String = "At least one piece of requested data is missing" &
                          " or is provided improperly."
      MessageBox.Show(msg)
    Else
      InputData(empName, hrWage, hrsWorked, allowances, prevPay, mStatus) 'Task 0
      pay = Gross_Pay(hrWage, hrsWorked)                                  'Task 1
      totalPay = Total_Pay(prevPay, pay)                                  'Task 2
      ficaTax = FICA_Tax(pay, prevPay, totalPay, mStatus)                          'Task 3
      fedTax = Fed_Tax(pay, allowances, mStatus)                          'Task 4
      check = Net_Check(pay, ficaTax, fedTax)                             'Task 5
      ShowPayroll(empName, pay, totalPay, ficaTax, fedTax, check)         'Task 6
    End If
  End Sub

  Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
    'Clear all text boxes and radio buttons for next employee's data
    txtName.Clear()
    txtWage.Clear()
    txtHours.Clear()
    txtAllowances.Clear()
    txtPriorPay.Clear()
    radSingle.Checked = False
    radMarried.Checked = False
    lstResults.Items.Clear()
    txtName.Focus()
  End Sub

  Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
    Me.Close()
  End Sub

  Function DataOK() As Boolean
    'Task 0: Validate data
    If (txtName.Text = "") Or (Not IsNumeric(txtWage.Text)) Or
       (Not IsNumeric(txtHours.Text)) Or (Not IsNumeric(txtAllowances.Text)) Or
       (Not IsNumeric(txtPriorPay.Text)) Or
       ((Not radSingle.Checked) And (Not radMarried.Checked)) Then
      Return False
    Else
      Return True
    End If
  End Function

  Sub InputData(ByRef empName As String, ByRef hrWage As Decimal,
                ByRef hrsWorked As Decimal, ByRef allowances As Integer,
                ByRef prevPay As Decimal, ByRef mStatus As String)
    'Task 0: Validate data
    empName = txtName.Text
    hrWage = CDec(txtWage.Text)
    hrsWorked = CDec(txtHours.Text)
    allowances = CInt(txtAllowances.Text)
    prevPay = CDec(txtPriorPay.Text)
    If radMarried.Checked Then
      mStatus = "M"
    Else
      mStatus = "S"
    End If
  End Sub

  Function Gross_Pay(hrWage As Decimal, hrsWorked As Decimal) As Decimal
    'Task 1: Compute weekly pay before taxes
    If hrsWorked <= 40 Then
      Return hrsWorked * hrWage
    Else
      Return 40 * hrWage + (hrsWorked - 40) * 1.5D * hrWage
    End If
  End Function

  Function Total_Pay(prevPay As Decimal, pay As Decimal) As Decimal
    'Task 2: Compute total pay before taxes
    Return prevPay + pay
  End Function

  Function FICA_Tax(pay As Decimal, prevPay As Decimal, totalPay As Decimal,
                  mStatus As String) As Decimal
    'Task 3: Compute social security and medicare tax
    'Calculate social security benefits tax and medicare tax
    'for a single employee.
    Const WAGE_BASE As Decimal = 128400D  'There is no Social Security Benefits
    '                                      tax on income above this level.
    Const SOCIAL_SECURITY_RATE As Decimal = 0.062D
    Const MEDICARE_RATE As Decimal = 0.0145D
    Dim medicareIncreaseBase As Decimal
    If mStatus = "S" Then
      medicareIncreaseBase = 200000
    Else
      medicareIncreaseBase = 250000
    End If
    Dim socialSecurityBenTax, medicareTax, ficaTax As Decimal
    'Calculate the Social Security Benefits tax.
    If totalPay <= WAGE_BASE Then
      socialSecurityBenTax = SOCIAL_SECURITY_RATE * pay
    ElseIf prevPay < WAGE_BASE Then
      socialSecurityBenTax = SOCIAL_SECURITY_RATE * (WAGE_BASE - prevPay)
    End If
    'Calculate the FICA tax.
    medicareTax = MEDICARE_RATE * pay
    If prevPay >= medicareIncreaseBase Then
      medicareTax += 0.009D * (totalPay - 200000D)
    End If
    ficaTax = socialSecurityBenTax + medicareTax
    Return Math.Round(ficaTax, 2)

  End Function

  Function Fed_Tax(pay As Decimal, allowances As Integer, mStatus As String) As Decimal
    'Task 4.1: Compute federal income tax withheld rounded to 2 decimal places 
    Dim adjPay As Decimal
    Dim tax As Decimal           'unrounded federal tax withheld
    Const WITHHOLDING_EXEMPTION As Decimal = 79.8D
    adjPay = pay - (WITHHOLDING_EXEMPTION * allowances)
    If adjPay < 0 Then
      adjPay = 0
    End If
    If mStatus = "S" Then
      tax = TaxSingle(adjPay)   'Task 4.2
    Else
      tax = TaxMarried(adjPay)  'Task 4.3
    End If
    Return Math.Round(tax, 2)   'round to nearest cent
  End Function

  Function TaxSingle(adjPay As Decimal) As Decimal
    'Task 4.2: Compute federal tax withheld for single person
    Select Case adjPay
      Case 0 To 71
        Return 0
      Case 71 To 254
        Return (0.1D * (adjPay - 71))
      Case 254 To 815
        Return 18.3D + 0.12D * (adjPay - 254)
      Case 815 To 1658
        Return 85.96D + 0.22D * (adjPay - 815)
      Case 1658 To 3100
        Return 271.08D + 0.24D * (adjPay - 1658)
      Case 3100 To 3917
        Return 617.16D + 0.32D * (adjPay - 3100)
      Case 3917 To 9687
        Return 878.6D + 0.35D * (adjPay - 3917)
      Case Is > 9687
        Return 2898.1D + 0.37D * (adjPay - 9687)
    End Select
  End Function

  Function TaxMarried(adjPay As Decimal) As Decimal
    'Task 4.3: Compute federal tax withheld for married person
    Select Case adjPay
      Case 0 To 222
        Return 0
      Case 222 To 588
        Return 0.1D * (adjPay - 222)
      Case 588 To 1711
        Return 36.6D + 0.12D * (adjPay - 588)
      Case 1711 To 3395
        Return 171.36D + 0.22D * (adjPay - 1711)
      Case 3395 To 6280
        Return 541.84D + 0.24D * (adjPay - 3395)
      Case 6280 To 7914
        Return 1234.24D + 0.32D * (adjPay - 6280)
      Case 7914 To 11761
        Return 1757.12D + 0.35D * (adjPay - 7914)
      Case Is > 11761
        Return 3103.57D + 0.37D * (adjPay - 11761)
    End Select
  End Function

  Function Net_Check(pay As Decimal, ficaTax As Decimal, fedTax As Decimal) As Decimal
    'Task 5: Compute amount of money paid to employee
    Return pay - ficaTax - fedTax
  End Function

  Sub ShowPayroll(empName As String, pay As Decimal,
                  totalPay As Decimal, ficaTax As Decimal,
                  fedTax As Decimal, check As Decimal)
    'Task 6: Display results of payroll computations
    lstResults.Items.Clear()
    lstResults.Items.Add("Payroll results for " & empName)
    lstResults.Items.Add("")
    lstResults.Items.Add("Gross pay this period:" & "   " & pay.ToString("C"))
    lstResults.Items.Add("")
    lstResults.Items.Add("Year-to-date earnings:" & "   " & totalPay.ToString("C"))
    lstResults.Items.Add("")
    lstResults.Items.Add("FICA tax this period:" & "    " & ficaTax.ToString("C"))
    lstResults.Items.Add("")
    lstResults.Items.Add("Income tax withheld:" & "     " & fedTax.ToString("C"))
    lstResults.Items.Add("")
    lstResults.Items.Add("Net pay (check amount):" & "  " & check.ToString("C"))
  End Sub

End Class
