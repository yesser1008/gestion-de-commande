<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modifier_client
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cod_cli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nom_cli = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.combo_remise = New System.Windows.Forms.ComboBox()
        Me.bt_ajout = New System.Windows.Forms.Button()
        Me.bt_modif = New System.Windows.Forms.Button()
        Me.bt_quit = New System.Windows.Forms.Button()
        Me.bt_sup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "code_client :"
        '
        'txt_cod_cli
        '
        Me.txt_cod_cli.Location = New System.Drawing.Point(110, 11)
        Me.txt_cod_cli.Name = "txt_cod_cli"
        Me.txt_cod_cli.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod_cli.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "nom_client :"
        '
        'txt_nom_cli
        '
        Me.txt_nom_cli.Location = New System.Drawing.Point(110, 42)
        Me.txt_nom_cli.Name = "txt_nom_cli"
        Me.txt_nom_cli.Size = New System.Drawing.Size(100, 20)
        Me.txt_nom_cli.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "taux_de_remise :"
        '
        'combo_remise
        '
        Me.combo_remise.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_remise.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_remise.FormattingEnabled = True
        Me.combo_remise.Items.AddRange(New Object() {"0", "10", "20", "30", "35"})
        Me.combo_remise.Location = New System.Drawing.Point(110, 72)
        Me.combo_remise.Name = "combo_remise"
        Me.combo_remise.Size = New System.Drawing.Size(100, 21)
        Me.combo_remise.TabIndex = 3
        '
        'bt_ajout
        '
        Me.bt_ajout.Location = New System.Drawing.Point(5, 115)
        Me.bt_ajout.Name = "bt_ajout"
        Me.bt_ajout.Size = New System.Drawing.Size(94, 23)
        Me.bt_ajout.TabIndex = 4
        Me.bt_ajout.Text = "ajouter"
        Me.bt_ajout.UseVisualStyleBackColor = True
        '
        'bt_modif
        '
        Me.bt_modif.Location = New System.Drawing.Point(110, 115)
        Me.bt_modif.Name = "bt_modif"
        Me.bt_modif.Size = New System.Drawing.Size(94, 23)
        Me.bt_modif.TabIndex = 5
        Me.bt_modif.Text = "modifier"
        Me.bt_modif.UseVisualStyleBackColor = True
        '
        'bt_quit
        '
        Me.bt_quit.Location = New System.Drawing.Point(110, 150)
        Me.bt_quit.Name = "bt_quit"
        Me.bt_quit.Size = New System.Drawing.Size(94, 23)
        Me.bt_quit.TabIndex = 7
        Me.bt_quit.Text = "quiter"
        Me.bt_quit.UseVisualStyleBackColor = True
        '
        'bt_sup
        '
        Me.bt_sup.Location = New System.Drawing.Point(5, 150)
        Me.bt_sup.Name = "bt_sup"
        Me.bt_sup.Size = New System.Drawing.Size(94, 23)
        Me.bt_sup.TabIndex = 6
        Me.bt_sup.Text = "supprimer"
        Me.bt_sup.UseVisualStyleBackColor = True
        '
        'modifier_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 189)
        Me.Controls.Add(Me.bt_sup)
        Me.Controls.Add(Me.bt_quit)
        Me.Controls.Add(Me.bt_modif)
        Me.Controls.Add(Me.bt_ajout)
        Me.Controls.Add(Me.combo_remise)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nom_cli)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cod_cli)
        Me.Controls.Add(Me.Label1)
        Me.Name = "modifier_client"
        Me.Text = "modifier_client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cod_cli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nom_cli As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents combo_remise As ComboBox
    Friend WithEvents bt_ajout As Button
    Friend WithEvents bt_modif As Button
    Friend WithEvents bt_quit As Button
    Friend WithEvents bt_sup As Button
End Class
