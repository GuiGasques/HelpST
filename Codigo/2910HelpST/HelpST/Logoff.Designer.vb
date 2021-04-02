<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logoff
	Inherits MetroFramework.Forms.MetroForm

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
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btnSair = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(39, 90)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(25, 13)
		Me.Label1.TabIndex = 16
		Me.Label1.Text = "Sair"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(149, 90)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(40, 13)
		Me.Label2.TabIndex = 17
		Me.Label2.Text = "Fechar"
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.White
		Me.Button1.BackgroundImage = Global.HelpST.My.Resources.Resources.img_476656
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button1.Location = New System.Drawing.Point(126, 12)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(84, 75)
		Me.Button1.TabIndex = 15
		Me.Button1.UseVisualStyleBackColor = False
		'
		'btnSair
		'
		Me.btnSair.BackColor = System.Drawing.Color.White
		Me.btnSair.BackgroundImage = Global.HelpST.My.Resources.Resources.exit_93_458494
		Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSair.Location = New System.Drawing.Point(12, 12)
		Me.btnSair.Name = "btnSair"
		Me.btnSair.Size = New System.Drawing.Size(81, 75)
		Me.btnSair.TabIndex = 14
		Me.btnSair.UseVisualStyleBackColor = False
		'
		'Logoff
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(222, 126)
		Me.ControlBox = False
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.btnSair)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Logoff"
		Me.Style = MetroFramework.MetroColorStyle.Purple
		Me.Text = "Logoff"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
