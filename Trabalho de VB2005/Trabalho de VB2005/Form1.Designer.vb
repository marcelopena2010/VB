<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuArquivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcNovo = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcSalvar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.opcSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNovo = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAbrir = New System.Windows.Forms.ToolStripButton()
        Me.btnGravar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSair = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsMensagem1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtTexto = New System.Windows.Forms.RichTextBox()
        Me.dlgAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSalvar = New System.Windows.Forms.SaveFileDialog()
        Me.dlgFonte = New System.Windows.Forms.FontDialog()
        Me.menuFormatar = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcLetra = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgImprimir = New System.Windows.Forms.PrintDialog()
        Me.Impressao = New System.Drawing.Printing.PrintDocument()
        Me.opcImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuArquivo, Me.menuFormatar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(534, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuArquivo
        '
        Me.menuArquivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcNovo, Me.opcAbrir, Me.opcSalvar, Me.opcImprimir, Me.ToolStripMenuItem1, Me.opcSair})
        Me.menuArquivo.Name = "menuArquivo"
        Me.menuArquivo.Size = New System.Drawing.Size(61, 20)
        Me.menuArquivo.Text = "&Arquivo"
        '
        'opcNovo
        '
        Me.opcNovo.Name = "opcNovo"
        Me.opcNovo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.opcNovo.Size = New System.Drawing.Size(157, 22)
        Me.opcNovo.Text = "Novo"
        Me.opcNovo.ToolTipText = "Novo arquivo texto"
        '
        'opcAbrir
        '
        Me.opcAbrir.Name = "opcAbrir"
        Me.opcAbrir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.opcAbrir.Size = New System.Drawing.Size(157, 22)
        Me.opcAbrir.Text = "Abrir"
        Me.opcAbrir.ToolTipText = "Abrir um arquivo texto"
        '
        'opcSalvar
        '
        Me.opcSalvar.Name = "opcSalvar"
        Me.opcSalvar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.opcSalvar.Size = New System.Drawing.Size(157, 22)
        Me.opcSalvar.Text = "Salvar"
        Me.opcSalvar.ToolTipText = "Gravar arquivo texto"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(154, 6)
        '
        'opcSair
        '
        Me.opcSair.Name = "opcSair"
        Me.opcSair.Size = New System.Drawing.Size(157, 22)
        Me.opcSair.Text = "Sair"
        Me.opcSair.ToolTipText = "Sair do aplicativo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovo, Me.btnAbrir, Me.btnGravar, Me.ToolStripSeparator1, Me.btnSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(534, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNovo
        '
        Me.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(23, 22)
        Me.btnNovo.Text = "ToolStripButton1"
        Me.btnNovo.ToolTipText = "Novo arquivo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(345, 386)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnAbrir
        '
        Me.btnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAbrir.Image = CType(resources.GetObject("btnAbrir.Image"), System.Drawing.Image)
        Me.btnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(23, 22)
        Me.btnAbrir.Text = "ToolStripButton1"
        Me.btnAbrir.ToolTipText = "Abrir arquivo"
        '
        'btnGravar
        '
        Me.btnGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(23, 22)
        Me.btnGravar.Text = "ToolStripButton2"
        Me.btnGravar.ToolTipText = "Gravar arquivo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnSair
        '
        Me.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(23, 22)
        Me.btnSair.Text = "ToolStripButton1"
        Me.btnSair.ToolTipText = "Sair"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsMensagem1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 490)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(534, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsMensagem1
        '
        Me.stsMensagem1.Name = "stsMensagem1"
        Me.stsMensagem1.Size = New System.Drawing.Size(103, 17)
        Me.stsMensagem1.Text = "Nome do arquivo:"
        '
        'txtTexto
        '
        Me.txtTexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTexto.Location = New System.Drawing.Point(0, 49)
        Me.txtTexto.MaxLength = 16000
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(534, 441)
        Me.txtTexto.TabIndex = 4
        Me.txtTexto.Text = ""
        '
        'dlgAbrir
        '
        Me.dlgAbrir.DefaultExt = "txt"
        Me.dlgAbrir.FileName = "OpenFileDialog1"
        Me.dlgAbrir.Filter = "Arquivo texto|*.txt"
        '
        'dlgSalvar
        '
        Me.dlgSalvar.DefaultExt = "txt"
        Me.dlgSalvar.Filter = "Arquivo texto|*.txt"
        '
        'menuFormatar
        '
        Me.menuFormatar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcLetra})
        Me.menuFormatar.Name = "menuFormatar"
        Me.menuFormatar.Size = New System.Drawing.Size(67, 20)
        Me.menuFormatar.Text = "&Formatar"
        '
        'opcLetra
        '
        Me.opcLetra.Name = "opcLetra"
        Me.opcLetra.Size = New System.Drawing.Size(152, 22)
        Me.opcLetra.Text = "Letra"
        Me.opcLetra.ToolTipText = "Formatar texto"
        '
        'dlgImprimir
        '
        Me.dlgImprimir.Document = Me.Impressao
        Me.dlgImprimir.UseEXDialog = True
        '
        'Impressao
        '
        '
        'opcImprimir
        '
        Me.opcImprimir.Name = "opcImprimir"
        Me.opcImprimir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.opcImprimir.Size = New System.Drawing.Size(157, 22)
        Me.opcImprimir.Text = "Imprimir"
        Me.opcImprimir.ToolTipText = "Imprimir arquivo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 512)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editor Simples"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuArquivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcNovo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcAbrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcSalvar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents opcSair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFormatar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcLetra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAbrir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGravar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsMensagem1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTexto As System.Windows.Forms.RichTextBox
    Friend WithEvents dlgAbrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSalvar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgFonte As System.Windows.Forms.FontDialog
    Friend WithEvents opcImprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgImprimir As System.Windows.Forms.PrintDialog
    Friend WithEvents Impressao As System.Drawing.Printing.PrintDocument

End Class
