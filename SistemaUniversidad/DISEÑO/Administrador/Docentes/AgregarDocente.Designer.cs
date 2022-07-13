using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using SistemaUniversidad.LOGICA.LogicalClasses;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.DISEÑO.Administrador.Docentes {
    partial class AgregarDocente {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        List<Proffessor> lstProfessor = new List<Proffessor>();

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

        void LoadFirstCarrerToCmb() {

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;

            try {
                //Execute query:
                query.CommandText = "SELECT * FROM Careers";
                SQLiteDataReader dr = query.ExecuteReader();

                if (dr.HasRows) {
                    while (dr.Read()) {
                        cmbGetFirstCareer.Items.Add(dr.GetString(0));
                    }
                } else {
                    MessageBox.Show("No hay carreras para mostrar");
                    cmbGetFirstCareer.Text = "Seleccionar";
                }
            } catch (System.Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                connection.Close();
            }
        }

        void LoadSecondCareerToCmb() {

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;

            try {
                //Execute query:
                query.CommandText = "SELECT * FROM Careers";
                SQLiteDataReader dr = query.ExecuteReader();

                if (dr.HasRows) {
                    while (dr.Read()) {
                        cmbGetSecondCareer.Items.Add(dr.GetString(0));
                    }
                } else {
                    MessageBox.Show("No hay carreras para mostrar");
                    cmbGetSecondCareer.Text = "Seleccionar";
                }
            } catch (System.Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                connection.Close();
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarDocente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGetSecondCareer = new System.Windows.Forms.ComboBox();
            this.cmbGetFirstCareer = new System.Windows.Forms.ComboBox();
            this.btnCancell = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblSecondCareer = new System.Windows.Forms.Label();
            this.lblFirstCareer = new System.Windows.Forms.Label();
            this.txtGetSecondSurname = new System.Windows.Forms.TextBox();
            this.lblSecondSurname = new System.Windows.Forms.Label();
            this.txtGetFirstSurname = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.txtGetName = new System.Windows.Forms.TextBox();
            this.lblNewProfessor = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGetSecondCareer);
            this.groupBox1.Controls.Add(this.cmbGetFirstCareer);
            this.groupBox1.Controls.Add(this.btnCancell);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lblSecondCareer);
            this.groupBox1.Controls.Add(this.lblFirstCareer);
            this.groupBox1.Controls.Add(this.txtGetSecondSurname);
            this.groupBox1.Controls.Add(this.lblSecondSurname);
            this.groupBox1.Controls.Add(this.txtGetFirstSurname);
            this.groupBox1.Controls.Add(this.lblPrimerApellido);
            this.groupBox1.Controls.Add(this.txtGetName);
            this.groupBox1.Controls.Add(this.lblNewProfessor);
            this.groupBox1.Location = new System.Drawing.Point(464, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 662);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cmbGetSecondCareer
            // 
            this.cmbGetSecondCareer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbGetSecondCareer.FormattingEnabled = true;
            this.cmbGetSecondCareer.Location = new System.Drawing.Point(338, 442);
            this.cmbGetSecondCareer.Name = "cmbGetSecondCareer";
            this.cmbGetSecondCareer.Size = new System.Drawing.Size(170, 29);
            this.cmbGetSecondCareer.TabIndex = 3;
            this.cmbGetSecondCareer.Text = "Seleccionar";
            this.cmbGetSecondCareer.TextChanged += new System.EventHandler(this.cmbGetSecondCareer_TextChanged);
            // 
            // cmbGetFirstCareer
            // 
            this.cmbGetFirstCareer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbGetFirstCareer.FormattingEnabled = true;
            this.cmbGetFirstCareer.Location = new System.Drawing.Point(338, 341);
            this.cmbGetFirstCareer.Name = "cmbGetFirstCareer";
            this.cmbGetFirstCareer.Size = new System.Drawing.Size(170, 29);
            this.cmbGetFirstCareer.TabIndex = 3;
            this.cmbGetFirstCareer.Text = "Seleccionar";
            this.cmbGetFirstCareer.TextChanged += new System.EventHandler(this.cmbGetFirstCareer_TextChanged);
            // 
            // btnCancell
            // 
            this.btnCancell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancell.Location = new System.Drawing.Point(410, 561);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(98, 37);
            this.btnCancell.TabIndex = 2;
            this.btnCancell.Text = "Cancelar";
            this.btnCancell.UseVisualStyleBackColor = true;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(84, 561);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 37);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblSecondCareer
            // 
            this.lblSecondCareer.AutoSize = true;
            this.lblSecondCareer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondCareer.Location = new System.Drawing.Point(55, 442);
            this.lblSecondCareer.Name = "lblSecondCareer";
            this.lblSecondCareer.Size = new System.Drawing.Size(146, 21);
            this.lblSecondCareer.TabIndex = 0;
            this.lblSecondCareer.Text = "Segunda carrera:";
            // 
            // lblFirstCareer
            // 
            this.lblFirstCareer.AutoSize = true;
            this.lblFirstCareer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstCareer.Location = new System.Drawing.Point(55, 344);
            this.lblFirstCareer.Name = "lblFirstCareer";
            this.lblFirstCareer.Size = new System.Drawing.Size(133, 21);
            this.lblFirstCareer.TabIndex = 0;
            this.lblFirstCareer.Text = "Primera carrera:";
            // 
            // txtGetSecondSurname
            // 
            this.txtGetSecondSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetSecondSurname.Location = new System.Drawing.Point(338, 242);
            this.txtGetSecondSurname.Multiline = true;
            this.txtGetSecondSurname.Name = "txtGetSecondSurname";
            this.txtGetSecondSurname.Size = new System.Drawing.Size(170, 27);
            this.txtGetSecondSurname.TabIndex = 1;
            this.txtGetSecondSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetSecondSurname_KeyPress);
            // 
            // lblSecondSurname
            // 
            this.lblSecondSurname.AutoSize = true;
            this.lblSecondSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondSurname.Location = new System.Drawing.Point(55, 242);
            this.lblSecondSurname.Name = "lblSecondSurname";
            this.lblSecondSurname.Size = new System.Drawing.Size(150, 21);
            this.lblSecondSurname.TabIndex = 0;
            this.lblSecondSurname.Text = "Segundo apellido:";
            // 
            // txtGetFirstSurname
            // 
            this.txtGetFirstSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetFirstSurname.Location = new System.Drawing.Point(338, 143);
            this.txtGetFirstSurname.Multiline = true;
            this.txtGetFirstSurname.Name = "txtGetFirstSurname";
            this.txtGetFirstSurname.Size = new System.Drawing.Size(170, 27);
            this.txtGetFirstSurname.TabIndex = 1;
            this.txtGetFirstSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetFirstSurname_KeyPress);
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(55, 143);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(127, 21);
            this.lblPrimerApellido.TabIndex = 0;
            this.lblPrimerApellido.Text = "Primer apellido:";
            // 
            // txtGetName
            // 
            this.txtGetName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetName.Location = new System.Drawing.Point(338, 43);
            this.txtGetName.Multiline = true;
            this.txtGetName.Name = "txtGetName";
            this.txtGetName.Size = new System.Drawing.Size(170, 27);
            this.txtGetName.TabIndex = 1;
            this.txtGetName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetName_KeyPress);
            // 
            // lblNewProfessor
            // 
            this.lblNewProfessor.AutoSize = true;
            this.lblNewProfessor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProfessor.Location = new System.Drawing.Point(55, 43);
            this.lblNewProfessor.Name = "lblNewProfessor";
            this.lblNewProfessor.Size = new System.Drawing.Size(77, 21);
            this.lblNewProfessor.TabIndex = 0;
            this.lblNewProfessor.Text = "Nombre:";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.Location = new System.Drawing.Point(13, 13);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(50, 50);
            this.btnCloseForm.TabIndex = 6;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(104, 196);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(270, 250);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // AgregarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 686);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarDocente";
            this.Text = "AgregarDocente";
            this.Load += new System.EventHandler(this.AgregarDocente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGetSecondCareer;
        private System.Windows.Forms.ComboBox cmbGetFirstCareer;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblSecondCareer;
        private System.Windows.Forms.Label lblFirstCareer;
        private System.Windows.Forms.TextBox txtGetSecondSurname;
        private System.Windows.Forms.Label lblSecondSurname;
        private System.Windows.Forms.TextBox txtGetFirstSurname;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TextBox txtGetName;
        private System.Windows.Forms.Label lblNewProfessor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnCloseForm;
    }
}