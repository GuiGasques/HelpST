<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUser))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnNovoChamado = New MetroFramework.Controls.MetroTile()
        Me.btnMeusChamados = New MetroFramework.Controls.MetroTile()
        Me.btnChamadosResolvidos = New MetroFramework.Controls.MetroTile()
        Me.btnChamadosExcluidos = New MetroFramework.Controls.MetroTile()
        Me.btnChamados = New MetroFramework.Controls.MetroTile()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 31)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(420, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 31)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Label2"
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.White
        Me.btnSair.BackgroundImage = Global.HelpST.My.Resources.Resources.exit_93_458494
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSair.Location = New System.Drawing.Point(654, 10)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(63, 61)
        Me.btnSair.TabIndex = 15
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BackColor = System.Drawing.Color.Purple
        Me.MetroPanel2.BackgroundImage = Global.HelpST.My.Resources.Resources.logoPequeno1
        Me.MetroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroPanel2.Controls.Add(Me.Label1)
        Me.MetroPanel2.Controls.Add(Me.MetroPanel1)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(9, 10)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(286, 107)
        Me.MetroPanel2.TabIndex = 9
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(79, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 42)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "HelpST"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(292, 0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(675, 103)
        Me.MetroPanel1.TabIndex = 7
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btnNovoChamado
        '
        Me.btnNovoChamado.ActiveControl = Nothing
        Me.btnNovoChamado.BackColor = System.Drawing.Color.Purple
        Me.btnNovoChamado.Location = New System.Drawing.Point(301, 123)
        Me.btnNovoChamado.Name = "btnNovoChamado"
        Me.btnNovoChamado.Size = New System.Drawing.Size(246, 131)
        Me.btnNovoChamado.TabIndex = 4
        Me.btnNovoChamado.Text = "Novo Chamado"
        Me.btnNovoChamado.TileImage = Global.HelpST.My.Resources.Resources.sendEmailB___Copia
        Me.btnNovoChamado.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNovoChamado.UseCustomBackColor = True
        Me.btnNovoChamado.UseSelectable = True
        Me.btnNovoChamado.UseTileImage = True
        '
        'btnMeusChamados
        '
        Me.btnMeusChamados.ActiveControl = Nothing
        Me.btnMeusChamados.BackColor = System.Drawing.Color.Purple
        Me.btnMeusChamados.Location = New System.Drawing.Point(9, 260)
        Me.btnMeusChamados.Name = "btnMeusChamados"
        Me.btnMeusChamados.Size = New System.Drawing.Size(538, 96)
        Me.btnMeusChamados.TabIndex = 3
        Me.btnMeusChamados.Text = "Meus Chamados"
        Me.btnMeusChamados.TileImage = Global.HelpST.My.Resources.Resources.MyemailB___Copia
        Me.btnMeusChamados.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnMeusChamados.UseCustomBackColor = True
        Me.btnMeusChamados.UseSelectable = True
        Me.btnMeusChamados.UseTileImage = True
        '
        'btnChamadosResolvidos
        '
        Me.btnChamadosResolvidos.ActiveControl = Nothing
        Me.btnChamadosResolvidos.BackColor = System.Drawing.Color.Purple
        Me.btnChamadosResolvidos.Location = New System.Drawing.Point(553, 123)
        Me.btnChamadosResolvidos.Name = "btnChamadosResolvidos"
        Me.btnChamadosResolvidos.Size = New System.Drawing.Size(151, 353)
        Me.btnChamadosResolvidos.TabIndex = 2
        Me.btnChamadosResolvidos.Text = "Chamados Finalizados"
        Me.btnChamadosResolvidos.TileImage = Global.HelpST.My.Resources.Resources.checkListBr___Copia
        Me.btnChamadosResolvidos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChamadosResolvidos.UseCustomBackColor = True
        Me.btnChamadosResolvidos.UseSelectable = True
        Me.btnChamadosResolvidos.UseTileImage = True
        '
        'btnChamadosExcluidos
        '
        Me.btnChamadosExcluidos.ActiveControl = Nothing
        Me.btnChamadosExcluidos.BackColor = System.Drawing.Color.Purple
        Me.btnChamadosExcluidos.Location = New System.Drawing.Point(9, 362)
        Me.btnChamadosExcluidos.Name = "btnChamadosExcluidos"
        Me.btnChamadosExcluidos.Size = New System.Drawing.Size(538, 114)
        Me.btnChamadosExcluidos.TabIndex = 1
        Me.btnChamadosExcluidos.Text = "Chamados Excluidos"
        Me.btnChamadosExcluidos.TileImage = Global.HelpST.My.Resources.Resources.TrashB___Copia
        Me.btnChamadosExcluidos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChamadosExcluidos.UseCustomBackColor = True
        Me.btnChamadosExcluidos.UseSelectable = True
        Me.btnChamadosExcluidos.UseTileImage = True
        '
        'btnChamados
        '
        Me.btnChamados.ActiveControl = Nothing
        Me.btnChamados.BackColor = System.Drawing.Color.Purple
        Me.btnChamados.Location = New System.Drawing.Point(9, 123)
        Me.btnChamados.Name = "btnChamados"
        Me.btnChamados.Size = New System.Drawing.Size(286, 131)
        Me.btnChamados.TabIndex = 0
        Me.btnChamados.Text = "Chamados"
        Me.btnChamados.TileImage = Global.HelpST.My.Resources.Resources.ChamadosB___Copia
        Me.btnChamados.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChamados.UseCustomBackColor = True
        Me.btnChamados.UseSelectable = True
        Me.btnChamados.UseTileImage = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(672, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Sair"
        '
        'MenuUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.btnNovoChamado)
        Me.Controls.Add(Me.btnMeusChamados)
        Me.Controls.Add(Me.btnChamadosResolvidos)
        Me.Controls.Add(Me.btnChamadosExcluidos)
        Me.Controls.Add(Me.btnChamados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MenuUser"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChamados As MetroFramework.Controls.MetroTile
	Friend WithEvents btnChamadosExcluidos As MetroFramework.Controls.MetroTile
	Friend WithEvents btnChamadosResolvidos As MetroFramework.Controls.MetroTile
	Friend WithEvents btnMeusChamados As MetroFramework.Controls.MetroTile
	Friend WithEvents btnNovoChamado As MetroFramework.Controls.MetroTile
	Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
	Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
