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
        //private List<Student> listaDetallesDeAlumnos = new List<Student>();
        private int edit = -1;

        private void LimpiarDataGrid(){
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
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnFiltrarDatos = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.pnlContendor = new System.Windows.Forms.Panel();
            this.btnReturnToMainForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.groupBoxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.pnlContendor.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(11, 11);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(150, 110);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Controls.Add(this.btnModificar);
            this.groupBoxFiltro.Controls.Add(this.txtDato);
            this.groupBoxFiltro.Controls.Add(this.lblDatos);
            this.groupBoxFiltro.Controls.Add(this.btnFiltrarDatos);
            this.groupBoxFiltro.Controls.Add(this.cmbFiltro);
            this.groupBoxFiltro.Controls.Add(this.lblFiltro);
            this.groupBoxFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltro.Location = new System.Drawing.Point(269, 137);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(521, 179);
            this.groupBoxFiltro.TabIndex = 11;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Filtrar búsqueda";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(210, 78);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(260, 26);
            this.txtDato.TabIndex = 4;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(47, 84);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(103, 20);
            this.lblDatos.TabIndex = 3;
            this.lblDatos.Text = "Dato a filtrar:";
            // 
            // btnFiltrarDatos
            // 
            this.btnFiltrarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarDatos.Location = new System.Drawing.Point(51, 125);
            this.btnFiltrarDatos.Name = "btnFiltrarDatos";
            this.btnFiltrarDatos.Size = new System.Drawing.Size(150, 35);
            this.btnFiltrarDatos.TabIndex = 0;
            this.btnFiltrarDatos.Text = "Filtrar";
            this.btnFiltrarDatos.UseVisualStyleBackColor = true;
            this.btnFiltrarDatos.Click += new System.EventHandler(this.btnFiltrarDatos_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(210, 33);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(260, 28);
            this.cmbFiltro.TabIndex = 2;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(47, 36);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(80, 20);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "Filtrar por:";
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(479, 56);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(311, 28);
            this.cmbCarreras.TabIndex = 10;
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Location = new System.Drawing.Point(319, 125);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 35);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(265, 59);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(171, 20);
            this.lblCarrera.TabIndex = 9;
            this.lblCarrera.Text = "Seleccione la carrera:";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.Location = new System.Drawing.Point(11, 348);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(1047, 325);
            this.dgvAlumnos.TabIndex = 0;
            // 
            // pnlContendor
            // 
            this.pnlContendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContendor.Controls.Add(this.btnReturnToMainForm);
            this.pnlContendor.Controls.Add(this.groupBoxFiltro);
            this.pnlContendor.Controls.Add(this.dgvAlumnos);
            this.pnlContendor.Controls.Add(this.cmbCarreras);
            this.pnlContendor.Controls.Add(this.imgLogo);
            this.pnlContendor.Controls.Add(this.lblCarrera);
            this.pnlContendor.Location = new System.Drawing.Point(0, 0);
            this.pnlContendor.Name = "pnlContendor";
            this.pnlContendor.Size = new System.Drawing.Size(1071, 687);
            this.pnlContendor.TabIndex = 14;
            // 
            // btnReturnToMainForm
            // 
            this.btnReturnToMainForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainForm.Location = new System.Drawing.Point(1010, 11);
            this.btnReturnToMainForm.Name = "btnReturnToMainForm";
            this.btnReturnToMainForm.Size = new System.Drawing.Size(48, 35);
            this.btnReturnToMainForm.TabIndex = 12;
            this.btnReturnToMainForm.Text = "X";
            this.btnReturnToMainForm.UseVisualStyleBackColor = true;
            this.btnReturnToMainForm.Click += new System.EventHandler(this.btnReturnToMainForm_Click);
            // 
            // ModificarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 686);
            this.Controls.Add(this.pnlContendor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarAlumno";
            this.Text = "ModificarAlumno";
            this.Load += new System.EventHandler(this.ModificarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.pnlContendor.ResumeLayout(false);
            this.pnlContendor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private Panel pnlContendor;
        private Button btnFiltrarDatos;
        private Button btnReturnToMainForm;
    }
}