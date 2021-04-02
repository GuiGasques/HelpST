<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NovoChamado
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NovoChamado))
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.txtTitulo = New MetroFramework.Controls.MetroTextBox()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.cbSalas = New MetroFramework.Controls.MetroComboBox()
		Me.cbPc = New MetroFramework.Controls.MetroComboBox()
		Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
		Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtDescriçao = New System.Windows.Forms.RichTextBox()
		Me.btnInserir = New MetroFramework.Controls.MetroButton()
		Me.btnEnviar = New System.Windows.Forms.Button()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
		Me.GroupBox1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(13, 111)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(44, 19)
		Me.MetroLabel1.TabIndex = 0
		Me.MetroLabel1.Text = "Titulo:"
		'
		'txtTitulo
		'
		'
		'
		'
		Me.txtTitulo.CustomButton.Image = Nothing
		Me.txtTitulo.CustomButton.Location = New System.Drawing.Point(182, 1)
		Me.txtTitulo.CustomButton.Name = ""
		Me.txtTitulo.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTitulo.CustomButton.TabIndex = 1
		Me.txtTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTitulo.CustomButton.UseSelectable = True
		Me.txtTitulo.CustomButton.Visible = False
		Me.txtTitulo.Lines = New String(-1) {}
		Me.txtTitulo.Location = New System.Drawing.Point(55, 107)
		Me.txtTitulo.MaxLength = 32767
		Me.txtTitulo.Name = "txtTitulo"
		Me.txtTitulo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTitulo.SelectedText = ""
		Me.txtTitulo.SelectionLength = 0
		Me.txtTitulo.SelectionStart = 0
		Me.txtTitulo.ShortcutsEnabled = True
		Me.txtTitulo.Size = New System.Drawing.Size(204, 23)
		Me.txtTitulo.TabIndex = 1
		Me.txtTitulo.UseSelectable = True
		Me.txtTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTitulo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.Location = New System.Drawing.Point(13, 158)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(36, 19)
		Me.MetroLabel2.TabIndex = 2
		Me.MetroLabel2.Text = "Sala:"
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = True
		Me.MetroLabel3.Location = New System.Drawing.Point(184, 158)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(89, 19)
		Me.MetroLabel3.TabIndex = 3
		Me.MetroLabel3.Text = "Computador:"
		'
		'cbSalas
		'
		Me.cbSalas.FormattingEnabled = True
		Me.cbSalas.ItemHeight = 23
		Me.cbSalas.Location = New System.Drawing.Point(55, 148)
		Me.cbSalas.Name = "cbSalas"
		Me.cbSalas.Size = New System.Drawing.Size(121, 29)
		Me.cbSalas.TabIndex = 4
		Me.cbSalas.UseSelectable = True
		'
		'cbPc
		'
		Me.cbPc.FormattingEnabled = True
		Me.cbPc.ItemHeight = 23
		Me.cbPc.Location = New System.Drawing.Point(279, 148)
		Me.cbPc.Name = "cbPc"
		Me.cbPc.Size = New System.Drawing.Size(121, 29)
		Me.cbPc.TabIndex = 5
		Me.cbPc.UseSelectable = True
		'
		'MetroLabel4
		'
		Me.MetroLabel4.AutoSize = True
		Me.MetroLabel4.Location = New System.Drawing.Point(279, 107)
		Me.MetroLabel4.Name = "MetroLabel4"
		Me.MetroLabel4.Size = New System.Drawing.Size(39, 19)
		Me.MetroLabel4.TabIndex = 6
		Me.MetroLabel4.Text = "Data:"
		'
		'MetroDateTime1
		'
		Me.MetroDateTime1.Location = New System.Drawing.Point(324, 101)
		Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
		Me.MetroDateTime1.Name = "MetroDateTime1"
		Me.MetroDateTime1.Size = New System.Drawing.Size(277, 29)
		Me.MetroDateTime1.TabIndex = 7
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtDescriçao)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.GroupBox1.Location = New System.Drawing.Point(3, 202)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(641, 364)
		Me.GroupBox1.TabIndex = 8
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Descriçao"
		'
		'txtDescriçao
		'
		Me.txtDescriçao.Location = New System.Drawing.Point(6, 19)
		Me.txtDescriçao.Name = "txtDescriçao"
		Me.txtDescriçao.Size = New System.Drawing.Size(629, 323)
		Me.txtDescriçao.TabIndex = 0
		Me.txtDescriçao.Text = ""
		'
		'btnInserir
		'
		Me.btnInserir.Location = New System.Drawing.Point(660, 510)
		Me.btnInserir.Name = "btnInserir"
		Me.btnInserir.Size = New System.Drawing.Size(319, 56)
		Me.btnInserir.TabIndex = 10
		Me.btnInserir.Text = "Inserir Imagem"
		Me.btnInserir.UseSelectable = True
		'
		'btnEnviar
		'
		Me.btnEnviar.Location = New System.Drawing.Point(660, 148)
		Me.btnEnviar.Name = "btnEnviar"
		Me.btnEnviar.Size = New System.Drawing.Size(319, 62)
		Me.btnEnviar.TabIndex = 11
		Me.btnEnviar.Text = "Enviar"
		Me.btnEnviar.UseVisualStyleBackColor = True
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'MetroLink1
		'
		Me.MetroLink1.Image = Global.HelpST.My.Resources.Resources.Voltar
		Me.MetroLink1.ImageSize = 34
		Me.MetroLink1.Location = New System.Drawing.Point(3, 11)
		Me.MetroLink1.Name = "MetroLink1"
		Me.MetroLink1.Size = New System.Drawing.Size(50, 52)
		Me.MetroLink1.TabIndex = 14
		Me.MetroLink1.Theme = MetroFramework.MetroThemeStyle.Light
		Me.MetroLink1.UseSelectable = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Location = New System.Drawing.Point(660, 228)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(319, 276)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.PictureBox1.TabIndex = 9
		Me.PictureBox1.TabStop = False
		'
		'MetroLabel5
		'
		Me.MetroLabel5.AutoSize = True
		Me.MetroLabel5.Location = New System.Drawing.Point(754, 11)
		Me.MetroLabel5.Name = "MetroLabel5"
		Me.MetroLabel5.Size = New System.Drawing.Size(83, 19)
		Me.MetroLabel5.TabIndex = 13
		Me.MetroLabel5.Text = "MetroLabel5"
		'
		'NovoChamado
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1046, 572)
		Me.ControlBox = False
		Me.Controls.Add(Me.MetroLink1)
		Me.Controls.Add(Me.MetroLabel5)
		Me.Controls.Add(Me.btnEnviar)
		Me.Controls.Add(Me.btnInserir)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.MetroDateTime1)
		Me.Controls.Add(Me.MetroLabel4)
		Me.Controls.Add(Me.cbPc)
		Me.Controls.Add(Me.cbSalas)
		Me.Controls.Add(Me.MetroLabel3)
		Me.Controls.Add(Me.MetroLabel2)
		Me.Controls.Add(Me.txtTitulo)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "NovoChamado"
		Me.Resizable = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Style = MetroFramework.MetroColorStyle.Purple
		Me.Text = "    Novo Chamado"
		Me.Theme = MetroFramework.MetroThemeStyle.[Default]
		Me.GroupBox1.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTitulo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbSalas As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbPc As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDescriçao As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnInserir As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEnviar As Button
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
End Class
