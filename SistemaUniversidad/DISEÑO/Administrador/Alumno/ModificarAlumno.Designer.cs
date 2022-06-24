using System.Collections.Generic;
using System.Windows.Forms;
using SistemaUniversidad.LOGICA;


namespace SistemaUniversidad.DISEÑO.Administrador
{
    partial class ModificarAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        string carnet = "";//Almacena el carnet a eliminar
        private List<Alumno> listaRsistemas = new List<Alumno>();
        private List<Alumno> listaRagronomia = new List<Alumno>();
        private List<Alumno> listaRelectrica = new List<Alumno>();
        private List<Alumno> listaRindustrial = new List<Alumno>();
        private int edit = -1;
        public void setAlumSistemas(List<Alumno> listR)
        {
            this.listaRsistemas = listR;
        }
        public void setAlumAgronomia(List<Alumno> listR)
        {
            this.listaRagronomia = listR;
        }
        public void setAlumElectrica(List<Alumno> listR)
        {
            this.listaRelectrica = listR;
        }
        public void setAlumIndustrial(List<Alumno> listR)
        {
            this.listaRindustrial = listR;
        }

        #region Actualizar Data Grid
        private void ActualizarDataSistemas()
        {
            if (listaRsistemas.Count != 0)
            {
                AgregarColumnasDTGV();

                foreach (Alumno item in listaRsistemas)
                {
                    string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                    item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                    item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                    item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                    dgvAlumnos.Rows.Add(registro);
                }
            }
            else
            {
                LimpiarDataGrid();
                MessageBox.Show("NO HAY REGISTRO DE ALUMNOS");
            }
        }
        private void ActualizarDataAgronomia()
        {
            if (listaRagronomia.Count != 0)
            {
                AgregarColumnasDTGV();

                foreach (Alumno item in listaRagronomia)
                {
                    string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                    item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                    item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                    item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                    dgvAlumnos.Rows.Add(registro);
                }
            }
            else
            {
                LimpiarDataGrid();
                MessageBox.Show("NO HAY REGISTRO DE ALUMNOS");
            }
        }
        private void ActualizarDataElectrica()
        {
            if (listaRelectrica.Count != 0)
            {
                AgregarColumnasDTGV();

                foreach (Alumno item in listaRelectrica)
                {
                    string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                    item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                    item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                    item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                    dgvAlumnos.Rows.Add(registro);
                }
            }
            else
            {
                LimpiarDataGrid();
                MessageBox.Show("NO HAY REGISTRO DE ALUMNOS");
            }
        }
        private void ActualizarDataIndustrial()
        {
            if (listaRindustrial.Count != 0)
            {
                AgregarColumnasDTGV();

                foreach (Alumno item in listaRindustrial)
                {
                    string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                    item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                    item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                    item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                    dgvAlumnos.Rows.Add(registro);
                }
            }
            else
            {
                LimpiarDataGrid();
                MessageBox.Show("NO HAY REGISTRO DE ALUMNOS");
            }
        }
        #endregion

        private void LimpiarDataGrid()
        {
            dgvAlumnos.Columns.Clear();
            dgvAlumnos.Rows.Clear();
            dgvAlumnos.DataSource = null;
        }
        private void AgregarColumnasDTGV()
        {
            dgvAlumnos.Columns.Clear();
            dgvAlumnos.Rows.Clear();
            dgvAlumnos.DataSource = null;

            dgvAlumnos.Columns.Add("nombres", "Nombres");
            dgvAlumnos.Columns.Add("primerApellido", "Primer apellido");
            dgvAlumnos.Columns.Add("sgundoApellido", "Segundo apellido");
            dgvAlumnos.Columns.Add("carnet", "Carnet");
            dgvAlumnos.Columns.Add("carrera", "Carrera");
            dgvAlumnos.Columns.Add("contraseña", "Contraseña");
            dgvAlumnos.Columns.Add("matricula", "Matricula N°");
            dgvAlumnos.Columns.Add("fechaNacimiento", "Fecha de nacimiento");
            dgvAlumnos.Columns.Add("documentoIdentidad", "Documento de identidad");
            dgvAlumnos.Columns.Add("sexo", "Sexo");
            dgvAlumnos.Columns.Add("direccion", "Dirección");
            dgvAlumnos.Columns.Add("telefono", "Teléfono");
            dgvAlumnos.Columns.Add("celular", "Celular");
            dgvAlumnos.Columns.Add("correo", "Correo");
            dgvAlumnos.Columns.Add("fechInscriocion", "Fecha de inscripción");
            dgvAlumnos.Columns.Add("nacionalidad", "Nacionalidad");
            dgvAlumnos.Columns.Add("estadoCivil", "Estado civil");
        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarAlumno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.dragControl1 = new SistemaUniversidad.LOGICA.DragControl();
            this.dragControl2 = new SistemaUniversidad.LOGICA.DragControl();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnDescrip = new System.Windows.Forms.Button();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboxFiltros = new System.Windows.Forms.CheckBox();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBoxBotones = new System.Windows.Forms.GroupBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.pnlContendor = new System.Windows.Forms.Panel();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.groupBoxFiltro.SuspendLayout();
            this.groupBoxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Controls.Add(this.lblTítulo);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1011, 35);
            this.pnlSuperior.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(966, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 35);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.ForeColor = System.Drawing.Color.White;
            this.lblTítulo.Location = new System.Drawing.Point(10, 7);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(250, 20);
            this.lblTítulo.TabIndex = 1;
            this.lblTítulo.Text = "MODIFICAR DATOS DE ALUMNOS";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.pnlSuperior;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.lblTítulo;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 51);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(150, 110);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // btnDescrip
            // 
            this.btnDescrip.Enabled = false;
            this.btnDescrip.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnDescrip.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnDescrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescrip.Location = new System.Drawing.Point(261, 60);
            this.btnDescrip.Name = "btnDescrip";
            this.btnDescrip.Size = new System.Drawing.Size(479, 68);
            this.btnDescrip.TabIndex = 2;
            this.btnDescrip.UseVisualStyleBackColor = true;
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.Location = new System.Drawing.Point(283, 74);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(435, 33);
            this.lblDescrip.TabIndex = 3;
            this.lblDescrip.Text = "MODIFICAR DATOS DE ALUMNOS";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Location = new System.Drawing.Point(24, 13);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(151, 52);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "CARGAR DATOS";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Controls.Add(this.txtDato);
            this.groupBoxFiltro.Controls.Add(this.lblDatos);
            this.groupBoxFiltro.Controls.Add(this.cmbFiltro);
            this.groupBoxFiltro.Controls.Add(this.lblFiltro);
            this.groupBoxFiltro.Controls.Add(this.cboxFiltros);
            this.groupBoxFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltro.Location = new System.Drawing.Point(245, 228);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(315, 179);
            this.groupBoxFiltro.TabIndex = 11;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "FILTRAR BUSQUEDA";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(172, 130);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 26);
            this.txtDato.TabIndex = 4;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(6, 133);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(160, 20);
            this.lblDatos.TabIndex = 3;
            this.lblDatos.Text = "Introduzca los datos:";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(149, 82);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(151, 28);
            this.cmbFiltro.TabIndex = 2;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(43, 85);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(101, 20);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "FILTRAR POR:";
            // 
            // cboxFiltros
            // 
            this.cboxFiltros.AutoSize = true;
            this.cboxFiltros.Location = new System.Drawing.Point(109, 37);
            this.cboxFiltros.Name = "cboxFiltros";
            this.cboxFiltros.Size = new System.Drawing.Size(149, 24);
            this.cboxFiltros.TabIndex = 0;
            this.cboxFiltros.Text = "APLICAR FILTROS";
            this.cboxFiltros.UseVisualStyleBackColor = true;
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(443, 166);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(311, 28);
            this.cmbCarreras.TabIndex = 10;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Location = new System.Drawing.Point(24, 123);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(151, 52);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Location = new System.Drawing.Point(24, 68);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(151, 52);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "MODIFICAR REGISTRO";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // groupBoxBotones
            // 
            this.groupBoxBotones.Controls.Add(this.btnRegresar);
            this.groupBoxBotones.Controls.Add(this.btnModificar);
            this.groupBoxBotones.Controls.Add(this.btnActualizar);
            this.groupBoxBotones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBotones.Location = new System.Drawing.Point(579, 228);
            this.groupBoxBotones.Name = "groupBoxBotones";
            this.groupBoxBotones.Size = new System.Drawing.Size(200, 179);
            this.groupBoxBotones.TabIndex = 12;
            this.groupBoxBotones.TabStop = false;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(266, 169);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(171, 20);
            this.lblCarrera.TabIndex = 9;
            this.lblCarrera.Text = "Seleccione la carrera:";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(22, 436);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(968, 242);
            this.dgvAlumnos.TabIndex = 13;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            // 
            // pnlContendor
            // 
            this.pnlContendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContendor.Location = new System.Drawing.Point(0, 0);
            this.pnlContendor.Name = "pnlContendor";
            this.pnlContendor.Size = new System.Drawing.Size(1011, 704);
            this.pnlContendor.TabIndex = 14;
            // 
            // ModificarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 704);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.groupBoxFiltro);
            this.Controls.Add(this.cmbCarreras);
            this.Controls.Add(this.groupBoxBotones);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.btnDescrip);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlContendor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarAlumno";
            this.Text = "ModificarAlumno";
            this.Load += new System.EventHandler(this.ModificarAlumno_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            this.groupBoxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private LOGICA.DragControl dragControl1;
        private System.Windows.Forms.Label lblTítulo;
        private LOGICA.DragControl dragControl2;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnDescrip;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.CheckBox cboxFiltros;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBoxBotones;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private Button btnCerrar;
        private Panel pnlContendor;
    }
}