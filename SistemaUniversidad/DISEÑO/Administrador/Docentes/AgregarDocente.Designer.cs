namespace SistemaUniversidad.DISEÑO.Administrador.Docentes {
    partial class AgregarDocente {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarDocente));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblNewProfessor = new System.Windows.Forms.Label();
            this.txtGetName = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.txtGetFirstSurname = new System.Windows.Forms.TextBox();
            this.lblSecondSurname = new System.Windows.Forms.Label();
            this.txtGetSecondSurname = new System.Windows.Forms.TextBox();
            this.lblFirstCareer = new System.Windows.Forms.Label();
            this.lblSecondCareer = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbGetFirstCareer = new System.Windows.Forms.ComboBox();
            this.cmbGetSecondCareer = new System.Windows.Forms.ComboBox();
            this.cmbGetSubject = new System.Windows.Forms.ComboBox();
            this.pnlSuperior.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlSuperior.Controls.Add(this.lblTitulo);
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(911, 35);
            this.pnlSuperior.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(356, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 20);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Agregar un nuevo docente";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(815, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(866, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 35);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGetSubject);
            this.groupBox1.Controls.Add(this.cmbGetSecondCareer);
            this.groupBox1.Controls.Add(this.cmbGetFirstCareer);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblSubject);
            this.groupBox1.Controls.Add(this.lblSecondCareer);
            this.groupBox1.Controls.Add(this.lblFirstCareer);
            this.groupBox1.Controls.Add(this.txtGetSecondSurname);
            this.groupBox1.Controls.Add(this.lblSecondSurname);
            this.groupBox1.Controls.Add(this.txtGetFirstSurname);
            this.groupBox1.Controls.Add(this.lblPrimerApellido);
            this.groupBox1.Controls.Add(this.txtGetName);
            this.groupBox1.Controls.Add(this.lblNewProfessor);
            this.groupBox1.Location = new System.Drawing.Point(427, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 502);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(91, 177);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(254, 188);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // lblNewProfessor
            // 
            this.lblNewProfessor.AutoSize = true;
            this.lblNewProfessor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProfessor.Location = new System.Drawing.Point(64, 40);
            this.lblNewProfessor.Name = "lblNewProfessor";
            this.lblNewProfessor.Size = new System.Drawing.Size(77, 21);
            this.lblNewProfessor.TabIndex = 0;
            this.lblNewProfessor.Text = "Nombre:";
            // 
            // txtGetName
            // 
            this.txtGetName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetName.Location = new System.Drawing.Point(230, 40);
            this.txtGetName.Multiline = true;
            this.txtGetName.Name = "txtGetName";
            this.txtGetName.Size = new System.Drawing.Size(170, 27);
            this.txtGetName.TabIndex = 1;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(64, 105);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(127, 21);
            this.lblPrimerApellido.TabIndex = 0;
            this.lblPrimerApellido.Text = "Primer apellido:";
            // 
            // txtGetFirstSurname
            // 
            this.txtGetFirstSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetFirstSurname.Location = new System.Drawing.Point(230, 105);
            this.txtGetFirstSurname.Multiline = true;
            this.txtGetFirstSurname.Name = "txtGetFirstSurname";
            this.txtGetFirstSurname.Size = new System.Drawing.Size(170, 27);
            this.txtGetFirstSurname.TabIndex = 1;
            // 
            // lblSecondSurname
            // 
            this.lblSecondSurname.AutoSize = true;
            this.lblSecondSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondSurname.Location = new System.Drawing.Point(64, 171);
            this.lblSecondSurname.Name = "lblSecondSurname";
            this.lblSecondSurname.Size = new System.Drawing.Size(150, 21);
            this.lblSecondSurname.TabIndex = 0;
            this.lblSecondSurname.Text = "Segundo apellido:";
            // 
            // txtGetSecondSurname
            // 
            this.txtGetSecondSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetSecondSurname.Location = new System.Drawing.Point(230, 171);
            this.txtGetSecondSurname.Multiline = true;
            this.txtGetSecondSurname.Name = "txtGetSecondSurname";
            this.txtGetSecondSurname.Size = new System.Drawing.Size(170, 27);
            this.txtGetSecondSurname.TabIndex = 1;
            // 
            // lblFirstCareer
            // 
            this.lblFirstCareer.AutoSize = true;
            this.lblFirstCareer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstCareer.Location = new System.Drawing.Point(64, 239);
            this.lblFirstCareer.Name = "lblFirstCareer";
            this.lblFirstCareer.Size = new System.Drawing.Size(133, 21);
            this.lblFirstCareer.TabIndex = 0;
            this.lblFirstCareer.Text = "Primera carrera:";
            // 
            // lblSecondCareer
            // 
            this.lblSecondCareer.AutoSize = true;
            this.lblSecondCareer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondCareer.Location = new System.Drawing.Point(64, 303);
            this.lblSecondCareer.Name = "lblSecondCareer";
            this.lblSecondCareer.Size = new System.Drawing.Size(146, 21);
            this.lblSecondCareer.TabIndex = 0;
            this.lblSecondCareer.Text = "Segunda carrera:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(64, 371);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(155, 21);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Materia a impartir:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbGetFirstCareer
            // 
            this.cmbGetFirstCareer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbGetFirstCareer.FormattingEnabled = true;
            this.cmbGetFirstCareer.Location = new System.Drawing.Point(230, 238);
            this.cmbGetFirstCareer.Name = "cmbGetFirstCareer";
            this.cmbGetFirstCareer.Size = new System.Drawing.Size(170, 29);
            this.cmbGetFirstCareer.TabIndex = 3;
            this.cmbGetFirstCareer.Text = "Seleccionar";
            // 
            // cmbGetSecondCareer
            // 
            this.cmbGetSecondCareer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbGetSecondCareer.FormattingEnabled = true;
            this.cmbGetSecondCareer.Location = new System.Drawing.Point(230, 300);
            this.cmbGetSecondCareer.Name = "cmbGetSecondCareer";
            this.cmbGetSecondCareer.Size = new System.Drawing.Size(170, 29);
            this.cmbGetSecondCareer.TabIndex = 3;
            this.cmbGetSecondCareer.Text = "Seleccionar";
            // 
            // cmbGetSubject
            // 
            this.cmbGetSubject.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbGetSubject.FormattingEnabled = true;
            this.cmbGetSubject.Location = new System.Drawing.Point(230, 368);
            this.cmbGetSubject.Name = "cmbGetSubject";
            this.cmbGetSubject.Size = new System.Drawing.Size(170, 29);
            this.cmbGetSubject.TabIndex = 3;
            this.cmbGetSubject.Text = "Seleccionar";
            // 
            // AgregarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 555);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarDocente";
            this.Text = "AgregarDocente";
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGetSecondCareer;
        private System.Windows.Forms.ComboBox cmbGetFirstCareer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblSecondCareer;
        private System.Windows.Forms.Label lblFirstCareer;
        private System.Windows.Forms.TextBox txtGetSecondSurname;
        private System.Windows.Forms.Label lblSecondSurname;
        private System.Windows.Forms.TextBox txtGetFirstSurname;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TextBox txtGetName;
        private System.Windows.Forms.Label lblNewProfessor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbGetSubject;
    }
}