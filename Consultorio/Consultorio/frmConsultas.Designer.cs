namespace Consultorio
{
    partial class frmConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblIdConsulta;
            System.Windows.Forms.Label lblIdMedico;
            System.Windows.Forms.Label lblidPaciente;
            System.Windows.Forms.Label lblDataConsulta;
            System.Windows.Forms.Label lblHoraIn;
            System.Windows.Forms.Label horaFimLabel;
            System.Windows.Forms.Label lblObs;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.consultorioDataSet = new Consultorio.ConsultorioDataSet();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultasTableAdapter = new Consultorio.ConsultorioDataSetTableAdapters.ConsultasTableAdapter();
            this.tableAdapterManager = new Consultorio.ConsultorioDataSetTableAdapters.TableAdapterManager();
            this.medicosTableAdapter = new Consultorio.ConsultorioDataSetTableAdapters.MedicosTableAdapter();
            this.pacientesTableAdapter = new Consultorio.ConsultorioDataSetTableAdapters.PacientesTableAdapter();
            this.consultasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.cboMedico = new System.Windows.Forms.ComboBox();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboPaciente = new System.Windows.Forms.ComboBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.dtHoraIn = new System.Windows.Forms.DateTimePicker();
            this.dtHoraFim = new System.Windows.Forms.DateTimePicker();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.epErro = new System.Windows.Forms.ErrorProvider(this.components);
            lblIdConsulta = new System.Windows.Forms.Label();
            lblIdMedico = new System.Windows.Forms.Label();
            lblidPaciente = new System.Windows.Forms.Label();
            lblDataConsulta = new System.Windows.Forms.Label();
            lblHoraIn = new System.Windows.Forms.Label();
            horaFimLabel = new System.Windows.Forms.Label();
            lblObs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingNavigator)).BeginInit();
            this.consultasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdConsulta
            // 
            lblIdConsulta.AutoSize = true;
            lblIdConsulta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblIdConsulta.Location = new System.Drawing.Point(12, 37);
            lblIdConsulta.Name = "lblIdConsulta";
            lblIdConsulta.Size = new System.Drawing.Size(54, 17);
            lblIdConsulta.TabIndex = 1;
            lblIdConsulta.Text = "Código";
            // 
            // lblIdMedico
            // 
            lblIdMedico.AutoSize = true;
            lblIdMedico.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblIdMedico.Location = new System.Drawing.Point(12, 71);
            lblIdMedico.Name = "lblIdMedico";
            lblIdMedico.Size = new System.Drawing.Size(117, 17);
            lblIdMedico.TabIndex = 3;
            lblIdMedico.Text = "Nome do Médico";
            // 
            // lblidPaciente
            // 
            lblidPaciente.AutoSize = true;
            lblidPaciente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblidPaciente.Location = new System.Drawing.Point(12, 105);
            lblidPaciente.Name = "lblidPaciente";
            lblidPaciente.Size = new System.Drawing.Size(128, 17);
            lblidPaciente.TabIndex = 5;
            lblidPaciente.Text = "Nome do Paciente";
            // 
            // lblDataConsulta
            // 
            lblDataConsulta.AutoSize = true;
            lblDataConsulta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDataConsulta.Location = new System.Drawing.Point(12, 139);
            lblDataConsulta.Name = "lblDataConsulta";
            lblDataConsulta.Size = new System.Drawing.Size(101, 17);
            lblDataConsulta.TabIndex = 7;
            lblDataConsulta.Text = "Data Consulta";
            // 
            // lblHoraIn
            // 
            lblHoraIn.AutoSize = true;
            lblHoraIn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHoraIn.Location = new System.Drawing.Point(12, 170);
            lblHoraIn.Name = "lblHoraIn";
            lblHoraIn.Size = new System.Drawing.Size(80, 17);
            lblHoraIn.TabIndex = 9;
            lblHoraIn.Text = "Hora Inicio:";
            // 
            // horaFimLabel
            // 
            horaFimLabel.AutoSize = true;
            horaFimLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horaFimLabel.Location = new System.Drawing.Point(12, 200);
            horaFimLabel.Name = "horaFimLabel";
            horaFimLabel.Size = new System.Drawing.Size(74, 17);
            horaFimLabel.TabIndex = 11;
            horaFimLabel.Text = "Hora Final";
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblObs.Location = new System.Drawing.Point(12, 231);
            lblObs.Name = "lblObs";
            lblObs.Size = new System.Drawing.Size(96, 17);
            lblObs.TabIndex = 13;
            lblObs.Text = "Observações";
            // 
            // consultorioDataSet
            // 
            this.consultorioDataSet.DataSetName = "ConsultorioDataSet";
            this.consultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultasBindingSource
            // 
            this.consultasBindingSource.DataMember = "Consultas";
            this.consultasBindingSource.DataSource = this.consultorioDataSet;
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultasTableAdapter = this.consultasTableAdapter;
            this.tableAdapterManager.MedicosTableAdapter = this.medicosTableAdapter;
            this.tableAdapterManager.PacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Consultorio.ConsultorioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // consultasBindingNavigator
            // 
            this.consultasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultasBindingNavigator.BindingSource = this.consultasBindingSource;
            this.consultasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultasBindingNavigator.CountItemFormat = "de {0}";
            this.consultasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.consultasBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.btnFechar});
            this.consultasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultasBindingNavigator.Name = "consultasBindingNavigator";
            this.consultasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultasBindingNavigator.Size = new System.Drawing.Size(474, 25);
            this.consultasBindingNavigator.TabIndex = 0;
            this.consultasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(78, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(61, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // consultasBindingNavigatorSaveItem
            // 
            this.consultasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasBindingNavigatorSaveItem.Image")));
            this.consultasBindingNavigatorSaveItem.Name = "consultasBindingNavigatorSaveItem";
            this.consultasBindingNavigatorSaveItem.Size = new System.Drawing.Size(58, 22);
            this.consultasBindingNavigatorSaveItem.Text = "Salvar";
            this.consultasBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultasBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFechar
            // 
            this.btnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(46, 22);
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Id", true));
            this.idLabel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel1.Location = new System.Drawing.Point(109, 37);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(150, 23);
            this.idLabel1.TabIndex = 2;
            this.idLabel1.Text = "label1";
            // 
            // cboMedico
            // 
            this.cboMedico.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultasBindingSource, "IdMedico", true));
            this.cboMedico.DataSource = this.medicosBindingSource;
            this.cboMedico.DisplayMember = "Nome";
            this.cboMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedico.FormattingEnabled = true;
            this.cboMedico.Location = new System.Drawing.Point(146, 71);
            this.cboMedico.Name = "cboMedico";
            this.cboMedico.Size = new System.Drawing.Size(168, 21);
            this.cboMedico.TabIndex = 1;
            this.cboMedico.ValueMember = "Id";
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.consultorioDataSet;
            // 
            // cboPaciente
            // 
            this.cboPaciente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultasBindingSource, "IdPaciente", true));
            this.cboPaciente.DataSource = this.pacientesBindingSource;
            this.cboPaciente.DisplayMember = "Nome";
            this.cboPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaciente.FormattingEnabled = true;
            this.cboPaciente.Location = new System.Drawing.Point(146, 105);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(168, 21);
            this.cboPaciente.TabIndex = 2;
            this.cboPaciente.ValueMember = "Id";
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.consultorioDataSet;
            // 
            // dtData
            // 
            this.dtData.CustomFormat = "dd/MMM/yyyy";
            this.dtData.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultasBindingSource, "DataConsulta", true));
            this.dtData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "DataConsulta", true));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.Location = new System.Drawing.Point(146, 139);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(104, 20);
            this.dtData.TabIndex = 3;
            // 
            // dtHoraIn
            // 
            this.dtHoraIn.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultasBindingSource, "HoraInicio", true));
            this.dtHoraIn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "HoraInicio", true));
            this.dtHoraIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraIn.Location = new System.Drawing.Point(146, 170);
            this.dtHoraIn.Name = "dtHoraIn";
            this.dtHoraIn.ShowUpDown = true;
            this.dtHoraIn.Size = new System.Drawing.Size(104, 20);
            this.dtHoraIn.TabIndex = 4;
            // 
            // dtHoraFim
            // 
            this.dtHoraFim.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultasBindingSource, "HoraFim", true));
            this.dtHoraFim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "HoraFim", true));
            this.dtHoraFim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraFim.Location = new System.Drawing.Point(146, 200);
            this.dtHoraFim.Name = "dtHoraFim";
            this.dtHoraFim.ShowUpDown = true;
            this.dtHoraFim.Size = new System.Drawing.Size(104, 20);
            this.dtHoraFim.TabIndex = 5;
            // 
            // txtObs
            // 
            this.txtObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Observacoes", true));
            this.txtObs.Location = new System.Drawing.Point(146, 231);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(306, 48);
            this.txtObs.TabIndex = 6;
            // 
            // epErro
            // 
            this.epErro.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epErro.ContainerControl = this;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(474, 281);
            this.Controls.Add(lblIdConsulta);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(lblIdMedico);
            this.Controls.Add(this.cboMedico);
            this.Controls.Add(lblidPaciente);
            this.Controls.Add(this.cboPaciente);
            this.Controls.Add(lblDataConsulta);
            this.Controls.Add(this.dtData);
            this.Controls.Add(lblHoraIn);
            this.Controls.Add(this.dtHoraIn);
            this.Controls.Add(horaFimLabel);
            this.Controls.Add(this.dtHoraFim);
            this.Controls.Add(lblObs);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.consultasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Consultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingNavigator)).EndInit();
            this.consultasBindingNavigator.ResumeLayout(false);
            this.consultasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConsultorioDataSet consultorioDataSet;
        private System.Windows.Forms.BindingSource consultasBindingSource;
        private ConsultorioDataSetTableAdapters.ConsultasTableAdapter consultasTableAdapter;
        private ConsultorioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton consultasBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.ComboBox cboMedico;
        private System.Windows.Forms.ComboBox cboPaciente;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.DateTimePicker dtHoraIn;
        private System.Windows.Forms.DateTimePicker dtHoraFim;
        private System.Windows.Forms.TextBox txtObs;
        private ConsultorioDataSetTableAdapters.MedicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private ConsultorioDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private System.Windows.Forms.ToolStripButton btnFechar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ErrorProvider epErro;
    }
}