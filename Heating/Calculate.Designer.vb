<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculate))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_volume = New System.Windows.Forms.TextBox()
        Me.TextBox_temperature = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button_info = New System.Windows.Forms.Button()
        Me.Button_calculate = New System.Windows.Forms.Button()
        Me.Button_rank_them = New System.Windows.Forms.Button()
        Me.Button_close = New System.Windows.Forms.Button()
        Me.Button_reset = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_energy = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_cost = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxMaterials = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCountries = New System.Windows.Forms.ComboBox()
        Me.Button_save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Volume"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Temperature"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Material"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Country"
        '
        'TextBox_volume
        '
        Me.TextBox_volume.Location = New System.Drawing.Point(265, 41)
        Me.TextBox_volume.Name = "TextBox_volume"
        Me.TextBox_volume.Size = New System.Drawing.Size(181, 31)
        Me.TextBox_volume.TabIndex = 4
        '
        'TextBox_temperature
        '
        Me.TextBox_temperature.Location = New System.Drawing.Point(265, 107)
        Me.TextBox_temperature.Name = "TextBox_temperature"
        Me.TextBox_temperature.Size = New System.Drawing.Size(181, 31)
        Me.TextBox_temperature.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(460, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "[ M³ ]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(460, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "[ C° ]"
        '
        'Button_info
        '
        Me.Button_info.Location = New System.Drawing.Point(608, 232)
        Me.Button_info.Name = "Button_info"
        Me.Button_info.Size = New System.Drawing.Size(167, 50)
        Me.Button_info.TabIndex = 10
        Me.Button_info.Text = "Help"
        Me.Button_info.UseVisualStyleBackColor = True
        '
        'Button_calculate
        '
        Me.Button_calculate.Location = New System.Drawing.Point(608, 23)
        Me.Button_calculate.Name = "Button_calculate"
        Me.Button_calculate.Size = New System.Drawing.Size(167, 49)
        Me.Button_calculate.TabIndex = 11
        Me.Button_calculate.Text = "Calculate"
        Me.Button_calculate.UseVisualStyleBackColor = True
        '
        'Button_rank_them
        '
        Me.Button_rank_them.Location = New System.Drawing.Point(608, 88)
        Me.Button_rank_them.Name = "Button_rank_them"
        Me.Button_rank_them.Size = New System.Drawing.Size(167, 50)
        Me.Button_rank_them.TabIndex = 12
        Me.Button_rank_them.Text = "Rank Them"
        Me.Button_rank_them.UseVisualStyleBackColor = True
        '
        'Button_close
        '
        Me.Button_close.Location = New System.Drawing.Point(608, 431)
        Me.Button_close.Name = "Button_close"
        Me.Button_close.Size = New System.Drawing.Size(167, 50)
        Me.Button_close.TabIndex = 13
        Me.Button_close.Text = "Close"
        Me.Button_close.UseVisualStyleBackColor = True
        '
        'Button_reset
        '
        Me.Button_reset.Location = New System.Drawing.Point(608, 160)
        Me.Button_reset.Name = "Button_reset"
        Me.Button_reset.Size = New System.Drawing.Size(167, 49)
        Me.Button_reset.TabIndex = 14
        Me.Button_reset.Text = "Reset"
        Me.Button_reset.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 390)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Energy"
        '
        'TextBox_energy
        '
        Me.TextBox_energy.Location = New System.Drawing.Point(265, 379)
        Me.TextBox_energy.Name = "TextBox_energy"
        Me.TextBox_energy.ReadOnly = True
        Me.TextBox_energy.Size = New System.Drawing.Size(181, 31)
        Me.TextBox_energy.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(460, 385)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "[ KJ ] "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(65, 456)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 25)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Cost"
        '
        'TextBox_cost
        '
        Me.TextBox_cost.Location = New System.Drawing.Point(265, 450)
        Me.TextBox_cost.Name = "TextBox_cost"
        Me.TextBox_cost.ReadOnly = True
        Me.TextBox_cost.Size = New System.Drawing.Size(181, 31)
        Me.TextBox_cost.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(460, 456)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 25)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "[ Cent ]"
        '
        'ComboBoxMaterials
        '
        Me.ComboBoxMaterials.FormattingEnabled = True
        Me.ComboBoxMaterials.Items.AddRange(New Object() {"Gas", "Electricity", "Coal"})
        Me.ComboBoxMaterials.Location = New System.Drawing.Point(265, 169)
        Me.ComboBoxMaterials.Name = "ComboBoxMaterials"
        Me.ComboBoxMaterials.Size = New System.Drawing.Size(181, 33)
        Me.ComboBoxMaterials.TabIndex = 21
        '
        'ComboBoxCountries
        '
        Me.ComboBoxCountries.FormattingEnabled = True
        Me.ComboBoxCountries.Items.AddRange(New Object() {"Sweden", "Italy", "Germany"})
        Me.ComboBoxCountries.Location = New System.Drawing.Point(265, 232)
        Me.ComboBoxCountries.Name = "ComboBoxCountries"
        Me.ComboBoxCountries.Size = New System.Drawing.Size(181, 33)
        Me.ComboBoxCountries.TabIndex = 22
        '
        'Button_save
        '
        Me.Button_save.Location = New System.Drawing.Point(608, 318)
        Me.Button_save.Name = "Button_save"
        Me.Button_save.Size = New System.Drawing.Size(167, 50)
        Me.Button_save.TabIndex = 23
        Me.Button_save.Text = "Save"
        Me.Button_save.UseVisualStyleBackColor = True
        '
        'Calculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(829, 510)
        Me.Controls.Add(Me.Button_save)
        Me.Controls.Add(Me.ComboBoxCountries)
        Me.Controls.Add(Me.ComboBoxMaterials)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox_cost)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox_energy)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button_reset)
        Me.Controls.Add(Me.Button_close)
        Me.Controls.Add(Me.Button_rank_them)
        Me.Controls.Add(Me.Button_calculate)
        Me.Controls.Add(Me.Button_info)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_temperature)
        Me.Controls.Add(Me.TextBox_volume)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Calculate"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_volume As TextBox
    Friend WithEvents TextBox_temperature As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button_info As Button
    Friend WithEvents Button_calculate As Button
    Friend WithEvents Button_rank_them As Button
    Friend WithEvents Button_close As Button
    Friend WithEvents Button_reset As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_energy As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_cost As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBoxMaterials As ComboBox
    Friend WithEvents ComboBoxCountries As ComboBox
    Friend WithEvents Button_save As Button
End Class
