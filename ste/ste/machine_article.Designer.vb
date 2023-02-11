<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class machine_article
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_cod_mach = New System.Windows.Forms.ComboBox()
        Me.combo_ref_art = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_capacite = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "selectioner code de la machine :"
        '
        'combo_cod_mach
        '
        Me.combo_cod_mach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_cod_mach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_cod_mach.FormattingEnabled = True
        Me.combo_cod_mach.Location = New System.Drawing.Point(193, 17)
        Me.combo_cod_mach.Name = "combo_cod_mach"
        Me.combo_cod_mach.Size = New System.Drawing.Size(121, 21)
        Me.combo_cod_mach.TabIndex = 1
        '
        'combo_ref_art
        '
        Me.combo_ref_art.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_ref_art.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_ref_art.FormattingEnabled = True
        Me.combo_ref_art.Location = New System.Drawing.Point(193, 58)
        Me.combo_ref_art.Name = "combo_ref_art"
        Me.combo_ref_art.Size = New System.Drawing.Size(121, 21)
        Me.combo_ref_art.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "selection le code de l'article :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Capacité maximale de fbrication  :"
        '
        'txt_capacite
        '
        Me.txt_capacite.Location = New System.Drawing.Point(193, 93)
        Me.txt_capacite.Name = "txt_capacite"
        Me.txt_capacite.Size = New System.Drawing.Size(100, 20)
        Me.txt_capacite.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "ajouter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(111, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "modifier"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(202, 145)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Quiter"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 193)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(343, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'machine_article
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 355)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_capacite)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.combo_ref_art)
        Me.Controls.Add(Me.combo_cod_mach)
        Me.Controls.Add(Me.Label1)
        Me.Name = "machine_article"
        Me.Text = "machine_article"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents combo_cod_mach As ComboBox
    Friend WithEvents combo_ref_art As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_capacite As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
