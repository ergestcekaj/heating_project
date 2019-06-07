<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Questionnaire
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.Lblcountry = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSummary = New System.Windows.Forms.Button()
        Me.BtnDone = New System.Windows.Forms.Button()
        Me.GrbGender = New System.Windows.Forms.GroupBox()
        Me.ChkFemale = New System.Windows.Forms.RadioButton()
        Me.ChkMale = New System.Windows.Forms.RadioButton()
        Me.GrbHobby = New System.Windows.Forms.GroupBox()
        Me.ListAge = New System.Windows.Forms.ListBox()
        Me.txbName = New System.Windows.Forms.TextBox()
        Me.CboCountry = New System.Windows.Forms.ComboBox()
        Me.chkReading = New System.Windows.Forms.CheckBox()
        Me.ChkSleeping = New System.Windows.Forms.CheckBox()
        Me.ChkEating = New System.Windows.Forms.CheckBox()
        Me.ChkDrinking = New System.Windows.Forms.CheckBox()
        Me.GrbGender.SuspendLayout()
        Me.GrbHobby.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(123, 33)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(207, 31)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Questions Form"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LblName.Location = New System.Drawing.Point(24, 94)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(80, 25)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Name :"
        '
        'LblAge
        '
        Me.LblAge.AutoSize = True
        Me.LblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LblAge.Location = New System.Drawing.Point(25, 140)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(55, 24)
        Me.LblAge.TabIndex = 2
        Me.LblAge.Text = "Age :"
        '
        'Lblcountry
        '
        Me.Lblcountry.AutoSize = True
        Me.Lblcountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lblcountry.Location = New System.Drawing.Point(24, 295)
        Me.Lblcountry.Name = "Lblcountry"
        Me.Lblcountry.Size = New System.Drawing.Size(171, 25)
        Me.Lblcountry.TabIndex = 3
        Me.Lblcountry.Text = "Country of birth :"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(69, 413)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(126, 58)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "Add a country name to the list" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSummary
        '
        Me.BtnSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnSummary.Location = New System.Drawing.Point(308, 358)
        Me.BtnSummary.Name = "BtnSummary"
        Me.BtnSummary.Size = New System.Drawing.Size(120, 41)
        Me.BtnSummary.TabIndex = 5
        Me.BtnSummary.Text = "Summary"
        Me.BtnSummary.UseVisualStyleBackColor = True
        '
        'BtnDone
        '
        Me.BtnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnDone.Location = New System.Drawing.Point(308, 425)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(120, 46)
        Me.BtnDone.TabIndex = 6
        Me.BtnDone.Text = "Done"
        Me.BtnDone.UseVisualStyleBackColor = True
        '
        'GrbGender
        '
        Me.GrbGender.Controls.Add(Me.ChkFemale)
        Me.GrbGender.Controls.Add(Me.ChkMale)
        Me.GrbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GrbGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GrbGender.Location = New System.Drawing.Point(29, 179)
        Me.GrbGender.Name = "GrbGender"
        Me.GrbGender.Size = New System.Drawing.Size(200, 100)
        Me.GrbGender.TabIndex = 9
        Me.GrbGender.TabStop = False
        Me.GrbGender.Text = "Gender"
        '
        'ChkFemale
        '
        Me.ChkFemale.AutoSize = True
        Me.ChkFemale.Location = New System.Drawing.Point(100, 47)
        Me.ChkFemale.Name = "ChkFemale"
        Me.ChkFemale.Size = New System.Drawing.Size(80, 24)
        Me.ChkFemale.TabIndex = 1
        Me.ChkFemale.TabStop = True
        Me.ChkFemale.Text = "Female"
        Me.ChkFemale.UseVisualStyleBackColor = True
        '
        'ChkMale
        '
        Me.ChkMale.AutoSize = True
        Me.ChkMale.Location = New System.Drawing.Point(14, 47)
        Me.ChkMale.Name = "ChkMale"
        Me.ChkMale.Size = New System.Drawing.Size(61, 24)
        Me.ChkMale.TabIndex = 0
        Me.ChkMale.TabStop = True
        Me.ChkMale.Text = "Male"
        Me.ChkMale.UseVisualStyleBackColor = True
        '
        'GrbHobby
        '
        Me.GrbHobby.Controls.Add(Me.ChkDrinking)
        Me.GrbHobby.Controls.Add(Me.ChkEating)
        Me.GrbHobby.Controls.Add(Me.ChkSleeping)
        Me.GrbHobby.Controls.Add(Me.chkReading)
        Me.GrbHobby.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GrbHobby.Location = New System.Drawing.Point(278, 125)
        Me.GrbHobby.Name = "GrbHobby"
        Me.GrbHobby.Size = New System.Drawing.Size(150, 195)
        Me.GrbHobby.TabIndex = 10
        Me.GrbHobby.TabStop = False
        Me.GrbHobby.Text = "Your hobby"
        '
        'ListAge
        '
        Me.ListAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ListAge.FormattingEnabled = True
        Me.ListAge.ItemHeight = 20
        Me.ListAge.Items.AddRange(New Object() {"0-20", "20-40", "40-60", "60- inf"})
        Me.ListAge.Location = New System.Drawing.Point(110, 144)
        Me.ListAge.Name = "ListAge"
        Me.ListAge.Size = New System.Drawing.Size(119, 24)
        Me.ListAge.TabIndex = 11
        '
        'txbName
        '
        Me.txbName.Location = New System.Drawing.Point(110, 99)
        Me.txbName.Name = "txbName"
        Me.txbName.Size = New System.Drawing.Size(119, 20)
        Me.txbName.TabIndex = 12
        '
        'CboCountry
        '
        Me.CboCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CboCountry.FormattingEnabled = True
        Me.CboCountry.Items.AddRange(New Object() {"Europe", "Asia", "South America", "Africa"})
        Me.CboCountry.Location = New System.Drawing.Point(69, 365)
        Me.CboCountry.Name = "CboCountry"
        Me.CboCountry.Size = New System.Drawing.Size(126, 28)
        Me.CboCountry.TabIndex = 13
        '
        'chkReading
        '
        Me.chkReading.AutoSize = True
        Me.chkReading.Location = New System.Drawing.Point(24, 40)
        Me.chkReading.Name = "chkReading"
        Me.chkReading.Size = New System.Drawing.Size(88, 24)
        Me.chkReading.TabIndex = 4
        Me.chkReading.Text = "Reading"
        Me.chkReading.UseVisualStyleBackColor = True
        '
        'ChkSleeping
        '
        Me.ChkSleeping.AutoSize = True
        Me.ChkSleeping.Location = New System.Drawing.Point(24, 70)
        Me.ChkSleeping.Name = "ChkSleeping"
        Me.ChkSleeping.Size = New System.Drawing.Size(90, 24)
        Me.ChkSleeping.TabIndex = 5
        Me.ChkSleeping.Text = "Sleeping"
        Me.ChkSleeping.UseVisualStyleBackColor = True
        '
        'ChkEating
        '
        Me.ChkEating.AutoSize = True
        Me.ChkEating.Location = New System.Drawing.Point(24, 100)
        Me.ChkEating.Name = "ChkEating"
        Me.ChkEating.Size = New System.Drawing.Size(74, 24)
        Me.ChkEating.TabIndex = 6
        Me.ChkEating.Text = "Eating"
        Me.ChkEating.UseVisualStyleBackColor = True
        '
        'ChkDrinking
        '
        Me.ChkDrinking.AutoSize = True
        Me.ChkDrinking.Location = New System.Drawing.Point(24, 130)
        Me.ChkDrinking.Name = "ChkDrinking"
        Me.ChkDrinking.Size = New System.Drawing.Size(86, 24)
        Me.ChkDrinking.TabIndex = 7
        Me.ChkDrinking.Text = "Drinking"
        Me.ChkDrinking.UseVisualStyleBackColor = True
        '
        'Questionnaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 489)
        Me.Controls.Add(Me.CboCountry)
        Me.Controls.Add(Me.txbName)
        Me.Controls.Add(Me.ListAge)
        Me.Controls.Add(Me.GrbHobby)
        Me.Controls.Add(Me.GrbGender)
        Me.Controls.Add(Me.BtnDone)
        Me.Controls.Add(Me.BtnSummary)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Lblcountry)
        Me.Controls.Add(Me.LblAge)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LblTitle)
        Me.Name = "Questionnaire"
        Me.Text = "Quetionnaire"
        Me.GrbGender.ResumeLayout(False)
        Me.GrbGender.PerformLayout()
        Me.GrbHobby.ResumeLayout(False)
        Me.GrbHobby.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents LblAge As System.Windows.Forms.Label
    Friend WithEvents Lblcountry As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnSummary As System.Windows.Forms.Button
    Friend WithEvents BtnDone As System.Windows.Forms.Button
    Friend WithEvents GrbGender As System.Windows.Forms.GroupBox
    Friend WithEvents ChkFemale As System.Windows.Forms.RadioButton
    Friend WithEvents ChkMale As System.Windows.Forms.RadioButton
    Friend WithEvents GrbHobby As System.Windows.Forms.GroupBox
    Friend WithEvents ListAge As System.Windows.Forms.ListBox
    Friend WithEvents txbName As System.Windows.Forms.TextBox
    Friend WithEvents CboCountry As System.Windows.Forms.ComboBox
    Friend WithEvents ChkDrinking As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEating As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSleeping As System.Windows.Forms.CheckBox
    Friend WithEvents chkReading As System.Windows.Forms.CheckBox

End Class
