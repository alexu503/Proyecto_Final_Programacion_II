using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.DISEÑO.Administrador.Asignaturas {
    partial class BuscarAsignatura {
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
                query.CommandText = "SELECT Career FROM Subjects";
                SQLiteDataReader dr = query.ExecuteReader();

                if (dr.HasRows) {
                    while (dr.Read()) {
                        cmbCarreras.Items.Add(dr.GetString(0));
                    }
                } else {
                    MessageBox.Show("No hay carreras para mostrar");
                }
            } catch (System.Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                connection.Close();
            }
        }

        void LoadSubjectsToCMB(ref string selectedCareer) {

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;

            try {
                //Execute query:
                query.CommandText = "SELECT Subject FROM Subjects WHERE Career = @SelectedCareer";
                query.Parameters.Add(new SQLiteParameter("@SelectedCareer", selectedCareer));
                SQLiteDataReader dr = query.ExecuteReader();

                if (dr.HasRows) {
                    while (dr.Read()) {
                        cmbGetSubjects.Items.Add(dr.GetString(1));
                    }
                } else {
                    MessageBox.Show("No hay carreras para mostrar");
                }
            } catch (System.Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                connection.Close();
            }
        }

        void LoadResultsToGrid(ref string selectedCareer, ref string selectedSubject) {
            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;

            try {
                SQLiteDataReader dr = query.ExecuteReader();

                if (dr.HasRows) {
                    //Execute query:
                    query.CommandText = "SELECT Career, Subject FROM Subjects WHERE Career = @SelectedCareer AND Subject = @SelectedSubject";
                    query.Parameters.Add(new SQLiteParameter("@SelectedCareer", selectedCareer));
                    query.Parameters.Add(new SQLiteParameter("@SelectedSubject", selectedSubject));

                    SQLiteDataAdapter da = new SQLiteDataAdapter();
                    da.SelectCommand = query;
                    DataTable table = new DataTable();
                    da.Fill(table);
                    MessageBox.Show("Datos actualizados");
                    //Show it to datagrid
                    dgvShowData.DataSource = table;
                } else {
                    MessageBox.Show("No hay nada para mostrar");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarAsignatura));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cmbGetSubjects = new System.Windows.Forms.ComboBox();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnReturnToMainForm = new System.Windows.Forms.Button();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCarrera);
            this.groupBox1.Controls.Add(this.cmbGetSubjects);
            this.groupBox1.Controls.Add(this.cmbCarreras);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(199, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 270);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblCarrera.Location = new System.Drawing.Point(51, 39);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(177, 21);
            this.lblCarrera.TabIndex = 12;
            this.lblCarrera.Text = "Seleccione la carrera:";
            // 
            // cmbGetSubjects
            // 
            this.cmbGetSubjects.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetSubjects.FormattingEnabled = true;
            this.cmbGetSubjects.Location = new System.Drawing.Point(352, 138);
            this.cmbGetSubjects.Name = "cmbGetSubjects";
            this.cmbGetSubjects.Size = new System.Drawing.Size(296, 29);
            this.cmbGetSubjects.TabIndex = 11;
            this.cmbGetSubjects.Text = "Seleccionar";
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(352, 42);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(296, 29);
            this.cmbCarreras.TabIndex = 11;
            this.cmbCarreras.Text = "Seleccionar";
            this.cmbCarreras.TextUpdate += new System.EventHandler(this.cmbCarreras_TextUpdate);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(55, 215);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 31);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Ver";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNombre.Location = new System.Drawing.Point(52, 141);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(186, 21);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre de la materia:";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(125, 90);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 8;
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
            // dgvShowData
            // 
            this.dgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowData.Location = new System.Drawing.Point(54, 309);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.Size = new System.Drawing.Size(954, 326);
            this.dgvShowData.TabIndex = 15;
            // 
            // BuscarAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 686);
            this.Controls.Add(this.dgvShowData);
            this.Controls.Add(this.btnReturnToMainForm);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarAsignatura";
            this.Text = "BuscarAsignatura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReturnToMainForm;
        private System.Windows.Forms.ComboBox cmbGetSubjects;
        private System.Windows.Forms.DataGridView dgvShowData;
    }
}