using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaUniversidad.LOGICA;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.DISEÑO.Administrador
{
    partial class Modificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<Alumno> listaModificable = new List<Alumno>();
        private List<Alumno> listaAlumnoGenerico = new List<Alumno>();
        private int indice;
        private int carrera;
        private string pass;
        string previousCarnet;

        private void mostrar(){

            foreach(Alumno x in listaModificable) {
                txtNombres.Text = x.getNombres();
                txrtPrimerApellido.Text = x.getPrimerApellido();
                txtSegundoApellido.Text = x.getSegundoApellido();
                cmbCarreras.Text = x.getCarrera(); ;
                txtCarnet.Text = x.getCarnet();
                txtDocumentoIdentidad.Text = x.getDocumentoIdentidad();
                txtDireccion.Text = x.getDireccion();
                txtTelefono.Text = x.getTelefono();
                txtCelular.Text = x.getCelular();
                txtCorreo.Text = x.getCorreo();
                txtFechaInscripcion.Text = x.getFechaInscripcion();
                cmbNacionalidad.Text = x.getNacionalidad();
                cmbEstadoCivil.Text = x.getEstadoCivil();
                previousCarnet = x.getCarnet(); ;

                if (x.getSexo() == "Masculino") {
                    rbtnMasculino.Checked = true;
                    rbtnFemenino.Checked = false;
                } else {
                    rbtnMasculino.Checked = false;
                    rbtnFemenino.Checked = true;
                }
            }
        }

        public void setDetalles(List<Alumno> listaRecibida) {
            this.listaModificable = listaRecibida;
        }

        public void setResive(int indice, int carrera){
            this.indice = indice;
            this.carrera = carrera;
        }

        void SaveToDatabase() {

            MySqlConnection connection = GenerateConnection.Connection();
            MySqlCommand query = new MySqlCommand();
            query.Connection = connection;
            foreach (Alumno x in listaAlumnoGenerico) {

                query.CommandText = "INSERT INTO Alumnos(Nombres, PrimerApellido, SegundoApellido, NombreCarrera, Carnet, Clave, Matricula, " +
                "FechaDeNacimiento, DocumentoDeIdentidad, Sexo, Direccion, Telefono, Celular, Correo, FechaInscripcion, Nacionalidad, EstadoCivil)" +
                "VALUES('"+x.getNombres()+"', '"+x.getPrimerApellido()+"', '"+x.getSegundoApellido()+"', '"+x.getCarrera()+"', '"+x.getCarnet()+"', " +
                "'"+x.getPasswrd()+"', '"+x.getMatricula().ToString()+"', '"+x.getFechaNacimiento()+"', '"+x.getDocumentoIdentidad()+"', '"+x.getSexo()+"'," +
                "'"+x.getDireccion()+"', '"+x.getTelefono()+"', '"+x.getCelular()+"', '"+x.getCorreo()+"', '"+x.getFechaInscripcion()+"', " +
                "'"+x.getNacionalidad()+"', '"+x.getEstadoCivil()+"') WHERE Carnet = '"+txtCarnet.Text+"'  ";
            }
            query.ExecuteNonQuery();
            connection.Close();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNoObli = new System.Windows.Forms.Label();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.lblMensaje6 = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblMensaje5 = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblMensaje4 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMensaje3 = new System.Windows.Forms.Label();
            this.lblCarreras = new System.Windows.Forms.Label();
            this.lblMensaje2 = new System.Windows.Forms.Label();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.lblMensaje1 = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txrtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtFechaInscripcion = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.dtPCalendarioNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDocumentoIdentidad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDocumentoIdentidad = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFechaInscripcion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.btnDescrip = new System.Windows.Forms.Button();
            this.btnSalirAggAlumno = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dragControl1 = new SistemaUniversidad.LOGICA.DragControl();
            this.dragControl2 = new SistemaUniversidad.LOGICA.DragControl();
            this.pnlSuperior.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlSuperior.Controls.Add(this.lblTitulo);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1136, 35);
            this.pnlSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(10, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(250, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "MODIFICAR DATOS DE ALUMNOS";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1093, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(43, 35);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblNoObli);
            this.groupBox1.Controls.Add(this.cmbNacionalidad);
            this.groupBox1.Controls.Add(this.txtCarnet);
            this.groupBox1.Controls.Add(this.lblMensaje6);
            this.groupBox1.Controls.Add(this.lblCarnet);
            this.groupBox1.Controls.Add(this.lblMensaje5);
            this.groupBox1.Controls.Add(this.lblMatricula);
            this.groupBox1.Controls.Add(this.lblMensaje4);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.lblMensaje3);
            this.groupBox1.Controls.Add(this.lblCarreras);
            this.groupBox1.Controls.Add(this.lblMensaje2);
            this.groupBox1.Controls.Add(this.cmbCarreras);
            this.groupBox1.Controls.Add(this.lblMensaje1);
            this.groupBox1.Controls.Add(this.lblPrimerApellido);
            this.groupBox1.Controls.Add(this.lblSegundoApellido);
            this.groupBox1.Controls.Add(this.lblNombres);
            this.groupBox1.Controls.Add(this.cmbEstadoCivil);
            this.groupBox1.Controls.Add(this.txrtPrimerApellido);
            this.groupBox1.Controls.Add(this.txtSegundoApellido);
            this.groupBox1.Controls.Add(this.txtFechaInscripcion);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.dtPCalendarioNacimiento);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.lblFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.lblDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.lblCorreo);
            this.groupBox1.Controls.Add(this.rbtnMasculino);
            this.groupBox1.Controls.Add(this.lblEstadoCivil);
            this.groupBox1.Controls.Add(this.rbtnFemenino);
            this.groupBox1.Controls.Add(this.lblNacionalidad);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.lblFechaInscripcion);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblCelular);
            this.groupBox1.Location = new System.Drawing.Point(204, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 585);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // lblNoObli
            // 
            this.lblNoObli.AutoSize = true;
            this.lblNoObli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoObli.ForeColor = System.Drawing.Color.Maroon;
            this.lblNoObli.Location = new System.Drawing.Point(406, 395);
            this.lblNoObli.Name = "lblNoObli";
            this.lblNoObli.Size = new System.Drawing.Size(104, 16);
            this.lblNoObli.TabIndex = 26;
            this.lblNoObli.Text = "NO OBLIGATORIO";
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(219, 531);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(129, 29);
            this.cmbNacionalidad.TabIndex = 25;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(128, 34);
            this.txtCarnet.MaxLength = 7;
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(100, 27);
            this.txtCarnet.TabIndex = 1;
            this.txtCarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarnet_KeyPress);
            // 
            // lblMensaje6
            // 
            this.lblMensaje6.AutoSize = true;
            this.lblMensaje6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje6.Location = new System.Drawing.Point(532, 536);
            this.lblMensaje6.Name = "lblMensaje6";
            this.lblMensaje6.Size = new System.Drawing.Size(88, 21);
            this.lblMensaje6.TabIndex = 24;
            this.lblMensaje6.Text = "Mensaje 6";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnet.Location = new System.Drawing.Point(52, 37);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(70, 21);
            this.lblCarnet.TabIndex = 0;
            this.lblCarnet.Text = "Carnet:";
            // 
            // lblMensaje5
            // 
            this.lblMensaje5.AutoSize = true;
            this.lblMensaje5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje5.Location = new System.Drawing.Point(538, 434);
            this.lblMensaje5.Name = "lblMensaje5";
            this.lblMensaje5.Size = new System.Drawing.Size(88, 21);
            this.lblMensaje5.TabIndex = 24;
            this.lblMensaje5.Text = "Mensaje 5";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(52, 85);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(107, 21);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matrícula N°";
            // 
            // lblMensaje4
            // 
            this.lblMensaje4.AutoSize = true;
            this.lblMensaje4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje4.Location = new System.Drawing.Point(519, 368);
            this.lblMensaje4.Name = "lblMensaje4";
            this.lblMensaje4.Size = new System.Drawing.Size(88, 21);
            this.lblMensaje4.TabIndex = 24;
            this.lblMensaje4.Text = "Mensaje 4";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Enabled = false;
            this.txtMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(56, 111);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(100, 27);
            this.txtMatricula.TabIndex = 3;
            // 
            // lblMensaje3
            // 
            this.lblMensaje3.AutoSize = true;
            this.lblMensaje3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje3.Location = new System.Drawing.Point(565, 301);
            this.lblMensaje3.Name = "lblMensaje3";
            this.lblMensaje3.Size = new System.Drawing.Size(88, 21);
            this.lblMensaje3.TabIndex = 24;
            this.lblMensaje3.Text = "Mensaje 3";
            // 
            // lblCarreras
            // 
            this.lblCarreras.AutoSize = true;
            this.lblCarreras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarreras.Location = new System.Drawing.Point(224, 85);
            this.lblCarreras.Name = "lblCarreras";
            this.lblCarreras.Size = new System.Drawing.Size(70, 21);
            this.lblCarreras.TabIndex = 4;
            this.lblCarreras.Text = "Carrera";
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.AutoSize = true;
            this.lblMensaje2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje2.Location = new System.Drawing.Point(532, 205);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(88, 21);
            this.lblMensaje2.TabIndex = 24;
            this.lblMensaje2.Text = "Mensaje 2";
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(227, 109);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(305, 29);
            this.cmbCarreras.TabIndex = 5;
            // 
            // lblMensaje1
            // 
            this.lblMensaje1.AutoSize = true;
            this.lblMensaje1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje1.Location = new System.Drawing.Point(260, 40);
            this.lblMensaje1.Name = "lblMensaje1";
            this.lblMensaje1.Size = new System.Drawing.Size(88, 21);
            this.lblMensaje1.TabIndex = 24;
            this.lblMensaje1.Text = "Mensaje 1";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(52, 166);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(125, 21);
            this.lblPrimerApellido.TabIndex = 6;
            this.lblPrimerApellido.Text = "Primer Apellido";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(197, 166);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(148, 21);
            this.lblSegundoApellido.TabIndex = 6;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(380, 166);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(79, 21);
            this.lblNombres.TabIndex = 6;
            this.lblNombres.Text = "Nombres";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(379, 533);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(153, 29);
            this.cmbEstadoCivil.TabIndex = 22;
            // 
            // txrtPrimerApellido
            // 
            this.txrtPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txrtPrimerApellido.Location = new System.Drawing.Point(56, 202);
            this.txrtPrimerApellido.Name = "txrtPrimerApellido";
            this.txrtPrimerApellido.Size = new System.Drawing.Size(132, 27);
            this.txrtPrimerApellido.TabIndex = 7;
            this.txrtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txrtPrimerApellido_KeyPress);
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(205, 202);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(135, 27);
            this.txtSegundoApellido.TabIndex = 8;
            this.txtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoApellido_KeyPress);
            // 
            // txtFechaInscripcion
            // 
            this.txtFechaInscripcion.Enabled = false;
            this.txtFechaInscripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInscripcion.Location = new System.Drawing.Point(56, 533);
            this.txtFechaInscripcion.Name = "txtFechaInscripcion";
            this.txtFechaInscripcion.Size = new System.Drawing.Size(142, 27);
            this.txtFechaInscripcion.TabIndex = 20;
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(384, 202);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(142, 27);
            this.txtNombres.TabIndex = 9;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(331, 428);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(201, 27);
            this.txtCorreo.TabIndex = 19;
            this.txtCorreo.Tag = "";
            // 
            // dtPCalendarioNacimiento
            // 
            this.dtPCalendarioNacimiento.CustomFormat = "dd-mm-yyyy";
            this.dtPCalendarioNacimiento.Enabled = false;
            this.dtPCalendarioNacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPCalendarioNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPCalendarioNacimiento.Location = new System.Drawing.Point(57, 296);
            this.dtPCalendarioNacimiento.Name = "dtPCalendarioNacimiento";
            this.dtPCalendarioNacimiento.Size = new System.Drawing.Size(131, 27);
            this.dtPCalendarioNacimiento.TabIndex = 10;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.Color.Black;
            this.txtCelular.Location = new System.Drawing.Point(128, 428);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(97, 27);
            this.txtCelular.TabIndex = 18;
            this.txtCelular.Tag = "";
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(53, 261);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(152, 21);
            this.lblFechaNacimiento.TabIndex = 11;
            this.lblFechaNacimiento.Text = "Fecha nacimiento";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(409, 365);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(92, 27);
            this.txtTelefono.TabIndex = 17;
            this.txtTelefono.Tag = "";
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblDocumentoIdentidad
            // 
            this.lblDocumentoIdentidad.AutoSize = true;
            this.lblDocumentoIdentidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentoIdentidad.Location = new System.Drawing.Point(224, 263);
            this.lblDocumentoIdentidad.Name = "lblDocumentoIdentidad";
            this.lblDocumentoIdentidad.Size = new System.Drawing.Size(112, 21);
            this.lblDocumentoIdentidad.TabIndex = 12;
            this.lblDocumentoIdentidad.Text = "DUI ó Carnet";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(141, 365);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(164, 27);
            this.txtDireccion.TabIndex = 16;
            // 
            // txtDocumentoIdentidad
            // 
            this.txtDocumentoIdentidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoIdentidad.Location = new System.Drawing.Point(227, 298);
            this.txtDocumentoIdentidad.Name = "txtDocumentoIdentidad";
            this.txtDocumentoIdentidad.Size = new System.Drawing.Size(100, 27);
            this.txtDocumentoIdentidad.TabIndex = 13;
            this.txtDocumentoIdentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumentoIdentidad_KeyPress);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(260, 431);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(63, 21);
            this.lblCorreo.TabIndex = 15;
            this.lblCorreo.Text = "Correo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.Location = new System.Drawing.Point(343, 298);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(106, 25);
            this.rbtnMasculino.TabIndex = 14;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(375, 490);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(97, 21);
            this.lblEstadoCivil.TabIndex = 15;
            this.lblEstadoCivil.Text = "Estado civil";
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemenino.Location = new System.Drawing.Point(455, 298);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(104, 25);
            this.rbtnFemenino.TabIndex = 14;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(220, 490);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(116, 21);
            this.lblNacionalidad.TabIndex = 15;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(52, 368);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(83, 21);
            this.lblDireccion.TabIndex = 15;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblFechaInscripcion
            // 
            this.lblFechaInscripcion.AutoSize = true;
            this.lblFechaInscripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInscripcion.Location = new System.Drawing.Point(52, 490);
            this.lblFechaInscripcion.Name = "lblFechaInscripcion";
            this.lblFechaInscripcion.Size = new System.Drawing.Size(146, 21);
            this.lblFechaInscripcion.TabIndex = 15;
            this.lblFechaInscripcion.Text = "Fecha Inscripción";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(327, 368);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(76, 21);
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(52, 431);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(65, 21);
            this.lblCelular.TabIndex = 15;
            this.lblCelular.Text = "Celular";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.Location = new System.Drawing.Point(382, 82);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(435, 33);
            this.lblDescrip.TabIndex = 28;
            this.lblDescrip.Text = "MODIFICAR DATOS DE ALUMNOS";
            // 
            // btnDescrip
            // 
            this.btnDescrip.Enabled = false;
            this.btnDescrip.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnDescrip.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnDescrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescrip.Location = new System.Drawing.Point(360, 68);
            this.btnDescrip.Name = "btnDescrip";
            this.btnDescrip.Size = new System.Drawing.Size(479, 68);
            this.btnDescrip.TabIndex = 27;
            this.btnDescrip.UseVisualStyleBackColor = true;
            // 
            // btnSalirAggAlumno
            // 
            this.btnSalirAggAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalirAggAlumno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAggAlumno.Location = new System.Drawing.Point(652, 769);
            this.btnSalirAggAlumno.Name = "btnSalirAggAlumno";
            this.btnSalirAggAlumno.Size = new System.Drawing.Size(110, 39);
            this.btnSalirAggAlumno.TabIndex = 31;
            this.btnSalirAggAlumno.Text = "Regresar";
            this.btnSalirAggAlumno.UseVisualStyleBackColor = true;
            this.btnSalirAggAlumno.Click += new System.EventHandler(this.btnSalirAggAlumno_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(520, 769);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 39);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(388, 769);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 39);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.pnlSuperior;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.lblTitulo;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 864);
            this.Controls.Add(this.btnSalirAggAlumno);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.btnDescrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNoObli;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label lblMensaje6;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblMensaje5;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblMensaje4;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMensaje3;
        private System.Windows.Forms.Label lblCarreras;
        private System.Windows.Forms.Label lblMensaje2;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.Label lblMensaje1;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.TextBox txrtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtFechaInscripcion;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DateTimePicker dtPCalendarioNacimiento;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDocumentoIdentidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDocumentoIdentidad;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFechaInscripcion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Button btnDescrip;
        private System.Windows.Forms.Button btnSalirAggAlumno;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private LOGICA.DragControl dragControl1;
        private LOGICA.DragControl dragControl2;
    }
}