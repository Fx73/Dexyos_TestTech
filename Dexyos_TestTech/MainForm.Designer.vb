<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.MyTextBox = New System.Windows.Forms.TextBox()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.C0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyTextBox
        '
        Me.MyTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MyTextBox.Location = New System.Drawing.Point(0, 250)
        Me.MyTextBox.Name = "MyTextBox"
        Me.MyTextBox.Size = New System.Drawing.Size(599, 23)
        Me.MyTextBox.TabIndex = 0
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MyDataGridView.ColumnHeadersVisible = False
        Me.MyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C0})
        Me.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.MyDataGridView.RowTemplate.Height = 25
        Me.MyDataGridView.ShowCellToolTips = False
        Me.MyDataGridView.ShowEditingIcon = False
        Me.MyDataGridView.Size = New System.Drawing.Size(599, 250)
        Me.MyDataGridView.TabIndex = 1
        '
        'C0
        '
        Me.C0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.C0.HeaderText = ""
        Me.C0.MinimumWidth = 2
        Me.C0.Name = "C0"
        Me.C0.ReadOnly = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 273)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.MyTextBox)
        Me.Name = "MainForm"
        Me.Text = "Dexyos : Test Technique"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MyTextBox As TextBox
    Friend WithEvents MyDataGridView As DataGridView
    Friend WithEvents C0 As DataGridViewTextBoxColumn
End Class
