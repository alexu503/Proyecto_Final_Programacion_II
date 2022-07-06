using System.Collections.Generic;
using SistemaUniversidad.LOGICA.LogicalClasses;


namespace SistemaUniversidad.DISEÑO.Administrador{
    partial class NuevoAlumno{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //Listas de alumnos por cada carrera
        private List<Student> listaAlumnoGenerico = new List<Student>();

        //void SaveToLogins() {
        //
        //    MySqlConnection connection = GenerateConnection.Connection();
        //    MySqlCommand query = new MySqlCommand();
        //    query.Connection = connection;
        //
        //    foreach (Student x in listaAlumnoGenerico) {
        //        query.CommandText = "";
        //    }
        //    query.ExecuteNonQuery();
        //    connection.Close();
        //}

        //Save to database
        //void SaveToDatabase() {
        //    
        //    MySqlConnection connection = GenerateConnection.Connection();
        //    MySqlCommand query = new MySqlCommand();
        //    query.Connection = connection;
        //
        //    foreach (Student x in listaAlumnoGenerico) {
        //
        //        query.CommandText = "INSERT INTO Alumnos(Nombres, PrimerApellido, SegundoApellido, NombreCarrera, Carnet, Clave, Matricula, " +
        //        "FechaDeNacimiento, DocumentoDeIdentidad, Sexo, Direccion, Telefono, Celular, Correo, FechaInscripcion, Nacionalidad, EstadoCivil)" +
        //        "VALUES('"+x.getNombres()+"', '"+x.getPrimerApellido()+"', '"+x.getSegundoApellido()+"', '"+x.getCarrera()+"', '"+x.getCarnet()+"', " +
        //        "'"+x.getPasswrd()+"', '"+x.getMatricula().ToString()+"', '"+x.getFechaNacimiento()+"', '"+x.getDocumentoIdentidad()+"', '"+x.getSexo()+"'," +
        //        "'"+x.getDireccion()+"', '"+x.getTelefono()+"', '"+x.getCelular()+"', '"+x.getCorreo()+"', '"+x.getFechaInscripcion()+"', " +
        //        "'"+x.getNacionalidad()+"', '"+x.getEstadoCivil()+"');" +
        //        "INSERT INTO Logins(Usuario, Clave, Rol) VALUES('"+x.getCarnet()+"', '"+x.getPasswrd()+"', 'Estudiante'); " +
        //        "INSERT INTO Notas(NombreCarrera, NombreMateria, CarnetAlumno, PrimerParcial, PrimerLab, SegundoParcial, SegundoLab, TercerParcial, TercerLab, CuartoParcial, CuartoLab, PromedioFinal) " +
        //        "VALUES('"+x.getCarrera()+"', '----', '"+x.getCarnet()+"', '0', '0', '0', '0', '0', '0', '0', '0', '0')";
        //    }
        //    MessageBox.Show("DATOS GUARDADOS CON EXITO", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    query.ExecuteNonQuery();
        //    connection.Close();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoAlumno));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNoObli = new System.Windows.Forms.Label();
            this.btnSalirAggAlumno = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMensaje6 = new System.Windows.Forms.Label();
            this.lblMensaje5 = new System.Windows.Forms.Label();
            this.lblMensaje4 = new System.Windows.Forms.Label();
            this.lblMensaje3 = new System.Windows.Forms.Label();
            this.lblCarreras = new System.Windows.Forms.Label();
            this.lblMensaje2 = new System.Windows.Forms.Label();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txrtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
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
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(19, 21);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(150, 110);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 33;
            this.imgLogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblNoObli);
            this.groupBox1.Controls.Add(this.btnSalirAggAlumno);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.cmbNacionalidad);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.lblMensaje6);
            this.groupBox1.Controls.Add(this.lblMensaje5);
            this.groupBox1.Controls.Add(this.lblMensaje4);
            this.groupBox1.Controls.Add(this.lblMensaje3);
            this.groupBox1.Controls.Add(this.lblCarreras);
            this.groupBox1.Controls.Add(this.lblMensaje2);
            this.groupBox1.Controls.Add(this.cmbCarreras);
            this.groupBox1.Controls.Add(this.lblPrimerApellido);
            this.groupBox1.Controls.Add(this.lblSegundoApellido);
            this.groupBox1.Controls.Add(this.lblNombres);
            this.groupBox1.Controls.Add(this.cmbEstadoCivil);
            this.groupBox1.Controls.Add(this.txrtPrimerApellido);
            this.groupBox1.Controls.Add(this.txtSegundoApellido);
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
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblCelular);
            this.groupBox1.Location = new System.Drawing.Point(175, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 599);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // lblNoObli
            // 
            this.lblNoObli.AutoSize = true;
            this.lblNoObli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoObli.ForeColor = System.Drawing.Color.Maroon;
            this.lblNoObli.Location = new System.Drawing.Point(294, 338);
            this.lblNoObli.Name = "lblNoObli";
            this.lblNoObli.Size = new System.Drawing.Size(104, 16);
            this.lblNoObli.TabIndex = 26;
            this.lblNoObli.Text = "NO OBLIGATORIO";
            // 
            // btnSalirAggAlumno
            // 
            this.btnSalirAggAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalirAggAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirAggAlumno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAggAlumno.Location = new System.Drawing.Point(794, 538);
            this.btnSalirAggAlumno.Name = "btnSalirAggAlumno";
            this.btnSalirAggAlumno.Size = new System.Drawing.Size(110, 39);
            this.btnSalirAggAlumno.TabIndex = 27;
            this.btnSalirAggAlumno.Text = "Regresar";
            this.btnSalirAggAlumno.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(664, 538);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 39);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(305, 432);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(129, 29);
            this.cmbNacionalidad.TabIndex = 25;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(531, 538);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 39);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblMensaje6
            // 
            this.lblMensaje6.AutoSize = true;
            this.lblMensaje6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje6.Location = new System.Drawing.Point(783, 435);
            this.lblMensaje6.Name = "lblMensaje6";
            this.lblMensaje6.Size = new System.Drawing.Size(88, 21);
            this.lblMensaje6.TabIndex = 24;
            this.lblMensaje6.Text = "Mensaje 6";
            // 
            // lblMensaje5
            // 
            this.lblMensaje5.AutoSize = true;
            this.lblMensaje5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje5.Location = new System.Drawing.Point(92, 459);
            this.lblMensaje5.Name = "lblMensaje5";
            this.lblMensaje5.Size = new System.Drawing.Size(88, 21);
            this.lblMensaje5.TabIndex = 24;
            this.lblMensaje5.Text = "Mensaje 5";
            // 
            // lblMensaje4
            // 
            this.lblMensaje4.AutoSize = true;
            this.lblMensaje4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje4.Location = new System.Drawing.Point(783, 314);
            this.lblMensaje4.Name = "lblMensaje4";
            this.lblMensaje4.Size = new System.Drawing.Size(88, 21);
            this.lblMensaje4.TabIndex = 24;
            this.lblMensaje4.Text = "Mensaje 4";
            // 
            // lblMensaje3
            // 
            this.lblMensaje3.AutoSize = true;
            this.lblMensaje3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje3.Location = new System.Drawing.Point(783, 202);
            this.lblMensaje3.Name = "lblMensaje3";
            this.lblMensaje3.Size = new System.Drawing.Size(88, 21);
            this.lblMensaje3.TabIndex = 24;
            this.lblMensaje3.Text = "Mensaje 3";
            // 
            // lblCarreras
            // 
            this.lblCarreras.AutoSize = true;
            this.lblCarreras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarreras.Location = new System.Drawing.Point(28, 524);
            this.lblCarreras.Name = "lblCarreras";
            this.lblCarreras.Size = new System.Drawing.Size(70, 21);
            this.lblCarreras.TabIndex = 4;
            this.lblCarreras.Text = "Carrera";
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.AutoSize = true;
            this.lblMensaje2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje2.Location = new System.Drawing.Point(783, 79);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(88, 21);
            this.lblMensaje2.TabIndex = 24;
            this.lblMensaje2.Text = "Mensaje 2";
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(31, 548);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(305, 29);
            this.cmbCarreras.TabIndex = 5;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(27, 40);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(125, 21);
            this.lblPrimerApellido.TabIndex = 6;
            this.lblPrimerApellido.Text = "Primer Apellido";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(298, 43);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(148, 21);
            this.lblSegundoApellido.TabIndex = 6;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(532, 43);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(79, 21);
            this.lblNombres.TabIndex = 6;
            this.lblNombres.Text = "Nombres";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(526, 435);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(153, 29);
            this.cmbEstadoCivil.TabIndex = 22;
            // 
            // txrtPrimerApellido
            // 
            this.txrtPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txrtPrimerApellido.Location = new System.Drawing.Point(31, 76);
            this.txrtPrimerApellido.Name = "txrtPrimerApellido";
            this.txrtPrimerApellido.Size = new System.Drawing.Size(132, 27);
            this.txrtPrimerApellido.TabIndex = 7;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(306, 79);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(135, 27);
            this.txtSegundoApellido.TabIndex = 8;
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(536, 79);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(200, 27);
            this.txtNombres.TabIndex = 9;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.Location = new System.Drawing.Point(38, 429);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(201, 27);
            this.txtCorreo.TabIndex = 19;
            this.txtCorreo.Tag = "universidad@gmail.com";
            this.txtCorreo.Text = "universidad@gmail.com";
            // 
            // dtPCalendarioNacimiento
            // 
            this.dtPCalendarioNacimiento.CustomFormat = "dd-mm-yyyy";
            this.dtPCalendarioNacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPCalendarioNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPCalendarioNacimiento.Location = new System.Drawing.Point(32, 199);
            this.dtPCalendarioNacimiento.Name = "dtPCalendarioNacimiento";
            this.dtPCalendarioNacimiento.Size = new System.Drawing.Size(131, 27);
            this.dtPCalendarioNacimiento.TabIndex = 10;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.Color.DimGray;
            this.txtCelular.Location = new System.Drawing.Point(526, 314);
            this.txtCelular.MaxLength = 9;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(128, 27);
            this.txtCelular.TabIndex = 18;
            this.txtCelular.Tag = "7259-8563";
            this.txtCelular.Text = "7259-8563";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(28, 164);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(152, 21);
            this.lblFechaNacimiento.TabIndex = 11;
            this.lblFechaNacimiento.Text = "Fecha nacimiento";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(302, 308);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(135, 27);
            this.txtTelefono.TabIndex = 17;
            this.txtTelefono.Tag = "2665-8563";
            this.txtTelefono.Text = "2665-8563";
            // 
            // lblDocumentoIdentidad
            // 
            this.lblDocumentoIdentidad.AutoSize = true;
            this.lblDocumentoIdentidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentoIdentidad.Location = new System.Drawing.Point(303, 164);
            this.lblDocumentoIdentidad.Name = "lblDocumentoIdentidad";
            this.lblDocumentoIdentidad.Size = new System.Drawing.Size(38, 21);
            this.lblDocumentoIdentidad.TabIndex = 12;
            this.lblDocumentoIdentidad.Text = "DUI";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(38, 314);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(164, 27);
            this.txtDireccion.TabIndex = 16;
            // 
            // txtDocumentoIdentidad
            // 
            this.txtDocumentoIdentidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoIdentidad.Location = new System.Drawing.Point(306, 199);
            this.txtDocumentoIdentidad.MaxLength = 10;
            this.txtDocumentoIdentidad.Name = "txtDocumentoIdentidad";
            this.txtDocumentoIdentidad.Size = new System.Drawing.Size(140, 27);
            this.txtDocumentoIdentidad.TabIndex = 13;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(34, 392);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(63, 21);
            this.lblCorreo.TabIndex = 15;
            this.lblCorreo.Text = "Correo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.Location = new System.Drawing.Point(526, 202);
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
            this.lblEstadoCivil.Location = new System.Drawing.Point(522, 400);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(97, 21);
            this.lblEstadoCivil.TabIndex = 15;
            this.lblEstadoCivil.Text = "Estado civil";
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemenino.Location = new System.Drawing.Point(638, 202);
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
            this.lblNacionalidad.Location = new System.Drawing.Point(302, 397);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(116, 21);
            this.lblNacionalidad.TabIndex = 15;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(34, 281);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(83, 21);
            this.lblDireccion.TabIndex = 15;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(298, 275);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(76, 21);
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(556, 281);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(65, 21);
            this.lblCelular.TabIndex = 15;
            this.lblCelular.Text = "Celular";
            // 
            // NuevoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 620);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoAlumno";
            this.Load += new System.EventHandler(this.NuevoAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNoObli;
        private System.Windows.Forms.Button btnSalirAggAlumno;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMensaje6;
        private System.Windows.Forms.Label lblMensaje5;
        private System.Windows.Forms.Label lblMensaje4;
        private System.Windows.Forms.Label lblMensaje3;
        private System.Windows.Forms.Label lblCarreras;
        private System.Windows.Forms.Label lblMensaje2;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.TextBox txrtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
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
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCelular;
    }
}