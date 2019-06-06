<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCancelaConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCancelaConsulta))
        Me.Controle_ClinicaDataSet1 = New Controle_de_Clinica.Controle_ClinicaDataSet()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.AgendaDeConsultasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Agenda_de_ConsultasTableAdapter = New Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.Agenda_de_ConsultasTableAdapter()
        Me.CadastroDePacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cadastro_de_PacientesTableAdapter = New Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.Cadastro_de_PacientesTableAdapter()
        Me.AgendaDeConsultasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgendaDeConsultasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgendaConsultasExcluirBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgendaConsultas_ExcluirTableAdapter = New Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.AgendaConsultas_ExcluirTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.DataTable1TableAdapter()
        Me.DataHoraConsultaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataConsultaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomePacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Controle_ClinicaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgendaDeConsultasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadastroDePacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgendaDeConsultasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgendaDeConsultasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgendaConsultasExcluirBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Controle_ClinicaDataSet1
        '
        Me.Controle_ClinicaDataSet1.DataSetName = "Controle_ClinicaDataSet"
        Me.Controle_ClinicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(12, 9)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(162, 13)
        Me.lblData.TabIndex = 0
        Me.lblData.Text = "Selecione a data desejada:"
        '
        'Calendario
        '
        Me.Calendario.Location = New System.Drawing.Point(15, 31)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 1
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.Color.Silver
        Me.btnListar.Image = CType(resources.GetObject("btnListar.Image"), System.Drawing.Image)
        Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnListar.Location = New System.Drawing.Point(254, 31)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 85)
        Me.btnListar.TabIndex = 2
        Me.btnListar.Text = "Listar"
        Me.btnListar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Silver
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(335, 31)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 85)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Silver
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(416, 31)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 85)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'AgendaDeConsultasBindingSource
        '
        Me.AgendaDeConsultasBindingSource.DataMember = "Agenda de Consultas"
        Me.AgendaDeConsultasBindingSource.DataSource = Me.Controle_ClinicaDataSet1
        '
        'Agenda_de_ConsultasTableAdapter
        '
        Me.Agenda_de_ConsultasTableAdapter.ClearBeforeFill = True
        '
        'CadastroDePacientesBindingSource
        '
        Me.CadastroDePacientesBindingSource.DataMember = "Cadastro de Pacientes"
        Me.CadastroDePacientesBindingSource.DataSource = Me.Controle_ClinicaDataSet1
        '
        'Cadastro_de_PacientesTableAdapter
        '
        Me.Cadastro_de_PacientesTableAdapter.ClearBeforeFill = True
        '
        'AgendaDeConsultasBindingSource1
        '
        Me.AgendaDeConsultasBindingSource1.DataMember = "Agenda de Consultas"
        Me.AgendaDeConsultasBindingSource1.DataSource = Me.Controle_ClinicaDataSet1
        '
        'AgendaDeConsultasBindingSource2
        '
        Me.AgendaDeConsultasBindingSource2.DataMember = "Agenda de Consultas"
        Me.AgendaDeConsultasBindingSource2.DataSource = Me.Controle_ClinicaDataSet1
        '
        'AgendaConsultasExcluirBindingSource
        '
        Me.AgendaConsultasExcluirBindingSource.DataMember = "AgendaConsultas_Excluir"
        Me.AgendaConsultasExcluirBindingSource.DataSource = Me.Controle_ClinicaDataSet1
        '
        'AgendaConsultas_ExcluirTableAdapter
        '
        Me.AgendaConsultas_ExcluirTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataHoraConsultaDataGridViewTextBoxColumn, Me.DataConsultaDataGridViewTextBoxColumn, Me.NomePacienteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DataTable1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 205)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(485, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Controle_ClinicaDataSet1
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'DataHoraConsultaDataGridViewTextBoxColumn
        '
        Me.DataHoraConsultaDataGridViewTextBoxColumn.DataPropertyName = "DataHoraConsulta"
        Me.DataHoraConsultaDataGridViewTextBoxColumn.HeaderText = "DataHoraConsulta"
        Me.DataHoraConsultaDataGridViewTextBoxColumn.Name = "DataHoraConsultaDataGridViewTextBoxColumn"
        '
        'DataConsultaDataGridViewTextBoxColumn
        '
        Me.DataConsultaDataGridViewTextBoxColumn.DataPropertyName = "DataConsulta"
        Me.DataConsultaDataGridViewTextBoxColumn.HeaderText = "DataConsulta"
        Me.DataConsultaDataGridViewTextBoxColumn.Name = "DataConsultaDataGridViewTextBoxColumn"
        '
        'NomePacienteDataGridViewTextBoxColumn
        '
        Me.NomePacienteDataGridViewTextBoxColumn.DataPropertyName = "NomePaciente"
        Me.NomePacienteDataGridViewTextBoxColumn.HeaderText = "NomePaciente"
        Me.NomePacienteDataGridViewTextBoxColumn.Name = "NomePacienteDataGridViewTextBoxColumn"
        '
        'formCancelaConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 367)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.lblData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formCancelaConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cancelamento de Consulta"
        CType(Me.Controle_ClinicaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgendaDeConsultasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadastroDePacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgendaDeConsultasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgendaDeConsultasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgendaConsultasExcluirBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Controle_ClinicaDataSet1 As Controle_de_Clinica.Controle_ClinicaDataSet
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents AgendaDeConsultasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Agenda_de_ConsultasTableAdapter As Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.Agenda_de_ConsultasTableAdapter
    Friend WithEvents CadastroDePacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cadastro_de_PacientesTableAdapter As Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.Cadastro_de_PacientesTableAdapter
    Friend WithEvents AgendaDeConsultasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AgendaDeConsultasBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents AgendaConsultasExcluirBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgendaConsultas_ExcluirTableAdapter As Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.AgendaConsultas_ExcluirTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents DataHoraConsultaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataConsultaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomePacienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
