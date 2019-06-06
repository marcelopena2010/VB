<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formFichaPaciente
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
        Me.components = New System.ComponentModel.Container()
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.DataGridPaciente = New System.Windows.Forms.DataGridView()
        Me.NomePacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroRGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroCPFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataNascimentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnderecoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComplementoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BairroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CadastroDePacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Controle_ClinicaDataSet = New Controle_de_Clinica.Controle_ClinicaDataSet()
        Me.Cadastro_de_PacientesTableAdapter = New Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.Cadastro_de_PacientesTableAdapter()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.PrintDlg = New System.Windows.Forms.PrintDialog()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        CType(Me.DataGridPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadastroDePacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Controle_ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMensagem
        '
        Me.lblMensagem.AutoSize = True
        Me.lblMensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensagem.Location = New System.Drawing.Point(12, 9)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(220, 13)
        Me.lblMensagem.TabIndex = 0
        Me.lblMensagem.Text = "Selecione o paciente a partir da lista:"
        '
        'DataGridPaciente
        '
        Me.DataGridPaciente.AllowUserToAddRows = False
        Me.DataGridPaciente.AllowUserToDeleteRows = False
        Me.DataGridPaciente.AutoGenerateColumns = False
        Me.DataGridPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPaciente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomePacienteDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.NumeroRGDataGridViewTextBoxColumn, Me.NumeroCPFDataGridViewTextBoxColumn, Me.DataNascimentoDataGridViewTextBoxColumn, Me.EnderecoDataGridViewTextBoxColumn, Me.NumeroDataGridViewTextBoxColumn, Me.ComplementoDataGridViewTextBoxColumn, Me.BairroDataGridViewTextBoxColumn, Me.CidadeDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.TelefoneDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn})
        Me.DataGridPaciente.DataSource = Me.CadastroDePacientesBindingSource
        Me.DataGridPaciente.Location = New System.Drawing.Point(15, 25)
        Me.DataGridPaciente.Name = "DataGridPaciente"
        Me.DataGridPaciente.ReadOnly = True
        Me.DataGridPaciente.Size = New System.Drawing.Size(412, 150)
        Me.DataGridPaciente.TabIndex = 1
        '
        'NomePacienteDataGridViewTextBoxColumn
        '
        Me.NomePacienteDataGridViewTextBoxColumn.DataPropertyName = "NomePaciente"
        Me.NomePacienteDataGridViewTextBoxColumn.HeaderText = "Nome do Paciente"
        Me.NomePacienteDataGridViewTextBoxColumn.Name = "NomePacienteDataGridViewTextBoxColumn"
        Me.NomePacienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomePacienteDataGridViewTextBoxColumn.Width = 250
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        Me.SexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SexoDataGridViewTextBoxColumn.Width = 35
        '
        'NumeroRGDataGridViewTextBoxColumn
        '
        Me.NumeroRGDataGridViewTextBoxColumn.DataPropertyName = "Numero_RG"
        Me.NumeroRGDataGridViewTextBoxColumn.HeaderText = "Numero RG"
        Me.NumeroRGDataGridViewTextBoxColumn.Name = "NumeroRGDataGridViewTextBoxColumn"
        Me.NumeroRGDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumeroCPFDataGridViewTextBoxColumn
        '
        Me.NumeroCPFDataGridViewTextBoxColumn.DataPropertyName = "Numero_CPF"
        Me.NumeroCPFDataGridViewTextBoxColumn.HeaderText = "Numero CPF"
        Me.NumeroCPFDataGridViewTextBoxColumn.Name = "NumeroCPFDataGridViewTextBoxColumn"
        Me.NumeroCPFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataNascimentoDataGridViewTextBoxColumn
        '
        Me.DataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento"
        Me.DataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nasc."
        Me.DataNascimentoDataGridViewTextBoxColumn.Name = "DataNascimentoDataGridViewTextBoxColumn"
        Me.DataNascimentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DataNascimentoDataGridViewTextBoxColumn.Width = 120
        '
        'EnderecoDataGridViewTextBoxColumn
        '
        Me.EnderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco"
        Me.EnderecoDataGridViewTextBoxColumn.HeaderText = "Endereco"
        Me.EnderecoDataGridViewTextBoxColumn.Name = "EnderecoDataGridViewTextBoxColumn"
        Me.EnderecoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 50
        '
        'ComplementoDataGridViewTextBoxColumn
        '
        Me.ComplementoDataGridViewTextBoxColumn.DataPropertyName = "Complemento"
        Me.ComplementoDataGridViewTextBoxColumn.HeaderText = "Complemento"
        Me.ComplementoDataGridViewTextBoxColumn.Name = "ComplementoDataGridViewTextBoxColumn"
        Me.ComplementoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ComplementoDataGridViewTextBoxColumn.Width = 80
        '
        'BairroDataGridViewTextBoxColumn
        '
        Me.BairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro"
        Me.BairroDataGridViewTextBoxColumn.HeaderText = "Bairro"
        Me.BairroDataGridViewTextBoxColumn.Name = "BairroDataGridViewTextBoxColumn"
        Me.BairroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CidadeDataGridViewTextBoxColumn
        '
        Me.CidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade"
        Me.CidadeDataGridViewTextBoxColumn.HeaderText = "Cidade"
        Me.CidadeDataGridViewTextBoxColumn.Name = "CidadeDataGridViewTextBoxColumn"
        Me.CidadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Width = 30
        '
        'TelefoneDataGridViewTextBoxColumn
        '
        Me.TelefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.Name = "TelefoneDataGridViewTextBoxColumn"
        Me.TelefoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "Celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        Me.CelularDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CadastroDePacientesBindingSource
        '
        Me.CadastroDePacientesBindingSource.DataMember = "Cadastro de Pacientes"
        Me.CadastroDePacientesBindingSource.DataSource = Me.Controle_ClinicaDataSet
        '
        'Controle_ClinicaDataSet
        '
        Me.Controle_ClinicaDataSet.DataSetName = "Controle_ClinicaDataSet"
        Me.Controle_ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cadastro_de_PacientesTableAdapter
        '
        Me.Cadastro_de_PacientesTableAdapter.ClearBeforeFill = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Controle_de_Clinica.My.Resources.Resources.icon_imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(249, 194)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(80, 32)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.Controle_de_Clinica.My.Resources.Resources.iconCancelar1
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(335, 194)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'PrintDlg
        '
        Me.PrintDlg.Document = Me.PrintDoc
        Me.PrintDlg.UseEXDialog = True
        '
        'PrintDoc
        '
        '
        'formFichaPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 262)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.DataGridPaciente)
        Me.Controls.Add(Me.lblMensagem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formFichaPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Impressao de Ficha de Paciente"
        CType(Me.DataGridPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadastroDePacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Controle_ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMensagem As System.Windows.Forms.Label
    Friend WithEvents DataGridPaciente As System.Windows.Forms.DataGridView
    Friend WithEvents Controle_ClinicaDataSet As Controle_de_Clinica.Controle_ClinicaDataSet
    Friend WithEvents CadastroDePacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cadastro_de_PacientesTableAdapter As Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.Cadastro_de_PacientesTableAdapter
    Friend WithEvents NomePacienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroRGDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroCPFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataNascimentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnderecoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComplementoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BairroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents PrintDlg As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDoc As System.Drawing.Printing.PrintDocument
End Class
