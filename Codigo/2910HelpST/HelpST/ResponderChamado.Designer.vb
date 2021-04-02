<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResponderChamado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResponderChamado))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtResposta = New System.Windows.Forms.RichTextBox()
        Me.btnEnviar = New MetroFramework.Controls.MetroButton()
        Me.cbNiveis = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtResposta)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 339)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Responder"
        '
        'txtResposta
        '
        Me.txtResposta.Location = New System.Drawing.Point(11, 20)
        Me.txtResposta.Name = "txtResposta"
        Me.txtResposta.Size = New System.Drawing.Size(620, 309)
        Me.txtResposta.TabIndex = 0
        Me.txtResposta.Text = ""
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(23, 420)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(621, 57)
        Me.btnEnviar.TabIndex = 1
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseSelectable = True
        '
        'cbNiveis
        '
        Me.cbNiveis.FormattingEnabled = True
        Me.cbNiveis.ItemHeight = 23
        Me.cbNiveis.Location = New System.Drawing.Point(486, 36)
        Me.cbNiveis.Name = "cbNiveis"
        Me.cbNiveis.Size = New System.Drawing.Size(158, 29)
        Me.cbNiveis.TabIndex = 2
        Me.cbNiveis.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(328, 40)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(158, 25)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Nivel do Chamado:"
        '
        'ResponderChamado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 500)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cbNiveis)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ResponderChamado"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "ResponderChamado"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents btnEnviar As MetroFramework.Controls.MetroButton
	Friend WithEvents txtResposta As RichTextBox
	Friend WithEvents cbNiveis As MetroFramework.Controls.MetroComboBox
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
