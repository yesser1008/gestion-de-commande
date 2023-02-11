<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class commande
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(commande))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.date_com = New System.Windows.Forms.DateTimePicker()
        Me.txt_nom_cli = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.date_liv_com = New System.Windows.Forms.DateTimePicker()
        Me.ref_cli = New System.Windows.Forms.ComboBox()
        Me.txt_num_com = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_num_art = New System.Windows.Forms.ComboBox()
        Me.bt_ajout = New System.Windows.Forms.Button()
        Me.txt_mnt_ligne = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_qtite = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_prix = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mnt_tot = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.data_liste_com = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bt_anul = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.liste_com = New System.Windows.Forms.ComboBox()
        Me.bt_rech = New System.Windows.Forms.Button()
        Me.bt_modif = New System.Windows.Forms.Button()
        Me.bt_sup = New System.Windows.Forms.Button()
        Me.bt_enreg = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.data_liste_com, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.date_com)
        Me.GroupBox1.Controls.Add(Me.txt_nom_cli)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.date_liv_com)
        Me.GroupBox1.Controls.Add(Me.ref_cli)
        Me.GroupBox1.Controls.Add(Me.txt_num_com)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 114)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commande"
        '
        'date_com
        '
        Me.date_com.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder
        Me.date_com.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText
        Me.date_com.Enabled = False
        Me.date_com.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_com.Location = New System.Drawing.Point(319, 21)
        Me.date_com.Name = "date_com"
        Me.date_com.Size = New System.Drawing.Size(99, 20)
        Me.date_com.TabIndex = 2
        Me.date_com.Value = New Date(2020, 5, 11, 0, 0, 0, 0)
        '
        'txt_nom_cli
        '
        Me.txt_nom_cli.Enabled = False
        Me.txt_nom_cli.Location = New System.Drawing.Point(253, 50)
        Me.txt_nom_cli.Name = "txt_nom_cli"
        Me.txt_nom_cli.Size = New System.Drawing.Size(266, 20)
        Me.txt_nom_cli.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(250, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date BC :"
        '
        'date_liv_com
        '
        Me.date_liv_com.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_liv_com.Location = New System.Drawing.Point(103, 77)
        Me.date_liv_com.Name = "date_liv_com"
        Me.date_liv_com.Size = New System.Drawing.Size(100, 20)
        Me.date_liv_com.TabIndex = 5
        Me.date_liv_com.Value = New Date(2020, 5, 11, 0, 0, 0, 0)
        '
        'ref_cli
        '
        Me.ref_cli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ref_cli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ref_cli.FormattingEnabled = True
        Me.ref_cli.Location = New System.Drawing.Point(66, 49)
        Me.ref_cli.Name = "ref_cli"
        Me.ref_cli.Size = New System.Drawing.Size(121, 21)
        Me.ref_cli.TabIndex = 3
        '
        'txt_num_com
        '
        Me.txt_num_com.Enabled = False
        Me.txt_num_com.Location = New System.Drawing.Point(103, 20)
        Me.txt_num_com.Name = "txt_num_com"
        Me.txt_num_com.Size = New System.Drawing.Size(100, 20)
        Me.txt_num_com.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date Livraison :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Client :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N°commande :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_num_art)
        Me.GroupBox2.Controls.Add(Me.bt_ajout)
        Me.GroupBox2.Controls.Add(Me.txt_mnt_ligne)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_qtite)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_prix)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(730, 63)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ligne"
        '
        'txt_num_art
        '
        Me.txt_num_art.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_num_art.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_num_art.FormattingEnabled = True
        Me.txt_num_art.Location = New System.Drawing.Point(61, 20)
        Me.txt_num_art.Name = "txt_num_art"
        Me.txt_num_art.Size = New System.Drawing.Size(100, 21)
        Me.txt_num_art.TabIndex = 6
        '
        'bt_ajout
        '
        Me.bt_ajout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.bt_ajout.Location = New System.Drawing.Point(649, 19)
        Me.bt_ajout.Name = "bt_ajout"
        Me.bt_ajout.Size = New System.Drawing.Size(75, 30)
        Me.bt_ajout.TabIndex = 10
        Me.bt_ajout.Text = "ajout"
        Me.bt_ajout.UseVisualStyleBackColor = True
        '
        'txt_mnt_ligne
        '
        Me.txt_mnt_ligne.Enabled = False
        Me.txt_mnt_ligne.Location = New System.Drawing.Point(526, 20)
        Me.txt_mnt_ligne.Name = "txt_mnt_ligne"
        Me.txt_mnt_ligne.Size = New System.Drawing.Size(100, 20)
        Me.txt_mnt_ligne.TabIndex = 9
        Me.txt_mnt_ligne.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(468, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Montant :"
        '
        'txt_qtite
        '
        Me.txt_qtite.Enabled = False
        Me.txt_qtite.Location = New System.Drawing.Point(357, 20)
        Me.txt_qtite.Name = "txt_qtite"
        Me.txt_qtite.Size = New System.Drawing.Size(100, 20)
        Me.txt_qtite.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(316, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Qtité :"
        '
        'txt_prix
        '
        Me.txt_prix.Enabled = False
        Me.txt_prix.Location = New System.Drawing.Point(203, 20)
        Me.txt_prix.Name = "txt_prix"
        Me.txt_prix.Size = New System.Drawing.Size(100, 20)
        Me.txt_prix.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(167, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Prix :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "N°Article :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mnt_tot)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.data_liste_com)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(801, 130)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lignes commande"
        '
        'mnt_tot
        '
        Me.mnt_tot.AutoSize = True
        Me.mnt_tot.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.mnt_tot.Location = New System.Drawing.Point(645, 59)
        Me.mnt_tot.Name = "mnt_tot"
        Me.mnt_tot.Size = New System.Drawing.Size(35, 22)
        Me.mnt_tot.TabIndex = 2
        Me.mnt_tot.Text = "0,0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Label9.Location = New System.Drawing.Point(645, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 22)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Montant Total"
        '
        'data_liste_com
        '
        Me.data_liste_com.AllowUserToDeleteRows = False
        Me.data_liste_com.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_liste_com.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.data_liste_com.Location = New System.Drawing.Point(9, 19)
        Me.data_liste_com.Name = "data_liste_com"
        Me.data_liste_com.ReadOnly = True
        Me.data_liste_com.Size = New System.Drawing.Size(617, 105)
        Me.data_liste_com.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code_Article"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 140
        '
        'Column2
        '
        Me.Column2.HeaderText = "Prix"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 140
        '
        'Column3
        '
        Me.Column3.HeaderText = "Qtité"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 140
        '
        'Column4
        '
        Me.Column4.HeaderText = "Montant"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 140
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.bt_anul)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.liste_com)
        Me.GroupBox4.Controls.Add(Me.bt_rech)
        Me.GroupBox4.Controls.Add(Me.bt_modif)
        Me.GroupBox4.Controls.Add(Me.bt_sup)
        Me.GroupBox4.Controls.Add(Me.bt_enreg)
        Me.GroupBox4.Location = New System.Drawing.Point(22, 352)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(853, 46)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(605, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "export PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bt_anul
        '
        Me.bt_anul.Location = New System.Drawing.Point(686, 17)
        Me.bt_anul.Name = "bt_anul"
        Me.bt_anul.Size = New System.Drawing.Size(75, 23)
        Me.bt_anul.TabIndex = 4
        Me.bt_anul.Text = "annuler"
        Me.bt_anul.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(767, 17)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Quiter"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'liste_com
        '
        Me.liste_com.FormattingEnabled = True
        Me.liste_com.Location = New System.Drawing.Point(387, 19)
        Me.liste_com.Name = "liste_com"
        Me.liste_com.Size = New System.Drawing.Size(191, 21)
        Me.liste_com.TabIndex = 16
        '
        'bt_rech
        '
        Me.bt_rech.Enabled = False
        Me.bt_rech.Location = New System.Drawing.Point(287, 17)
        Me.bt_rech.Name = "bt_rech"
        Me.bt_rech.Size = New System.Drawing.Size(75, 23)
        Me.bt_rech.TabIndex = 15
        Me.bt_rech.Text = "Recherche"
        Me.bt_rech.UseVisualStyleBackColor = True
        '
        'bt_modif
        '
        Me.bt_modif.Enabled = False
        Me.bt_modif.Location = New System.Drawing.Point(194, 17)
        Me.bt_modif.Name = "bt_modif"
        Me.bt_modif.Size = New System.Drawing.Size(75, 23)
        Me.bt_modif.TabIndex = 14
        Me.bt_modif.Text = "Modifier"
        Me.bt_modif.UseVisualStyleBackColor = True
        '
        'bt_sup
        '
        Me.bt_sup.Enabled = False
        Me.bt_sup.Location = New System.Drawing.Point(103, 17)
        Me.bt_sup.Name = "bt_sup"
        Me.bt_sup.Size = New System.Drawing.Size(75, 23)
        Me.bt_sup.TabIndex = 13
        Me.bt_sup.Text = "Supprimer"
        Me.bt_sup.UseVisualStyleBackColor = True
        '
        'bt_enreg
        '
        Me.bt_enreg.Location = New System.Drawing.Point(9, 17)
        Me.bt_enreg.Name = "bt_enreg"
        Me.bt_enreg.Size = New System.Drawing.Size(75, 23)
        Me.bt_enreg.TabIndex = 12
        Me.bt_enreg.Text = "Enregistrer"
        Me.bt_enreg.UseVisualStyleBackColor = True
        '
        'commande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 410)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "commande"
        Me.Text = "commande"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.data_liste_com, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents date_com As DateTimePicker
    Friend WithEvents txt_nom_cli As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents date_liv_com As DateTimePicker
    Friend WithEvents ref_cli As ComboBox
    Friend WithEvents txt_num_com As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_mnt_ligne As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_qtite As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_prix As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents data_liste_com As DataGridView
    Friend WithEvents bt_ajout As Button
    Friend WithEvents mnt_tot As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents liste_com As ComboBox
    Friend WithEvents bt_rech As Button
    Friend WithEvents bt_modif As Button
    Friend WithEvents bt_sup As Button
    Friend WithEvents bt_enreg As Button
    Friend WithEvents txt_num_art As ComboBox
    Friend WithEvents bt_anul As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
