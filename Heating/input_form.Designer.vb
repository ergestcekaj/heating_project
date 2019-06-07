<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class input_form
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
        Me.Button_submit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox_date = New System.Windows.Forms.ComboBox()
        Me.ComboBox_name = New System.Windows.Forms.ComboBox()
        Me.TextBox_duration = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button_submit
        '
        Me.Button_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_submit.Location = New System.Drawing.Point(470, 319)
        Me.Button_submit.Name = "Button_submit"
        Me.Button_submit.Size = New System.Drawing.Size(167, 54)
        Me.Button_submit.TabIndex = 0
        Me.Button_submit.Text = "Submit"
        Me.Button_submit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Duration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Date"
        '
        'ComboBox_date
        '
        Me.ComboBox_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_date.FormattingEnabled = True
        Me.ComboBox_date.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "Novermber", "December"})
        Me.ComboBox_date.Location = New System.Drawing.Point(250, 174)
        Me.ComboBox_date.Name = "ComboBox_date"
        Me.ComboBox_date.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_date.TabIndex = 4
        '
        'ComboBox_name
        '
        Me.ComboBox_name.FormattingEnabled = True
        Me.ComboBox_name.Items.AddRange(New Object() {"Artan", "Michele", "Lucie", "Hugo", "Rodrigo"})
        Me.ComboBox_name.Location = New System.Drawing.Point(250, 66)
        Me.ComboBox_name.Name = "ComboBox_name"
        Me.ComboBox_name.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_name.TabIndex = 5
        '
        'TextBox_duration
        '
        Me.TextBox_duration.Location = New System.Drawing.Point(253, 125)
        Me.TextBox_duration.Name = "TextBox_duration"
        Me.TextBox_duration.Size = New System.Drawing.Size(117, 20)
        Me.TextBox_duration.TabIndex = 6
        '
        'input_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 389)
        Me.Controls.Add(Me.TextBox_duration)
        Me.Controls.Add(Me.ComboBox_name)
        Me.Controls.Add(Me.ComboBox_date)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_submit)
        Me.Name = "input_form"
        Me.Text = "input_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_submit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox_date As ComboBox
    Friend WithEvents ComboBox_name As ComboBox
    Friend WithEvents TextBox_duration As TextBox
End Class
