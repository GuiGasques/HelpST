<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TelaLogin
	Inherits MetroFramework.Forms.MetroForm

	'Descartar substituições de formulário para limpar a lista de componentes.
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

	'Exigido pelo Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
	'Pode ser modificado usando o Windows Form Designer.  
	'Não o modifique usando o editor de códigos.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaLogin))
        Me.txtLogin = New MetroFramework.Controls.MetroTextBox()
        Me.txtSenha = New MetroFramework.Controls.MetroTextBox()
        Me.btnEntrar = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLogin
        '
        Me.txtLogin.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtLogin.CustomButton.Image = Nothing
        Me.txtLogin.CustomButton.Location = New System.Drawing.Point(458, 1)
        Me.txtLogin.CustomButton.Name = ""
        Me.txtLogin.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLogin.CustomButton.TabIndex = 1
        Me.txtLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLogin.CustomButton.UseSelectable = True
        Me.txtLogin.CustomButton.Visible = False
        Me.txtLogin.ForeColor = System.Drawing.Color.Black
        Me.txtLogin.Lines = New String() {"LOGIN"}
        Me.txtLogin.Location = New System.Drawing.Point(277, 82)
        Me.txtLogin.MaxLength = 32767
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLogin.SelectedText = ""
        Me.txtLogin.SelectionLength = 0
        Me.txtLogin.SelectionStart = 0
        Me.txtLogin.ShortcutsEnabled = True
        Me.txtLogin.Size = New System.Drawing.Size(480, 23)
        Me.txtLogin.TabIndex = 2
        Me.txtLogin.Text = "LOGIN"
        Me.txtLogin.UseCustomBackColor = True
        Me.txtLogin.UseCustomForeColor = True
        Me.txtLogin.UseSelectable = True
        Me.txtLogin.WaterMarkColor = System.Drawing.Color.Black
        Me.txtLogin.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSenha.CustomButton.Image = Nothing
        Me.txtSenha.CustomButton.Location = New System.Drawing.Point(458, 1)
        Me.txtSenha.CustomButton.Name = ""
        Me.txtSenha.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSenha.CustomButton.TabIndex = 1
        Me.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSenha.CustomButton.UseSelectable = True
        Me.txtSenha.CustomButton.Visible = False
        Me.txtSenha.ForeColor = System.Drawing.Color.Black
        Me.txtSenha.Lines = New String() {"SENHA"}
        Me.txtSenha.Location = New System.Drawing.Point(277, 140)
        Me.txtSenha.MaxLength = 32767
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSenha.SelectedText = ""
        Me.txtSenha.SelectionLength = 0
        Me.txtSenha.SelectionStart = 0
        Me.txtSenha.ShortcutsEnabled = True
        Me.txtSenha.Size = New System.Drawing.Size(480, 23)
        Me.txtSenha.TabIndex = 3
        Me.txtSenha.Text = "SENHA"
        Me.txtSenha.UseCustomBackColor = True
        Me.txtSenha.UseCustomForeColor = True
        Me.txtSenha.UseSelectable = True
        Me.txtSenha.WaterMarkColor = System.Drawing.Color.Black
        Me.txtSenha.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnEntrar
        '
        Me.btnEntrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEntrar.Location = New System.Drawing.Point(277, 201)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(480, 40)
        Me.btnEntrar.TabIndex = 4
        Me.btnEntrar.Text = "ENTRAR"
        Me.btnEntrar.UseCustomBackColor = True
        Me.btnEntrar.UseCustomForeColor = True
        Me.btnEntrar.UseSelectable = True
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Location = New System.Drawing.Point(277, 267)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(480, 40)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseCustomBackColor = True
        Me.btnCancelar.UseCustomForeColor = True
        Me.btnCancelar.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(461, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ENTRAR"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.Purple
        Me.MetroPanel1.BackgroundImage = Global.HelpST.My.Resources.Resources.logo4
        Me.MetroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MetroPanel1.Controls.Add(Me.Label2)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(-4, -3)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(250, 335)
        Me.MetroPanel1.TabIndex = 6
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(4, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 73)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "HelpST"
        '
        'TelaLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 330)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TelaLogin"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "                                     "
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents txtLogin As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtSenha As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnEntrar As MetroFramework.Controls.MetroButton
	Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
End Class
