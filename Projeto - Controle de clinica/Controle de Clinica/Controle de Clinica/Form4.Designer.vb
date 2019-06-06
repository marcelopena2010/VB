<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formVerConsultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formVerConsultas))
        Me.lblData = New System.Windows.Forms.Label()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Controle_ClinicaDataSet1 = New Controle_de_Clinica.Controle_ClinicaDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataHoraConsultaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomePacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Controle_ClinicaDataSet = New Controle_de_Clinica.Controle_ClinicaDataSet()
        Me.DataTable1TableAdapter = New Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.DataTable1TableAdapter()
        CType(Me.Controle_ClinicaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Controle_ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'btnVisualizar
        '
        Me.btnVisualizar.BackColor = System.Drawing.Color.Silver
        Me.btnVisualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisualizar.Image = CType(resources.GetObject("btnVisualizar.Image"), System.Drawing.Image)
        Me.btnVisualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVisualizar.Location = New System.Drawing.Point(254, 31)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(135, 130)
        Me.btnVisualizar.TabIndex = 2
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVisualizar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Silver
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.Location = New System.Drawing.Point(395, 31)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(110, 130)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'Controle_ClinicaDataSet1
        '
        Me.Controle_ClinicaDataSet1.DataSetName = "Controle_ClinicaDataSet"
        Me.Controle_ClinicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataHoraConsultaDataGridViewTextBoxColumn, Me.NomePacienteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DataTable1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 205)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(507, 155)
        Me.DataGridView1.TabIndex = 4
        '
        'DataHoraConsultaDataGridViewTextBoxColumn
        '
        Me.DataHoraConsultaDataGridViewTextBoxColumn.DataPropertyName = "DataHoraConsulta"
        Me.DataHoraConsultaDataGridViewTextBoxColumn.HeaderText = "Data/Hora"
        Me.DataHoraConsultaDataGridViewTextBoxColumn.Name = "DataHoraConsultaDataGridViewTextBoxColumn"
        Me.DataHoraConsultaDataGridViewTextBoxColumn.Width = 150
        '
        'NomePacienteDataGridViewTextBoxColumn
        '
        Me.NomePacienteDataGridViewTextBoxColumn.DataPropertyName = "NomePaciente"
        Me.NomePacienteDataGridViewTextBoxColumn.HeaderText = "Nome do Paciente"
        Me.NomePacienteDataGridViewTextBoxColumn.Name = "NomePacienteDataGridViewTextBoxColumn"
        Me.NomePacienteDataGridViewTextBoxColumn.Width = 280
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Controle_ClinicaDataSet
        '
        'Controle_ClinicaDataSet
        '
        Me.Controle_ClinicaDataSet.DataSetName = "Controle_ClinicaDataSet"
        Me.Controle_ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'formVerConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 372)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.lblData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formVerConsultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Verificar Consultas"
        CType(Me.Controle_ClinicaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Controle_ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnVisualizar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Controle_ClinicaDataSet1 As Controle_de_Clinica.Controle_ClinicaDataSet
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Controle_ClinicaDataSet As Controle_de_Clinica.Controle_ClinicaDataSet
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents DataHoraConsultaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomePacienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
