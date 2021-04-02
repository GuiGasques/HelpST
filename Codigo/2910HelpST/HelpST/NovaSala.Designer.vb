<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NovaSala
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NovaSala))
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
		Me.txtNomeAmbiente = New MetroFramework.Controls.MetroTextBox()
		Me.btnEnviar = New MetroFramework.Controls.MetroButton()
		Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
		Me.cbComponentes = New MetroFramework.Controls.MetroComboBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.gridSalas = New MetroFramework.Controls.MetroGrid()
		Me.btnAlterar = New MetroFramework.Controls.MetroButton()
		Me.btnExcluir = New MetroFramework.Controls.MetroButton()
		Me.GroupBox1.SuspendLayout()
		CType(Me.gridSalas, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(12, 87)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(96, 19)
		Me.MetroLabel1.TabIndex = 0
		Me.MetroLabel1.Text = "Nome da Sala:"
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.Location = New System.Drawing.Point(12, 146)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(94, 19)
		Me.MetroLabel2.TabIndex = 1
		Me.MetroLabel2.Text = "Componentes:"
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = True
		Me.MetroLabel3.Location = New System.Drawing.Point(12, 202)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(107, 19)
		Me.MetroLabel3.TabIndex = 2
		Me.MetroLabel3.Text = "Data de Criaçao:"
		'
		'MetroDateTime1
		'
		Me.MetroDateTime1.Location = New System.Drawing.Point(125, 192)
		Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
		Me.MetroDateTime1.Name = "MetroDateTime1"
		Me.MetroDateTime1.Size = New System.Drawing.Size(260, 29)
		Me.MetroDateTime1.TabIndex = 3
		'
		'txtNomeAmbiente
		'
		'
		'
		'
		Me.txtNomeAmbiente.CustomButton.Image = Nothing
		Me.txtNomeAmbiente.CustomButton.Location = New System.Drawing.Point(172, 1)
		Me.txtNomeAmbiente.CustomButton.Name = ""
		Me.txtNomeAmbiente.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtNomeAmbiente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtNomeAmbiente.CustomButton.TabIndex = 1
		Me.txtNomeAmbiente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtNomeAmbiente.CustomButton.UseSelectable = True
		Me.txtNomeAmbiente.CustomButton.Visible = False
		Me.txtNomeAmbiente.Lines = New String(-1) {}
		Me.txtNomeAmbiente.Location = New System.Drawing.Point(114, 83)
		Me.txtNomeAmbiente.MaxLength = 32767
		Me.txtNomeAmbiente.Name = "txtNomeAmbiente"
		Me.txtNomeAmbiente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtNomeAmbiente.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNomeAmbiente.SelectedText = ""
		Me.txtNomeAmbiente.SelectionLength = 0
		Me.txtNomeAmbiente.SelectionStart = 0
		Me.txtNomeAmbiente.ShortcutsEnabled = True
		Me.txtNomeAmbiente.Size = New System.Drawing.Size(194, 23)
		Me.txtNomeAmbiente.TabIndex = 6
		Me.txtNomeAmbiente.UseSelectable = True
		Me.txtNomeAmbiente.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtNomeAmbiente.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'btnEnviar
		'
		Me.btnEnviar.Location = New System.Drawing.Point(12, 248)
		Me.btnEnviar.Name = "btnEnviar"
		Me.btnEnviar.Size = New System.Drawing.Size(373, 43)
		Me.btnEnviar.TabIndex = 7
		Me.btnEnviar.Text = "Enviar"
		Me.btnEnviar.UseSelectable = True
		'
		'MetroLabel4
		'
		Me.MetroLabel4.AutoSize = True
		Me.MetroLabel4.Location = New System.Drawing.Point(684, 20)
		Me.MetroLabel4.Name = "MetroLabel4"
		Me.MetroLabel4.Size = New System.Drawing.Size(13, 19)
		Me.MetroLabel4.TabIndex = 9
		Me.MetroLabel4.Text = " "
		'
		'MetroLink1
		'
		Me.MetroLink1.Image = Global.HelpST.My.Resources.Resources.Voltar
		Me.MetroLink1.ImageSize = 34
		Me.MetroLink1.Location = New System.Drawing.Point(2, 20)
		Me.MetroLink1.Name = "MetroLink1"
		Me.MetroLink1.Size = New System.Drawing.Size(50, 41)
		Me.MetroLink1.TabIndex = 16
		Me.MetroLink1.UseSelectable = True
		'
		'cbComponentes
		'
		Me.cbComponentes.FormattingEnabled = True
		Me.cbComponentes.ItemHeight = 23
		Me.cbComponentes.Location = New System.Drawing.Point(113, 143)
		Me.cbComponentes.Name = "cbComponentes"
		Me.cbComponentes.Size = New System.Drawing.Size(121, 29)
		Me.cbComponentes.TabIndex = 17
		Me.cbComponentes.UseSelectable = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.gridSalas)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(391, 64)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(497, 354)
		Me.GroupBox1.TabIndex = 18
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Salas:"
		'
		'gridSalas
		'
		Me.gridSalas.AllowUserToResizeRows = False
		Me.gridSalas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.gridSalas.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.gridSalas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.gridSalas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.gridSalas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.gridSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.gridSalas.DefaultCellStyle = DataGridViewCellStyle2
		Me.gridSalas.EnableHeadersVisualStyles = False
		Me.gridSalas.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.gridSalas.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.gridSalas.Location = New System.Drawing.Point(7, 19)
		Me.gridSalas.Name = "gridSalas"
		Me.gridSalas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.gridSalas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.gridSalas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.gridSalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.gridSalas.Size = New System.Drawing.Size(484, 329)
		Me.gridSalas.TabIndex = 0
		'
		'btnAlterar
		'
		Me.btnAlterar.Location = New System.Drawing.Point(12, 315)
		Me.btnAlterar.Name = "btnAlterar"
		Me.btnAlterar.Size = New System.Drawing.Size(373, 43)
		Me.btnAlterar.TabIndex = 19
		Me.btnAlterar.Text = "Alterar"
		Me.btnAlterar.UseSelectable = True
		'
		'btnExcluir
		'
		Me.btnExcluir.Location = New System.Drawing.Point(12, 375)
		Me.btnExcluir.Name = "btnExcluir"
		Me.btnExcluir.Size = New System.Drawing.Size(373, 43)
		Me.btnExcluir.TabIndex = 20
		Me.btnExcluir.Text = "Excluir"
		Me.btnExcluir.UseSelectable = True
		'
		'NovaSala
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(896, 441)
		Me.ControlBox = False
		Me.Controls.Add(Me.btnExcluir)
		Me.Controls.Add(Me.btnAlterar)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.cbComponentes)
		Me.Controls.Add(Me.MetroLink1)
		Me.Controls.Add(Me.MetroLabel4)
		Me.Controls.Add(Me.btnEnviar)
		Me.Controls.Add(Me.txtNomeAmbiente)
		Me.Controls.Add(Me.MetroDateTime1)
		Me.Controls.Add(Me.MetroLabel3)
		Me.Controls.Add(Me.MetroLabel2)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "NovaSala"
		Me.Resizable = False
		Me.Style = MetroFramework.MetroColorStyle.Purple
		Me.Text = "    NovaSala"
		Me.Theme = MetroFramework.MetroThemeStyle.[Default]
		Me.GroupBox1.ResumeLayout(False)
		CType(Me.gridSalas, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
	Friend WithEvents txtNomeAmbiente As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnEnviar As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
	Friend WithEvents cbComponentes As MetroFramework.Controls.MetroComboBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents gridSalas As MetroFramework.Controls.MetroGrid
	Friend WithEvents btnAlterar As MetroFramework.Controls.MetroButton
	Friend WithEvents btnExcluir As MetroFramework.Controls.MetroButton
End Class
