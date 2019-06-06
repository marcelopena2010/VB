<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPrincipal
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuArquivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcConvenios = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcPacientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menuConsultas = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcVerificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcMarcar = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcCancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuRelatorios = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcRelFichaPaciente = New System.Windows.Forms.ToolStripMenuItem()
        Me.picImagem = New System.Windows.Forms.PictureBox()
        Me.btnConvenio = New System.Windows.Forms.ToolStripButton()
        Me.btnPaciente = New System.Windows.Forms.ToolStripButton()
        Me.btnVisualizarConsultas = New System.Windows.Forms.ToolStripButton()
        Me.btnMarcarConsulta = New System.Windows.Forms.ToolStripButton()
        Me.btnSair = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuArquivo, Me.menuCadastro, Me.menuConsultas, Me.menuRelatorios})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuArquivo
        '
        Me.menuArquivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcSair})
        Me.menuArquivo.Name = "menuArquivo"
        Me.menuArquivo.Size = New System.Drawing.Size(61, 20)
        Me.menuArquivo.Text = "&Arquivo"
        '
        'opcSair
        '
        Me.opcSair.Name = "opcSair"
        Me.opcSair.Size = New System.Drawing.Size(93, 22)
        Me.opcSair.Text = "Sair"
        '
        'menuCadastro
        '
        Me.menuCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcConvenios, Me.opcPacientes})
        Me.menuCadastro.Name = "menuCadastro"
        Me.menuCadastro.Size = New System.Drawing.Size(66, 20)
        Me.menuCadastro.Text = "&Cadastro"
        '
        'opcConvenios
        '
        Me.opcConvenios.Name = "opcConvenios"
        Me.opcConvenios.Size = New System.Drawing.Size(130, 22)
        Me.opcConvenios.Text = "Convenios"
        '
        'opcPacientes
        '
        Me.opcPacientes.Name = "opcPacientes"
        Me.opcPacientes.Size = New System.Drawing.Size(130, 22)
        Me.opcPacientes.Text = "Pacientes"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConvenio, Me.btnPaciente, Me.ToolStripSeparator1, Me.btnVisualizarConsultas, Me.btnMarcarConsulta, Me.ToolStripSeparator2, Me.btnSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(624, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblData})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(624, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblData
        '
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(34, 17)
        Me.lblData.Text = "Data:"
        '
        'menuConsultas
        '
        Me.menuConsultas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcVerificar, Me.opcMarcar, Me.opcCancelar})
        Me.menuConsultas.Name = "menuConsultas"
        Me.menuConsultas.Size = New System.Drawing.Size(71, 20)
        Me.menuConsultas.Text = "Con&sultas"
        '
        'opcVerificar
        '
        Me.opcVerificar.Name = "opcVerificar"
        Me.opcVerificar.Size = New System.Drawing.Size(170, 22)
        Me.opcVerificar.Text = "Verificar consultas"
        '
        'opcMarcar
        '
        Me.opcMarcar.Name = "opcMarcar"
        Me.opcMarcar.Size = New System.Drawing.Size(170, 22)
        Me.opcMarcar.Text = "Marcar consulta"
        '
        'opcCancelar
        '
        Me.opcCancelar.Name = "opcCancelar"
        Me.opcCancelar.Size = New System.Drawing.Size(170, 22)
        Me.opcCancelar.Text = "Cancelar consulta"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'menuRelatorios
        '
        Me.menuRelatorios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcRelFichaPaciente})
        Me.menuRelatorios.Name = "menuRelatorios"
        Me.menuRelatorios.Size = New System.Drawing.Size(71, 20)
        Me.menuRelatorios.Text = "&Relatorios"
        '
        'opcRelFichaPaciente
        '
        Me.opcRelFichaPaciente.Name = "opcRelFichaPaciente"
        Me.opcRelFichaPaciente.Size = New System.Drawing.Size(166, 22)
        Me.opcRelFichaPaciente.Text = "Ficha de Paciente"
        '
        'picImagem
        '
        Me.picImagem.BackgroundImage = CType(resources.GetObject("picImagem.BackgroundImage"), System.Drawing.Image)
        Me.picImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picImagem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picImagem.Location = New System.Drawing.Point(0, 49)
        Me.picImagem.Name = "picImagem"
        Me.picImagem.Size = New System.Drawing.Size(624, 371)
        Me.picImagem.TabIndex = 3
        Me.picImagem.TabStop = False
        '
        'btnConvenio
        '
        Me.btnConvenio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnConvenio.Image = CType(resources.GetObject("btnConvenio.Image"), System.Drawing.Image)
        Me.btnConvenio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConvenio.Name = "btnConvenio"
        Me.btnConvenio.Size = New System.Drawing.Size(23, 22)
        Me.btnConvenio.Text = "ToolStripButton1"
        Me.btnConvenio.ToolTipText = "Cadastro de Convenios"
        '
        'btnPaciente
        '
        Me.btnPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPaciente.Image = CType(resources.GetObject("btnPaciente.Image"), System.Drawing.Image)
        Me.btnPaciente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(23, 22)
        Me.btnPaciente.Text = "ToolStripButton2"
        Me.btnPaciente.ToolTipText = "Cadastro de Pacientes"
        '
        'btnVisualizarConsultas
        '
        Me.btnVisualizarConsultas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnVisualizarConsultas.Image = CType(resources.GetObject("btnVisualizarConsultas.Image"), System.Drawing.Image)
        Me.btnVisualizarConsultas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVisualizarConsultas.Name = "btnVisualizarConsultas"
        Me.btnVisualizarConsultas.Size = New System.Drawing.Size(23, 22)
        Me.btnVisualizarConsultas.Text = "ToolStripButton1"
        Me.btnVisualizarConsultas.ToolTipText = "Visualizar Consultas"
        '
        'btnMarcarConsulta
        '
        Me.btnMarcarConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMarcarConsulta.Image = CType(resources.GetObject("btnMarcarConsulta.Image"), System.Drawing.Image)
        Me.btnMarcarConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMarcarConsulta.Name = "btnMarcarConsulta"
        Me.btnMarcarConsulta.Size = New System.Drawing.Size(23, 22)
        Me.btnMarcarConsulta.Text = "ToolStripButton2"
        Me.btnMarcarConsulta.ToolTipText = "Marcar Consulta"
        '
        'btnSair
        '
        Me.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(23, 22)
        Me.btnSair.Text = "ToolStripButton3"
        Me.btnSair.ToolTipText = "Sair"
        '
        'formPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.picImagem)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Clinica Medica"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuArquivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcSair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCadastro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcConvenios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcPacientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnConvenio As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPaciente As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblData As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents picImagem As System.Windows.Forms.PictureBox
    Friend WithEvents menuConsultas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcVerificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcMarcar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcCancelar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnVisualizarConsultas As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMarcarConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuRelatorios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcRelFichaPaciente As System.Windows.Forms.ToolStripMenuItem

End Class
