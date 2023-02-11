<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modifier_emp
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
        Me.bt_sup = New System.Windows.Forms.Button()
        Me.bt_quit = New System.Windows.Forms.Button()
        Me.bt_modif = New System.Windows.Forms.Button()
        Me.bt_ajout = New System.Windows.Forms.Button()
        Me.txt_password_emp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nom_emp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lk_lib_affiche = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.secretaire = New System.Windows.Forms.RadioButton()
        Me.tech = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ListeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecretaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResponsableFabricationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_sup
        '
        Me.bt_sup.Location = New System.Drawing.Point(10, 194)
        Me.bt_sup.Name = "bt_sup"
        Me.bt_sup.Size = New System.Drawing.Size(94, 23)
        Me.bt_sup.TabIndex = 7
        Me.bt_sup.Text = "supprimer"
        Me.bt_sup.UseVisualStyleBackColor = True
        '
        'bt_quit
        '
        Me.bt_quit.Location = New System.Drawing.Point(114, 194)
        Me.bt_quit.Name = "bt_quit"
        Me.bt_quit.Size = New System.Drawing.Size(94, 23)
        Me.bt_quit.TabIndex = 8
        Me.bt_quit.Text = "quiter"
        Me.bt_quit.UseVisualStyleBackColor = True
        '
        'bt_modif
        '
        Me.bt_modif.Location = New System.Drawing.Point(114, 165)
        Me.bt_modif.Name = "bt_modif"
        Me.bt_modif.Size = New System.Drawing.Size(94, 23)
        Me.bt_modif.TabIndex = 6
        Me.bt_modif.Text = "modifier"
        Me.bt_modif.UseVisualStyleBackColor = True
        '
        'bt_ajout
        '
        Me.bt_ajout.Location = New System.Drawing.Point(10, 165)
        Me.bt_ajout.Name = "bt_ajout"
        Me.bt_ajout.Size = New System.Drawing.Size(94, 23)
        Me.bt_ajout.TabIndex = 5
        Me.bt_ajout.Text = "ajouter"
        Me.bt_ajout.UseVisualStyleBackColor = True
        '
        'txt_password_emp
        '
        Me.txt_password_emp.Location = New System.Drawing.Point(75, 67)
        Me.txt_password_emp.Name = "txt_password_emp"
        Me.txt_password_emp.Size = New System.Drawing.Size(100, 20)
        Me.txt_password_emp.TabIndex = 2
        Me.txt_password_emp.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "password :"
        '
        'txt_nom_emp
        '
        Me.txt_nom_emp.Location = New System.Drawing.Point(75, 36)
        Me.txt_nom_emp.Name = "txt_nom_emp"
        Me.txt_nom_emp.Size = New System.Drawing.Size(100, 20)
        Me.txt_nom_emp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "nom_emp :"
        '
        'lk_lib_affiche
        '
        Me.lk_lib_affiche.AutoSize = True
        Me.lk_lib_affiche.Location = New System.Drawing.Point(181, 74)
        Me.lk_lib_affiche.Name = "lk_lib_affiche"
        Me.lk_lib_affiche.Size = New System.Drawing.Size(42, 13)
        Me.lk_lib_affiche.TabIndex = 21
        Me.lk_lib_affiche.TabStop = True
        Me.lk_lib_affiche.Text = "afficher"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Fonction :"
        '
        'secretaire
        '
        Me.secretaire.AutoSize = True
        Me.secretaire.Location = New System.Drawing.Point(75, 103)
        Me.secretaire.Name = "secretaire"
        Me.secretaire.Size = New System.Drawing.Size(71, 17)
        Me.secretaire.TabIndex = 3
        Me.secretaire.TabStop = True
        Me.secretaire.Text = "secretaire"
        Me.secretaire.UseVisualStyleBackColor = True
        '
        'tech
        '
        Me.tech.AutoSize = True
        Me.tech.Location = New System.Drawing.Point(75, 126)
        Me.tech.Name = "tech"
        Me.tech.Size = New System.Drawing.Size(137, 17)
        Me.tech.TabIndex = 4
        Me.tech.TabStop = True
        Me.tech.Text = "responsable_fabrication"
        Me.tech.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(238, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ListeToolStripMenuItem
        '
        Me.ListeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ListeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SecretaireToolStripMenuItem, Me.ResponsableFabricationToolStripMenuItem})
        Me.ListeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.ListeToolStripMenuItem.Name = "ListeToolStripMenuItem"
        Me.ListeToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.ListeToolStripMenuItem.Text = "liste"
        '
        'SecretaireToolStripMenuItem
        '
        Me.SecretaireToolStripMenuItem.Name = "SecretaireToolStripMenuItem"
        Me.SecretaireToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.SecretaireToolStripMenuItem.Text = "secretaire"
        '
        'ResponsableFabricationToolStripMenuItem
        '
        Me.ResponsableFabricationToolStripMenuItem.Name = "ResponsableFabricationToolStripMenuItem"
        Me.ResponsableFabricationToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ResponsableFabricationToolStripMenuItem.Text = "responsable fabrication"
        '
        'modifier_emp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 230)
        Me.Controls.Add(Me.tech)
        Me.Controls.Add(Me.secretaire)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lk_lib_affiche)
        Me.Controls.Add(Me.bt_sup)
        Me.Controls.Add(Me.bt_quit)
        Me.Controls.Add(Me.bt_modif)
        Me.Controls.Add(Me.bt_ajout)
        Me.Controls.Add(Me.txt_password_emp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nom_emp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "modifier_emp"
        Me.Text = "modifier_emp"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_sup As Button
    Friend WithEvents bt_quit As Button
    Friend WithEvents bt_modif As Button
    Friend WithEvents bt_ajout As Button
    Friend WithEvents txt_password_emp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nom_emp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lk_lib_affiche As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents secretaire As RadioButton
    Friend WithEvents tech As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ListeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SecretaireToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResponsableFabricationToolStripMenuItem As ToolStripMenuItem
End Class
