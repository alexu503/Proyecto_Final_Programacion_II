using System.Collections.Generic;
using System.Windows.Forms;
using SistemaUniversidad.LOGICA;

namespace SistemaUniversidad.DISEÑO.Administrador
{
    partial class EliminarAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        string carnet = "";//Almacena el carnet a eliminar
        //private List<Student> listaRsistemas = new List<Student>();
        //private List<Student> listaRagronomia = new List<Student>();
        //private List<Student> listaRelectrica = new List<Student>();
        //private List<Student> listaRindustrial = new List<Student>();
        private int eliminar = -1;
        //public void setAlumSistemas(List<Student> listR)
        //{
        //    this.listaRsistemas = listR;
        //}
        //public void setAlumAgronomia(List<Student> listR)
        //{
        //    this.listaRagronomia = listR;
        //}
        //public void setAlumElectrica(List<Student> listR)
        //{
        //    this.listaRelectrica = listR;
        //}
        //public void setAlumIndustrial(List<Student> listR)
        //{
        //    this.listaRindustrial = listR;
        //}

        #region Actualizar Data Grid
        //
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarAlumno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnFiltrarDatos = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReturnToMainForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.groupBoxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 11);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(150, 110);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 3;
            this.imgLogo.TabStop = false;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(251, 35);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(171, 20);
            this.lblCarrera.TabIndex = 4;
            this.lblCarrera.Text = "Seleccione la carrera:";
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(568, 32);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(311, 28);
            this.cmbCarreras.TabIndex = 5;
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Controls.Add(this.txtDato);
            this.groupBoxFiltro.Controls.Add(this.btnEliminar);
            this.groupBoxFiltro.Controls.Add(this.lblDatos);
            this.groupBoxFiltro.Controls.Add(this.btnFiltrarDatos);
            this.groupBoxFiltro.Controls.Add(this.cmbFiltro);
            this.groupBoxFiltro.Controls.Add(this.lblFiltro);
            this.groupBoxFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltro.Location = new System.Drawing.Point(255, 97);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(624, 179);
            this.groupBoxFiltro.TabIndex = 6;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Filtrar búsqueda";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(313, 81);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(277, 26);
            this.txtDato.TabIndex = 4;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(28, 87);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(109, 20);
            this.lblDatos.TabIndex = 3;
            this.lblDatos.Text = "Datos a filtrar:";
            this.lblDatos.Click += new System.EventHandler(this.lblDatos_Click);
            // 
            // btnFiltrarDatos
            // 
            this.btnFiltrarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarDatos.Location = new System.Drawing.Point(32, 123);
            this.btnFiltrarDatos.Name = "btnFiltrarDatos";
            this.btnFiltrarDatos.Size = new System.Drawing.Size(135, 30);
            this.btnFiltrarDatos.TabIndex = 0;
            this.btnFiltrarDatos.Text = "Cargar";
            this.btnFiltrarDatos.UseVisualStyleBackColor = true;
            this.btnFiltrarDatos.Click += new System.EventHandler(this.btnFiltrarDatos_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(313, 37);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(277, 28);
            this.cmbFiltro.TabIndex = 2;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(28, 40);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(80, 20);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "Filtrar por:";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 321);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(1047, 352);
            this.dgvAlumnos.TabIndex = 7;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedor.Controls.Add(this.btnReturnToMainForm);
            this.pnlContenedor.Controls.Add(this.imgLogo);
            this.pnlContenedor.Controls.Add(this.dgvAlumnos);
            this.pnlContenedor.Controls.Add(this.lblCarrera);
            this.pnlContenedor.Controls.Add(this.groupBoxFiltro);
            this.pnlContenedor.Controls.Add(this.cmbCarreras);
            this.pnlContenedor.Location = new System.Drawing.Point(-1, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1074, 686);
            this.pnlContenedor.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(455, 123);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 30);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReturnToMainForm
            // 
            this.btnReturnToMainForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainForm.Location = new System.Drawing.Point(1011, 11);
            this.btnReturnToMainForm.Name = "btnReturnToMainForm";
            this.btnReturnToMainForm.Size = new System.Drawing.Size(48, 35);
            this.btnReturnToMainForm.TabIndex = 13;
            this.btnReturnToMainForm.Text = "X";
            this.btnReturnToMainForm.UseVisualStyleBackColor = true;
            this.btnReturnToMainForm.Click += new System.EventHandler(this.btnReturnToMainForm_Click);
            // 
            // EliminarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 686);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarAlumno";
            this.Load += new System.EventHandler(this.EliminarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Panel pnlContenedor;
        private Button btnFiltrarDatos;
        private Button btnEliminar;
        private Button btnReturnToMainForm;
    }
}