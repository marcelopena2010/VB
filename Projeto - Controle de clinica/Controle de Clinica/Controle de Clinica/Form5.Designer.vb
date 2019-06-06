<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMarcaConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMarcaConsulta))
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.DataGridPaciente = New System.Windows.Forms.DataGridView()
        Me.CodigoPacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomePacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CadastroDePacientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Controle_ClinicaDataSet = New Controle_de_Clinica.Controle_ClinicaDataSet()
        Me.CadastroDePacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cadastro_de_PacientesTableAdapter = New Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.Cadastro_de_PacientesTableAdapter()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.lblHorario = New System.Windows.Forms.Label()
        Me.mskHorario = New System.Windows.Forms.MaskedTextBox()
        Me.lblConvenio = New System.Windows.Forms.Label()
        Me.DataGridConvenio = New System.Windows.Forms.DataGridView()
        Me.CodigoConvenioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeConvenioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CadastroDeConveniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cadastro_de_ConveniosTableAdapter = New Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.Cadastro_de_ConveniosTableAdapter()
        Me.btnMarcar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Agenda_de_ConsultasTableAdapter1 = New Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.Agenda_de_ConsultasTableAdapter()
        Me.Controle_ClinicaDataSet1 = New Controle_de_Clinica.Controle_ClinicaDataSet()
        CType(Me.DataGridPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadastroDePacientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Controle_ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadastroDePacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridConvenio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadastroDeConveniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Controle_ClinicaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaciente.Location = New System.Drawing.Point(12, 9)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(127, 13)
        Me.lblPaciente.TabIndex = 0
        Me.lblPaciente.Text = "Selecione o paciente"
        '
        'DataGridPaciente
        '
        Me.DataGridPaciente.AllowUserToAddRows = False
        Me.DataGridPaciente.AllowUserToDeleteRows = False
        Me.DataGridPaciente.AutoGenerateColumns = False
        Me.DataGridPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPaciente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoPacienteDataGridViewTextBoxColumn, Me.NomePacienteDataGridViewTextBoxColumn, Me.TelefoneDataGridViewTextBoxColumn})
        Me.DataGridPaciente.DataSource = Me.CadastroDePacientesBindingSource1
        Me.DataGridPaciente.Location = New System.Drawing.Point(15, 34)
        Me.DataGridPaciente.Name = "DataGridPaciente"
        Me.DataGridPaciente.ReadOnly = True
        Me.DataGridPaciente.Size = New System.Drawing.Size(475, 103)
        Me.DataGridPaciente.TabIndex = 1
        '
        'CodigoPacienteDataGridViewTextBoxColumn
        '
        Me.CodigoPacienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoPaciente"
        Me.CodigoPacienteDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoPacienteDataGridViewTextBoxColumn.Name = "CodigoPacienteDataGridViewTextBoxColumn"
        Me.CodigoPacienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoPacienteDataGridViewTextBoxColumn.Width = 50
        '
        'NomePacienteDataGridViewTextBoxColumn
        '
        Me.NomePacienteDataGridViewTextBoxColumn.DataPropertyName = "NomePaciente"
        Me.NomePacienteDataGridViewTextBoxColumn.HeaderText = "Nome do Paciente"
        Me.NomePacienteDataGridViewTextBoxColumn.Name = "NomePacienteDataGridViewTextBoxColumn"
        Me.NomePacienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomePacienteDataGridViewTextBoxColumn.Width = 280
        '
        'TelefoneDataGridViewTextBoxColumn
        '
        Me.TelefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.Name = "TelefoneDataGridViewTextBoxColumn"
        Me.TelefoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CadastroDePacientesBindingSource1
        '
        Me.CadastroDePacientesBindingSource1.DataMember = "Cadastro de Pacientes"
        Me.CadastroDePacientesBindingSource1.DataSource = Me.Controle_ClinicaDataSet
        '
        'Controle_ClinicaDataSet
        '
        Me.Controle_ClinicaDataSet.DataSetName = "Controle_ClinicaDataSet"
        Me.Controle_ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CadastroDePacientesBindingSource
        '
        Me.CadastroDePacientesBindingSource.DataMember = "Cadastro de Pacientes"
        Me.CadastroDePacientesBindingSource.DataSource = Me.Controle_ClinicaDataSet
        '
        'Cadastro_de_PacientesTableAdapter
        '
        Me.Cadastro_de_PacientesTableAdapter.ClearBeforeFill = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(15, 149)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 2
        '
        'lblHorario
        '
        Me.lblHorario.AutoSize = True
        Me.lblHorario.Location = New System.Drawing.Point(254, 149)
        Me.lblHorario.Name = "lblHorario"
        Me.lblHorario.Size = New System.Drawing.Size(41, 13)
        Me.lblHorario.TabIndex = 3
        Me.lblHorario.Text = "Horario"
        '
        'mskHorario
        '
        Me.mskHorario.Location = New System.Drawing.Point(301, 146)
        Me.mskHorario.Mask = "00:00"
        Me.mskHorario.Name = "mskHorario"
        Me.mskHorario.Size = New System.Drawing.Size(35, 20)
        Me.mskHorario.TabIndex = 4
        Me.mskHorario.ValidatingType = GetType(Date)
        '
        'lblConvenio
        '
        Me.lblConvenio.AutoSize = True
        Me.lblConvenio.Location = New System.Drawing.Point(256, 169)
        Me.lblConvenio.Name = "lblConvenio"
        Me.lblConvenio.Size = New System.Drawing.Size(52, 13)
        Me.lblConvenio.TabIndex = 5
        Me.lblConvenio.Text = "Convenio"
        '
        'DataGridConvenio
        '
        Me.DataGridConvenio.AutoGenerateColumns = False
        Me.DataGridConvenio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridConvenio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoConvenioDataGridViewTextBoxColumn, Me.NomeConvenioDataGridViewTextBoxColumn})
        Me.DataGridConvenio.DataSource = Me.CadastroDeConveniosBindingSource
        Me.DataGridConvenio.Location = New System.Drawing.Point(257, 185)
        Me.DataGridConvenio.Name = "DataGridConvenio"
        Me.DataGridConvenio.Size = New System.Drawing.Size(231, 93)
        Me.DataGridConvenio.TabIndex = 6
        '
        'CodigoConvenioDataGridViewTextBoxColumn
        '
        Me.CodigoConvenioDataGridViewTextBoxColumn.DataPropertyName = "CodigoConvenio"
        Me.CodigoConvenioDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoConvenioDataGridViewTextBoxColumn.Name = "CodigoConvenioDataGridViewTextBoxColumn"
        Me.CodigoConvenioDataGridViewTextBoxColumn.Width = 50
        '
        'NomeConvenioDataGridViewTextBoxColumn
        '
        Me.NomeConvenioDataGridViewTextBoxColumn.DataPropertyName = "NomeConvenio"
        Me.NomeConvenioDataGridViewTextBoxColumn.HeaderText = "Convenio"
        Me.NomeConvenioDataGridViewTextBoxColumn.Name = "NomeConvenioDataGridViewTextBoxColumn"
        Me.NomeConvenioDataGridViewTextBoxColumn.Width = 180
        '
        'CadastroDeConveniosBindingSource
        '
        Me.CadastroDeConveniosBindingSource.DataMember = "Cadastro de Convenios"
        Me.CadastroDeConveniosBindingSource.DataSource = Me.Controle_ClinicaDataSet
        '
        'Cadastro_de_ConveniosTableAdapter
        '
        Me.Cadastro_de_ConveniosTableAdapter.ClearBeforeFill = True
        '
        'btnMarcar
        '
        Me.btnMarcar.BackColor = System.Drawing.Color.Silver
        Me.btnMarcar.Image = CType(resources.GetObject("btnMarcar.Image"), System.Drawing.Image)
        Me.btnMarcar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMarcar.Location = New System.Drawing.Point(254, 288)
        Me.btnMarcar.Name = "btnMarcar"
        Me.btnMarcar.Size = New System.Drawing.Size(75, 56)
        Me.btnMarcar.TabIndex = 7
        Me.btnMarcar.Text = "Marcar"
        Me.btnMarcar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMarcar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Silver
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(413, 288)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 56)
        Me.btnSair.TabIndex = 8
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'Agenda_de_ConsultasTableAdapter1
        '
        Me.Agenda_de_ConsultasTableAdapter1.ClearBeforeFill = True
        '
        'Controle_ClinicaDataSet1
        '
        Me.Controle_ClinicaDataSet1.DataSetName = "Controle_ClinicaDataSet"
        Me.Controle_ClinicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'formMarcaConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 367)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnMarcar)
        Me.Controls.Add(Me.DataGridConvenio)
        Me.Controls.Add(Me.lblConvenio)
        Me.Controls.Add(Me.mskHorario)
        Me.Controls.Add(Me.lblHorario)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.DataGridPaciente)
        Me.Controls.Add(Me.lblPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formMarcaConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Marcar Consulta"
        CType(Me.DataGridPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadastroDePacientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Controle_ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadastroDePacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridConvenio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadastroDeConveniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Controle_ClinicaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPaciente As System.Windows.Forms.Label
    Friend WithEvents DataGridPaciente As System.Windows.Forms.DataGridView
    Friend WithEvents Controle_ClinicaDataSet As Controle_de_Clinica.Controle_ClinicaDataSet
    Friend WithEvents CadastroDePacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cadastro_de_PacientesTableAdapter As Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.Cadastro_de_PacientesTableAdapter
    Friend WithEvents CodigoPacienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomePacienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CadastroDePacientesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblHorario As System.Windows.Forms.Label
    Friend WithEvents mskHorario As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblConvenio As System.Windows.Forms.Label
    Friend WithEvents DataGridConvenio As System.Windows.Forms.DataGridView
    Friend WithEvents CadastroDeConveniosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cadastro_de_ConveniosTableAdapter As Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.Cadastro_de_ConveniosTableAdapter
    Friend WithEvents CodigoConvenioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeConvenioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnMarcar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Agenda_de_ConsultasTableAdapter1 As Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.Agenda_de_ConsultasTableAdapter
    Friend WithEvents Controle_ClinicaDataSet1 As Controle_de_Clinica.Controle_ClinicaDataSet
End Class
