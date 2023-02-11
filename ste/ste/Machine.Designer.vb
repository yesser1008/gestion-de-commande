<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Machine
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cod_mach = New System.Windows.Forms.TextBox()
        Me.txt_nom_mach = New System.Windows.Forms.TextBox()
        Me.ajouter = New System.Windows.Forms.Button()
        Me.supprimer = New System.Windows.Forms.Button()
        Me.Quiter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code Machine :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom Machine :"
        '
        'txt_cod_mach
        '
        Me.txt_cod_mach.Location = New System.Drawing.Point(120, 35)
        Me.txt_cod_mach.Name = "txt_cod_mach"
        Me.txt_cod_mach.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod_mach.TabIndex = 2
        '
        'txt_nom_mach
        '
        Me.txt_nom_mach.Location = New System.Drawing.Point(325, 35)
        Me.txt_nom_mach.Name = "txt_nom_mach"
        Me.txt_nom_mach.Size = New System.Drawing.Size(100, 20)
        Me.txt_nom_mach.TabIndex = 3
        '
        'ajouter
        '
        Me.ajouter.Location = New System.Drawing.Point(57, 82)
        Me.ajouter.Name = "ajouter"
        Me.ajouter.Size = New System.Drawing.Size(75, 23)
        Me.ajouter.TabIndex = 4
        Me.ajouter.Text = "ajouter"
        Me.ajouter.UseVisualStyleBackColor = True
        '
        'supprimer
        '
        Me.supprimer.Location = New System.Drawing.Point(183, 82)
        Me.supprimer.Name = "supprimer"
        Me.supprimer.Size = New System.Drawing.Size(75, 23)
        Me.supprimer.TabIndex = 5
        Me.supprimer.Text = "supprimer"
        Me.supprimer.UseVisualStyleBackColor = True
        '
        'Quiter
        '
        Me.Quiter.Location = New System.Drawing.Point(312, 82)
        Me.Quiter.Name = "Quiter"
        Me.Quiter.Size = New System.Drawing.Size(75, 23)
        Me.Quiter.TabIndex = 6
        Me.Quiter.Text = "Quiter"
        Me.Quiter.UseVisualStyleBackColor = True
        '
        'Machine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 125)
        Me.Controls.Add(Me.Quiter)
        Me.Controls.Add(Me.supprimer)
        Me.Controls.Add(Me.ajouter)
        Me.Controls.Add(Me.txt_nom_mach)
        Me.Controls.Add(Me.txt_cod_mach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Machine"
        Me.Text = "Machine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cod_mach As TextBox
    Friend WithEvents txt_nom_mach As TextBox
    Friend WithEvents ajouter As Button
    Friend WithEvents supprimer As Button
    Friend WithEvents Quiter As Button
End Class
