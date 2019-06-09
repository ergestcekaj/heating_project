<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DB_form
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
        Me.DataGridView_Filtered_Data = New System.Windows.Forms.DataGridView()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Names = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Total_Cost = New System.Windows.Forms.Label()
        Me.ListBox_Month = New System.Windows.Forms.ListBox()
        Me.ListBox_Name = New System.Windows.Forms.ListBox()
        CType(Me.DataGridView_Filtered_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_Filtered_Data
        '
        Me.DataGridView_Filtered_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Filtered_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridView_Filtered_Data.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_Filtered_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Filtered_Data.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_Filtered_Data.Location = New System.Drawing.Point(354, 56)
        Me.DataGridView_Filtered_Data.Name = "DataGridView_Filtered_Data"
        Me.DataGridView_Filtered_Data.ReadOnly = True
        Me.DataGridView_Filtered_Data.Size = New System.Drawing.Size(423, 289)
        Me.DataGridView_Filtered_Data.TabIndex = 0
        '
        'Button_Save
        '
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(46, 389)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(88, 36)
        Me.Button_Save.TabIndex = 1
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Names
        '
        Me.Names.AutoSize = True
        Me.Names.Location = New System.Drawing.Point(46, 56)
        Me.Names.Name = "Names"
        Me.Names.Size = New System.Drawing.Size(35, 13)
        Me.Names.TabIndex = 2
        Me.Names.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Month"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(350, 389)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total Cost :"
        '
        'Label_Total_Cost
        '
        Me.Label_Total_Cost.AutoSize = True
        Me.Label_Total_Cost.Location = New System.Drawing.Point(499, 389)
        Me.Label_Total_Cost.Name = "Label_Total_Cost"
        Me.Label_Total_Cost.Size = New System.Drawing.Size(0, 13)
        Me.Label_Total_Cost.TabIndex = 7
        '
        'ListBox_Month
        '
        Me.ListBox_Month.FormattingEnabled = True
        Me.ListBox_Month.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ListBox_Month.Location = New System.Drawing.Point(126, 203)
        Me.ListBox_Month.Name = "ListBox_Month"
        Me.ListBox_Month.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox_Month.Size = New System.Drawing.Size(120, 160)
        Me.ListBox_Month.TabIndex = 9
        '
        'ListBox_Name
        '
        Me.ListBox_Name.FormattingEnabled = True
        Me.ListBox_Name.Items.AddRange(New Object() {"Artan", "Michele", "Lucie", "Hugo", "Rodrigo"})
        Me.ListBox_Name.Location = New System.Drawing.Point(126, 56)
        Me.ListBox_Name.Name = "ListBox_Name"
        Me.ListBox_Name.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox_Name.Size = New System.Drawing.Size(120, 95)
        Me.ListBox_Name.TabIndex = 10
        '
        'DB_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox_Name)
        Me.Controls.Add(Me.ListBox_Month)
        Me.Controls.Add(Me.Label_Total_Cost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Names)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.DataGridView_Filtered_Data)
        Me.Name = "DB_form"
        Me.Text = "Operations "
        CType(Me.DataGridView_Filtered_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView_Filtered_Data As DataGridView
    Friend WithEvents Button_Save As Button
    Friend WithEvents Names As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_Total_Cost As Label
    Friend WithEvents ListBox_Month As ListBox
    Friend WithEvents ListBox_Name As ListBox
End Class
