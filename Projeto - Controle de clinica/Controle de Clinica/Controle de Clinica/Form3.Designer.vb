<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCadPacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCadPacientes))
        Dim CodigoPacienteLabel As System.Windows.Forms.Label
        Dim NomePacienteLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim Numero_RGLabel As System.Windows.Forms.Label
        Dim Numero_CPFLabel As System.Windows.Forms.Label
        Dim DataNascimentoLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Me.Controle_ClinicaDataSet = New Controle_de_Clinica.Controle_ClinicaDataSet()
        Me.Cadastro_de_PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cadastro_de_PacientesTableAdapter = New Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.Cadastro_de_PacientesTableAdapter()
        Me.TableAdapterManager = New Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.TableAdapterManager()
        Me.Cadastro_de_PacientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Cadastro_de_PacientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoPacienteLabel1 = New System.Windows.Forms.Label()
        Me.NomePacienteTextBox = New System.Windows.Forms.TextBox()
        Me.SexoTextBox = New System.Windows.Forms.TextBox()
        Me.Numero_RGTextBox = New System.Windows.Forms.TextBox()
        Me.Numero_CPFTextBox = New System.Windows.Forms.TextBox()
        Me.DataNascimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        CodigoPacienteLabel = New System.Windows.Forms.Label()
        NomePacienteLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        Numero_RGLabel = New System.Windows.Forms.Label()
        Numero_CPFLabel = New System.Windows.Forms.Label()
        DataNascimentoLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        ComplementoLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        CType(Me.Controle_ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cadastro_de_PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cadastro_de_PacientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cadastro_de_PacientesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Controle_ClinicaDataSet
        '
        Me.Controle_ClinicaDataSet.DataSetName = "Controle_ClinicaDataSet"
        Me.Controle_ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cadastro_de_PacientesBindingSource
        '
        Me.Cadastro_de_PacientesBindingSource.DataMember = "Cadastro de Pacientes"
        Me.Cadastro_de_PacientesBindingSource.DataSource = Me.Controle_ClinicaDataSet
        '
        'Cadastro_de_PacientesTableAdapter
        '
        Me.Cadastro_de_PacientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Agenda_de_ConsultasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Cadastro_de_ConveniosTableAdapter = Nothing
        Me.TableAdapterManager.Cadastro_de_PacientesTableAdapter = Me.Cadastro_de_PacientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Cadastro_de_PacientesBindingNavigator
        '
        Me.Cadastro_de_PacientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Cadastro_de_PacientesBindingNavigator.BindingSource = Me.Cadastro_de_PacientesBindingSource
        Me.Cadastro_de_PacientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Cadastro_de_PacientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Cadastro_de_PacientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Cadastro_de_PacientesBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.Cadastro_de_PacientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Cadastro_de_PacientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Cadastro_de_PacientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Cadastro_de_PacientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Cadastro_de_PacientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Cadastro_de_PacientesBindingNavigator.Name = "Cadastro_de_PacientesBindingNavigator"
        Me.Cadastro_de_PacientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Cadastro_de_PacientesBindingNavigator.Size = New System.Drawing.Size(544, 25)
        Me.Cadastro_de_PacientesBindingNavigator.TabIndex = 0
        Me.Cadastro_de_PacientesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Cadastro_de_PacientesBindingNavigatorSaveItem
        '
        Me.Cadastro_de_PacientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cadastro_de_PacientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("Cadastro_de_PacientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Cadastro_de_PacientesBindingNavigatorSaveItem.Name = "Cadastro_de_PacientesBindingNavigatorSaveItem"
        Me.Cadastro_de_PacientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Cadastro_de_PacientesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CodigoPacienteLabel
        '
        CodigoPacienteLabel.AutoSize = True
        CodigoPacienteLabel.Location = New System.Drawing.Point(12, 44)
        CodigoPacienteLabel.Name = "CodigoPacienteLabel"
        CodigoPacienteLabel.Size = New System.Drawing.Size(88, 13)
        CodigoPacienteLabel.TabIndex = 1
        CodigoPacienteLabel.Text = "Codigo Paciente:"
        '
        'CodigoPacienteLabel1
        '
        Me.CodigoPacienteLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cadastro_de_PacientesBindingSource, "CodigoPaciente", True))
        Me.CodigoPacienteLabel1.Location = New System.Drawing.Point(110, 44)
        Me.CodigoPacienteLabel1.Name = "CodigoPacienteLabel1"
        Me.CodigoPacienteLabel1.Size = New System.Drawing.Size(200, 23)
        Me.CodigoPacienteLabel1.TabIndex = 2
        '
        'NomePacienteLabel
        '
        NomePacienteLabel.AutoSize = True
        NomePacienteLabel.Location = New System.Drawing.Point(12, 73)
        NomePacienteLabel.Name = "NomePacienteLabel"
        NomePacienteLabel.Size = New System.Drawing.Size(83, 13)
        NomePacienteLabel.TabIndex = 3
        NomePacienteLabel.Text = "Nome Paciente:"
        '
        'NomePacienteTextBox
        '
        Me.NomePacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cadastro_de_PacientesBindingSource, "NomePaciente", True))
        Me.NomePacienteTextBox.Location = New System.Drawing.Point(111, 70)
        Me.NomePacienteTextBox.Name = "NomePacienteTextBox"
        Me.NomePacienteTextBox.Size = New System.Drawing.Size(361, 20)
        Me.NomePacienteTextBox.TabIndex = 4
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(12, 99)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(76, 13)
        SexoLabel.TabIndex = 5
        SexoLabel.Text = "Sexo: (F ou M)"
        '
        'SexoTextBox
        '
        Me.SexoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cadastro_de_PacientesBindingSource, "Sexo", True))
        Me.SexoTextBox.Location = New System.Drawing.Point(110, 96)
        Me.SexoTextBox.Name = "SexoTextBox"
        Me.SexoTextBox.Size = New System.Drawing.Size(35, 20)
        Me.SexoTextBox.TabIndex = 6
        '
        'Numero_RGLabel
        '
        Numero_RGLabel.AutoSize = True
        Numero_RGLabel.Location = New System.Drawing.Point(12, 125)
        Numero_RGLabel.Name = "Numero_RGLabel"
        Numero_RGLabel.Size = New System.Drawing.Size(66, 13)
        Numero_RGLabel.TabIndex = 7
        Numero_RGLabel.Text = "Numero RG:"
        '
        'Numero_RGTextBox
        '
        Me.Numero_RGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cadastro_de_PacientesBindingSource, "Numero_RG", True))
        Me.Numero_RGTextBox.Location = New System.Drawing.Point(110, 122)
        Me.Numero_RGTextBox.Name = "Numero_RGTextBox"
        Me.Numero_RGTextBox.Size = New System.Drawing.Size(139, 20)
        Me.Numero_RGTextBox.TabIndex = 8
        '
        'Numero_CPFLabel
        '
        Numero_CPFLabel.AutoSize = True
        Numero_CPFLabel.Location = New System.Drawing.Point(268, 129)
        Numero_CPFLabel.Name = "Numero_CPFLabel"
        Numero_CPFLabel.Size = New System.Drawing.Size(70, 13)
        Numero_CPFLabel.TabIndex = 9
        Numero_CPFLabel.Text = "Numero CPF:"
        '
        'Numero_CPFTextBox
        '
        Me.Numero_CPFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cadastro_de_PacientesBindingSource, "Numero_CPF", True))
        Me.Numero_CPFTextBox.Location = New System.Drawing.Point(345, 129)
        Me.Numero_CPFTextBox.Name = "Numero_CPFTextBox"
        Me.Numero_CPFTextBox.Size = New System.Drawing.Size(127, 20)
        Me.Numero_CPFTextBox.TabIndex = 10
        '
        'DataNascimentoLabel
        '
        DataNascimentoLabel.AutoSize = True
        DataNascimentoLabel.Location = New System.Drawing.Point(12, 157)
        DataNascimentoLabel.Name = "DataNascimentoLabel"
        DataNascimentoLabel.Size = New System.Drawing.Size(92, 13)
        DataNascimentoLabel.TabIndex = 11
        DataNascimentoLabel.Text = "Data Nascimento:"
        '
        'DataNascimentoDateTimePicker
        '
        Me.DataNascimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Cadastro_de_PacientesBindingSource, "DataNascimento", True))
        Me.DataNascimentoDateTimePicker.Location = New System.Drawing.Point(110, 153)
        Me.DataNascimentoDateTimePicker.Name = "DataNascimentoDateTimePicker"
        Me.DataNascimentoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataNascimentoDateTimePicker.TabIndex = 12
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(12, 181)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 13
        EnderecoLabel.Text = "Endereco:"
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cadastro_de_PacientesBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(112, 178)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(218, 20)
        Me.EnderecoTextBox.TabIndex = 14
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Location = New System.Drawing.Point(356, 181)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(47, 13)
        NumeroLabel.TabIndex = 15
        NumeroLabel.Text = "Numero:"
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cadastro_de_PacientesBindingSource, "Numero", True))
        Me.NumeroTextBox.Location = New System.Drawing.Point(409, 178)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(63, 20)
        Me.NumeroTextBox.TabIndex = 16
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Location = New System.Drawing.Point(12, 204)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(74, 13)
        ComplementoLabel.TabIndex = 17
        ComplementoLabel.Text = "Complemento:"
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cadastro_de_PacientesBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Location = New System.Drawing.Point(112, 201)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(137, 20)
        Me.ComplementoTextBox.TabIndex = 18
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(12, 229)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(37, 13)
        BairroLabel.TabIndex = 19
        BairroLabel.Text = "Bairro:"
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cadastro_de_PacientesBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(110, 226)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BairroTextBox.TabIndex = 20
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(12, 252)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(43, 13)
        CidadeLabel.TabIndex = 21
        CidadeLabel.Text = "Cidade:"
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cadastro_de_PacientesBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(110, 249)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(220, 20)
        Me.CidadeTextBox.TabIndex = 22
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(348, 252)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 23
        EstadoLabel.Text = "Estado:"
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cadastro_de_PacientesBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(410, 249)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(62, 20)
        Me.EstadoTextBox.TabIndex = 24
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(12, 279)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneLabel.TabIndex = 25
        TelefoneLabel.Text = "Telefone:"
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cadastro_de_PacientesBindingSource, "Telefone", True))
        Me.TelefoneTextBox.Location = New System.Drawing.Point(110, 276)
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(139, 20)
        Me.TelefoneTextBox.TabIndex = 26
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(268, 279)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(42, 13)
        CelularLabel.TabIndex = 27
        CelularLabel.Text = "Celular:"
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cadastro_de_PacientesBindingSource, "Celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(333, 276)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(139, 20)
        Me.CelularTextBox.TabIndex = 28
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Fechar Janela"
        '
        'formCadPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 421)
        Me.Controls.Add(CodigoPacienteLabel)
        Me.Controls.Add(Me.CodigoPacienteLabel1)
        Me.Controls.Add(NomePacienteLabel)
        Me.Controls.Add(Me.NomePacienteTextBox)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(Me.SexoTextBox)
        Me.Controls.Add(Numero_RGLabel)
        Me.Controls.Add(Me.Numero_RGTextBox)
        Me.Controls.Add(Numero_CPFLabel)
        Me.Controls.Add(Me.Numero_CPFTextBox)
        Me.Controls.Add(DataNascimentoLabel)
        Me.Controls.Add(Me.DataNascimentoDateTimePicker)
        Me.Controls.Add(EnderecoLabel)
        Me.Controls.Add(Me.EnderecoTextBox)
        Me.Controls.Add(NumeroLabel)
        Me.Controls.Add(Me.NumeroTextBox)
        Me.Controls.Add(ComplementoLabel)
        Me.Controls.Add(Me.ComplementoTextBox)
        Me.Controls.Add(BairroLabel)
        Me.Controls.Add(Me.BairroTextBox)
        Me.Controls.Add(CidadeLabel)
        Me.Controls.Add(Me.CidadeTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(Me.TelefoneTextBox)
        Me.Controls.Add(CelularLabel)
        Me.Controls.Add(Me.CelularTextBox)
        Me.Controls.Add(Me.Cadastro_de_PacientesBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formCadPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastro de Pacientes"
        CType(Me.Controle_ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cadastro_de_PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cadastro_de_PacientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cadastro_de_PacientesBindingNavigator.ResumeLayout(False)
        Me.Cadastro_de_PacientesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Controle_ClinicaDataSet As Controle_de_Clinica.Controle_ClinicaDataSet
    Friend WithEvents Cadastro_de_PacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cadastro_de_PacientesTableAdapter As Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.Cadastro_de_PacientesTableAdapter
    Friend WithEvents TableAdapterManager As Controle_de_Clinica.Controle_ClinicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cadastro_de_PacientesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Cadastro_de_PacientesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoPacienteLabel1 As System.Windows.Forms.Label
    Friend WithEvents NomePacienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Numero_RGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Numero_CPFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataNascimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EnderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComplementoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
End Class
