<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class lignes_com
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lignes_com))
        Me.ligne_com = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.ligne_com, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ligne_com
        '
        Me.ligne_com.AllowUserToDeleteRows = False
        Me.ligne_com.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ligne_com.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2})
        Me.ligne_com.Location = New System.Drawing.Point(10, 18)
        Me.ligne_com.Name = "ligne_com"
        Me.ligne_com.ReadOnly = True
        Me.ligne_com.Size = New System.Drawing.Size(436, 245)
        Me.ligne_com.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code Article"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 140
        '
        'Column3
        '
        Me.Column3.HeaderText = "Qtité"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 140
        '
        'Column2
        '
        Me.Column2.HeaderText = "Moule"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ligne_com)
        Me.Panel1.Location = New System.Drawing.Point(2, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 277)
        Me.Panel1.TabIndex = 13
        '
        'lignes_com
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 300)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "lignes_com"
        Me.Text = "lignes_com"
        CType(Me.ligne_com, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ligne_com As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
