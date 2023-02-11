<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin))
        Me.bt_tech = New System.Windows.Forms.Button()
        Me.bt_commande = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bt_mod_cli = New System.Windows.Forms.Button()
        Me.bt_mod_emp = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bt_art = New System.Windows.Forms.Button()
        Me.bt_quiter = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bt_mach = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_tech
        '
        Me.bt_tech.Location = New System.Drawing.Point(141, 74)
        Me.bt_tech.Name = "bt_tech"
        Me.bt_tech.Size = New System.Drawing.Size(89, 23)
        Me.bt_tech.TabIndex = 3
        Me.bt_tech.Text = "tech"
        Me.bt_tech.UseVisualStyleBackColor = True
        '
        'bt_commande
        '
        Me.bt_commande.Location = New System.Drawing.Point(141, 103)
        Me.bt_commande.Name = "bt_commande"
        Me.bt_commande.Size = New System.Drawing.Size(89, 23)
        Me.bt_commande.TabIndex = 4
        Me.bt_commande.Text = "commande"
        Me.bt_commande.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "modification des clients :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "modifier compte emp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "gestion de fabrication"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gestion de commande"
        '
        'bt_mod_cli
        '
        Me.bt_mod_cli.Location = New System.Drawing.Point(141, 16)
        Me.bt_mod_cli.Name = "bt_mod_cli"
        Me.bt_mod_cli.Size = New System.Drawing.Size(89, 23)
        Me.bt_mod_cli.TabIndex = 1
        Me.bt_mod_cli.Text = "modifier_client"
        Me.bt_mod_cli.UseVisualStyleBackColor = True
        '
        'bt_mod_emp
        '
        Me.bt_mod_emp.Location = New System.Drawing.Point(141, 45)
        Me.bt_mod_emp.Name = "bt_mod_emp"
        Me.bt_mod_emp.Size = New System.Drawing.Size(89, 23)
        Me.bt_mod_emp.TabIndex = 2
        Me.bt_mod_emp.Text = "modifier_emp"
        Me.bt_mod_emp.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Article :"
        '
        'bt_art
        '
        Me.bt_art.Location = New System.Drawing.Point(141, 133)
        Me.bt_art.Name = "bt_art"
        Me.bt_art.Size = New System.Drawing.Size(89, 23)
        Me.bt_art.TabIndex = 5
        Me.bt_art.Text = "gérer"
        Me.bt_art.UseVisualStyleBackColor = True
        '
        'bt_quiter
        '
        Me.bt_quiter.Location = New System.Drawing.Point(44, 218)
        Me.bt_quiter.Name = "bt_quiter"
        Me.bt_quiter.Size = New System.Drawing.Size(151, 23)
        Me.bt_quiter.TabIndex = 6
        Me.bt_quiter.Text = "quiter"
        Me.bt_quiter.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Machine :"
        '
        'bt_mach
        '
        Me.bt_mach.Location = New System.Drawing.Point(141, 160)
        Me.bt_mach.Name = "bt_mach"
        Me.bt_mach.Size = New System.Drawing.Size(89, 23)
        Me.bt_mach.TabIndex = 14
        Me.bt_mach.Text = "gérer"
        Me.bt_mach.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Machine + Article :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "affecter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 253)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bt_mach)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bt_quiter)
        Me.Controls.Add(Me.bt_art)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bt_mod_emp)
        Me.Controls.Add(Me.bt_mod_cli)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_commande)
        Me.Controls.Add(Me.bt_tech)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "admin"
        Me.Text = "admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_tech As Button
    Friend WithEvents bt_commande As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bt_mod_cli As Button
    Friend WithEvents bt_mod_emp As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents bt_art As Button
    Friend WithEvents bt_quiter As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents bt_mach As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
