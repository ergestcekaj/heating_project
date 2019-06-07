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
        Dim lblTREE_SPECI As System.Windows.Forms.Label
        Dim lblADRES_FOR As System.Windows.Forms.Label
        Me.myDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblTreSpesies = New System.Windows.Forms.Label()
        Me.lstbxSpecies = New System.Windows.Forms.ListBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnTakeData = New System.Windows.Forms.Button()
        Me.txtTREE_SPECI = New System.Windows.Forms.TextBox()
        Me.txtADRES_FOR = New System.Windows.Forms.TextBox()
        lblTREE_SPECI = New System.Windows.Forms.Label()
        lblADRES_FOR = New System.Windows.Forms.Label()
        CType(Me.myDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTREE_SPECI
        '
        lblTREE_SPECI.AutoSize = True
        lblTREE_SPECI.Location = New System.Drawing.Point(29, 78)
        lblTREE_SPECI.Name = "lblTREE_SPECI"
        lblTREE_SPECI.Size = New System.Drawing.Size(71, 13)
        lblTREE_SPECI.TabIndex = 15
        lblTREE_SPECI.Text = "Tree species:"
        '
        'lblADRES_FOR
        '
        lblADRES_FOR.AutoSize = True
        lblADRES_FOR.Location = New System.Drawing.Point(21, 52)
        lblADRES_FOR.Name = "lblADRES_FOR"
        lblADRES_FOR.Size = New System.Drawing.Size(79, 13)
        lblADRES_FOR.TabIndex = 13
        lblADRES_FOR.Text = "Forest address:"
        '
        'myDataGridView
        '
        Me.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.myDataGridView.Location = New System.Drawing.Point(9, 115)
        Me.myDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.myDataGridView.Name = "myDataGridView"
        Me.myDataGridView.RowTemplate.Height = 24
        Me.myDataGridView.Size = New System.Drawing.Size(723, 273)
        Me.myDataGridView.TabIndex = 0
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(644, 72)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 21
        Me.btnShow.Text = "Show info"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'lblTreSpesies
        '
        Me.lblTreSpesies.AutoSize = True
        Me.lblTreSpesies.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTreSpesies.Location = New System.Drawing.Point(488, 20)
        Me.lblTreSpesies.Name = "lblTreSpesies"
        Me.lblTreSpesies.Size = New System.Drawing.Size(162, 17)
        Me.lblTreSpesies.TabIndex = 20
        Me.lblTreSpesies.Text = "Address of forest stands"
        '
        'lstbxSpecies
        '
        Me.lstbxSpecies.FormattingEnabled = True
        Me.lstbxSpecies.Location = New System.Drawing.Point(491, 39)
        Me.lstbxSpecies.Name = "lstbxSpecies"
        Me.lstbxSpecies.Size = New System.Drawing.Size(146, 56)
        Me.lstbxSpecies.TabIndex = 19
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(20, 20)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(168, 18)
        Me.lblInfo.TabIndex = 18
        Me.lblInfo.Text = "Some values of first row"
        '
        'btnTakeData
        '
        Me.btnTakeData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnTakeData.Location = New System.Drawing.Point(291, 32)
        Me.btnTakeData.Name = "btnTakeData"
        Me.btnTakeData.Size = New System.Drawing.Size(113, 61)
        Me.btnTakeData.TabIndex = 17
        Me.btnTakeData.Text = "Take data"
        Me.btnTakeData.UseVisualStyleBackColor = True
        '
        'txtTREE_SPECI
        '
        Me.txtTREE_SPECI.Location = New System.Drawing.Point(106, 76)
        Me.txtTREE_SPECI.Name = "txtTREE_SPECI"
        Me.txtTREE_SPECI.Size = New System.Drawing.Size(69, 20)
        Me.txtTREE_SPECI.TabIndex = 16
        '
        'txtADRES_FOR
        '
        Me.txtADRES_FOR.Location = New System.Drawing.Point(106, 50)
        Me.txtADRES_FOR.Name = "txtADRES_FOR"
        Me.txtADRES_FOR.Size = New System.Drawing.Size(126, 20)
        Me.txtADRES_FOR.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 400)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblTreSpesies)
        Me.Controls.Add(Me.lstbxSpecies)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnTakeData)
        Me.Controls.Add(lblTREE_SPECI)
        Me.Controls.Add(Me.txtTREE_SPECI)
        Me.Controls.Add(lblADRES_FOR)
        Me.Controls.Add(Me.txtADRES_FOR)
        Me.Controls.Add(Me.myDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.myDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents lblTreSpesies As System.Windows.Forms.Label
    Friend WithEvents lstbxSpecies As System.Windows.Forms.ListBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnTakeData As System.Windows.Forms.Button
    Friend WithEvents txtTREE_SPECI As System.Windows.Forms.TextBox
    Friend WithEvents txtADRES_FOR As System.Windows.Forms.TextBox

End Class
