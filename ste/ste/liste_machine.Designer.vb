<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class liste_machine
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lab_art = New System.Windows.Forms.Label()
        Me.bt_aff = New System.Windows.Forms.Button()
        Me.bt_libre = New System.Windows.Forms.Button()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lab_art)
        Me.Panel1.Controls.Add(Me.bt_aff)
        Me.Panel1.Controls.Add(Me.bt_libre)
        Me.Panel1.Controls.Add(Me.txt_nom)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_cod)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 226)
        Me.Panel1.TabIndex = 0
        '
        'lab_art
        '
        Me.lab_art.AutoSize = True
        Me.lab_art.Location = New System.Drawing.Point(9, 60)
        Me.lab_art.Name = "lab_art"
        Me.lab_art.Size = New System.Drawing.Size(19, 13)
        Me.lab_art.TabIndex = 8
        Me.lab_art.Text = "art"
        Me.lab_art.Visible = False
        '
        'bt_aff
        '
        Me.bt_aff.Enabled = False
        Me.bt_aff.Location = New System.Drawing.Point(276, 59)
        Me.bt_aff.Name = "bt_aff"
        Me.bt_aff.Size = New System.Drawing.Size(75, 23)
        Me.bt_aff.TabIndex = 7
        Me.bt_aff.Text = "affecter"
        Me.bt_aff.UseVisualStyleBackColor = True
        '
        'bt_libre
        '
        Me.bt_libre.Enabled = False
        Me.bt_libre.Location = New System.Drawing.Point(179, 60)
        Me.bt_libre.Name = "bt_libre"
        Me.bt_libre.Size = New System.Drawing.Size(75, 23)
        Me.bt_libre.TabIndex = 6
        Me.bt_libre.Text = "libérer"
        Me.bt_libre.UseVisualStyleBackColor = True
        '
        'txt_nom
        '
        Me.txt_nom.Enabled = False
        Me.txt_nom.Location = New System.Drawing.Point(267, 17)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(100, 20)
        Me.txt_nom.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "nom_mach"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "code_machine"
        '
        'txt_cod
        '
        Me.txt_cod.Enabled = False
        Me.txt_cod.Location = New System.Drawing.Point(89, 17)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(355, 124)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "code_machine"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "qté_max"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "disponibilité"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'liste_machine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 250)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "liste_machine"
        Me.Text = "liste_machine"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents bt_aff As Button
    Friend WithEvents bt_libre As Button
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents lab_art As Label
End Class
