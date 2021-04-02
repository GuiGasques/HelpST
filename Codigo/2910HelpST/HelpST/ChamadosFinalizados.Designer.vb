<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChamadosFinalizados
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
		Me.cbPc = New MetroFramework.Controls.MetroComboBox()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.cbSalas = New MetroFramework.Controls.MetroComboBox()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.gridChamadosFinalizados = New MetroFramework.Controls.MetroGrid()
		Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		CType(Me.gridChamadosFinalizados, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.cbCargo)
		Me.GroupBox1.Controls.Add(Me.MetroLabel3)
		Me.GroupBox1.Controls.Add(Me.cbPc)
		Me.GroupBox1.Controls.Add(Me.MetroLabel2)
		Me.GroupBox1.Controls.Add(Me.cbSalas)
		Me.GroupBox1.Controls.Add(Me.MetroLabel1)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.GroupBox1.Location = New System.Drawing.Point(8, 86)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(1023, 57)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Selecione:"
		'
		'cbCargo
		'
		Me.cbCargo.FormattingEnabled = True
		Me.cbCargo.ItemHeight = 23
		Me.cbCargo.Location = New System.Drawing.Point(430, 21)
		Me.cbCargo.Name = "cbCargo"
		Me.cbCargo.Size = New System.Drawing.Size(121, 29)
		Me.cbCargo.TabIndex = 5
		Me.cbCargo.UseSelectable = True
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = True
		Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
		Me.MetroLabel3.Location = New System.Drawing.Point(362, 25)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(62, 25)
		Me.MetroLabel3.TabIndex = 4
		Me.MetroLabel3.Text = "Cargo:"
		'
		'cbPc
		'
		Me.cbPc.FormattingEnabled = True
		Me.cbPc.ItemHeight = 23
		Me.cbPc.Location = New System.Drawing.Point(235, 21)
		Me.cbPc.Name = "cbPc"
		Me.cbPc.Size = New System.Drawing.Size(121, 29)
		Me.cbPc.TabIndex = 3
		Me.cbPc.UseSelectable = True
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
		Me.MetroLabel2.Location = New System.Drawing.Point(186, 25)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(37, 25)
		Me.MetroLabel2.TabIndex = 2
		Me.MetroLabel2.Text = "PC:"
		'
		'cbSalas
		'
		Me.cbSalas.FormattingEnabled = True
		Me.cbSalas.ItemHeight = 23
		Me.cbSalas.Location = New System.Drawing.Point(59, 21)
		Me.cbSalas.Name = "cbSalas"
		Me.cbSalas.Size = New System.Drawing.Size(121, 29)
		Me.cbSalas.TabIndex = 1
		Me.cbSalas.UseSelectable = True
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
		Me.MetroLabel1.Location = New System.Drawing.Point(6, 25)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(47, 25)
		Me.MetroLabel1.TabIndex = 0
		Me.MetroLabel1.Text = "Sala:"
		'
		'gridChamadosFinalizados
		'
		Me.gridChamadosFinalizados.AllowUserToAddRows = False
		Me.gridChamadosFinalizados.AllowUserToDeleteRows = False
		Me.gridChamadosFinalizados.AllowUserToResizeColumns = False
		Me.gridChamadosFinalizados.AllowUserToResizeRows = False
		Me.gridChamadosFinalizados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gridChamadosFinalizados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.gridChamadosFinalizados.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.gridChamadosFinalizados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.gridChamadosFinalizados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.gridChamadosFinalizados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.gridChamadosFinalizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.gridChamadosFinalizados.DefaultCellStyle = DataGridViewCellStyle2
		Me.gridChamadosFinalizados.EnableHeadersVisualStyles = False
		Me.gridChamadosFinalizados.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.gridChamadosFinalizados.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.gridChamadosFinalizados.Location = New System.Drawing.Point(15, 149)
		Me.gridChamadosFinalizados.Name = "gridChamadosFinalizados"
		Me.gridChamadosFinalizados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.gridChamadosFinalizados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.gridChamadosFinalizados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.gridChamadosFinalizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.gridChamadosFinalizados.Size = New System.Drawing.Size(1059, 452)
		Me.gridChamadosFinalizados.TabIndex = 7
		'
		'MetroLink1
		'
		Me.MetroLink1.Image = Global.HelpST.My.Resources.Resources.Voltar
		Me.MetroLink1.ImageSize = 34
		Me.MetroLink1.Location = New System.Drawing.Point(7, 12)
		Me.MetroLink1.Name = "MetroLink1"
		Me.MetroLink1.Size = New System.Drawing.Size(44, 48)
		Me.MetroLink1.TabIndex = 8
		Me.MetroLink1.UseSelectable = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(821, 12)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(116, 31)
		Me.Label3.TabIndex = 14
		Me.Label3.Text = "Usuario:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(931, 12)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(95, 31)
		Me.Label2.TabIndex = 13
		Me.Label2.Text = "Label2"
		'
		'ChamadosFinalizados
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1083, 624)
		Me.ControlBox = False
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.MetroLink1)
		Me.Controls.Add(Me.gridChamadosFinalizados)
		Me.Controls.Add(Me.GroupBox1)
		Me.MaximizeBox = False
		Me.Name = "ChamadosFinalizados"
		Me.Resizable = False
		Me.Style = MetroFramework.MetroColorStyle.Purple
		Me.Text = "    ChamadosFinalizados"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.gridChamadosFinalizados, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents cbCargo As MetroFramework.Controls.MetroComboBox
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents cbPc As MetroFramework.Controls.MetroComboBox
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents cbSalas As MetroFramework.Controls.MetroComboBox
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents gridChamadosFinalizados As MetroFramework.Controls.MetroGrid
	Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
End Class
