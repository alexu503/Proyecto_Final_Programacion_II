using System;
using System.Windows.Forms;
using System.Data.SQLite;
using SistemaUniversidad.LOGICA.DATABASE;
//using SistemaUniversidad.LOGICA.DATABASE.Queries;

namespace SistemaUniversidad.DISEÑO.Administrador.Asignaturas {
    partial class AgregarAsignatura {
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
        void LoadCarrersToCmb() {

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;

            try {
                //Execute query:
                query.CommandText = "SELECT * FROM Careers";
                SQLiteDataReader dr = query.ExecuteReader();

                if (dr.HasRows) {
                    while (dr.Read()) {
                        cmbCarreras.Items.Add(dr.GetString(0));
                    }
                } else {
                    MessageBox.Show("No hay carreras para mostrar");
                    cmbCarreras.Text = "Seleccionar";
                }
            } catch (System.Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                connection.Close();
            }
        }

        void LoadProfessors(string selectedCareer) {
            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;

            try {
                //Execute query:
                query.CommandText = "SELECT ProfessorID FROM Professor WHERE CareerA = @CareerA OR CareerB = @CareerB";
                query.Parameters.Add(new SQLiteParameter("@CareerA", selectedCareer));
                query.Parameters.Add(new SQLiteParameter("@CareerB", selectedCareer));
                SQLiteDataReader dr = query.ExecuteReader();

                if (dr.HasRows) {
                    while (dr.Read()) {
                        cmbSelectProfessor.Items.Add(dr.GetString(0));
                    }
                } else {
                    MessageBox.Show("No hay carreras para mostrar");
                    cmbCarreras.Text = "Seleccionar";
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAsignatura));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cmbSelectProfessor = new System.Windows.Forms.ComboBox();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtGetNewSubjectName = new System.Windows.Forms.TextBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnReturnToMainForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(162, 540);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 31);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancell
            // 
            this.btnCancell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancell.Location = new System.Drawing.Point(776, 540);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(89, 31);
            this.btnCancell.TabIndex = 2;
            this.btnCancell.Text = "Cancelar";
            this.btnCancell.UseVisualStyleBackColor = true;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCarrera);
            this.groupBox1.Controls.Add(this.cmbSelectProfessor);
            this.groupBox1.Controls.Add(this.cmbCarreras);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtGetNewSubjectName);
            this.groupBox1.Location = new System.Drawing.Point(162, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 340);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblCarrera.Location = new System.Drawing.Point(50, 59);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(177, 21);
            this.lblCarrera.TabIndex = 12;
            this.lblCarrera.Text = "Seleccione la carrera:";
            // 
            // cmbSelectProfessor
            // 
            this.cmbSelectProfessor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectProfessor.FormattingEnabled = true;
            this.cmbSelectProfessor.Location = new System.Drawing.Point(351, 255);
            this.cmbSelectProfessor.Name = "cmbSelectProfessor";
            this.cmbSelectProfessor.Size = new System.Drawing.Size(296, 29);
            this.cmbSelectProfessor.TabIndex = 10;
            this.cmbSelectProfessor.Text = "Seleccionar";
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(351, 62);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(296, 29);
            this.cmbCarreras.TabIndex = 11;
            this.cmbCarreras.Text = "Seleccionar";
            this.cmbCarreras.SelectedValueChanged += new System.EventHandler(this.cmbCarreras_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(51, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Docente designado:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNombre.Location = new System.Drawing.Point(51, 161);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(186, 21);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre de la materia:";
            // 
            // txtGetNewSubjectName
            // 
            this.txtGetNewSubjectName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtGetNewSubjectName.Location = new System.Drawing.Point(351, 154);
            this.txtGetNewSubjectName.Name = "txtGetNewSubjectName";
            this.txtGetNewSubjectName.Size = new System.Drawing.Size(296, 27);
            this.txtGetNewSubjectName.TabIndex = 7;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(125, 90);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 4;
            this.imgLogo.TabStop = false;
            // 
            // btnReturnToMainForm
            // 
            this.btnReturnToMainForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainForm.Location = new System.Drawing.Point(1011, 12);
            this.btnReturnToMainForm.Name = "btnReturnToMainForm";
            this.btnReturnToMainForm.Size = new System.Drawing.Size(48, 35);
            this.btnReturnToMainForm.TabIndex = 14;
            this.btnReturnToMainForm.Text = "X";
            this.btnReturnToMainForm.UseVisualStyleBackColor = true;
            this.btnReturnToMainForm.Click += new System.EventHandler(this.btnReturnToMainForm_Click);
            // 
            // AgregarAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 686);
            this.Controls.Add(this.btnReturnToMainForm);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarAsignatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarAsignatura";
            this.Load += new System.EventHandler(this.AgregarAsignatura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cmbSelectProfessor;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtGetNewSubjectName;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnReturnToMainForm;
    }
}