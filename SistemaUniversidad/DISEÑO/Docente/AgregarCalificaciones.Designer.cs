using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SistemaUniversidad.LOGICA;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.DISEÑO.Docente
{
    partial class AgregarCalificaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        List<Calificaciones> lstCalificaciones = new List<Calificaciones>();

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

        void UpdateData() {

            MySqlConnection connection = GenerateConnection.Connection();
            MySqlCommand query = new MySqlCommand();
            query.Connection = connection;

            try {
                foreach (Calificaciones x in lstCalificaciones) {
                    query.CommandText = "UPDATE Notas SET NombreMateria = '"+cmbMaterias.Text+"', PrimerParcial = '"+x.PrimerParcial+"', PrimerLab = '"+x.PrimerLab+"', SegundoParcial = '"+x.SegundoParcial+"', " +
                        "SegundoLab = '"+x.SegundoParcial+"', TercerParcial = '"+x.TercerParcial+"' , TercerLab = '"+x.TercerLab+"', CuartoParcial = '"+x.CuartoParcial+"', " +
                        "CuartoLab = '"+x.CuartoLab+"', PromedioFinal = '"+x.Promedio+"' " +
                        "WHERE CarnetAlumno = '"+cmbGetCarnet.Text+"'";
                }
                query.ExecuteNonQuery();
                MessageBox.Show("DATOS GUARDADOS CON EXITO", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                connection.Close();
            }

            cmbCarreras.Items.Clear();
            cmbMaterias.Items.Clear();
            cmbGetCarnet.Items.Clear();
            txtGetPrimerParcial.Clear();
            txtGetPrimerLab.Clear();
            txtGetSegundoParcial.Clear();
            txtGetSegundoLab.Clear();
            txtGetTercerParcial.Clear();
            txtGetTercerLab.Clear();
            txtGetCuartoParcial.Clear();
            txtGetCuartoLab.Clear();
        }

        protected override void Dispose(bool disposing){
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCalificaciones));
            this.pnlConten = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGetCuartoLab = new System.Windows.Forms.TextBox();
            this.txtGetCuartoParcial = new System.Windows.Forms.TextBox();
            this.txtGetSegundoLab = new System.Windows.Forms.TextBox();
            this.txtGetTercerLab = new System.Windows.Forms.TextBox();
            this.txtGetTercerParcial = new System.Windows.Forms.TextBox();
            this.txtGetPrimerLab = new System.Windows.Forms.TextBox();
            this.txtGetSegundoParcial = new System.Windows.Forms.TextBox();
            this.txtGetPrimerParcial = new System.Windows.Forms.TextBox();
            this.lblNotasLabs = new System.Windows.Forms.Label();
            this.lblNotasParciales = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.groupBoxBotones = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAsignarNota = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmbGetCarnet = new System.Windows.Forms.ComboBox();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblCarnetAlumno = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.dragControl1 = new SistemaUniversidad.LOGICA.DragControl();
            this.dragControl2 = new SistemaUniversidad.LOGICA.DragControl();
            this.pnlConten.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.groupBoxBotones.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConten
            // 
            this.pnlConten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConten.Controls.Add(this.groupBox1);
            this.pnlConten.Controls.Add(this.dgvAlumnos);
            this.pnlConten.Controls.Add(this.groupBoxBotones);
            this.pnlConten.Controls.Add(this.pnlSuperior);
            this.pnlConten.Controls.Add(this.cmbGetCarnet);
            this.pnlConten.Controls.Add(this.cmbMaterias);
            this.pnlConten.Controls.Add(this.cmbCarreras);
            this.pnlConten.Controls.Add(this.lblMateria);
            this.pnlConten.Controls.Add(this.lblCarnetAlumno);
            this.pnlConten.Controls.Add(this.lblCarrera);
            this.pnlConten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConten.Location = new System.Drawing.Point(0, 0);
            this.pnlConten.Name = "pnlConten";
            this.pnlConten.Size = new System.Drawing.Size(847, 589);
            this.pnlConten.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGetCuartoLab);
            this.groupBox1.Controls.Add(this.txtGetCuartoParcial);
            this.groupBox1.Controls.Add(this.txtGetSegundoLab);
            this.groupBox1.Controls.Add(this.txtGetTercerLab);
            this.groupBox1.Controls.Add(this.txtGetTercerParcial);
            this.groupBox1.Controls.Add(this.txtGetPrimerLab);
            this.groupBox1.Controls.Add(this.txtGetSegundoParcial);
            this.groupBox1.Controls.Add(this.txtGetPrimerParcial);
            this.groupBox1.Controls.Add(this.lblNotasLabs);
            this.groupBox1.Controls.Add(this.lblNotasParciales);
            this.groupBox1.Location = new System.Drawing.Point(215, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 202);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // txtGetCuartoLab
            // 
            this.txtGetCuartoLab.Location = new System.Drawing.Point(455, 163);
            this.txtGetCuartoLab.Multiline = true;
            this.txtGetCuartoLab.Name = "txtGetCuartoLab";
            this.txtGetCuartoLab.Size = new System.Drawing.Size(65, 31);
            this.txtGetCuartoLab.TabIndex = 1;
            this.txtGetCuartoLab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetCuartoLab_KeyPress);
            // 
            // txtGetCuartoParcial
            // 
            this.txtGetCuartoParcial.Location = new System.Drawing.Point(94, 163);
            this.txtGetCuartoParcial.Multiline = true;
            this.txtGetCuartoParcial.Name = "txtGetCuartoParcial";
            this.txtGetCuartoParcial.Size = new System.Drawing.Size(65, 31);
            this.txtGetCuartoParcial.TabIndex = 1;
            this.txtGetCuartoParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetCuartoParcial_KeyPress);
            // 
            // txtGetSegundoLab
            // 
            this.txtGetSegundoLab.Location = new System.Drawing.Point(455, 89);
            this.txtGetSegundoLab.Multiline = true;
            this.txtGetSegundoLab.Name = "txtGetSegundoLab";
            this.txtGetSegundoLab.Size = new System.Drawing.Size(65, 31);
            this.txtGetSegundoLab.TabIndex = 1;
            this.txtGetSegundoLab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetSegundoLab_KeyPress);
            // 
            // txtGetTercerLab
            // 
            this.txtGetTercerLab.Location = new System.Drawing.Point(455, 126);
            this.txtGetTercerLab.Multiline = true;
            this.txtGetTercerLab.Name = "txtGetTercerLab";
            this.txtGetTercerLab.Size = new System.Drawing.Size(65, 31);
            this.txtGetTercerLab.TabIndex = 1;
            this.txtGetTercerLab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetTecerLab_KeyPress);
            // 
            // txtGetTercerParcial
            // 
            this.txtGetTercerParcial.Location = new System.Drawing.Point(94, 126);
            this.txtGetTercerParcial.Multiline = true;
            this.txtGetTercerParcial.Name = "txtGetTercerParcial";
            this.txtGetTercerParcial.Size = new System.Drawing.Size(65, 31);
            this.txtGetTercerParcial.TabIndex = 1;
            this.txtGetTercerParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetTercerParcial_KeyPress);
            // 
            // txtGetPrimerLab
            // 
            this.txtGetPrimerLab.Location = new System.Drawing.Point(455, 52);
            this.txtGetPrimerLab.Multiline = true;
            this.txtGetPrimerLab.Name = "txtGetPrimerLab";
            this.txtGetPrimerLab.Size = new System.Drawing.Size(65, 31);
            this.txtGetPrimerLab.TabIndex = 1;
            this.txtGetPrimerLab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetPrimerLab_KeyPress);
            // 
            // txtGetSegundoParcial
            // 
            this.txtGetSegundoParcial.Location = new System.Drawing.Point(94, 89);
            this.txtGetSegundoParcial.Multiline = true;
            this.txtGetSegundoParcial.Name = "txtGetSegundoParcial";
            this.txtGetSegundoParcial.Size = new System.Drawing.Size(65, 31);
            this.txtGetSegundoParcial.TabIndex = 1;
            this.txtGetSegundoParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetSegundoParcial_KeyPress);
            // 
            // txtGetPrimerParcial
            // 
            this.txtGetPrimerParcial.Location = new System.Drawing.Point(94, 52);
            this.txtGetPrimerParcial.Multiline = true;
            this.txtGetPrimerParcial.Name = "txtGetPrimerParcial";
            this.txtGetPrimerParcial.Size = new System.Drawing.Size(65, 31);
            this.txtGetPrimerParcial.TabIndex = 1;
            this.txtGetPrimerParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetPrimerParcial_KeyPress);
            // 
            // lblNotasLabs
            // 
            this.lblNotasLabs.AutoSize = true;
            this.lblNotasLabs.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblNotasLabs.Location = new System.Drawing.Point(364, 21);
            this.lblNotasLabs.Name = "lblNotasLabs";
            this.lblNotasLabs.Size = new System.Drawing.Size(247, 20);
            this.lblNotasLabs.TabIndex = 0;
            this.lblNotasLabs.Text = "Calificaciones para laboratorios:";
            // 
            // lblNotasParciales
            // 
            this.lblNotasParciales.AutoSize = true;
            this.lblNotasParciales.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblNotasParciales.Location = new System.Drawing.Point(21, 21);
            this.lblNotasParciales.Name = "lblNotasParciales";
            this.lblNotasParciales.Size = new System.Drawing.Size(223, 20);
            this.lblNotasParciales.TabIndex = 0;
            this.lblNotasParciales.Text = "Calificaciones para parciales";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(15, 342);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.Size = new System.Drawing.Size(819, 225);
            this.dgvAlumnos.TabIndex = 20;
            // 
            // groupBoxBotones
            // 
            this.groupBoxBotones.Controls.Add(this.btnRegresar);
            this.groupBoxBotones.Controls.Add(this.btnAsignarNota);
            this.groupBoxBotones.Controls.Add(this.btnActualizar);
            this.groupBoxBotones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBotones.Location = new System.Drawing.Point(15, 99);
            this.groupBoxBotones.Name = "groupBoxBotones";
            this.groupBoxBotones.Size = new System.Drawing.Size(176, 202);
            this.groupBoxBotones.TabIndex = 19;
            this.groupBoxBotones.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Location = new System.Drawing.Point(11, 137);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(151, 52);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAsignarNota
            // 
            this.btnAsignarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarNota.Location = new System.Drawing.Point(11, 79);
            this.btnAsignarNota.Name = "btnAsignarNota";
            this.btnAsignarNota.Size = new System.Drawing.Size(151, 52);
            this.btnAsignarNota.TabIndex = 1;
            this.btnAsignarNota.Text = "ASIGNAR NOTAS";
            this.btnAsignarNota.UseVisualStyleBackColor = true;
            this.btnAsignarNota.Click += new System.EventHandler(this.btnAsignarNota_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Location = new System.Drawing.Point(11, 21);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(151, 52);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "CARGAR DATOS";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlSuperior.Controls.Add(this.btnRestaurar);
            this.pnlSuperior.Controls.Add(this.lblTitulo);
            this.pnlSuperior.Controls.Add(this.btnMaximizar);
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(845, 35);
            this.pnlSuperior.TabIndex = 17;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(757, -1);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(45, 35);
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(11, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 20);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "ASIGNAR CALIFICACIONES";
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(757, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(45, 35);
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(717, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 35);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(801, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 35);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // cmbGetCarnet
            // 
            this.cmbGetCarnet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetCarnet.FormattingEnabled = true;
            this.cmbGetCarnet.Location = new System.Drawing.Point(741, 59);
            this.cmbGetCarnet.Name = "cmbGetCarnet";
            this.cmbGetCarnet.Size = new System.Drawing.Size(93, 28);
            this.cmbGetCarnet.TabIndex = 16;
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(457, 56);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(150, 28);
            this.cmbMaterias.TabIndex = 16;
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(96, 56);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(278, 28);
            this.cmbCarreras.TabIndex = 16;
            this.cmbCarreras.SelectedValueChanged += new System.EventHandler(this.cmbCarreras_SelectedValueChanged);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(381, 59);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(67, 20);
            this.lblMateria.TabIndex = 15;
            this.lblMateria.Text = "Materia";
            // 
            // lblCarnetAlumno
            // 
            this.lblCarnetAlumno.AutoSize = true;
            this.lblCarnetAlumno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnetAlumno.Location = new System.Drawing.Point(613, 59);
            this.lblCarnetAlumno.Name = "lblCarnetAlumno";
            this.lblCarnetAlumno.Size = new System.Drawing.Size(122, 20);
            this.lblCarnetAlumno.TabIndex = 15;
            this.lblCarnetAlumno.Text = "Carnet alumno:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(20, 59);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(70, 20);
            this.lblCarrera.TabIndex = 15;
            this.lblCarrera.Text = "Carrera:";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.pnlSuperior;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.lblTitulo;
            // 
            // AgregarCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 589);
            this.Controls.Add(this.pnlConten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCalificaciones";
            this.Text = "AgregarCalificaciones";
            this.pnlConten.ResumeLayout(false);
            this.pnlConten.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.groupBoxBotones.ResumeLayout(false);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConten;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private LOGICA.DragControl dragControl1;
        private LOGICA.DragControl dragControl2;
        private System.Windows.Forms.GroupBox groupBoxBotones;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAsignarNota;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNotasLabs;
        private System.Windows.Forms.Label lblNotasParciales;
        private System.Windows.Forms.TextBox txtGetCuartoLab;
        private System.Windows.Forms.TextBox txtGetCuartoParcial;
        private System.Windows.Forms.TextBox txtGetTercerLab;
        private System.Windows.Forms.TextBox txtGetTercerParcial;
        private System.Windows.Forms.TextBox txtGetPrimerLab;
        private System.Windows.Forms.TextBox txtGetSegundoParcial;
        private System.Windows.Forms.TextBox txtGetPrimerParcial;
        private System.Windows.Forms.TextBox txtGetSegundoLab;
        private System.Windows.Forms.Label lblCarnetAlumno;
        private ComboBox cmbMaterias;
        private Label lblMateria;
        private ComboBox cmbGetCarnet;
    }
}