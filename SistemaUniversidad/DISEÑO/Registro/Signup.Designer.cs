using System.Collections.Generic;
using SistemaUniversidad.LOGICA.LogicalClasses;

namespace SistemaUniversidad.DISEÑO.Registro {
    partial class Signup {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        List<Student> lstStudent = new List<Student>();

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancell = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.lblNoObli = new System.Windows.Forms.Label();
            this.cmbGetNationality = new System.Windows.Forms.ComboBox();
            this.lblCareer = new System.Windows.Forms.Label();
            this.cmbGetCareer = new System.Windows.Forms.ComboBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbGetMaritalStatus = new System.Windows.Forms.ComboBox();
            this.txtGetLastname = new System.Windows.Forms.TextBox();
            this.txtGetName = new System.Windows.Forms.TextBox();
            this.txtGetEmail = new System.Windows.Forms.TextBox();
            this.dtPGetBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtGetMobilePhone = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtGetPhone = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtGetAddress = new System.Windows.Forms.TextBox();
            this.txtGetDNI = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMobilePhone = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 41);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(150, 110);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 35;
            this.imgLogo.TabStop = false;
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.ForeColor = System.Drawing.Color.White;
            this.lblDescrip.Location = new System.Drawing.Point(474, 2);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(171, 33);
            this.lblDescrip.TabIndex = 34;
            this.lblDescrip.Text = "Registrarme";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnCancell);
            this.groupBox1.Controls.Add(this.btnSignup);
            this.groupBox1.Controls.Add(this.lblNoObli);
            this.groupBox1.Controls.Add(this.cmbGetNationality);
            this.groupBox1.Controls.Add(this.lblCareer);
            this.groupBox1.Controls.Add(this.cmbGetCareer);
            this.groupBox1.Controls.Add(this.lblLastname);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.cmbGetMaritalStatus);
            this.groupBox1.Controls.Add(this.txtGetLastname);
            this.groupBox1.Controls.Add(this.txtGetName);
            this.groupBox1.Controls.Add(this.txtGetEmail);
            this.groupBox1.Controls.Add(this.dtPGetBirthday);
            this.groupBox1.Controls.Add(this.txtGetMobilePhone);
            this.groupBox1.Controls.Add(this.lblBirthday);
            this.groupBox1.Controls.Add(this.txtGetPhone);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Controls.Add(this.lblDNI);
            this.groupBox1.Controls.Add(this.txtGetAddress);
            this.groupBox1.Controls.Add(this.txtGetDNI);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.rbtnMale);
            this.groupBox1.Controls.Add(this.lblMaritalStatus);
            this.groupBox1.Controls.Add(this.rbtnFemale);
            this.groupBox1.Controls.Add(this.lblNacionalidad);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblMobilePhone);
            this.groupBox1.Location = new System.Drawing.Point(156, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 600);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // btnCancell
            // 
            this.btnCancell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancell.Location = new System.Drawing.Point(571, 528);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(113, 44);
            this.btnCancell.TabIndex = 27;
            this.btnCancell.Text = "Cancelar";
            this.btnCancell.UseVisualStyleBackColor = true;
            // 
            // btnSignup
            // 
            this.btnSignup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(198, 528);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(113, 44);
            this.btnSignup.TabIndex = 27;
            this.btnSignup.Text = "Registrarme";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblNoObli
            // 
            this.lblNoObli.AutoSize = true;
            this.lblNoObli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoObli.ForeColor = System.Drawing.Color.Maroon;
            this.lblNoObli.Location = new System.Drawing.Point(656, 291);
            this.lblNoObli.Name = "lblNoObli";
            this.lblNoObli.Size = new System.Drawing.Size(104, 16);
            this.lblNoObli.TabIndex = 26;
            this.lblNoObli.Text = "NO OBLIGATORIO";
            // 
            // cmbGetNationality
            // 
            this.cmbGetNationality.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetNationality.FormattingEnabled = true;
            this.cmbGetNationality.Location = new System.Drawing.Point(609, 376);
            this.cmbGetNationality.Name = "cmbGetNationality";
            this.cmbGetNationality.Size = new System.Drawing.Size(151, 29);
            this.cmbGetNationality.TabIndex = 25;
            // 
            // lblCareer
            // 
            this.lblCareer.AutoSize = true;
            this.lblCareer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCareer.Location = new System.Drawing.Point(477, 459);
            this.lblCareer.Name = "lblCareer";
            this.lblCareer.Size = new System.Drawing.Size(70, 21);
            this.lblCareer.TabIndex = 4;
            this.lblCareer.Text = "Carrera";
            // 
            // cmbGetCareer
            // 
            this.cmbGetCareer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetCareer.FormattingEnabled = true;
            this.cmbGetCareer.Location = new System.Drawing.Point(571, 454);
            this.cmbGetCareer.Name = "cmbGetCareer";
            this.cmbGetCareer.Size = new System.Drawing.Size(307, 29);
            this.cmbGetCareer.TabIndex = 5;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(26, 49);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(74, 21);
            this.lblLastname.TabIndex = 6;
            this.lblLastname.Text = "Apellido";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(474, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 21);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nombres";
            // 
            // cmbGetMaritalStatus
            // 
            this.cmbGetMaritalStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetMaritalStatus.FormattingEnabled = true;
            this.cmbGetMaritalStatus.Location = new System.Drawing.Point(135, 451);
            this.cmbGetMaritalStatus.Name = "cmbGetMaritalStatus";
            this.cmbGetMaritalStatus.Size = new System.Drawing.Size(172, 29);
            this.cmbGetMaritalStatus.TabIndex = 22;
            // 
            // txtGetLastname
            // 
            this.txtGetLastname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetLastname.Location = new System.Drawing.Point(131, 46);
            this.txtGetLastname.Name = "txtGetLastname";
            this.txtGetLastname.Size = new System.Drawing.Size(132, 27);
            this.txtGetLastname.TabIndex = 7;
            this.txtGetLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetLastname_KeyPress);
            // 
            // txtGetName
            // 
            this.txtGetName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetName.Location = new System.Drawing.Point(571, 49);
            this.txtGetName.Name = "txtGetName";
            this.txtGetName.Size = new System.Drawing.Size(142, 27);
            this.txtGetName.TabIndex = 9;
            this.txtGetName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetName_KeyPress);
            // 
            // txtGetEmail
            // 
            this.txtGetEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtGetEmail.Location = new System.Drawing.Point(559, 214);
            this.txtGetEmail.Name = "txtGetEmail";
            this.txtGetEmail.Size = new System.Drawing.Size(201, 27);
            this.txtGetEmail.TabIndex = 19;
            this.txtGetEmail.Tag = "universidad@gmail.com";
            this.txtGetEmail.Text = "universidad@gmail.com";
            // 
            // dtPGetBirthday
            // 
            this.dtPGetBirthday.CustomFormat = "dd-mm-yyyy";
            this.dtPGetBirthday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPGetBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPGetBirthday.Location = new System.Drawing.Point(242, 135);
            this.dtPGetBirthday.Name = "dtPGetBirthday";
            this.dtPGetBirthday.Size = new System.Drawing.Size(131, 27);
            this.dtPGetBirthday.TabIndex = 10;
            // 
            // txtGetMobilePhone
            // 
            this.txtGetMobilePhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetMobilePhone.ForeColor = System.Drawing.Color.DimGray;
            this.txtGetMobilePhone.Location = new System.Drawing.Point(242, 286);
            this.txtGetMobilePhone.MaxLength = 9;
            this.txtGetMobilePhone.Name = "txtGetMobilePhone";
            this.txtGetMobilePhone.Size = new System.Drawing.Size(136, 27);
            this.txtGetMobilePhone.TabIndex = 18;
            this.txtGetMobilePhone.Tag = "7259-8563";
            this.txtGetMobilePhone.Text = "7259-8563";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(26, 135);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(177, 21);
            this.lblBirthday.TabIndex = 11;
            this.lblBirthday.Text = "Fecha de nacimiento";
            // 
            // txtGetPhone
            // 
            this.txtGetPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetPhone.ForeColor = System.Drawing.Color.DimGray;
            this.txtGetPhone.Location = new System.Drawing.Point(558, 286);
            this.txtGetPhone.MaxLength = 9;
            this.txtGetPhone.Name = "txtGetPhone";
            this.txtGetPhone.Size = new System.Drawing.Size(92, 27);
            this.txtGetPhone.TabIndex = 17;
            this.txtGetPhone.Tag = "7259-8563";
            this.txtGetPhone.Text = "7259-8563";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(475, 130);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(46, 21);
            this.lblSex.TabIndex = 12;
            this.lblSex.Text = "Sexo";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(27, 211);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(210, 21);
            this.lblDNI.TabIndex = 12;
            this.lblDNI.Text = "Documento de identidad";
            // 
            // txtGetAddress
            // 
            this.txtGetAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetAddress.Location = new System.Drawing.Point(131, 370);
            this.txtGetAddress.Name = "txtGetAddress";
            this.txtGetAddress.Size = new System.Drawing.Size(318, 27);
            this.txtGetAddress.TabIndex = 16;
            // 
            // txtGetDNI
            // 
            this.txtGetDNI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetDNI.Location = new System.Drawing.Point(243, 208);
            this.txtGetDNI.MaxLength = 10;
            this.txtGetDNI.Name = "txtGetDNI";
            this.txtGetDNI.Size = new System.Drawing.Size(135, 27);
            this.txtGetDNI.TabIndex = 13;
            this.txtGetDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetDNI_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(478, 214);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 21);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Correo";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(527, 130);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(106, 25);
            this.rbtnMale.TabIndex = 14;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Masculino";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritalStatus.Location = new System.Drawing.Point(32, 454);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(97, 21);
            this.lblMaritalStatus.TabIndex = 15;
            this.lblMaritalStatus.Text = "Estado civil";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(639, 130);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(104, 25);
            this.rbtnFemale.TabIndex = 14;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Femenino";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(478, 376);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(116, 21);
            this.lblNacionalidad.TabIndex = 15;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(32, 373);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(83, 21);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Dirección";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(477, 289);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(76, 21);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Teléfono";
            // 
            // lblMobilePhone
            // 
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobilePhone.Location = new System.Drawing.Point(26, 292);
            this.lblMobilePhone.Name = "lblMobilePhone";
            this.lblMobilePhone.Size = new System.Drawing.Size(144, 21);
            this.lblMobilePhone.TabIndex = 15;
            this.lblMobilePhone.Text = "Teléfono (celular)";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Controls.Add(this.lblDescrip);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1094, 35);
            this.pnlSuperior.TabIndex = 33;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1051, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(43, 35);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 653);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNoObli;
        private System.Windows.Forms.ComboBox cmbGetNationality;
        private System.Windows.Forms.Label lblCareer;
        private System.Windows.Forms.ComboBox cmbGetCareer;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbGetMaritalStatus;
        private System.Windows.Forms.TextBox txtGetLastname;
        private System.Windows.Forms.TextBox txtGetName;
        private System.Windows.Forms.TextBox txtGetEmail;
        private System.Windows.Forms.DateTimePicker dtPGetBirthday;
        private System.Windows.Forms.TextBox txtGetMobilePhone;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox txtGetPhone;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtGetAddress;
        private System.Windows.Forms.TextBox txtGetDNI;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMobilePhone;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label lblSex;
    }
}