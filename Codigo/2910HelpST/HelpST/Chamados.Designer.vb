<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chamados
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.cbCargo = New MetroFramework.Controls.MetroComboBox()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.cbPc = New MetroFramework.Controls.MetroComboBox()
		Me.cbSalas = New MetroFramework.Controls.MetroComboBox()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.gridChamados = New MetroFramework.Controls.MetroGrid()
		Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		CType(Me.gridChamados, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.cbCargo)
		Me.GroupBox1.Controls.Add(Me.MetroLabel3)
		Me.GroupBox1.Controls.Add(Me.MetroLabel2)
		Me.GroupBox1.Controls.Add(Me.cbPc)
		Me.GroupBox1.Controls.Add(Me.cbSalas)
		Me.GroupBox1.Controls.Add(Me.MetroLabel1)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.GroupBox1.Location = New System.Drawing.Point(4, 92)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(1140, 57)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Selecione:"
		'
		'cbCargo
		'
		Me.cbCargo.FormattingEnabled = True
		Me.cbCargo.ItemHeight = 23
		Me.cbCargo.Location = New System.Drawing.Point(422, 21)
		Me.cbCargo.Name = "cbCargo"
		Me.cbCargo.Size = New System.Drawing.Size(121, 29)
		Me.cbCargo.TabIndex = 5
		Me.cbCargo.Theme = MetroFramework.MetroThemeStyle.Light
		Me.cbCargo.UseSelectable = True
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = True
		Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
		Me.MetroLabel3.Location = New System.Drawing.Point(347, 25)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(69, 25)
		Me.MetroLabel3.TabIndex = 4
		Me.MetroLabel3.Text = "Cargos:"
		Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Light
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
		Me.MetroLabel2.Location = New System.Drawing.Point(176, 26)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(37, 25)
		Me.MetroLabel2.TabIndex = 2
		Me.MetroLabel2.Text = "PC:"
		Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Light
		'
		'cbPc
		'
		Me.cbPc.FormattingEnabled = True
		Me.cbPc.ItemHeight = 23
		Me.cbPc.Location = New System.Drawing.Point(219, 21)
		Me.cbPc.Name = "cbPc"
		Me.cbPc.Size = New System.Drawing.Size(119, 29)
		Me.cbPc.TabIndex = 3
		Me.cbPc.Theme = MetroFramework.MetroThemeStyle.Light
		Me.cbPc.UseSelectable = True
		'
		'cbSalas
		'
		Me.cbSalas.FormattingEnabled = True
		Me.cbSalas.ItemHeight = 23
		Me.cbSalas.Location = New System.Drawing.Point(49, 22)
		Me.cbSalas.Name = "cbSalas"
		Me.cbSalas.Size = New System.Drawing.Size(121, 29)
		Me.cbSalas.TabIndex = 1
		Me.cbSalas.Theme = MetroFramework.MetroThemeStyle.Light
		Me.cbSalas.UseSelectable = True
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
		Me.MetroLabel1.Location = New System.Drawing.Point(1, 26)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(47, 25)
		Me.MetroLabel1.TabIndex = 0
		Me.MetroLabel1.Text = "Sala:"
		Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Light
		'
		'gridChamados
		'
		Me.gridChamados.AllowUserToAddRows = False
		Me.gridChamados.AllowUserToDeleteRows = False
		Me.gridChamados.AllowUserToOrderColumns = True
		Me.gridChamados.AllowUserToResizeColumns = False
		Me.gridChamados.AllowUserToResizeRows = False
		Me.gridChamados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gridChamados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.gridChamados.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.gridChamados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.gridChamados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.gridChamados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.gridChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.gridChamados.DefaultCellStyle = DataGridViewCellStyle2
		Me.gridChamados.EnableHeadersVisualStyles = False
		Me.gridChamados.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.gridChamados.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.gridChamados.Location = New System.Drawing.Point(4, 155)
		Me.gridChamados.Name = "gridChamados"
		Me.gridChamados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.gridChamados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.gridChamados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.gridChamados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.gridChamados.Size = New System.Drawing.Size(1172, 446)
		Me.gridChamados.TabIndex = 1
		Me.gridChamados.Theme = MetroFramework.MetroThemeStyle.Light
		'
		'MetroLink1
		'
		Me.MetroLink1.Image = Global.HelpST.My.Resources.Resources.Voltar
		Me.MetroLink1.ImageSize = 34
		Me.MetroLink1.Location = New System.Drawing.Point(4, 18)
		Me.MetroLink1.Name = "MetroLink1"
		Me.MetroLink1.Size = New System.Drawing.Size(61, 43)
		Me.MetroLink1.TabIndex = 5
		Me.MetroLink1.Theme = MetroFramework.MetroThemeStyle.Light
		Me.MetroLink1.UseSelectable = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(882, 18)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(0, 13)
		Me.Label2.TabIndex = 8
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(831, 18)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(116, 31)
		Me.Label3.TabIndex = 14
		Me.Label3.Text = "Usuario:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(941, 18)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(95, 31)
		Me.Label4.TabIndex = 13
		Me.Label4.Text = "Label4"
		'
		'Chamados
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1182, 624)
		Me.ControlBox = False
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.MetroLink1)
		Me.Controls.Add(Me.gridChamados)
		Me.Controls.Add(Me.GroupBox1)
		Me.MaximizeBox = False
		Me.Name = "Chamados"
		Me.Resizable = False
		Me.Style = MetroFramework.MetroColorStyle.Purple
		Me.Text = "      Chamados"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.gridChamados, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gridChamados As MetroFramework.Controls.MetroGrid
    Friend WithEvents cbCargo As MetroFramework.Controls.MetroComboBox
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents cbPc As MetroFramework.Controls.MetroComboBox
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents cbSalas As MetroFramework.Controls.MetroComboBox
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
End Class
