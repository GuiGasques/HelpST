<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovoUsuario
	Inherits MetroFramework.Forms.MetroForm

	'Descartar substituições de formulário para limpar a lista de componentes.
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

	'Exigido pelo Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
	'Pode ser modificado usando o Windows Form Designer.  
	'Não o modifique usando o editor de códigos.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NovoUsuario))
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
		Me.txtNome = New MetroFramework.Controls.MetroTextBox()
		Me.txtLogin = New MetroFramework.Controls.MetroTextBox()
		Me.txtSenha = New MetroFramework.Controls.MetroTextBox()
		Me.cbCargo = New MetroFramework.Controls.MetroComboBox()
		Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.gridUser = New MetroFramework.Controls.MetroGrid()
		Me.btnAlterar = New MetroFramework.Controls.MetroButton()
		Me.btnExcluir = New MetroFramework.Controls.MetroButton()
		Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
		Me.btnEnviar = New MetroFramework.Controls.MetroButton()
		Me.GroupBox1.SuspendLayout()
		CType(Me.gridUser, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(1, 122)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(49, 19)
		Me.MetroLabel1.TabIndex = 0
		Me.MetroLabel1.Text = "Nome:"
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.Location = New System.Drawing.Point(1, 179)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(95, 19)
		Me.MetroLabel2.TabIndex = 1
		Me.MetroLabel2.Text = "Cargo Escolar:"
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = True
		Me.MetroLabel3.Location = New System.Drawing.Point(3, 239)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(44, 19)
		Me.MetroLabel3.TabIndex = 2
		Me.MetroLabel3.Text = "Login:"
		'
		'MetroLabel4
		'
		Me.MetroLabel4.AutoSize = True
		Me.MetroLabel4.Location = New System.Drawing.Point(5, 309)
		Me.MetroLabel4.Name = "MetroLabel4"
		Me.MetroLabel4.Size = New System.Drawing.Size(47, 19)
		Me.MetroLabel4.TabIndex = 3
		Me.MetroLabel4.Text = "Senha:"
		'
		'MetroLabel5
		'
		Me.MetroLabel5.AutoSize = True
		Me.MetroLabel5.Location = New System.Drawing.Point(3, 373)
		Me.MetroLabel5.Name = "MetroLabel5"
		Me.MetroLabel5.Size = New System.Drawing.Size(116, 19)
		Me.MetroLabel5.TabIndex = 4
		Me.MetroLabel5.Text = "Data de Matricula:"
		'
		'txtNome
		'
		'
		'
		'
		Me.txtNome.CustomButton.Image = Nothing
		Me.txtNome.CustomButton.Location = New System.Drawing.Point(291, 1)
		Me.txtNome.CustomButton.Name = ""
		Me.txtNome.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtNome.CustomButton.TabIndex = 1
		Me.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtNome.CustomButton.UseSelectable = True
		Me.txtNome.CustomButton.Visible = False
		Me.txtNome.Lines = New String(-1) {}
		Me.txtNome.Location = New System.Drawing.Point(58, 118)
		Me.txtNome.MaxLength = 32767
		Me.txtNome.Name = "txtNome"
		Me.txtNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNome.SelectedText = ""
		Me.txtNome.SelectionLength = 0
		Me.txtNome.SelectionStart = 0
		Me.txtNome.ShortcutsEnabled = True
		Me.txtNome.Size = New System.Drawing.Size(313, 23)
		Me.txtNome.TabIndex = 5
		Me.txtNome.UseSelectable = True
		Me.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtNome.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtLogin
		'
		'
		'
		'
		Me.txtLogin.CustomButton.Image = Nothing
		Me.txtLogin.CustomButton.Location = New System.Drawing.Point(291, 1)
		Me.txtLogin.CustomButton.Name = ""
		Me.txtLogin.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtLogin.CustomButton.TabIndex = 1
		Me.txtLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtLogin.CustomButton.UseSelectable = True
		Me.txtLogin.CustomButton.Visible = False
		Me.txtLogin.Lines = New String(-1) {}
		Me.txtLogin.Location = New System.Drawing.Point(58, 235)
		Me.txtLogin.MaxLength = 32767
		Me.txtLogin.Name = "txtLogin"
		Me.txtLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLogin.SelectedText = ""
		Me.txtLogin.SelectionLength = 0
		Me.txtLogin.SelectionStart = 0
		Me.txtLogin.ShortcutsEnabled = True
		Me.txtLogin.Size = New System.Drawing.Size(313, 23)
		Me.txtLogin.TabIndex = 6
		Me.txtLogin.UseSelectable = True
		Me.txtLogin.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtLogin.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtSenha
		'
		'
		'
		'
		Me.txtSenha.CustomButton.Image = Nothing
		Me.txtSenha.CustomButton.Location = New System.Drawing.Point(291, 1)
		Me.txtSenha.CustomButton.Name = ""
		Me.txtSenha.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtSenha.CustomButton.TabIndex = 1
		Me.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtSenha.CustomButton.UseSelectable = True
		Me.txtSenha.CustomButton.Visible = False
		Me.txtSenha.Lines = New String(-1) {}
		Me.txtSenha.Location = New System.Drawing.Point(58, 305)
		Me.txtSenha.MaxLength = 32767
		Me.txtSenha.Name = "txtSenha"
		Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSenha.SelectedText = ""
		Me.txtSenha.SelectionLength = 0
		Me.txtSenha.SelectionStart = 0
		Me.txtSenha.ShortcutsEnabled = True
		Me.txtSenha.Size = New System.Drawing.Size(313, 23)
		Me.txtSenha.TabIndex = 7
		Me.txtSenha.UseSelectable = True
		Me.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtSenha.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'cbCargo
		'
		Me.cbCargo.FormattingEnabled = True
		Me.cbCargo.ItemHeight = 23
		Me.cbCargo.Location = New System.Drawing.Point(102, 169)
		Me.cbCargo.Name = "cbCargo"
		Me.cbCargo.Size = New System.Drawing.Size(137, 29)
		Me.cbCargo.TabIndex = 8
		Me.cbCargo.UseSelectable = True
		'
		'MetroDateTime1
		'
		Me.MetroDateTime1.Location = New System.Drawing.Point(125, 363)
		Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
		Me.MetroDateTime1.Name = "MetroDateTime1"
		Me.MetroDateTime1.Size = New System.Drawing.Size(266, 29)
		Me.MetroDateTime1.TabIndex = 10
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.gridUser)
		Me.GroupBox1.Controls.Add(Me.btnAlterar)
		Me.GroupBox1.Controls.Add(Me.btnExcluir)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.GroupBox1.Location = New System.Drawing.Point(397, 103)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(775, 418)
		Me.GroupBox1.TabIndex = 11
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Altere Aqui"
		'
		'gridUser
		'
		Me.gridUser.AllowUserToAddRows = False
		Me.gridUser.AllowUserToDeleteRows = False
		Me.gridUser.AllowUserToResizeColumns = False
		Me.gridUser.AllowUserToResizeRows = False
		Me.gridUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.gridUser.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.gridUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.gridUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.gridUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.gridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.gridUser.DefaultCellStyle = DataGridViewCellStyle2
		Me.gridUser.EnableHeadersVisualStyles = False
		Me.gridUser.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.gridUser.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.gridUser.Location = New System.Drawing.Point(6, 19)
		Me.gridUser.Name = "gridUser"
		Me.gridUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.gridUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.gridUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.gridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.gridUser.Size = New System.Drawing.Size(755, 347)
		Me.gridUser.TabIndex = 3
		'
		'btnAlterar
		'
		Me.btnAlterar.Location = New System.Drawing.Point(32, 372)
		Me.btnAlterar.Name = "btnAlterar"
		Me.btnAlterar.Size = New System.Drawing.Size(326, 40)
		Me.btnAlterar.TabIndex = 2
		Me.btnAlterar.Text = "Alterar"
		Me.btnAlterar.UseSelectable = True
		'
		'btnExcluir
		'
		Me.btnExcluir.Location = New System.Drawing.Point(415, 373)
		Me.btnExcluir.Name = "btnExcluir"
		Me.btnExcluir.Size = New System.Drawing.Size(325, 39)
		Me.btnExcluir.TabIndex = 1
		Me.btnExcluir.Text = "Excluir"
		Me.btnExcluir.UseSelectable = True
		'
		'MetroLabel6
		'
		Me.MetroLabel6.AutoSize = True
		Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
		Me.MetroLabel6.Location = New System.Drawing.Point(768, 12)
		Me.MetroLabel6.Name = "MetroLabel6"
		Me.MetroLabel6.Size = New System.Drawing.Size(106, 25)
		Me.MetroLabel6.TabIndex = 13
		Me.MetroLabel6.Text = "MetroLabel6"
		'
		'MetroLink1
		'
		Me.MetroLink1.Image = Global.HelpST.My.Resources.Resources.Voltar
		Me.MetroLink1.ImageSize = 34
		Me.MetroLink1.Location = New System.Drawing.Point(1, 12)
		Me.MetroLink1.Name = "MetroLink1"
		Me.MetroLink1.Size = New System.Drawing.Size(51, 55)
		Me.MetroLink1.TabIndex = 15
		Me.MetroLink1.UseSelectable = True
		'
		'btnEnviar
		'
		Me.btnEnviar.Location = New System.Drawing.Point(23, 470)
		Me.btnEnviar.Name = "btnEnviar"
		Me.btnEnviar.Size = New System.Drawing.Size(348, 45)
		Me.btnEnviar.TabIndex = 18
		Me.btnEnviar.Text = "Enviar"
		Me.btnEnviar.UseSelectable = True
		'
		'NovoUsuario
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1181, 544)
		Me.ControlBox = False
		Me.Controls.Add(Me.btnEnviar)
		Me.Controls.Add(Me.MetroLink1)
		Me.Controls.Add(Me.MetroLabel6)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.MetroDateTime1)
		Me.Controls.Add(Me.cbCargo)
		Me.Controls.Add(Me.txtSenha)
		Me.Controls.Add(Me.txtLogin)
		Me.Controls.Add(Me.txtNome)
		Me.Controls.Add(Me.MetroLabel5)
		Me.Controls.Add(Me.MetroLabel4)
		Me.Controls.Add(Me.MetroLabel3)
		Me.Controls.Add(Me.MetroLabel2)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "NovoUsuario"
		Me.Resizable = False
		Me.Style = MetroFramework.MetroColorStyle.Purple
		Me.Text = "     NovoUsuario"
		Me.Theme = MetroFramework.MetroThemeStyle.[Default]
		Me.GroupBox1.ResumeLayout(False)
		CType(Me.gridUser, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtNome As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtLogin As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtSenha As MetroFramework.Controls.MetroTextBox
	Friend WithEvents cbCargo As MetroFramework.Controls.MetroComboBox
	Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents gridUser As MetroFramework.Controls.MetroGrid
	Friend WithEvents btnAlterar As MetroFramework.Controls.MetroButton
	Friend WithEvents btnExcluir As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
	Friend WithEvents btnEnviar As MetroFramework.Controls.MetroButton
End Class
