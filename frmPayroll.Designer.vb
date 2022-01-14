Partial Public Class frmPayroll
  Inherits System.Windows.Forms.Form

  <System.Diagnostics.DebuggerNonUserCode()> _
  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()

  End Sub

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents btnNext As System.Windows.Forms.Button
  Friend WithEvents btnQuit As System.Windows.Forms.Button
  Friend WithEvents lblName As System.Windows.Forms.Label
  Friend WithEvents lblWage As System.Windows.Forms.Label
  Friend WithEvents lblHours As System.Windows.Forms.Label
  Friend WithEvents lblAllowancess As System.Windows.Forms.Label
  Friend WithEvents lblPriorPay As System.Windows.Forms.Label
  Friend WithEvents lstResults As System.Windows.Forms.ListBox

  'Required by the Windows Form Designer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.lblAllowancess = New System.Windows.Forms.Label()
    Me.lblPriorPay = New System.Windows.Forms.Label()
    Me.lblHours = New System.Windows.Forms.Label()
    Me.lstResults = New System.Windows.Forms.ListBox()
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.lblName = New System.Windows.Forms.Label()
    Me.lblWage = New System.Windows.Forms.Label()
    Me.btnQuit = New System.Windows.Forms.Button()
    Me.btnNext = New System.Windows.Forms.Button()
    Me.txtAllowances = New System.Windows.Forms.TextBox()
    Me.txtName = New System.Windows.Forms.TextBox()
    Me.txtWage = New System.Windows.Forms.TextBox()
    Me.txtHours = New System.Windows.Forms.TextBox()
    Me.txtPriorPay = New System.Windows.Forms.TextBox()
    Me.grpMarital = New System.Windows.Forms.GroupBox()
    Me.radMarried = New System.Windows.Forms.RadioButton()
    Me.radSingle = New System.Windows.Forms.RadioButton()
    Me.grpMarital.SuspendLayout()
    Me.SuspendLayout()
    '
    'lblAllowancess
    '
    Me.lblAllowancess.Location = New System.Drawing.Point(40, 115)
    Me.lblAllowancess.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblAllowancess.Name = "lblAllowancess"
    Me.lblAllowancess.Size = New System.Drawing.Size(152, 36)
    Me.lblAllowancess.TabIndex = 6
    Me.lblAllowancess.Text = "Number of withholding allowances:"
    Me.lblAllowancess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblPriorPay
    '
    Me.lblPriorPay.AutoSize = True
    Me.lblPriorPay.Location = New System.Drawing.Point(8, 161)
    Me.lblPriorPay.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblPriorPay.Name = "lblPriorPay"
    Me.lblPriorPay.Size = New System.Drawing.Size(182, 17)
    Me.lblPriorPay.TabIndex = 10
    Me.lblPriorPay.Text = "Total pay prior to this week:"
    Me.lblPriorPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblHours
    '
    Me.lblHours.AutoSize = True
    Me.lblHours.Location = New System.Drawing.Point(23, 89)
    Me.lblHours.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblHours.Name = "lblHours"
    Me.lblHours.Size = New System.Drawing.Size(167, 17)
    Me.lblHours.TabIndex = 4
    Me.lblHours.Text = "Number of hours worked:"
    Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lstResults
    '
    Me.lstResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lstResults.FormattingEnabled = True
    Me.lstResults.ItemHeight = 17
    Me.lstResults.Location = New System.Drawing.Point(307, 15)
    Me.lstResults.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lstResults.Name = "lstResults"
    Me.lstResults.Size = New System.Drawing.Size(355, 208)
    Me.lstResults.TabIndex = 15
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(19, 244)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(176, 39)
    Me.btnDisplay.TabIndex = 12
    Me.btnDisplay.Text = "Display Payroll"
    '
    'lblName
    '
    Me.lblName.AutoSize = True
    Me.lblName.Location = New System.Drawing.Point(80, 18)
    Me.lblName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblName.Name = "lblName"
    Me.lblName.Size = New System.Drawing.Size(113, 17)
    Me.lblName.TabIndex = 0
    Me.lblName.Text = "Employee name:"
    Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblWage
    '
    Me.lblWage.AutoSize = True
    Me.lblWage.Location = New System.Drawing.Point(101, 53)
    Me.lblWage.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblWage.Name = "lblWage"
    Me.lblWage.Size = New System.Drawing.Size(90, 17)
    Me.lblWage.TabIndex = 2
    Me.lblWage.Text = "Hourly wage:"
    Me.lblWage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'btnQuit
    '
    Me.btnQuit.Location = New System.Drawing.Point(417, 242)
    Me.btnQuit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnQuit.Name = "btnQuit"
    Me.btnQuit.Size = New System.Drawing.Size(176, 39)
    Me.btnQuit.TabIndex = 14
    Me.btnQuit.Text = "Quit"
    '
    'btnNext
    '
    Me.btnNext.Location = New System.Drawing.Point(218, 244)
    Me.btnNext.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnNext.Name = "btnNext"
    Me.btnNext.Size = New System.Drawing.Size(176, 39)
    Me.btnNext.TabIndex = 13
    Me.btnNext.Text = "Next Employee"
    '
    'txtAllowances
    '
    Me.txtAllowances.Location = New System.Drawing.Point(197, 122)
    Me.txtAllowances.Margin = New System.Windows.Forms.Padding(4)
    Me.txtAllowances.Name = "txtAllowances"
    Me.txtAllowances.Size = New System.Drawing.Size(80, 22)
    Me.txtAllowances.TabIndex = 3
    '
    'txtName
    '
    Me.txtName.Location = New System.Drawing.Point(197, 15)
    Me.txtName.Margin = New System.Windows.Forms.Padding(4)
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(80, 22)
    Me.txtName.TabIndex = 0
    '
    'txtWage
    '
    Me.txtWage.Location = New System.Drawing.Point(197, 50)
    Me.txtWage.Margin = New System.Windows.Forms.Padding(4)
    Me.txtWage.Name = "txtWage"
    Me.txtWage.Size = New System.Drawing.Size(80, 22)
    Me.txtWage.TabIndex = 1
    '
    'txtHours
    '
    Me.txtHours.Location = New System.Drawing.Point(197, 86)
    Me.txtHours.Margin = New System.Windows.Forms.Padding(4)
    Me.txtHours.Name = "txtHours"
    Me.txtHours.Size = New System.Drawing.Size(80, 22)
    Me.txtHours.TabIndex = 2
    '
    'txtPriorPay
    '
    Me.txtPriorPay.Location = New System.Drawing.Point(197, 158)
    Me.txtPriorPay.Margin = New System.Windows.Forms.Padding(4)
    Me.txtPriorPay.Name = "txtPriorPay"
    Me.txtPriorPay.Size = New System.Drawing.Size(80, 22)
    Me.txtPriorPay.TabIndex = 4
    '
    'grpMarital
    '
    Me.grpMarital.Controls.Add(Me.radMarried)
    Me.grpMarital.Controls.Add(Me.radSingle)
    Me.grpMarital.Location = New System.Drawing.Point(84, 192)
    Me.grpMarital.Margin = New System.Windows.Forms.Padding(4)
    Me.grpMarital.Name = "grpMarital"
    Me.grpMarital.Padding = New System.Windows.Forms.Padding(4)
    Me.grpMarital.Size = New System.Drawing.Size(195, 46)
    Me.grpMarital.TabIndex = 5
    Me.grpMarital.TabStop = False
    Me.grpMarital.Text = "Marital Status"
    '
    'radMarried
    '
    Me.radMarried.AutoSize = True
    Me.radMarried.Location = New System.Drawing.Point(107, 20)
    Me.radMarried.Margin = New System.Windows.Forms.Padding(4)
    Me.radMarried.Name = "radMarried"
    Me.radMarried.Size = New System.Drawing.Size(77, 21)
    Me.radMarried.TabIndex = 1
    Me.radMarried.Text = "Married"
    Me.radMarried.UseVisualStyleBackColor = True
    '
    'radSingle
    '
    Me.radSingle.AutoSize = True
    Me.radSingle.Location = New System.Drawing.Point(13, 20)
    Me.radSingle.Margin = New System.Windows.Forms.Padding(4)
    Me.radSingle.Name = "radSingle"
    Me.radSingle.Size = New System.Drawing.Size(68, 21)
    Me.radSingle.TabIndex = 0
    Me.radSingle.Text = "Single"
    Me.radSingle.UseVisualStyleBackColor = True
    '
    'frmPayroll
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(676, 294)
    Me.Controls.Add(Me.grpMarital)
    Me.Controls.Add(Me.txtPriorPay)
    Me.Controls.Add(Me.txtHours)
    Me.Controls.Add(Me.txtWage)
    Me.Controls.Add(Me.txtName)
    Me.Controls.Add(Me.txtAllowances)
    Me.Controls.Add(Me.lstResults)
    Me.Controls.Add(Me.lblPriorPay)
    Me.Controls.Add(Me.lblAllowancess)
    Me.Controls.Add(Me.lblHours)
    Me.Controls.Add(Me.lblWage)
    Me.Controls.Add(Me.lblName)
    Me.Controls.Add(Me.btnQuit)
    Me.Controls.Add(Me.btnNext)
    Me.Controls.Add(Me.btnDisplay)
    Me.Location = New System.Drawing.Point(13, 13)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmPayroll"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Weekly Payroll"
    Me.grpMarital.ResumeLayout(False)
    Me.grpMarital.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtAllowances As System.Windows.Forms.TextBox
  Friend WithEvents txtName As System.Windows.Forms.TextBox
  Friend WithEvents txtWage As System.Windows.Forms.TextBox
  Friend WithEvents txtHours As System.Windows.Forms.TextBox
  Friend WithEvents txtPriorPay As System.Windows.Forms.TextBox
  Private components As System.ComponentModel.IContainer
  Friend WithEvents grpMarital As System.Windows.Forms.GroupBox
  Friend WithEvents radMarried As System.Windows.Forms.RadioButton
  Friend WithEvents radSingle As System.Windows.Forms.RadioButton

End Class
