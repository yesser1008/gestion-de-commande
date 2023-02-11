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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_pas = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.annuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "utilisateur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "mot de passe"
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(92, 11)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(126, 20)
        Me.txt_nom.TabIndex = 2
        '
        'txt_pas
        '
        Me.txt_pas.Location = New System.Drawing.Point(92, 51)
        Me.txt_pas.Name = "txt_pas"
        Me.txt_pas.Size = New System.Drawing.Size(126, 20)
        Me.txt_pas.TabIndex = 3
        Me.txt_pas.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(12, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "connecter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'annuler
        '
        Me.annuler.Location = New System.Drawing.Point(94, 85)
        Me.annuler.Name = "annuler"
        Me.annuler.Size = New System.Drawing.Size(75, 23)
        Me.annuler.TabIndex = 5
        Me.annuler.Text = "annuler"
        Me.annuler.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 114)
        Me.Controls.Add(Me.annuler)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_pas)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_pas As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents annuler As Button
End Class
