<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class articles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(articles))
        Me.bt_ajout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ref_art = New System.Windows.Forms.TextBox()
        Me.txt_typ_art = New System.Windows.Forms.TextBox()
        Me.txt_prix_art = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Radio_all = New System.Windows.Forms.RadioButton()
        Me.radio_part = New System.Windows.Forms.RadioButton()
        Me.bt_modif = New System.Windows.Forms.Button()
        Me.bt_suprimer = New System.Windows.Forms.Button()
        Me.bt_quit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_moule = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_ajout
        '
        Me.bt_ajout.Location = New System.Drawing.Point(397, 21)
        Me.bt_ajout.Name = "bt_ajout"
        Me.bt_ajout.Size = New System.Drawing.Size(75, 23)
        Me.bt_ajout.TabIndex = 5
        Me.bt_ajout.Text = "ajouter"
        Me.bt_ajout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REF_ART :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TYP_ART :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PRIX :"
        '
        'txt_ref_art
        '
        Me.txt_ref_art.Location = New System.Drawing.Point(92, 23)
        Me.txt_ref_art.Name = "txt_ref_art"
        Me.txt_ref_art.Size = New System.Drawing.Size(100, 20)
        Me.txt_ref_art.TabIndex = 1
        '
        'txt_typ_art
        '
        Me.txt_typ_art.Location = New System.Drawing.Point(271, 23)
        Me.txt_typ_art.Name = "txt_typ_art"
        Me.txt_typ_art.Size = New System.Drawing.Size(100, 20)
        Me.txt_typ_art.TabIndex = 2
        '
        'txt_prix_art
        '
        Me.txt_prix_art.Location = New System.Drawing.Point(92, 63)
        Me.txt_prix_art.Name = "txt_prix_art"
        Me.txt_prix_art.Size = New System.Drawing.Size(100, 20)
        Me.txt_prix_art.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 155)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(348, 129)
        Me.DataGridView1.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.HeaderText = "REF_ART"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "TYP_ART"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "PRIX"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Radio_all
        '
        Me.Radio_all.AutoSize = True
        Me.Radio_all.Location = New System.Drawing.Point(33, 100)
        Me.Radio_all.Name = "Radio_all"
        Me.Radio_all.Size = New System.Drawing.Size(97, 17)
        Me.Radio_all.TabIndex = 9
        Me.Radio_all.TabStop = True
        Me.Radio_all.Text = "tous les articles"
        Me.Radio_all.UseVisualStyleBackColor = True
        '
        'radio_part
        '
        Me.radio_part.AutoSize = True
        Me.radio_part.Location = New System.Drawing.Point(142, 100)
        Me.radio_part.Name = "radio_part"
        Me.radio_part.Size = New System.Drawing.Size(190, 17)
        Me.radio_part.TabIndex = 10
        Me.radio_part.TabStop = True
        Me.radio_part.Text = "Article n'ont jamais été commandés"
        Me.radio_part.UseVisualStyleBackColor = True
        '
        'bt_modif
        '
        Me.bt_modif.Location = New System.Drawing.Point(397, 51)
        Me.bt_modif.Name = "bt_modif"
        Me.bt_modif.Size = New System.Drawing.Size(75, 23)
        Me.bt_modif.TabIndex = 6
        Me.bt_modif.Text = "modifier"
        Me.bt_modif.UseVisualStyleBackColor = True
        '
        'bt_suprimer
        '
        Me.bt_suprimer.Location = New System.Drawing.Point(397, 81)
        Me.bt_suprimer.Name = "bt_suprimer"
        Me.bt_suprimer.Size = New System.Drawing.Size(75, 23)
        Me.bt_suprimer.TabIndex = 7
        Me.bt_suprimer.Text = "supprimer"
        Me.bt_suprimer.UseVisualStyleBackColor = True
        '
        'bt_quit
        '
        Me.bt_quit.Location = New System.Drawing.Point(397, 111)
        Me.bt_quit.Name = "bt_quit"
        Me.bt_quit.Size = New System.Drawing.Size(75, 23)
        Me.bt_quit.TabIndex = 8
        Me.bt_quit.Text = "fermer"
        Me.bt_quit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Moule"
        '
        'txt_moule
        '
        Me.txt_moule.Location = New System.Drawing.Point(271, 63)
        Me.txt_moule.Name = "txt_moule"
        Me.txt_moule.Size = New System.Drawing.Size(100, 20)
        Me.txt_moule.TabIndex = 12
        '
        'articles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 292)
        Me.Controls.Add(Me.txt_moule)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_prix_art)
        Me.Controls.Add(Me.bt_quit)
        Me.Controls.Add(Me.bt_suprimer)
        Me.Controls.Add(Me.bt_modif)
        Me.Controls.Add(Me.radio_part)
        Me.Controls.Add(Me.Radio_all)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_typ_art)
        Me.Controls.Add(Me.txt_ref_art)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_ajout)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "articles"
        Me.Text = "Gestion des Articles"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_ajout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_ref_art As TextBox
    Friend WithEvents txt_typ_art As TextBox
    Friend WithEvents txt_prix_art As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Radio_all As RadioButton
    Friend WithEvents radio_part As RadioButton
    Friend WithEvents bt_modif As Button
    Friend WithEvents bt_suprimer As Button
    Friend WithEvents bt_quit As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_moule As TextBox
End Class
