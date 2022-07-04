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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.pnlSubMenuHorarios = new System.Windows.Forms.Panel();
            this.btnBuscarHorario = new System.Windows.Forms.Button();
            this.btnAgregarHorario = new System.Windows.Forms.Button();
            this.btnEliminarHorario = new System.Windows.Forms.Button();
            this.btnModificarHorario = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnGestionarHorarios = new System.Windows.Forms.Button();
            this.pnlSubMenuDocentes = new System.Windows.Forms.Panel();
            this.btnEliminarDocentes = new System.Windows.Forms.Button();
            this.btnModificarDocentes = new System.Windows.Forms.Button();
            this.btnBuscaeDocentes = new System.Windows.Forms.Button();
            this.btnAgregarDocentes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGestionarDocentes = new System.Windows.Forms.Button();
            this.pnlSubMenuCarreras = new System.Windows.Forms.Panel();
            this.btnBucarCarrera = new System.Windows.Forms.Button();
            this.btnAgregarCarrera = new System.Windows.Forms.Button();
            this.btnEliminarCarrera = new System.Windows.Forms.Button();
            this.btnModificarCarrera = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGestionarCarreras = new System.Windows.Forms.Button();
            this.pnlSubMenuAsignaturas = new System.Windows.Forms.Panel();
            this.btnEliminarAsignatura = new System.Windows.Forms.Button();
            this.btnBuscarAsignatura = new System.Windows.Forms.Button();
            this.btnAgregarAsignatura = new System.Windows.Forms.Button();
            this.btnModificarAsignatura = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnGestionarAsignaturas = new System.Windows.Forms.Button();
            this.pnlSubMenuAlumnos = new System.Windows.Forms.Panel();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnGestionarAlumnos = new System.Windows.Forms.Button();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.imgVision = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.imgMision = new System.Windows.Forms.PictureBox();
            this.imgLogoTipo = new System.Windows.Forms.PictureBox();
            this.pnlSuperiorMenuAdmin = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.imgMasOpciones = new System.Windows.Forms.PictureBox();
            this.dragControlMenuAdmin = new SistemaUniversidad.LOGICA.DragControl();
            this.panelContenedor.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlSubMenuHorarios.SuspendLayout();
            this.pnlSubMenuDocentes.SuspendLayout();
            this.pnlSubMenuCarreras.SuspendLayout();
            this.pnlSubMenuAsignaturas.SuspendLayout();
            this.pnlSubMenuAlumnos.SuspendLayout();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoTipo)).BeginInit();
            this.pnlSuperiorMenuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMasOpciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenedor.Controls.Add(this.pnlContenedor);
            this.panelContenedor.Controls.Add(this.pnlSuperiorMenuAdmin);
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1207, 679);
            this.panelContenedor.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContenedor.Controls.Add(this.panel1);
            this.pnlContenedor.Controls.Add(this.imgVision);
            this.pnlContenedor.Controls.Add(this.btnMaximizar);
            this.pnlContenedor.Controls.Add(this.imgMision);
            this.pnlContenedor.Controls.Add(this.imgLogoTipo);
            this.pnlContenedor.Location = new System.Drawing.Point(0, 35);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1205, 642);
            this.pnlContenedor.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlMenuLateral);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 643);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 641);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(271, 248);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(558, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(402, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(254, 188);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
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
            this.pnlMenuLateral.Size = new System.Drawing.Size(200, 641);
            this.pnlMenuLateral.TabIndex = 1;
            // 
            // pnlSubMenuHorarios
            // 
            this.pnlSubMenuHorarios.Controls.Add(this.btnBuscarHorario);
            this.pnlSubMenuHorarios.Controls.Add(this.btnAgregarHorario);
            this.pnlSubMenuHorarios.Controls.Add(this.btnEliminarHorario);
            this.pnlSubMenuHorarios.Controls.Add(this.btnModificarHorario);
            this.pnlSubMenuHorarios.Controls.Add(this.panel5);
            this.pnlSubMenuHorarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuHorarios.Location = new System.Drawing.Point(0, 689);
            this.pnlSubMenuHorarios.Name = "pnlSubMenuHorarios";
            this.pnlSubMenuHorarios.Size = new System.Drawing.Size(183, 116);
            this.pnlSubMenuHorarios.TabIndex = 11;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(3, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 116);
            this.panel5.TabIndex = 2;
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
            this.btnGestionarHorarios.Location = new System.Drawing.Point(0, 654);
            this.btnGestionarHorarios.Name = "btnGestionarHorarios";
            this.btnGestionarHorarios.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnGestionarHorarios.Size = new System.Drawing.Size(183, 35);
            this.btnGestionarHorarios.TabIndex = 10;
            this.btnGestionarHorarios.Text = "   Horarios";
            this.btnGestionarHorarios.UseVisualStyleBackColor = true;
            this.btnGestionarHorarios.Click += new System.EventHandler(this.btnGestionarHorarios_Click);
            // 
            // pnlSubMenuDocentes
            // 
            this.pnlSubMenuDocentes.Controls.Add(this.btnEliminarDocentes);
            this.pnlSubMenuDocentes.Controls.Add(this.btnModificarDocentes);
            this.pnlSubMenuDocentes.Controls.Add(this.btnBuscaeDocentes);
            this.pnlSubMenuDocentes.Controls.Add(this.btnAgregarDocentes);
            this.pnlSubMenuDocentes.Controls.Add(this.panel3);
            this.pnlSubMenuDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuDocentes.Location = new System.Drawing.Point(0, 538);
            this.pnlSubMenuDocentes.Name = "pnlSubMenuDocentes";
            this.pnlSubMenuDocentes.Size = new System.Drawing.Size(183, 116);
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
            this.btnGestionarDocentes.Location = new System.Drawing.Point(0, 503);
            this.btnGestionarDocentes.Name = "btnGestionarDocentes";
            this.btnGestionarDocentes.Size = new System.Drawing.Size(183, 35);
            this.btnGestionarDocentes.TabIndex = 8;
            this.btnGestionarDocentes.Text = "   Docentes";
            this.btnGestionarDocentes.UseVisualStyleBackColor = true;
            this.btnGestionarDocentes.Click += new System.EventHandler(this.btnGestionarDocentes_Click);
            // 
            // pnlSubMenuCarreras
            // 
            this.pnlSubMenuCarreras.Controls.Add(this.btnBucarCarrera);
            this.pnlSubMenuCarreras.Controls.Add(this.btnAgregarCarrera);
            this.pnlSubMenuCarreras.Controls.Add(this.btnEliminarCarrera);
            this.pnlSubMenuCarreras.Controls.Add(this.btnModificarCarrera);
            this.pnlSubMenuCarreras.Controls.Add(this.panel4);
            this.pnlSubMenuCarreras.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuCarreras.Location = new System.Drawing.Point(0, 387);
            this.pnlSubMenuCarreras.Name = "pnlSubMenuCarreras";
            this.pnlSubMenuCarreras.Size = new System.Drawing.Size(183, 116);
            this.pnlSubMenuCarreras.TabIndex = 7;
            // 
            // btnBucarCarrera
            // 
            this.btnBucarCarrera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBucarCarrera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBucarCarrera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBucarCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBucarCarrera.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBucarCarrera.ForeColor = System.Drawing.Color.White;
            this.btnBucarCarrera.Image = ((System.Drawing.Image)(resources.GetObject("btnBucarCarrera.Image")));
            this.btnBucarCarrera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBucarCarrera.Location = new System.Drawing.Point(6, 86);
            this.btnBucarCarrera.Name = "btnBucarCarrera";
            this.btnBucarCarrera.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnBucarCarrera.Size = new System.Drawing.Size(198, 30);
            this.btnBucarCarrera.TabIndex = 1;
            this.btnBucarCarrera.Text = "Buscar";
            this.btnBucarCarrera.UseVisualStyleBackColor = true;
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
            this.btnAgregarCarrera.Location = new System.Drawing.Point(6, -1);
            this.btnAgregarCarrera.Name = "btnAgregarCarrera";
            this.btnAgregarCarrera.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAgregarCarrera.Size = new System.Drawing.Size(198, 30);
            this.btnAgregarCarrera.TabIndex = 1;
            this.btnAgregarCarrera.Text = "Agregar";
            this.btnAgregarCarrera.UseVisualStyleBackColor = true;
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
            this.btnEliminarCarrera.Location = new System.Drawing.Point(6, 28);
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
            this.btnModificarCarrera.Location = new System.Drawing.Point(6, 57);
            this.btnModificarCarrera.Name = "btnModificarCarrera";
            this.btnModificarCarrera.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnModificarCarrera.Size = new System.Drawing.Size(198, 30);
            this.btnModificarCarrera.TabIndex = 1;
            this.btnModificarCarrera.Text = "Modificar";
            this.btnModificarCarrera.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 116);
            this.panel4.TabIndex = 0;
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
            this.btnGestionarCarreras.Location = new System.Drawing.Point(0, 352);
            this.btnGestionarCarreras.Name = "btnGestionarCarreras";
            this.btnGestionarCarreras.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnGestionarCarreras.Size = new System.Drawing.Size(183, 35);
            this.btnGestionarCarreras.TabIndex = 6;
            this.btnGestionarCarreras.Text = "  Carreras";
            this.btnGestionarCarreras.UseVisualStyleBackColor = true;
            this.btnGestionarCarreras.Click += new System.EventHandler(this.btnGestionarCarreras_Click);
            // 
            // pnlSubMenuAsignaturas
            // 
            this.pnlSubMenuAsignaturas.Controls.Add(this.btnEliminarAsignatura);
            this.pnlSubMenuAsignaturas.Controls.Add(this.btnBuscarAsignatura);
            this.pnlSubMenuAsignaturas.Controls.Add(this.btnAgregarAsignatura);
            this.pnlSubMenuAsignaturas.Controls.Add(this.btnModificarAsignatura);
            this.pnlSubMenuAsignaturas.Controls.Add(this.panel7);
            this.pnlSubMenuAsignaturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuAsignaturas.Location = new System.Drawing.Point(0, 236);
            this.pnlSubMenuAsignaturas.Name = "pnlSubMenuAsignaturas";
            this.pnlSubMenuAsignaturas.Size = new System.Drawing.Size(183, 116);
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
            this.btnBuscarAsignatura.Location = new System.Drawing.Point(6, 86);
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
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(3, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 116);
            this.panel7.TabIndex = 0;
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
            this.btnGestionarAsignaturas.Size = new System.Drawing.Size(183, 35);
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
            this.pnlSubMenuAlumnos.Controls.Add(this.panel8);
            this.pnlSubMenuAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuAlumnos.Location = new System.Drawing.Point(0, 85);
            this.pnlSubMenuAlumnos.Name = "pnlSubMenuAlumnos";
            this.pnlSubMenuAlumnos.Size = new System.Drawing.Size(183, 116);
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
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(3, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 116);
            this.panel8.TabIndex = 0;
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
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // imgVision
            // 
            this.imgVision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgVision.Image = ((System.Drawing.Image)(resources.GetObject("imgVision.Image")));
            this.imgVision.Location = new System.Drawing.Point(372, 401);
            this.imgVision.Name = "imgVision";
            this.imgVision.Size = new System.Drawing.Size(558, 126);
            this.imgVision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVision.TabIndex = 2;
            this.imgVision.TabStop = false;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1119, 24);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(45, 35);
            this.btnMaximizar.TabIndex = 0;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // imgMision
            // 
            this.imgMision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgMision.Image = ((System.Drawing.Image)(resources.GetObject("imgMision.Image")));
            this.imgMision.Location = new System.Drawing.Point(372, 249);
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
            this.imgLogoTipo.Location = new System.Drawing.Point(503, 20);
            this.imgLogoTipo.Name = "imgLogoTipo";
            this.imgLogoTipo.Size = new System.Drawing.Size(254, 188);
            this.imgLogoTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoTipo.TabIndex = 0;
            this.imgLogoTipo.TabStop = false;
            // 
            // pnlSuperiorMenuAdmin
            // 
            this.pnlSuperiorMenuAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlSuperiorMenuAdmin.Controls.Add(this.btnMinimizar);
            this.pnlSuperiorMenuAdmin.Controls.Add(this.btnCerrar);
            this.pnlSuperiorMenuAdmin.Controls.Add(this.imgMasOpciones);
            this.pnlSuperiorMenuAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSuperiorMenuAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorMenuAdmin.Name = "pnlSuperiorMenuAdmin";
            this.pnlSuperiorMenuAdmin.Size = new System.Drawing.Size(1205, 677);
            this.pnlSuperiorMenuAdmin.TabIndex = 3;
            this.pnlSuperiorMenuAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperiorMenuAdmin_MouseDown_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1119, 3);
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
            this.imgMasOpciones.Location = new System.Drawing.Point(-1, 0);
            this.imgMasOpciones.Name = "imgMasOpciones";
            this.imgMasOpciones.Size = new System.Drawing.Size(36, 34);
            this.imgMasOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMasOpciones.TabIndex = 0;
            this.imgMasOpciones.TabStop = false;
            this.imgMasOpciones.Click += new System.EventHandler(this.imgMasOpciones_Click);
            // 
            // dragControlMenuAdmin
            // 
            this.dragControlMenuAdmin.SelectControl = null;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1207, 680);
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
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlSubMenuHorarios.ResumeLayout(false);
            this.pnlSubMenuDocentes.ResumeLayout(false);
            this.pnlSubMenuCarreras.ResumeLayout(false);
            this.pnlSubMenuAsignaturas.ResumeLayout(false);
            this.pnlSubMenuAlumnos.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgVision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoTipo)).EndInit();
            this.pnlSuperiorMenuAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgMasOpciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private LOGICA.DragControl dragControlMenuAdmin;
        private Panel pnlContenedor;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
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
        private Button btnBucarCarrera;
        private Button btnAgregarCarrera;
        private Button btnEliminarCarrera;
        private Button btnModificarCarrera;
        private Panel panel4;
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
        private Button btnAgregarAlumno;
        private Panel panel8;
        private Button btnGestionarAlumnos;
        private Panel pnlHome;
        private Button btnCerrarSesion;
        private PictureBox imgVision;
        private Button btnMaximizar;
        private PictureBox imgMision;
        private PictureBox imgLogoTipo;
        private Panel pnlSuperiorMenuAdmin;
        private Button btnMinimizar;
        private Button btnCerrar;
        private PictureBox imgMasOpciones;
    }
}