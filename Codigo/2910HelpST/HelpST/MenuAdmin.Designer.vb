<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAdmin))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNovoUsuario = New MetroFramework.Controls.MetroTile()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnChamadosExcluidos = New MetroFramework.Controls.MetroTile()
        Me.btnNovoChamado = New MetroFramework.Controls.MetroTile()
        Me.btnChamadosFinalizados = New MetroFramework.Controls.MetroTile()
        Me.btnChamados = New MetroFramework.Controls.MetroTile()
        Me.btnMeusChamados = New MetroFramework.Controls.MetroTile()
        Me.btnNovaSala = New MetroFramework.Controls.MetroTile()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(677, -20)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel1.TabIndex = 8
        Me.MetroLabel1.Text = "MetroLabel1"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.Label2)
        Me.MetroPanel1.Controls.Add(Me.Label3)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(453, 10)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(329, 103)
        Me.MetroPanel1.TabIndex = 7
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 31)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 31)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(797, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Sair"
        '
        'btnNovoUsuario
        '
        Me.btnNovoUsuario.ActiveControl = Nothing
        Me.btnNovoUsuario.BackColor = System.Drawing.Color.Purple
        Me.btnNovoUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNovoUsuario.Location = New System.Drawing.Point(646, 119)
        Me.btnNovoUsuario.Name = "btnNovoUsuario"
        Me.btnNovoUsuario.Size = New System.Drawing.Size(179, 260)
        Me.btnNovoUsuario.TabIndex = 10
        Me.btnNovoUsuario.Text = "Novo Usuario"
        Me.btnNovoUsuario.TileImage = Global.HelpST.My.Resources.Resources.newUserB
        Me.btnNovoUsuario.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNovoUsuario.UseCustomBackColor = True
        Me.btnNovoUsuario.UseCustomForeColor = True
        Me.btnNovoUsuario.UseSelectable = True
        Me.btnNovoUsuario.UseTileImage = True
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.White
        Me.btnSair.BackgroundImage = Global.HelpST.My.Resources.Resources.exit_93_458494
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSair.Location = New System.Drawing.Point(788, 10)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(59, 55)
        Me.btnSair.TabIndex = 13
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BackColor = System.Drawing.Color.Purple
        Me.MetroPanel2.BackgroundImage = Global.HelpST.My.Resources.Resources.logoPequeno1
        Me.MetroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroPanel2.Controls.Add(Me.Label1)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(23, 10)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(424, 103)
        Me.MetroPanel2.TabIndex = 2
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
        Me.Label1.Location = New System.Drawing.Point(91, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 42)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "HelpST"
        '
        'btnChamadosExcluidos
        '
        Me.btnChamadosExcluidos.ActiveControl = Nothing
        Me.btnChamadosExcluidos.BackColor = System.Drawing.Color.Purple
        Me.btnChamadosExcluidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnChamadosExcluidos.Location = New System.Drawing.Point(453, 385)
        Me.btnChamadosExcluidos.Name = "btnChamadosExcluidos"
        Me.btnChamadosExcluidos.Size = New System.Drawing.Size(187, 196)
        Me.btnChamadosExcluidos.TabIndex = 1
        Me.btnChamadosExcluidos.Text = "Chamados Excluidos"
        Me.btnChamadosExcluidos.TileImage = Global.HelpST.My.Resources.Resources.TrashB
        Me.btnChamadosExcluidos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChamadosExcluidos.UseCustomBackColor = True
        Me.btnChamadosExcluidos.UseCustomForeColor = True
        Me.btnChamadosExcluidos.UseSelectable = True
        Me.btnChamadosExcluidos.UseTileImage = True
        '
        'btnNovoChamado
        '
        Me.btnNovoChamado.ActiveControl = Nothing
        Me.btnNovoChamado.BackColor = System.Drawing.Color.Purple
        Me.btnNovoChamado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNovoChamado.Location = New System.Drawing.Point(646, 385)
        Me.btnNovoChamado.Name = "btnNovoChamado"
        Me.btnNovoChamado.Size = New System.Drawing.Size(179, 196)
        Me.btnNovoChamado.TabIndex = 4
        Me.btnNovoChamado.Text = "Novo Chamado"
        Me.btnNovoChamado.TileImage = Global.HelpST.My.Resources.Resources.sendEmailB
        Me.btnNovoChamado.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNovoChamado.UseCustomBackColor = True
        Me.btnNovoChamado.UseCustomForeColor = True
        Me.btnNovoChamado.UseSelectable = True
        Me.btnNovoChamado.UseTileImage = True
        '
        'btnChamadosFinalizados
        '
        Me.btnChamadosFinalizados.ActiveControl = Nothing
        Me.btnChamadosFinalizados.BackColor = System.Drawing.Color.Purple
        Me.btnChamadosFinalizados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnChamadosFinalizados.Location = New System.Drawing.Point(236, 353)
        Me.btnChamadosFinalizados.Name = "btnChamadosFinalizados"
        Me.btnChamadosFinalizados.Size = New System.Drawing.Size(211, 228)
        Me.btnChamadosFinalizados.TabIndex = 6
        Me.btnChamadosFinalizados.Text = "Chamados Finalizados"
        Me.btnChamadosFinalizados.TileImage = Global.HelpST.My.Resources.Resources.checkListBr
        Me.btnChamadosFinalizados.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChamadosFinalizados.UseCustomBackColor = True
        Me.btnChamadosFinalizados.UseCustomForeColor = True
        Me.btnChamadosFinalizados.UseSelectable = True
        Me.btnChamadosFinalizados.UseTileImage = True
        '
        'btnChamados
        '
        Me.btnChamados.ActiveControl = Nothing
        Me.btnChamados.BackColor = System.Drawing.Color.Purple
        Me.btnChamados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnChamados.Location = New System.Drawing.Point(236, 119)
        Me.btnChamados.Name = "btnChamados"
        Me.btnChamados.Size = New System.Drawing.Size(211, 228)
        Me.btnChamados.TabIndex = 5
        Me.btnChamados.Text = "Chamados"
        Me.btnChamados.TileImage = Global.HelpST.My.Resources.Resources.ChamadosB
        Me.btnChamados.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChamados.UseCustomBackColor = True
        Me.btnChamados.UseCustomForeColor = True
        Me.btnChamados.UseSelectable = True
        Me.btnChamados.UseTileImage = True
        '
        'btnMeusChamados
        '
        Me.btnMeusChamados.ActiveControl = Nothing
        Me.btnMeusChamados.BackColor = System.Drawing.Color.Purple
        Me.btnMeusChamados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMeusChamados.Location = New System.Drawing.Point(23, 119)
        Me.btnMeusChamados.Name = "btnMeusChamados"
        Me.btnMeusChamados.Size = New System.Drawing.Size(207, 462)
        Me.btnMeusChamados.TabIndex = 3
        Me.btnMeusChamados.Text = "Meus Chamados"
        Me.btnMeusChamados.TileImage = Global.HelpST.My.Resources.Resources.MyemailB
        Me.btnMeusChamados.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnMeusChamados.UseCustomBackColor = True
        Me.btnMeusChamados.UseCustomForeColor = True
        Me.btnMeusChamados.UseSelectable = True
        Me.btnMeusChamados.UseTileImage = True
        '
        'btnNovaSala
        '
        Me.btnNovaSala.ActiveControl = Nothing
        Me.btnNovaSala.BackColor = System.Drawing.Color.Purple
        Me.btnNovaSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNovaSala.Location = New System.Drawing.Point(453, 119)
        Me.btnNovaSala.Name = "btnNovaSala"
        Me.btnNovaSala.Size = New System.Drawing.Size(187, 260)
        Me.btnNovaSala.TabIndex = 2
        Me.btnNovaSala.Text = "Nova Sala"
        Me.btnNovaSala.TileImage = Global.HelpST.My.Resources.Resources.NewEmailB
        Me.btnNovaSala.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNovaSala.UseCustomBackColor = True
        Me.btnNovaSala.UseCustomForeColor = True
        Me.btnNovaSala.UseSelectable = True
        Me.btnNovaSala.UseTileImage = True
        '
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 603)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnNovoUsuario)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.btnChamadosExcluidos)
        Me.Controls.Add(Me.btnNovoChamado)
        Me.Controls.Add(Me.btnChamadosFinalizados)
        Me.Controls.Add(Me.btnChamados)
        Me.Controls.Add(Me.btnMeusChamados)
        Me.Controls.Add(Me.btnNovaSala)
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "MenuAdmin"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChamadosExcluidos As MetroFramework.Controls.MetroTile
    Friend WithEvents btnNovaSala As MetroFramework.Controls.MetroTile
    Friend WithEvents btnMeusChamados As MetroFramework.Controls.MetroTile
    Friend WithEvents btnNovoChamado As MetroFramework.Controls.MetroTile
    Friend WithEvents btnChamados As MetroFramework.Controls.MetroTile
    Friend WithEvents btnChamadosFinalizados As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnNovoUsuario As MetroFramework.Controls.MetroTile
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
