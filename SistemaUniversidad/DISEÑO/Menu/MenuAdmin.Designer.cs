using System.Collections.Generic;
using System.Windows.Forms;
using SistemaUniversidad.LOGICA;

namespace SistemaUniversidad.DISEÑO.Menu
{
    partial class MenuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //Listas de alumnos por cada carrera
        private List<Alumno> listaRsistemas = new List<Alumno>();
        private List<Alumno> listaRagronomia = new List<Alumno>();
        private List<Alumno> listaRelectrica = new List<Alumno>();
        private List<Alumno> listaRindustrial = new List<Alumno>();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.imgVision = new System.Windows.Forms.PictureBox();
            this.imgMision = new System.Windows.Forms.PictureBox();
            this.imgLogoTipo = new System.Windows.Forms.PictureBox();
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.pnlSubMenuCalificaciones = new System.Windows.Forms.Panel();
            this.btnEliminarCalificaciones = new System.Windows.Forms.Button();
            this.btnBuscarCalificaciones = new System.Windows.Forms.Button();
            this.btnAgrerarCalificaciones = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnGestionarCalificaciones = new System.Windows.Forms.Button();
            this.pnlSubMenuDocentes = new System.Windows.Forms.Panel();
            this.btnEliminarDocentes = new System.Windows.Forms.Button();
            this.btnModificarDocentes = new System.Windows.Forms.Button();
            this.btnBuscaeDocentes = new System.Windows.Forms.Button();
            this.btnAgregarDocentes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGestionarDocentes = new System.Windows.Forms.Button();
            this.pnlSubMenuAsignaturas = new System.Windows.Forms.Panel();
            this.btnEliminarAsignatura = new System.Windows.Forms.Button();
            this.btnBuscarAsignatura = new System.Windows.Forms.Button();
            this.btnAgregarAsignatura = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGestionarAsignaturas = new System.Windows.Forms.Button();
            this.pnlSubMenuAlumnos = new System.Windows.Forms.Panel();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGestionarAlumnos = new System.Windows.Forms.Button();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlSuperiorMenuAdmin = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.imgMasOpciones = new System.Windows.Forms.PictureBox();
            this.dragControlMenuAdmin = new SistemaUniversidad.LOGICA.DragControl();
            this.panelContenedor.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoTipo)).BeginInit();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlSubMenuCalificaciones.SuspendLayout();
            this.pnlSubMenuDocentes.SuspendLayout();
            this.pnlSubMenuAsignaturas.SuspendLayout();
            this.pnlSubMenuAlumnos.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlSuperiorMenuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMasOpciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenedor.Controls.Add(this.pnlContenedor);
            this.panelContenedor.Controls.Add(this.pnlMenuLateral);
            this.panelContenedor.Controls.Add(this.pnlSuperiorMenuAdmin);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1207, 794);
            this.panelContenedor.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContenedor.Controls.Add(this.imgVision);
            this.pnlContenedor.Controls.Add(this.imgMision);
            this.pnlContenedor.Controls.Add(this.imgLogoTipo);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 35);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1005, 757);
            this.pnlContenedor.TabIndex = 2;
            // 
            // imgVision
            // 
            this.imgVision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgVision.Image = ((System.Drawing.Image)(resources.GetObject("imgVision.Image")));
            this.imgVision.Location = new System.Drawing.Point(272, 458);
            this.imgVision.Name = "imgVision";
            this.imgVision.Size = new System.Drawing.Size(558, 126);
            this.imgVision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVision.TabIndex = 2;
            this.imgVision.TabStop = false;
            // 
            // imgMision
            // 
            this.imgMision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgMision.Image = ((System.Drawing.Image)(resources.GetObject("imgMision.Image")));
            this.imgMision.Location = new System.Drawing.Point(272, 306);
            this.imgMision.Name = "imgMision";
            this.imgMision.Size = new System.Drawing.Size(558, 126);
            this.imgMision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMision.TabIndex = 1;
            this.imgMision.TabStop = false;
            // 
            // imgLogoTipo
            // 
            this.imgLogoTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLogoTipo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoTipo.Image")));
            this.imgLogoTipo.Location = new System.Drawing.Point(403, 77);
            this.imgLogoTipo.Name = "imgLogoTipo";
            this.imgLogoTipo.Size = new System.Drawing.Size(254, 188);
            this.imgLogoTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoTipo.TabIndex = 0;
            this.imgLogoTipo.TabStop = false;
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.AutoScroll = true;
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuCalificaciones);
            this.pnlMenuLateral.Controls.Add(this.btnGestionarCalificaciones);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuDocentes);
            this.pnlMenuLateral.Controls.Add(this.btnGestionarDocentes);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuAsignaturas);
            this.pnlMenuLateral.Controls.Add(this.btnGestionarAsignaturas);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuAlumnos);
            this.pnlMenuLateral.Controls.Add(this.btnGestionarAlumnos);
            this.pnlMenuLateral.Controls.Add(this.pnlHome);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 35);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(200, 757);
            this.pnlMenuLateral.TabIndex = 1;
            // 
            // pnlSubMenuCalificaciones
            // 
            this.pnlSubMenuCalificaciones.Controls.Add(this.btnEliminarCalificaciones);
            this.pnlSubMenuCalificaciones.Controls.Add(this.btnBuscarCalificaciones);
            this.pnlSubMenuCalificaciones.Controls.Add(this.btnAgrerarCalificaciones);
            this.pnlSubMenuCalificaciones.Controls.Add(this.panel6);
            this.pnlSubMenuCalificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuCalificaciones.Location = new System.Drawing.Point(0, 511);
            this.pnlSubMenuCalificaciones.Name = "pnlSubMenuCalificaciones";
            this.pnlSubMenuCalificaciones.Size = new System.Drawing.Size(200, 89);
            this.pnlSubMenuCalificaciones.TabIndex = 13;
            // 
            // btnEliminarCalificaciones
            // 
            this.btnEliminarCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCalificaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminarCalificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminarCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCalificaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCalificaciones.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCalificaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCalificaciones.Image")));
            this.btnEliminarCalificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCalificaciones.Location = new System.Drawing.Point(6, 28);
            this.btnEliminarCalificaciones.Name = "btnEliminarCalificaciones";
            this.btnEliminarCalificaciones.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEliminarCalificaciones.Size = new System.Drawing.Size(198, 30);
            this.btnEliminarCalificaciones.TabIndex = 11;
            this.btnEliminarCalificaciones.Text = "Eliminar";
            this.btnEliminarCalificaciones.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCalificaciones
            // 
            this.btnBuscarCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCalificaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscarCalificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscarCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCalificaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCalificaciones.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCalificaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCalificaciones.Image")));
            this.btnBuscarCalificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCalificaciones.Location = new System.Drawing.Point(6, 55);
            this.btnBuscarCalificaciones.Name = "btnBuscarCalificaciones";
            this.btnBuscarCalificaciones.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnBuscarCalificaciones.Size = new System.Drawing.Size(198, 30);
            this.btnBuscarCalificaciones.TabIndex = 8;
            this.btnBuscarCalificaciones.Text = "Buscar";
            this.btnBuscarCalificaciones.UseVisualStyleBackColor = true;
            // 
            // btnAgrerarCalificaciones
            // 
            this.btnAgrerarCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgrerarCalificaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgrerarCalificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgrerarCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrerarCalificaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrerarCalificaciones.ForeColor = System.Drawing.Color.White;
            this.btnAgrerarCalificaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnAgrerarCalificaciones.Image")));
            this.btnAgrerarCalificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgrerarCalificaciones.Location = new System.Drawing.Point(6, -1);
            this.btnAgrerarCalificaciones.Name = "btnAgrerarCalificaciones";
            this.btnAgrerarCalificaciones.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAgrerarCalificaciones.Size = new System.Drawing.Size(198, 30);
            this.btnAgrerarCalificaciones.TabIndex = 9;
            this.btnAgrerarCalificaciones.Text = "Agregar";
            this.btnAgrerarCalificaciones.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(3, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 116);
            this.panel6.TabIndex = 7;
            // 
            // btnGestionarCalificaciones
            // 
            this.btnGestionarCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionarCalificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarCalificaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionarCalificaciones.FlatAppearance.BorderSize = 2;
            this.btnGestionarCalificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionarCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarCalificaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarCalificaciones.ForeColor = System.Drawing.Color.White;
            this.btnGestionarCalificaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarCalificaciones.Image")));
            this.btnGestionarCalificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarCalificaciones.Location = new System.Drawing.Point(0, 476);
            this.btnGestionarCalificaciones.Name = "btnGestionarCalificaciones";
            this.btnGestionarCalificaciones.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnGestionarCalificaciones.Size = new System.Drawing.Size(200, 35);
            this.btnGestionarCalificaciones.TabIndex = 12;
            this.btnGestionarCalificaciones.Text = "    Calificaciones";
            this.btnGestionarCalificaciones.UseVisualStyleBackColor = true;
            this.btnGestionarCalificaciones.Click += new System.EventHandler(this.btnGestionarCalificaciones_Click);
            // 
            // pnlSubMenuDocentes
            // 
            this.pnlSubMenuDocentes.Controls.Add(this.btnEliminarDocentes);
            this.pnlSubMenuDocentes.Controls.Add(this.btnModificarDocentes);
            this.pnlSubMenuDocentes.Controls.Add(this.btnBuscaeDocentes);
            this.pnlSubMenuDocentes.Controls.Add(this.btnAgregarDocentes);
            this.pnlSubMenuDocentes.Controls.Add(this.panel3);
            this.pnlSubMenuDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuDocentes.Location = new System.Drawing.Point(0, 360);
            this.pnlSubMenuDocentes.Name = "pnlSubMenuDocentes";
            this.pnlSubMenuDocentes.Size = new System.Drawing.Size(200, 116);
            this.pnlSubMenuDocentes.TabIndex = 9;
            // 
            // btnEliminarDocentes
            // 
            this.btnEliminarDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarDocentes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminarDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminarDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDocentes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocentes.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDocentes.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarDocentes.Image")));
            this.btnEliminarDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDocentes.Location = new System.Drawing.Point(6, 28);
            this.btnEliminarDocentes.Name = "btnEliminarDocentes";
            this.btnEliminarDocentes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEliminarDocentes.Size = new System.Drawing.Size(198, 30);
            this.btnEliminarDocentes.TabIndex = 1;
            this.btnEliminarDocentes.Text = "Eliminar";
            this.btnEliminarDocentes.UseVisualStyleBackColor = true;
            // 
            // btnModificarDocentes
            // 
            this.btnModificarDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarDocentes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnModificarDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnModificarDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDocentes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDocentes.ForeColor = System.Drawing.Color.White;
            this.btnModificarDocentes.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarDocentes.Image")));
            this.btnModificarDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarDocentes.Location = new System.Drawing.Point(6, 57);
            this.btnModificarDocentes.Name = "btnModificarDocentes";
            this.btnModificarDocentes.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnModificarDocentes.Size = new System.Drawing.Size(198, 30);
            this.btnModificarDocentes.TabIndex = 1;
            this.btnModificarDocentes.Text = "Modificar";
            this.btnModificarDocentes.UseVisualStyleBackColor = true;
            // 
            // btnBuscaeDocentes
            // 
            this.btnBuscaeDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaeDocentes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscaeDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscaeDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaeDocentes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaeDocentes.ForeColor = System.Drawing.Color.White;
            this.btnBuscaeDocentes.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaeDocentes.Image")));
            this.btnBuscaeDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaeDocentes.Location = new System.Drawing.Point(6, 86);
            this.btnBuscaeDocentes.Name = "btnBuscaeDocentes";
            this.btnBuscaeDocentes.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnBuscaeDocentes.Size = new System.Drawing.Size(198, 30);
            this.btnBuscaeDocentes.TabIndex = 1;
            this.btnBuscaeDocentes.Text = "Buscar";
            this.btnBuscaeDocentes.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDocentes
            // 
            this.btnAgregarDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDocentes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDocentes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDocentes.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDocentes.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDocentes.Image")));
            this.btnAgregarDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDocentes.Location = new System.Drawing.Point(6, -1);
            this.btnAgregarDocentes.Name = "btnAgregarDocentes";
            this.btnAgregarDocentes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAgregarDocentes.Size = new System.Drawing.Size(198, 30);
            this.btnAgregarDocentes.TabIndex = 1;
            this.btnAgregarDocentes.Text = "Agregar";
            this.btnAgregarDocentes.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 116);
            this.panel3.TabIndex = 0;
            // 
            // btnGestionarDocentes
            // 
            this.btnGestionarDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionarDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarDocentes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionarDocentes.FlatAppearance.BorderSize = 2;
            this.btnGestionarDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionarDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarDocentes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarDocentes.ForeColor = System.Drawing.Color.White;
            this.btnGestionarDocentes.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarDocentes.Image")));
            this.btnGestionarDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarDocentes.Location = new System.Drawing.Point(0, 325);
            this.btnGestionarDocentes.Name = "btnGestionarDocentes";
            this.btnGestionarDocentes.Size = new System.Drawing.Size(200, 35);
            this.btnGestionarDocentes.TabIndex = 8;
            this.btnGestionarDocentes.Text = "   Docentes";
            this.btnGestionarDocentes.UseVisualStyleBackColor = true;
            this.btnGestionarDocentes.Click += new System.EventHandler(this.btnGestionarDocentes_Click);
            // 
            // pnlSubMenuAsignaturas
            // 
            this.pnlSubMenuAsignaturas.Controls.Add(this.btnEliminarAsignatura);
            this.pnlSubMenuAsignaturas.Controls.Add(this.btnBuscarAsignatura);
            this.pnlSubMenuAsignaturas.Controls.Add(this.btnAgregarAsignatura);
            this.pnlSubMenuAsignaturas.Controls.Add(this.panel2);
            this.pnlSubMenuAsignaturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuAsignaturas.Location = new System.Drawing.Point(0, 236);
            this.pnlSubMenuAsignaturas.Name = "pnlSubMenuAsignaturas";
            this.pnlSubMenuAsignaturas.Size = new System.Drawing.Size(200, 89);
            this.pnlSubMenuAsignaturas.TabIndex = 5;
            // 
            // btnEliminarAsignatura
            // 
            this.btnEliminarAsignatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarAsignatura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminarAsignatura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminarAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAsignatura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAsignatura.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarAsignatura.Image")));
            this.btnEliminarAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarAsignatura.Location = new System.Drawing.Point(6, 28);
            this.btnEliminarAsignatura.Name = "btnEliminarAsignatura";
            this.btnEliminarAsignatura.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEliminarAsignatura.Size = new System.Drawing.Size(198, 30);
            this.btnEliminarAsignatura.TabIndex = 1;
            this.btnEliminarAsignatura.Text = "Eliminar";
            this.btnEliminarAsignatura.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAsignatura
            // 
            this.btnBuscarAsignatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarAsignatura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscarAsignatura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscarAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAsignatura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAsignatura.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAsignatura.Image")));
            this.btnBuscarAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarAsignatura.Location = new System.Drawing.Point(6, 55);
            this.btnBuscarAsignatura.Name = "btnBuscarAsignatura";
            this.btnBuscarAsignatura.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnBuscarAsignatura.Size = new System.Drawing.Size(198, 30);
            this.btnBuscarAsignatura.TabIndex = 1;
            this.btnBuscarAsignatura.Text = "Buscar";
            this.btnBuscarAsignatura.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAsignatura
            // 
            this.btnAgregarAsignatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarAsignatura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarAsignatura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAsignatura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAsignatura.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarAsignatura.Image")));
            this.btnAgregarAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAsignatura.Location = new System.Drawing.Point(6, -1);
            this.btnAgregarAsignatura.Name = "btnAgregarAsignatura";
            this.btnAgregarAsignatura.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAgregarAsignatura.Size = new System.Drawing.Size(198, 30);
            this.btnAgregarAsignatura.TabIndex = 1;
            this.btnAgregarAsignatura.Text = "Agregar";
            this.btnAgregarAsignatura.UseVisualStyleBackColor = true;
            this.btnAgregarAsignatura.Click += new System.EventHandler(this.btnAgregarAsignatura_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 116);
            this.panel2.TabIndex = 0;
            // 
            // btnGestionarAsignaturas
            // 
            this.btnGestionarAsignaturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionarAsignaturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarAsignaturas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionarAsignaturas.FlatAppearance.BorderSize = 2;
            this.btnGestionarAsignaturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionarAsignaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarAsignaturas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarAsignaturas.ForeColor = System.Drawing.Color.White;
            this.btnGestionarAsignaturas.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarAsignaturas.Image")));
            this.btnGestionarAsignaturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarAsignaturas.Location = new System.Drawing.Point(0, 201);
            this.btnGestionarAsignaturas.Name = "btnGestionarAsignaturas";
            this.btnGestionarAsignaturas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGestionarAsignaturas.Size = new System.Drawing.Size(200, 35);
            this.btnGestionarAsignaturas.TabIndex = 1;
            this.btnGestionarAsignaturas.Text = "       Asignaturas";
            this.btnGestionarAsignaturas.UseVisualStyleBackColor = true;
            this.btnGestionarAsignaturas.Click += new System.EventHandler(this.btnGestionarAsignaturas_Click);
            // 
            // pnlSubMenuAlumnos
            // 
            this.pnlSubMenuAlumnos.Controls.Add(this.btnBuscarAlumno);
            this.pnlSubMenuAlumnos.Controls.Add(this.btnModificarAlumno);
            this.pnlSubMenuAlumnos.Controls.Add(this.btnEliminarAlumno);
            this.pnlSubMenuAlumnos.Controls.Add(this.btnAgregarAlumno);
            this.pnlSubMenuAlumnos.Controls.Add(this.panel1);
            this.pnlSubMenuAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuAlumnos.Location = new System.Drawing.Point(0, 85);
            this.pnlSubMenuAlumnos.Name = "pnlSubMenuAlumnos";
            this.pnlSubMenuAlumnos.Size = new System.Drawing.Size(200, 116);
            this.pnlSubMenuAlumnos.TabIndex = 4;
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAlumno.Image")));
            this.btnBuscarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarAlumno.Location = new System.Drawing.Point(6, 86);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnBuscarAlumno.Size = new System.Drawing.Size(198, 30);
            this.btnBuscarAlumno.TabIndex = 1;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnModificarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnModificarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnModificarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarAlumno.Image")));
            this.btnModificarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarAlumno.Location = new System.Drawing.Point(6, 57);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnModificarAlumno.Size = new System.Drawing.Size(198, 30);
            this.btnModificarAlumno.TabIndex = 1;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarAlumno.Image")));
            this.btnEliminarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarAlumno.Location = new System.Drawing.Point(6, 28);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEliminarAlumno.Size = new System.Drawing.Size(198, 30);
            this.btnEliminarAlumno.TabIndex = 1;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarAlumno.Image")));
            this.btnAgregarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAlumno.Location = new System.Drawing.Point(6, -1);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAgregarAlumno.Size = new System.Drawing.Size(198, 30);
            this.btnAgregarAlumno.TabIndex = 1;
            this.btnAgregarAlumno.Text = "Agregar";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 116);
            this.panel1.TabIndex = 0;
            // 
            // btnGestionarAlumnos
            // 
            this.btnGestionarAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionarAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarAlumnos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionarAlumnos.FlatAppearance.BorderSize = 2;
            this.btnGestionarAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarAlumnos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnGestionarAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarAlumnos.Image")));
            this.btnGestionarAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarAlumnos.Location = new System.Drawing.Point(0, 50);
            this.btnGestionarAlumnos.Name = "btnGestionarAlumnos";
            this.btnGestionarAlumnos.Size = new System.Drawing.Size(200, 35);
            this.btnGestionarAlumnos.TabIndex = 1;
            this.btnGestionarAlumnos.Text = "   Alumnos";
            this.btnGestionarAlumnos.UseVisualStyleBackColor = true;
            this.btnGestionarAlumnos.Click += new System.EventHandler(this.btnGestionarAlumnos_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.btnCerrarSesion);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(200, 50);
            this.pnlHome.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(-1, 0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(205, 50);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "      Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pnlSuperiorMenuAdmin
            // 
            this.pnlSuperiorMenuAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlSuperiorMenuAdmin.Controls.Add(this.btnMinimizar);
            this.pnlSuperiorMenuAdmin.Controls.Add(this.btnMaximizar);
            this.pnlSuperiorMenuAdmin.Controls.Add(this.btnRestaurar);
            this.pnlSuperiorMenuAdmin.Controls.Add(this.btnCerrar);
            this.pnlSuperiorMenuAdmin.Controls.Add(this.imgMasOpciones);
            this.pnlSuperiorMenuAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorMenuAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorMenuAdmin.Name = "pnlSuperiorMenuAdmin";
            this.pnlSuperiorMenuAdmin.Size = new System.Drawing.Size(1205, 35);
            this.pnlSuperiorMenuAdmin.TabIndex = 0;
            this.pnlSuperiorMenuAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperiorMenuAdmin_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1077, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 35);
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1119, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(45, 35);
            this.btnMaximizar.TabIndex = 0;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1119, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(45, 35);
            this.btnRestaurar.TabIndex = 0;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1160, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 35);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // imgMasOpciones
            // 
            this.imgMasOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMasOpciones.Image = ((System.Drawing.Image)(resources.GetObject("imgMasOpciones.Image")));
            this.imgMasOpciones.Location = new System.Drawing.Point(14, -1);
            this.imgMasOpciones.Name = "imgMasOpciones";
            this.imgMasOpciones.Size = new System.Drawing.Size(36, 34);
            this.imgMasOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMasOpciones.TabIndex = 0;
            this.imgMasOpciones.TabStop = false;
            this.imgMasOpciones.Click += new System.EventHandler(this.imgMasOpciones_Click);
            // 
            // dragControlMenuAdmin
            // 
            this.dragControlMenuAdmin.SelectControl = this.pnlSuperiorMenuAdmin;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1207, 794);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.panelContenedor.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgVision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoTipo)).EndInit();
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlSubMenuCalificaciones.ResumeLayout(false);
            this.pnlSubMenuDocentes.ResumeLayout(false);
            this.pnlSubMenuAsignaturas.ResumeLayout(false);
            this.pnlSubMenuAlumnos.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.pnlSuperiorMenuAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgMasOpciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel pnlSuperiorMenuAdmin;
        private System.Windows.Forms.Panel pnlMenuLateral;
        private LOGICA.DragControl dragControlMenuAdmin;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Button btnGestionarAlumnos;
        private System.Windows.Forms.Button btnGestionarAsignaturas;
        private System.Windows.Forms.Panel pnlSubMenuAlumnos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSubMenuAsignaturas;
        private System.Windows.Forms.Button btnGestionarDocentes;
        private System.Windows.Forms.Panel pnlSubMenuDocentes;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Button btnBuscarAsignatura;
        private System.Windows.Forms.Button btnAgregarAsignatura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminarAsignatura;
        private System.Windows.Forms.Button btnGestionarCalificaciones;
        private System.Windows.Forms.Panel pnlSubMenuCalificaciones;
        private System.Windows.Forms.Button btnBuscaeDocentes;
        private System.Windows.Forms.Button btnAgregarDocentes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEliminarDocentes;
        private System.Windows.Forms.Button btnModificarDocentes;
        private System.Windows.Forms.Button btnBuscarCalificaciones;
        private System.Windows.Forms.Button btnAgrerarCalificaciones;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnEliminarCalificaciones;
        private System.Windows.Forms.PictureBox imgMasOpciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrarSesion;
        private PictureBox imgLogoTipo;
        private PictureBox imgVision;
        private PictureBox imgMision;
    }
}