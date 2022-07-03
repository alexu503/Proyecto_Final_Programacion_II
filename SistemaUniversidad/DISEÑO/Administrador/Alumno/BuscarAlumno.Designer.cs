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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarAlumno));
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dragControlMover = new SistemaUniversidad.LOGICA.DragControl();
            this.dragControlMover2 = new SistemaUniversidad.LOGICA.DragControl();
            this.btnDescrip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldatos = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.groupBoxBotones = new System.Windows.Forms.GroupBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnLoadFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.groupBoxFiltro.SuspendLayout();
            this.groupBoxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(28, 454);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(968, 242);
            this.dgvAlumnos.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(15, 19);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(139, 52);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Cargar datos";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(15, 77);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(139, 52);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(442, 165);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(296, 28);
            this.cmbCarreras.TabIndex = 3;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(265, 168);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(171, 20);
            this.lblCarrera.TabIndex = 4;
            this.lblCarrera.Text = "Seleccione la carrera:";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlSuperior.Controls.Add(this.lblTitulo);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1027, 35);
            this.pnlSuperior.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "BUSCAR ALUMNO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(982, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 35);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dragControlMover
            // 
            this.dragControlMover.SelectControl = this.pnlSuperior;
            // 
            // dragControlMover2
            // 
            this.dragControlMover2.SelectControl = this.lblTitulo;
            // 
            // btnDescrip
            // 
            this.btnDescrip.Enabled = false;
            this.btnDescrip.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnDescrip.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnDescrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescrip.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescrip.Location = new System.Drawing.Point(354, 67);
            this.btnDescrip.Name = "btnDescrip";
            this.btnDescrip.Size = new System.Drawing.Size(296, 55);
            this.btnDescrip.TabIndex = 12;
            this.btnDescrip.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "BUSCAR ALUMNO";
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatos.Location = new System.Drawing.Point(5, 86);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(160, 20);
            this.lbldatos.TabIndex = 14;
            this.lbldatos.Text = "Introduzca los datos:";
            // 
            // txtDato
            // 
            this.txtDato.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(171, 83);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(126, 26);
            this.txtDato.TabIndex = 15;
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Controls.Add(this.btnLoadFilters);
            this.groupBoxFiltro.Controls.Add(this.lblFiltro);
            this.groupBoxFiltro.Controls.Add(this.cmbFiltro);
            this.groupBoxFiltro.Controls.Add(this.txtDato);
            this.groupBoxFiltro.Controls.Add(this.lbldatos);
            this.groupBoxFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltro.Location = new System.Drawing.Point(244, 229);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(315, 179);
            this.groupBoxFiltro.TabIndex = 18;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "FILTRAR BUSQUEDA";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(43, 38);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(101, 20);
            this.lblFiltro.TabIndex = 17;
            this.lblFiltro.Text = "FILTRAR POR:";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(150, 35);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(147, 28);
            this.cmbFiltro.TabIndex = 16;
            // 
            // groupBoxBotones
            // 
            this.groupBoxBotones.Controls.Add(this.btnActualizar);
            this.groupBoxBotones.Controls.Add(this.btnRegresar);
            this.groupBoxBotones.Location = new System.Drawing.Point(584, 250);
            this.groupBoxBotones.Name = "groupBoxBotones";
            this.groupBoxBotones.Size = new System.Drawing.Size(175, 146);
            this.groupBoxBotones.TabIndex = 19;
            this.groupBoxBotones.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 52);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(150, 110);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 20;
            this.imgLogo.TabStop = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedor.Controls.Add(this.dgvAlumnos);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1027, 743);
            this.pnlContenedor.TabIndex = 21;
            // 
            // btnLoadFilters
            // 
            this.btnLoadFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadFilters.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFilters.Location = new System.Drawing.Point(91, 129);
            this.btnLoadFilters.Name = "btnLoadFilters";
            this.btnLoadFilters.Size = new System.Drawing.Size(139, 38);
            this.btnLoadFilters.TabIndex = 1;
            this.btnLoadFilters.Text = "Cargar datos";
            this.btnLoadFilters.UseVisualStyleBackColor = true;
            this.btnLoadFilters.Click += new System.EventHandler(this.btnLoadFilters_Click);
            // 
            // BuscarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 743);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.groupBoxBotones);
            this.Controls.Add(this.groupBoxFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDescrip);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.cmbCarreras);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarAlumno";
            this.Load += new System.EventHandler(this.BuscarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            this.groupBoxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegresar;
        private ComboBox cmbCarreras;
        private Label lblCarrera;
        private Panel pnlSuperior;
        private Button btnCerrar;
        private DragControl dragControlMover;
        private Label lblTitulo;
        private DragControl dragControlMover2;
        private Button btnDescrip;
        private Label label1;
        private Label lbldatos;
        private TextBox txtDato;
        private GroupBox groupBoxFiltro;
        private GroupBox groupBoxBotones;
        private Label lblFiltro;
        private ComboBox cmbFiltro;
        private PictureBox imgLogo;
        private Panel pnlContenedor;
        private Button btnLoadFilters;
    }
}