using System.Collections.Generic;
using System.Windows.Forms;
using SistemaUniversidad.LOGICA;

namespace SistemaUniversidad.DISEÑO.Administrador
{
    partial class BuscarAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarAlumno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dragControlMover = new SistemaUniversidad.LOGICA.DragControl();
            this.dragControlMover2 = new SistemaUniversidad.LOGICA.DragControl();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.btnLoadFilters = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.lbldatos = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnReturnToMainForm = new System.Windows.Forms.Button();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.groupBoxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedor.Controls.Add(this.btnReturnToMainForm);
            this.pnlContenedor.Controls.Add(this.imgLogo);
            this.pnlContenedor.Controls.Add(this.groupBoxFiltro);
            this.pnlContenedor.Controls.Add(this.lblCarrera);
            this.pnlContenedor.Controls.Add(this.cmbCarreras);
            this.pnlContenedor.Controls.Add(this.dgvAlumnos);
            this.pnlContenedor.Location = new System.Drawing.Point(-1, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1072, 688);
            this.pnlContenedor.TabIndex = 21;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 11);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(150, 110);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 26;
            this.imgLogo.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(369, 128);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(139, 35);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Cargar datos";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Controls.Add(this.btnActualizar);
            this.groupBoxFiltro.Controls.Add(this.btnLoadFilters);
            this.groupBoxFiltro.Controls.Add(this.lblFiltro);
            this.groupBoxFiltro.Controls.Add(this.cmbFiltro);
            this.groupBoxFiltro.Controls.Add(this.txtDato);
            this.groupBoxFiltro.Controls.Add(this.lbldatos);
            this.groupBoxFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltro.Location = new System.Drawing.Point(279, 100);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(531, 179);
            this.groupBoxFiltro.TabIndex = 24;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Filtrar datos";
            // 
            // btnLoadFilters
            // 
            this.btnLoadFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadFilters.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFilters.Location = new System.Drawing.Point(28, 132);
            this.btnLoadFilters.Name = "btnLoadFilters";
            this.btnLoadFilters.Size = new System.Drawing.Size(139, 31);
            this.btnLoadFilters.TabIndex = 1;
            this.btnLoadFilters.Text = "Cargar datos";
            this.btnLoadFilters.UseVisualStyleBackColor = true;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(24, 38);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(80, 20);
            this.lblFiltro.TabIndex = 17;
            this.lblFiltro.Text = "Filtrar por:";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(235, 35);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(273, 28);
            this.cmbFiltro.TabIndex = 16;
            // 
            // txtDato
            // 
            this.txtDato.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(235, 83);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(273, 26);
            this.txtDato.TabIndex = 15;
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatos.Location = new System.Drawing.Point(24, 86);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(103, 20);
            this.lbldatos.TabIndex = 14;
            this.lbldatos.Text = "Dato a filtrar:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(275, 41);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(171, 20);
            this.lblCarrera.TabIndex = 23;
            this.lblCarrera.Text = "Seleccione la carrera:";
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(514, 38);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(296, 28);
            this.cmbCarreras.TabIndex = 22;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 336);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(1047, 337);
            this.dgvAlumnos.TabIndex = 21;
            // 
            // btnReturnToMainForm
            // 
            this.btnReturnToMainForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainForm.Location = new System.Drawing.Point(1011, 11);
            this.btnReturnToMainForm.Name = "btnReturnToMainForm";
            this.btnReturnToMainForm.Size = new System.Drawing.Size(48, 35);
            this.btnReturnToMainForm.TabIndex = 27;
            this.btnReturnToMainForm.Text = "X";
            this.btnReturnToMainForm.UseVisualStyleBackColor = true;
            this.btnReturnToMainForm.Click += new System.EventHandler(this.btnReturnToMainForm_Click);
            // 
            // BuscarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 686);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarAlumno";
            this.Load += new System.EventHandler(this.BuscarAlumno_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DragControl dragControlMover;
        private DragControl dragControlMover2;
        private Panel pnlContenedor;
        private PictureBox imgLogo;
        private Button btnActualizar;
        private GroupBox groupBoxFiltro;
        private Button btnLoadFilters;
        private Label lblFiltro;
        private ComboBox cmbFiltro;
        private TextBox txtDato;
        private Label lbldatos;
        private Label lblCarrera;
        private ComboBox cmbCarreras;
        private DataGridView dgvAlumnos;
        private Button btnReturnToMainForm;
    }
}