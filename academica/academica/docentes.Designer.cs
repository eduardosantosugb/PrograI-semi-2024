namespace academica
{
    partial class docentes
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
            this.lblBuscarDocente = new System.Windows.Forms.Label();
            this.txtBuscarDocente = new System.Windows.Forms.TextBox();
            this.grdDatosDocente = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEdicionDocente = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.btnModificarDocente = new System.Windows.Forms.Button();
            this.btnNuevoDocente = new System.Windows.Forms.Button();
            this.grbNavegacionDocente = new System.Windows.Forms.GroupBox();
            this.lblRegistrosDocente = new System.Windows.Forms.Label();
            this.btnUltimoDocente = new System.Windows.Forms.Button();
            this.btnSiguienteDocente = new System.Windows.Forms.Button();
            this.btnAnteriorDocente = new System.Windows.Forms.Button();
            this.btnPrimeroDocente = new System.Windows.Forms.Button();
            this.grbDatosDocente = new System.Windows.Forms.GroupBox();
            this.CboxEspecialidadesDocente = new System.Windows.Forms.ComboBox();
            this.lblEspecialidadDocente = new System.Windows.Forms.Label();
            this.txtGmailDocente = new System.Windows.Forms.TextBox();
            this.lblGmailDocente = new System.Windows.Forms.Label();
            this.lblDuiDocente = new System.Windows.Forms.Label();
            this.txtDuiDocente = new System.Windows.Forms.TextBox();
            this.lblTelefonoDocente = new System.Windows.Forms.Label();
            this.txtTelefonoDocente = new System.Windows.Forms.TextBox();
            this.lblDireccionDocente = new System.Windows.Forms.Label();
            this.txtDireccionDocente = new System.Windows.Forms.TextBox();
            this.lblNombreDocente = new System.Windows.Forms.Label();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.lblCodigoDocente = new System.Windows.Forms.Label();
            this.txtCodigoDocente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDocente)).BeginInit();
            this.grbEdicionDocente.SuspendLayout();
            this.grbNavegacionDocente.SuspendLayout();
            this.grbDatosDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarDocente
            // 
            this.lblBuscarDocente.AutoSize = true;
            this.lblBuscarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarDocente.Location = new System.Drawing.Point(574, 45);
            this.lblBuscarDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarDocente.Name = "lblBuscarDocente";
            this.lblBuscarDocente.Size = new System.Drawing.Size(117, 29);
            this.lblBuscarDocente.TabIndex = 20;
            this.lblBuscarDocente.Text = "BUSCAR:";
            // 
            // txtBuscarDocente
            // 
            this.txtBuscarDocente.Location = new System.Drawing.Point(711, 45);
            this.txtBuscarDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarDocente.Name = "txtBuscarDocente";
            this.txtBuscarDocente.Size = new System.Drawing.Size(461, 22);
            this.txtBuscarDocente.TabIndex = 21;
            this.txtBuscarDocente.TextChanged += new System.EventHandler(this.txtBuscarDocente_TextChanged);
            this.txtBuscarDocente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarDocente_KeyUp_1);
            // 
            // grdDatosDocente
            // 
            this.grdDatosDocente.AllowUserToAddRows = false;
            this.grdDatosDocente.AllowUserToDeleteRows = false;
            this.grdDatosDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.grdDatosDocente.Location = new System.Drawing.Point(579, 91);
            this.grdDatosDocente.Margin = new System.Windows.Forms.Padding(4);
            this.grdDatosDocente.Name = "grdDatosDocente";
            this.grdDatosDocente.ReadOnly = true;
            this.grdDatosDocente.RowHeadersWidth = 51;
            this.grdDatosDocente.Size = new System.Drawing.Size(579, 310);
            this.grdDatosDocente.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idAlumno";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "CODIGO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "DIRECCION";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "TELEFONO";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // grbEdicionDocente
            // 
            this.grbEdicionDocente.Controls.Add(this.btnEliminarDocente);
            this.grbEdicionDocente.Controls.Add(this.btnModificarDocente);
            this.grbEdicionDocente.Controls.Add(this.btnNuevoDocente);
            this.grbEdicionDocente.Location = new System.Drawing.Point(340, 440);
            this.grbEdicionDocente.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicionDocente.Name = "grbEdicionDocente";
            this.grbEdicionDocente.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicionDocente.Size = new System.Drawing.Size(392, 71);
            this.grbEdicionDocente.TabIndex = 18;
            this.grbEdicionDocente.TabStop = false;
            this.grbEdicionDocente.Text = "Navegacion";
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocente.Location = new System.Drawing.Point(252, 23);
            this.btnEliminarDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(129, 47);
            this.btnEliminarDocente.TabIndex = 6;
            this.btnEliminarDocente.Text = "Eliminar";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click);
            // 
            // btnModificarDocente
            // 
            this.btnModificarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDocente.Location = new System.Drawing.Point(116, 23);
            this.btnModificarDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarDocente.Name = "btnModificarDocente";
            this.btnModificarDocente.Size = new System.Drawing.Size(139, 47);
            this.btnModificarDocente.TabIndex = 5;
            this.btnModificarDocente.Text = "Modificar";
            this.btnModificarDocente.UseVisualStyleBackColor = true;
            this.btnModificarDocente.Click += new System.EventHandler(this.btnModificarDocente_Click);
            // 
            // btnNuevoDocente
            // 
            this.btnNuevoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDocente.Location = new System.Drawing.Point(8, 23);
            this.btnNuevoDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoDocente.Name = "btnNuevoDocente";
            this.btnNuevoDocente.Size = new System.Drawing.Size(111, 47);
            this.btnNuevoDocente.TabIndex = 4;
            this.btnNuevoDocente.Text = "Nuevo";
            this.btnNuevoDocente.UseVisualStyleBackColor = true;
            this.btnNuevoDocente.Click += new System.EventHandler(this.btnNuevoDocente_Click);
            // 
            // grbNavegacionDocente
            // 
            this.grbNavegacionDocente.Controls.Add(this.lblRegistrosDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnUltimoDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnSiguienteDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnAnteriorDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnPrimeroDocente);
            this.grbNavegacionDocente.Location = new System.Drawing.Point(29, 442);
            this.grbNavegacionDocente.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacionDocente.Name = "grbNavegacionDocente";
            this.grbNavegacionDocente.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacionDocente.Size = new System.Drawing.Size(284, 71);
            this.grbNavegacionDocente.TabIndex = 17;
            this.grbNavegacionDocente.TabStop = false;
            this.grbNavegacionDocente.Text = "Navegacion";
            // 
            // lblRegistrosDocente
            // 
            this.lblRegistrosDocente.AutoSize = true;
            this.lblRegistrosDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosDocente.Location = new System.Drawing.Point(101, 30);
            this.lblRegistrosDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosDocente.Name = "lblRegistrosDocente";
            this.lblRegistrosDocente.Size = new System.Drawing.Size(77, 29);
            this.lblRegistrosDocente.TabIndex = 10;
            this.lblRegistrosDocente.Text = "x de n";
            // 
            // btnUltimoDocente
            // 
            this.btnUltimoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoDocente.Location = new System.Drawing.Point(229, 17);
            this.btnUltimoDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimoDocente.Name = "btnUltimoDocente";
            this.btnUltimoDocente.Size = new System.Drawing.Size(47, 47);
            this.btnUltimoDocente.TabIndex = 3;
            this.btnUltimoDocente.Text = ">|";
            this.btnUltimoDocente.UseVisualStyleBackColor = true;
            this.btnUltimoDocente.Click += new System.EventHandler(this.btnUltimoDocente_Click);
            // 
            // btnSiguienteDocente
            // 
            this.btnSiguienteDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDocente.Location = new System.Drawing.Point(185, 17);
            this.btnSiguienteDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteDocente.Name = "btnSiguienteDocente";
            this.btnSiguienteDocente.Size = new System.Drawing.Size(47, 47);
            this.btnSiguienteDocente.TabIndex = 2;
            this.btnSiguienteDocente.Text = ">";
            this.btnSiguienteDocente.UseVisualStyleBackColor = true;
            this.btnSiguienteDocente.Click += new System.EventHandler(this.btnSiguienteDocente_Click);
            // 
            // btnAnteriorDocente
            // 
            this.btnAnteriorDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorDocente.Location = new System.Drawing.Point(53, 22);
            this.btnAnteriorDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorDocente.Name = "btnAnteriorDocente";
            this.btnAnteriorDocente.Size = new System.Drawing.Size(47, 47);
            this.btnAnteriorDocente.TabIndex = 1;
            this.btnAnteriorDocente.Text = "<";
            this.btnAnteriorDocente.UseVisualStyleBackColor = true;
            this.btnAnteriorDocente.Click += new System.EventHandler(this.btnAnteriorDocente_Click);
            // 
            // btnPrimeroDocente
            // 
            this.btnPrimeroDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroDocente.Location = new System.Drawing.Point(9, 22);
            this.btnPrimeroDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeroDocente.Name = "btnPrimeroDocente";
            this.btnPrimeroDocente.Size = new System.Drawing.Size(47, 47);
            this.btnPrimeroDocente.TabIndex = 0;
            this.btnPrimeroDocente.Text = "|<";
            this.btnPrimeroDocente.UseVisualStyleBackColor = true;
            this.btnPrimeroDocente.Click += new System.EventHandler(this.btnPrimeroDocente_Click);
            // 
            // grbDatosDocente
            // 
            this.grbDatosDocente.Controls.Add(this.CboxEspecialidadesDocente);
            this.grbDatosDocente.Controls.Add(this.lblEspecialidadDocente);
            this.grbDatosDocente.Controls.Add(this.txtGmailDocente);
            this.grbDatosDocente.Controls.Add(this.lblGmailDocente);
            this.grbDatosDocente.Controls.Add(this.lblDuiDocente);
            this.grbDatosDocente.Controls.Add(this.txtDuiDocente);
            this.grbDatosDocente.Controls.Add(this.lblTelefonoDocente);
            this.grbDatosDocente.Controls.Add(this.txtTelefonoDocente);
            this.grbDatosDocente.Controls.Add(this.lblDireccionDocente);
            this.grbDatosDocente.Controls.Add(this.txtDireccionDocente);
            this.grbDatosDocente.Controls.Add(this.lblNombreDocente);
            this.grbDatosDocente.Controls.Add(this.txtNombreDocente);
            this.grbDatosDocente.Controls.Add(this.lblCodigoDocente);
            this.grbDatosDocente.Controls.Add(this.txtCodigoDocente);
            this.grbDatosDocente.Enabled = false;
            this.grbDatosDocente.Location = new System.Drawing.Point(29, 31);
            this.grbDatosDocente.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatosDocente.Name = "grbDatosDocente";
            this.grbDatosDocente.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatosDocente.Size = new System.Drawing.Size(520, 360);
            this.grbDatosDocente.TabIndex = 16;
            this.grbDatosDocente.TabStop = false;
            this.grbDatosDocente.Text = "Datos Docente";
            this.grbDatosDocente.Enter += new System.EventHandler(this.grbDatosDocente_Enter);
            // 
            // CboxEspecialidadesDocente
            // 
            this.CboxEspecialidadesDocente.FormattingEnabled = true;
            this.CboxEspecialidadesDocente.Items.AddRange(new object[] {
            "Informatico",
            "Contador",
            "Matematico",
            "Abogado",
            "Salud"});
            this.CboxEspecialidadesDocente.Location = new System.Drawing.Point(201, 325);
            this.CboxEspecialidadesDocente.Name = "CboxEspecialidadesDocente";
            this.CboxEspecialidadesDocente.Size = new System.Drawing.Size(121, 24);
            this.CboxEspecialidadesDocente.TabIndex = 14;
            // 
            // lblEspecialidadDocente
            // 
            this.lblEspecialidadDocente.AutoSize = true;
            this.lblEspecialidadDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadDocente.Location = new System.Drawing.Point(41, 320);
            this.lblEspecialidadDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidadDocente.Name = "lblEspecialidadDocente";
            this.lblEspecialidadDocente.Size = new System.Drawing.Size(153, 29);
            this.lblEspecialidadDocente.TabIndex = 13;
            this.lblEspecialidadDocente.Text = "Especalidad:";
            // 
            // txtGmailDocente
            // 
            this.txtGmailDocente.Location = new System.Drawing.Point(175, 279);
            this.txtGmailDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtGmailDocente.Name = "txtGmailDocente";
            this.txtGmailDocente.Size = new System.Drawing.Size(132, 22);
            this.txtGmailDocente.TabIndex = 11;
            // 
            // lblGmailDocente
            // 
            this.lblGmailDocente.AutoSize = true;
            this.lblGmailDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmailDocente.Location = new System.Drawing.Point(41, 272);
            this.lblGmailDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGmailDocente.Name = "lblGmailDocente";
            this.lblGmailDocente.Size = new System.Drawing.Size(82, 29);
            this.lblGmailDocente.TabIndex = 10;
            this.lblGmailDocente.Text = "Gmail:";
            // 
            // lblDuiDocente
            // 
            this.lblDuiDocente.AutoSize = true;
            this.lblDuiDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuiDocente.Location = new System.Drawing.Point(46, 233);
            this.lblDuiDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuiDocente.Name = "lblDuiDocente";
            this.lblDuiDocente.Size = new System.Drawing.Size(55, 29);
            this.lblDuiDocente.TabIndex = 9;
            this.lblDuiDocente.Text = "Dui:";
            // 
            // txtDuiDocente
            // 
            this.txtDuiDocente.Location = new System.Drawing.Point(175, 240);
            this.txtDuiDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuiDocente.Name = "txtDuiDocente";
            this.txtDuiDocente.Size = new System.Drawing.Size(132, 22);
            this.txtDuiDocente.TabIndex = 8;
            // 
            // lblTelefonoDocente
            // 
            this.lblTelefonoDocente.AutoSize = true;
            this.lblTelefonoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoDocente.Location = new System.Drawing.Point(41, 191);
            this.lblTelefonoDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoDocente.Name = "lblTelefonoDocente";
            this.lblTelefonoDocente.Size = new System.Drawing.Size(116, 29);
            this.lblTelefonoDocente.TabIndex = 7;
            this.lblTelefonoDocente.Text = "Telefono:";
            // 
            // txtTelefonoDocente
            // 
            this.txtTelefonoDocente.Location = new System.Drawing.Point(175, 196);
            this.txtTelefonoDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoDocente.Name = "txtTelefonoDocente";
            this.txtTelefonoDocente.Size = new System.Drawing.Size(132, 22);
            this.txtTelefonoDocente.TabIndex = 6;
            this.txtTelefonoDocente.TextChanged += new System.EventHandler(this.txtTelefonoDocente_TextChanged);
            // 
            // lblDireccionDocente
            // 
            this.lblDireccionDocente.AutoSize = true;
            this.lblDireccionDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionDocente.Location = new System.Drawing.Point(41, 143);
            this.lblDireccionDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionDocente.Name = "lblDireccionDocente";
            this.lblDireccionDocente.Size = new System.Drawing.Size(121, 29);
            this.lblDireccionDocente.TabIndex = 5;
            this.lblDireccionDocente.Text = "Direccion:";
            // 
            // txtDireccionDocente
            // 
            this.txtDireccionDocente.Location = new System.Drawing.Point(175, 148);
            this.txtDireccionDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionDocente.Name = "txtDireccionDocente";
            this.txtDireccionDocente.Size = new System.Drawing.Size(333, 22);
            this.txtDireccionDocente.TabIndex = 4;
            // 
            // lblNombreDocente
            // 
            this.lblNombreDocente.AutoSize = true;
            this.lblNombreDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDocente.Location = new System.Drawing.Point(41, 94);
            this.lblNombreDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDocente.Name = "lblNombreDocente";
            this.lblNombreDocente.Size = new System.Drawing.Size(107, 29);
            this.lblNombreDocente.TabIndex = 3;
            this.lblNombreDocente.Text = "Nombre:";
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(175, 98);
            this.txtNombreDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(333, 22);
            this.txtNombreDocente.TabIndex = 2;
            // 
            // lblCodigoDocente
            // 
            this.lblCodigoDocente.AutoSize = true;
            this.lblCodigoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDocente.Location = new System.Drawing.Point(41, 46);
            this.lblCodigoDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoDocente.Name = "lblCodigoDocente";
            this.lblCodigoDocente.Size = new System.Drawing.Size(98, 29);
            this.lblCodigoDocente.TabIndex = 1;
            this.lblCodigoDocente.Text = "Codigo:";
            // 
            // txtCodigoDocente
            // 
            this.txtCodigoDocente.Location = new System.Drawing.Point(175, 50);
            this.txtCodigoDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoDocente.Name = "txtCodigoDocente";
            this.txtCodigoDocente.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoDocente.TabIndex = 0;
            this.txtCodigoDocente.TextChanged += new System.EventHandler(this.txtCodigoDocente_TextChanged);
            // 
            // docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 588);
            this.Controls.Add(this.lblBuscarDocente);
            this.Controls.Add(this.txtBuscarDocente);
            this.Controls.Add(this.grdDatosDocente);
            this.Controls.Add(this.grbEdicionDocente);
            this.Controls.Add(this.grbNavegacionDocente);
            this.Controls.Add(this.grbDatosDocente);
            this.Name = "docentes";
            this.Text = "docentes";
            this.Load += new System.EventHandler(this.docentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDocente)).EndInit();
            this.grbEdicionDocente.ResumeLayout(false);
            this.grbNavegacionDocente.ResumeLayout(false);
            this.grbNavegacionDocente.PerformLayout();
            this.grbDatosDocente.ResumeLayout(false);
            this.grbDatosDocente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBuscarDocente;
        private System.Windows.Forms.TextBox txtBuscarDocente;
        private System.Windows.Forms.DataGridView grdDatosDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox grbEdicionDocente;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.Button btnModificarDocente;
        private System.Windows.Forms.Button btnNuevoDocente;
        private System.Windows.Forms.GroupBox grbNavegacionDocente;
        private System.Windows.Forms.Label lblRegistrosDocente;
        private System.Windows.Forms.Button btnUltimoDocente;
        private System.Windows.Forms.Button btnSiguienteDocente;
        private System.Windows.Forms.Button btnAnteriorDocente;
        private System.Windows.Forms.Button btnPrimeroDocente;
        private System.Windows.Forms.GroupBox grbDatosDocente;
        private System.Windows.Forms.Label lblEspecialidadDocente;
        private System.Windows.Forms.TextBox txtGmailDocente;
        private System.Windows.Forms.Label lblGmailDocente;
        private System.Windows.Forms.Label lblDuiDocente;
        private System.Windows.Forms.TextBox txtDuiDocente;
        private System.Windows.Forms.Label lblTelefonoDocente;
        private System.Windows.Forms.TextBox txtTelefonoDocente;
        private System.Windows.Forms.Label lblDireccionDocente;
        private System.Windows.Forms.TextBox txtDireccionDocente;
        private System.Windows.Forms.Label lblNombreDocente;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.Label lblCodigoDocente;
        private System.Windows.Forms.TextBox txtCodigoDocente;
        private System.Windows.Forms.ComboBox CboxEspecialidadesDocente;
    }
}