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
        //private List<Student> listaRsistemas = new List<Student>();
        //private List<Student> listaRagronomia = new List<Student>();
        //private List<Student> listaRelectrica = new List<Student>();
        //private List<Student> listaRindustrial = new List<Student>();
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
            this.pnlSuperiorMenuAdmin = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.imgMasOpciones = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.dragControlMenuAdmin = new SistemaUniversidad.LOGICA.DragControl();
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnGestionarAlumnos = new System.Windows.Forms.Button();
            this.pnlSubMenuAlumnos = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.btnGestionarAsignaturas = new System.Windows.Forms.Button();
            this.pnlSubMenuAsignaturas = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnModificarAsignatura = new System.Windows.Forms.Button();
            this.btnAgregarAsignatura = new System.Windows.Forms.Button();
            this.btnBuscarAsignatura = new System.Windows.Forms.Button();
            this.btnEliminarAsignatura = new System.Windows.Forms.Button();
            this.btnGestionarCarreras = new System.Windows.Forms.Button();
            this.pnlSubMenuCarreras = new System.Windows.Forms.Panel();
            this.btnEliminarCarrera = new System.Windows.Forms.Button();
            this.btnModificarCarrera = new System.Windows.Forms.Button();
            this.btnBuscarCarrera = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAgregarCarrera = new System.Windows.Forms.Button();
            this.btnGestionarDocentes = new System.Windows.Forms.Button();
            this.pnlSubMenuDocentes = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregarDocentes = new System.Windows.Forms.Button();
            this.btnBuscaeDocentes = new System.Windows.Forms.Button();
            this.btnModificarDocentes = new System.Windows.Forms.Button();
            this.btnEliminarDocentes = new System.Windows.Forms.Button();
            this.btnGestionarHorarios = new System.Windows.Forms.Button();
            this.pnlSubMenuHorarios = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnModificarHorario = new System.Windows.Forms.Button();
            this.btnEliminarHorario = new System.Windows.Forms.Button();
            this.btnAgregarHorario = new System.Windows.Forms.Button();
            this.btnBuscarHorario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgVision = new System.Windows.Forms.PictureBox();
            this.imgMision = new System.Windows.Forms.PictureBox();
            this.imgLogoTipo = new System.Windows.Forms.PictureBox();
            this.pnlSuperiorMenuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMasOpciones)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlSubMenuAlumnos.SuspendLayout();
            this.pnlSubMenuAsignaturas.SuspendLayout();
            this.pnlSubMenuCarreras.SuspendLayout();
            this.pnlSubMenuDocentes.SuspendLayout();
            this.pnlSubMenuHorarios.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperiorMenuAdmin
            // 
            this.pnlSuperiorMenuAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlSuperiorMenuAdmin.Controls.Add(this.lblTitulo);
            this.pnlSuperiorMenuAdmin.Controls.Add(this.btnCloseForm);
            this.pnlSuperiorMenuAdmin.Controls.Add(this.btnMinimizar);
            this.pnlSuperiorMenuAdmin.Controls.Add(this.btnCerrar);
            this.pnlSuperiorMenuAdmin.Controls.Add(this.imgMasOpciones);
            this.pnlSuperiorMenuAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSuperiorMenuAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorMenuAdmin.Name = "pnlSuperiorMenuAdmin";
            this.pnlSuperiorMenuAdmin.Size = new System.Drawing.Size(1335, 784);
            this.pnlSuperiorMenuAdmin.TabIndex = 3;
            this.pnlSuperiorMenuAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperiorMenuAdmin_MouseDown_1);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(689, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(96, 21);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Bienvenido";
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.Image")));
            this.btnCloseForm.Location = new System.Drawing.Point(1290, -1);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(45, 35);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1234, -1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 35);
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1346, 0);
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
            this.imgMasOpciones.Location = new System.Drawing.Point(-1, 0);
            this.imgMasOpciones.Name = "imgMasOpciones";
            this.imgMasOpciones.Size = new System.Drawing.Size(36, 34);
            this.imgMasOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMasOpciones.TabIndex = 0;
            this.imgMasOpciones.TabStop = false;
            this.imgMasOpciones.Click += new System.EventHandler(this.imgMasOpciones_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.pnlSuperiorMenuAdmin);
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1339, 785);
            this.panelContenedor.TabIndex = 0;
            // 
            // dragControlMenuAdmin
            // 
            this.dragControlMenuAdmin.SelectControl = null;
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.AutoScroll = true;
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuHorarios);
            this.pnlMenuLateral.Controls.Add(this.btnGestionarHorarios);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuDocentes);
            this.pnlMenuLateral.Controls.Add(this.btnGestionarDocentes);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuCarreras);
            this.pnlMenuLateral.Controls.Add(this.btnGestionarCarreras);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuAsignaturas);
            this.pnlMenuLateral.Controls.Add(this.btnGestionarAsignaturas);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuAlumnos);
            this.pnlMenuLateral.Controls.Add(this.btnGestionarAlumnos);
            this.pnlMenuLateral.Controls.Add(this.pnlHome);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(200, 749);
            this.pnlMenuLateral.TabIndex = 1;
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.btnCerrarSesion);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(183, 50);
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
            this.btnGestionarAlumnos.Size = new System.Drawing.Size(183, 35);
            this.btnGestionarAlumnos.TabIndex = 1;
            this.btnGestionarAlumnos.Text = "   Alumnos";
            this.btnGestionarAlumnos.UseVisualStyleBackColor = true;
            this.btnGestionarAlumnos.Click += new System.EventHandler(this.btnGestionarAlumnos_Click);
            // 
            // pnlSubMenuAlumnos
            // 
            this.pnlSubMenuAlumnos.Controls.Add(this.btnBuscarAlumno);
            this.pnlSubMenuAlumnos.Controls.Add(this.btnModificarAlumno);
            this.pnlSubMenuAlumnos.Controls.Add(this.btnEliminarAlumno);
            this.pnlSubMenuAlumnos.Controls.Add(this.panel8);
            this.pnlSubMenuAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuAlumnos.Location = new System.Drawing.Point(0, 85);
            this.pnlSubMenuAlumnos.Name = "pnlSubMenuAlumnos";
            this.pnlSubMenuAlumnos.Size = new System.Drawing.Size(183, 90);
            this.pnlSubMenuAlumnos.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(3, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 116);
            this.panel8.TabIndex = 0;
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
            this.btnEliminarAlumno.Location = new System.Drawing.Point(6, -1);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEliminarAlumno.Size = new System.Drawing.Size(198, 30);
            this.btnEliminarAlumno.TabIndex = 1;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
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
            this.btnModificarAlumno.Location = new System.Drawing.Point(6, 28);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnModificarAlumno.Size = new System.Drawing.Size(198, 30);
            this.btnModificarAlumno.TabIndex = 1;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
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
            this.btnBuscarAlumno.Location = new System.Drawing.Point(6, 57);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnBuscarAlumno.Size = new System.Drawing.Size(198, 30);
            this.btnBuscarAlumno.TabIndex = 1;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
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
            this.btnGestionarAsignaturas.Location = new System.Drawing.Point(0, 175);
            this.btnGestionarAsignaturas.Name = "btnGestionarAsignaturas";
            this.btnGestionarAsignaturas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGestionarAsignaturas.Size = new System.Drawing.Size(183, 35);
            this.btnGestionarAsignaturas.TabIndex = 1;
            this.btnGestionarAsignaturas.Text = "       Asignaturas";
            this.btnGestionarAsignaturas.UseVisualStyleBackColor = true;
            this.btnGestionarAsignaturas.Click += new System.EventHandler(this.btnGestionarAsignaturas_Click);
            // 
            // pnlSubMenuAsignaturas
            // 
            this.pnlSubMenuAsignaturas.Controls.Add(this.btnEliminarAsignatura);
            this.pnlSubMenuAsignaturas.Controls.Add(this.btnBuscarAsignatura);
            this.pnlSubMenuAsignaturas.Controls.Add(this.btnAgregarAsignatura);
            this.pnlSubMenuAsignaturas.Controls.Add(this.btnModificarAsignatura);
            this.pnlSubMenuAsignaturas.Controls.Add(this.panel7);
            this.pnlSubMenuAsignaturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuAsignaturas.Location = new System.Drawing.Point(0, 210);
            this.pnlSubMenuAsignaturas.Name = "pnlSubMenuAsignaturas";
            this.pnlSubMenuAsignaturas.Size = new System.Drawing.Size(183, 116);
            this.pnlSubMenuAsignaturas.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(3, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 116);
            this.panel7.TabIndex = 0;
            // 
            // btnModificarAsignatura
            // 
            this.btnModificarAsignatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarAsignatura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnModificarAsignatura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnModificarAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAsignatura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAsignatura.ForeColor = System.Drawing.Color.White;
            this.btnModificarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarAsignatura.Image")));
            this.btnModificarAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarAsignatura.Location = new System.Drawing.Point(6, 57);
            this.btnModificarAsignatura.Name = "btnModificarAsignatura";
            this.btnModificarAsignatura.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnModificarAsignatura.Size = new System.Drawing.Size(198, 30);
            this.btnModificarAsignatura.TabIndex = 1;
            this.btnModificarAsignatura.Text = "Modificar";
            this.btnModificarAsignatura.UseVisualStyleBackColor = true;
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
            this.btnBuscarAsignatura.Location = new System.Drawing.Point(6, 86);
            this.btnBuscarAsignatura.Name = "btnBuscarAsignatura";
            this.btnBuscarAsignatura.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnBuscarAsignatura.Size = new System.Drawing.Size(198, 30);
            this.btnBuscarAsignatura.TabIndex = 1;
            this.btnBuscarAsignatura.Text = "Buscar";
            this.btnBuscarAsignatura.UseVisualStyleBackColor = true;
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
            // btnGestionarCarreras
            // 
            this.btnGestionarCarreras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionarCarreras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarCarreras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionarCarreras.FlatAppearance.BorderSize = 2;
            this.btnGestionarCarreras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionarCarreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarCarreras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarCarreras.ForeColor = System.Drawing.Color.White;
            this.btnGestionarCarreras.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarCarreras.Image")));
            this.btnGestionarCarreras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarCarreras.Location = new System.Drawing.Point(0, 326);
            this.btnGestionarCarreras.Name = "btnGestionarCarreras";
            this.btnGestionarCarreras.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnGestionarCarreras.Size = new System.Drawing.Size(183, 35);
            this.btnGestionarCarreras.TabIndex = 6;
            this.btnGestionarCarreras.Text = "  Carreras";
            this.btnGestionarCarreras.UseVisualStyleBackColor = true;
            this.btnGestionarCarreras.Click += new System.EventHandler(this.btnGestionarCarreras_Click);
            // 
            // pnlSubMenuCarreras
            // 
            this.pnlSubMenuCarreras.Controls.Add(this.btnAgregarCarrera);
            this.pnlSubMenuCarreras.Controls.Add(this.panel4);
            this.pnlSubMenuCarreras.Controls.Add(this.btnBuscarCarrera);
            this.pnlSubMenuCarreras.Controls.Add(this.btnModificarCarrera);
            this.pnlSubMenuCarreras.Controls.Add(this.btnEliminarCarrera);
            this.pnlSubMenuCarreras.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuCarreras.Location = new System.Drawing.Point(0, 361);
            this.pnlSubMenuCarreras.Name = "pnlSubMenuCarreras";
            this.pnlSubMenuCarreras.Size = new System.Drawing.Size(183, 118);
            this.pnlSubMenuCarreras.TabIndex = 7;
            // 
            // btnEliminarCarrera
            // 
            this.btnEliminarCarrera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCarrera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminarCarrera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminarCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCarrera.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCarrera.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCarrera.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCarrera.Image")));
            this.btnEliminarCarrera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCarrera.Location = new System.Drawing.Point(6, 31);
            this.btnEliminarCarrera.Name = "btnEliminarCarrera";
            this.btnEliminarCarrera.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEliminarCarrera.Size = new System.Drawing.Size(198, 30);
            this.btnEliminarCarrera.TabIndex = 1;
            this.btnEliminarCarrera.Text = "Eliminar";
            this.btnEliminarCarrera.UseVisualStyleBackColor = true;
            // 
            // btnModificarCarrera
            // 
            this.btnModificarCarrera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCarrera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnModificarCarrera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnModificarCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCarrera.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCarrera.ForeColor = System.Drawing.Color.White;
            this.btnModificarCarrera.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarCarrera.Image")));
            this.btnModificarCarrera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCarrera.Location = new System.Drawing.Point(6, 60);
            this.btnModificarCarrera.Name = "btnModificarCarrera";
            this.btnModificarCarrera.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnModificarCarrera.Size = new System.Drawing.Size(198, 30);
            this.btnModificarCarrera.TabIndex = 1;
            this.btnModificarCarrera.Text = "Modificar";
            this.btnModificarCarrera.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCarrera
            // 
            this.btnBuscarCarrera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCarrera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscarCarrera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscarCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCarrera.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCarrera.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCarrera.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCarrera.Image")));
            this.btnBuscarCarrera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCarrera.Location = new System.Drawing.Point(6, 88);
            this.btnBuscarCarrera.Name = "btnBuscarCarrera";
            this.btnBuscarCarrera.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnBuscarCarrera.Size = new System.Drawing.Size(198, 30);
            this.btnBuscarCarrera.TabIndex = 1;
            this.btnBuscarCarrera.Text = "Buscar";
            this.btnBuscarCarrera.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 116);
            this.panel4.TabIndex = 2;
            // 
            // btnAgregarCarrera
            // 
            this.btnAgregarCarrera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCarrera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarCarrera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCarrera.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCarrera.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCarrera.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCarrera.Image")));
            this.btnAgregarCarrera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCarrera.Location = new System.Drawing.Point(6, 2);
            this.btnAgregarCarrera.Name = "btnAgregarCarrera";
            this.btnAgregarCarrera.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAgregarCarrera.Size = new System.Drawing.Size(198, 30);
            this.btnAgregarCarrera.TabIndex = 1;
            this.btnAgregarCarrera.Text = "Agregar";
            this.btnAgregarCarrera.UseVisualStyleBackColor = true;
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
            this.btnGestionarDocentes.Location = new System.Drawing.Point(0, 479);
            this.btnGestionarDocentes.Name = "btnGestionarDocentes";
            this.btnGestionarDocentes.Size = new System.Drawing.Size(183, 35);
            this.btnGestionarDocentes.TabIndex = 8;
            this.btnGestionarDocentes.Text = "   Docentes";
            this.btnGestionarDocentes.UseVisualStyleBackColor = true;
            this.btnGestionarDocentes.Click += new System.EventHandler(this.btnGestionarDocentes_Click);
            // 
            // pnlSubMenuDocentes
            // 
            this.pnlSubMenuDocentes.Controls.Add(this.btnEliminarDocentes);
            this.pnlSubMenuDocentes.Controls.Add(this.btnModificarDocentes);
            this.pnlSubMenuDocentes.Controls.Add(this.btnBuscaeDocentes);
            this.pnlSubMenuDocentes.Controls.Add(this.btnAgregarDocentes);
            this.pnlSubMenuDocentes.Controls.Add(this.panel3);
            this.pnlSubMenuDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuDocentes.Location = new System.Drawing.Point(0, 514);
            this.pnlSubMenuDocentes.Name = "pnlSubMenuDocentes";
            this.pnlSubMenuDocentes.Size = new System.Drawing.Size(183, 116);
            this.pnlSubMenuDocentes.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 116);
            this.panel3.TabIndex = 0;
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
            // btnGestionarHorarios
            // 
            this.btnGestionarHorarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionarHorarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarHorarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionarHorarios.FlatAppearance.BorderSize = 2;
            this.btnGestionarHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionarHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarHorarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarHorarios.ForeColor = System.Drawing.Color.White;
            this.btnGestionarHorarios.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarHorarios.Image")));
            this.btnGestionarHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarHorarios.Location = new System.Drawing.Point(0, 630);
            this.btnGestionarHorarios.Name = "btnGestionarHorarios";
            this.btnGestionarHorarios.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnGestionarHorarios.Size = new System.Drawing.Size(183, 35);
            this.btnGestionarHorarios.TabIndex = 10;
            this.btnGestionarHorarios.Text = "   Horarios";
            this.btnGestionarHorarios.UseVisualStyleBackColor = true;
            this.btnGestionarHorarios.Click += new System.EventHandler(this.btnGestionarHorarios_Click);
            // 
            // pnlSubMenuHorarios
            // 
            this.pnlSubMenuHorarios.Controls.Add(this.btnBuscarHorario);
            this.pnlSubMenuHorarios.Controls.Add(this.btnAgregarHorario);
            this.pnlSubMenuHorarios.Controls.Add(this.btnEliminarHorario);
            this.pnlSubMenuHorarios.Controls.Add(this.btnModificarHorario);
            this.pnlSubMenuHorarios.Controls.Add(this.panel5);
            this.pnlSubMenuHorarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuHorarios.Location = new System.Drawing.Point(0, 665);
            this.pnlSubMenuHorarios.Name = "pnlSubMenuHorarios";
            this.pnlSubMenuHorarios.Size = new System.Drawing.Size(183, 116);
            this.pnlSubMenuHorarios.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(3, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 116);
            this.panel5.TabIndex = 2;
            // 
            // btnModificarHorario
            // 
            this.btnModificarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarHorario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnModificarHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnModificarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarHorario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarHorario.ForeColor = System.Drawing.Color.White;
            this.btnModificarHorario.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarHorario.Image")));
            this.btnModificarHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarHorario.Location = new System.Drawing.Point(6, 55);
            this.btnModificarHorario.Name = "btnModificarHorario";
            this.btnModificarHorario.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnModificarHorario.Size = new System.Drawing.Size(198, 30);
            this.btnModificarHorario.TabIndex = 5;
            this.btnModificarHorario.Text = "Modificar";
            this.btnModificarHorario.UseVisualStyleBackColor = true;
            // 
            // btnEliminarHorario
            // 
            this.btnEliminarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarHorario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminarHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarHorario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHorario.ForeColor = System.Drawing.Color.White;
            this.btnEliminarHorario.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarHorario.Image")));
            this.btnEliminarHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarHorario.Location = new System.Drawing.Point(6, 26);
            this.btnEliminarHorario.Name = "btnEliminarHorario";
            this.btnEliminarHorario.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEliminarHorario.Size = new System.Drawing.Size(198, 30);
            this.btnEliminarHorario.TabIndex = 6;
            this.btnEliminarHorario.Text = "Eliminar";
            this.btnEliminarHorario.UseVisualStyleBackColor = true;
            // 
            // btnAgregarHorario
            // 
            this.btnAgregarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarHorario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHorario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHorario.ForeColor = System.Drawing.Color.White;
            this.btnAgregarHorario.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarHorario.Image")));
            this.btnAgregarHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarHorario.Location = new System.Drawing.Point(6, -3);
            this.btnAgregarHorario.Name = "btnAgregarHorario";
            this.btnAgregarHorario.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAgregarHorario.Size = new System.Drawing.Size(198, 30);
            this.btnAgregarHorario.TabIndex = 4;
            this.btnAgregarHorario.Text = "Agregar";
            this.btnAgregarHorario.UseVisualStyleBackColor = true;
            // 
            // btnBuscarHorario
            // 
            this.btnBuscarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarHorario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscarHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarHorario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHorario.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHorario.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarHorario.Image")));
            this.btnBuscarHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarHorario.Location = new System.Drawing.Point(6, 84);
            this.btnBuscarHorario.Name = "btnBuscarHorario";
            this.btnBuscarHorario.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnBuscarHorario.Size = new System.Drawing.Size(198, 30);
            this.btnBuscarHorario.TabIndex = 3;
            this.btnBuscarHorario.Text = "Buscar";
            this.btnBuscarHorario.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imgVision);
            this.panel1.Controls.Add(this.imgMision);
            this.panel1.Controls.Add(this.imgLogoTipo);
            this.panel1.Controls.Add(this.pnlMenuLateral);
            this.panel1.Location = new System.Drawing.Point(-1, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 751);
            this.panel1.TabIndex = 4;
            // 
            // imgVision
            // 
            this.imgVision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgVision.Image = ((System.Drawing.Image)(resources.GetObject("imgVision.Image")));
            this.imgVision.Location = new System.Drawing.Point(458, 521);
            this.imgVision.Name = "imgVision";
            this.imgVision.Size = new System.Drawing.Size(558, 126);
            this.imgVision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVision.TabIndex = 8;
            this.imgVision.TabStop = false;
            // 
            // imgMision
            // 
            this.imgMision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgMision.Image = ((System.Drawing.Image)(resources.GetObject("imgMision.Image")));
            this.imgMision.Location = new System.Drawing.Point(458, 326);
            this.imgMision.Name = "imgMision";
            this.imgMision.Size = new System.Drawing.Size(558, 126);
            this.imgMision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMision.TabIndex = 7;
            this.imgMision.TabStop = false;
            // 
            // imgLogoTipo
            // 
            this.imgLogoTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLogoTipo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoTipo.Image")));
            this.imgLogoTipo.Location = new System.Drawing.Point(601, 81);
            this.imgLogoTipo.Name = "imgLogoTipo";
            this.imgLogoTipo.Size = new System.Drawing.Size(254, 188);
            this.imgLogoTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoTipo.TabIndex = 6;
            this.imgLogoTipo.TabStop = false;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1336, 785);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.pnlSuperiorMenuAdmin.ResumeLayout(false);
            this.pnlSuperiorMenuAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMasOpciones)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.pnlSubMenuAlumnos.ResumeLayout(false);
            this.pnlSubMenuAsignaturas.ResumeLayout(false);
            this.pnlSubMenuCarreras.ResumeLayout(false);
            this.pnlSubMenuDocentes.ResumeLayout(false);
            this.pnlSubMenuHorarios.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgVision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoTipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LOGICA.DragControl dragControlMenuAdmin;
        private Panel pnlSuperiorMenuAdmin;
        private Label lblTitulo;
        private Button btnMinimizar;
        private Button btnCerrar;
        private PictureBox imgMasOpciones;
        private Panel panelContenedor;
        private Button btnCloseForm;
        private Panel panel1;
        private Panel pnlMenuLateral;
        private Panel pnlSubMenuHorarios;
        private Button btnBuscarHorario;
        private Button btnAgregarHorario;
        private Button btnEliminarHorario;
        private Button btnModificarHorario;
        private Panel panel5;
        private Button btnGestionarHorarios;
        private Panel pnlSubMenuDocentes;
        private Button btnEliminarDocentes;
        private Button btnModificarDocentes;
        private Button btnBuscaeDocentes;
        private Button btnAgregarDocentes;
        private Panel panel3;
        private Button btnGestionarDocentes;
        private Panel pnlSubMenuCarreras;
        private Button btnAgregarCarrera;
        private Panel panel4;
        private Button btnBuscarCarrera;
        private Button btnModificarCarrera;
        private Button btnEliminarCarrera;
        private Button btnGestionarCarreras;
        private Panel pnlSubMenuAsignaturas;
        private Button btnEliminarAsignatura;
        private Button btnBuscarAsignatura;
        private Button btnAgregarAsignatura;
        private Button btnModificarAsignatura;
        private Panel panel7;
        private Button btnGestionarAsignaturas;
        private Panel pnlSubMenuAlumnos;
        private Button btnBuscarAlumno;
        private Button btnModificarAlumno;
        private Button btnEliminarAlumno;
        private Panel panel8;
        private Button btnGestionarAlumnos;
        private Panel pnlHome;
        private Button btnCerrarSesion;
        private PictureBox imgVision;
        private PictureBox imgMision;
        private PictureBox imgLogoTipo;
    }
}