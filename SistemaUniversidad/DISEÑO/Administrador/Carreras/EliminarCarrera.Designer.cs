using System;
using System.Windows.Forms;
using SistemaUniversidad.LOGICA.DATABASE.Queries;

namespace SistemaUniversidad.DISEÑO.Administrador.Carreras {
    partial class EliminarCarrera {
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

        void LoadCareers() {

            try {
                cmbDeleteCareers.Text = "Selecciona una carrerea";
                if (SearchData.GetCareers().HasRows) {
                    while (SearchData.GetCareers().Read()) {
                        cmbDeleteCareers.Items.Add(SearchData.GetCareers().GetString(0));
                    }
                } else {
                    MessageBox.Show("No hay carreras para mostrar");
                }
            }catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarCarrera));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDeleteCareers = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancell = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReturnToMainForm = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDeleteCareers);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.btnCancell);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(188, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbDeleteCareers
            // 
            this.cmbDeleteCareers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteCareers.FormattingEnabled = true;
            this.cmbDeleteCareers.Location = new System.Drawing.Point(403, 145);
            this.cmbDeleteCareers.Name = "cmbDeleteCareers";
            this.cmbDeleteCareers.Size = new System.Drawing.Size(215, 29);
            this.cmbDeleteCareers.TabIndex = 17;
            this.cmbDeleteCareers.Text = "Seleccionar";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(106, 148);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(262, 21);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Seleccionar la carrera a eliminar:";
            // 
            // btnCancell
            // 
            this.btnCancell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancell.Location = new System.Drawing.Point(521, 271);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(97, 31);
            this.btnCancell.TabIndex = 14;
            this.btnCancell.Text = "Cancelar";
            this.btnCancell.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(110, 271);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 31);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturnToMainForm
            // 
            this.btnReturnToMainForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainForm.Location = new System.Drawing.Point(1011, 12);
            this.btnReturnToMainForm.Name = "btnReturnToMainForm";
            this.btnReturnToMainForm.Size = new System.Drawing.Size(48, 35);
            this.btnReturnToMainForm.TabIndex = 19;
            this.btnReturnToMainForm.Text = "X";
            this.btnReturnToMainForm.UseVisualStyleBackColor = true;
            this.btnReturnToMainForm.Click += new System.EventHandler(this.btnReturnToMainForm_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(125, 90);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 18;
            this.imgLogo.TabStop = false;
            // 
            // EliminarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 686);
            this.Controls.Add(this.btnReturnToMainForm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarCarrera";
            this.Load += new System.EventHandler(this.EliminarCarrera_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbDeleteCareers;
        private Label lblNombre;
        private Button btnCancell;
        private Button btnDelete;
        private Button btnReturnToMainForm;
        private PictureBox imgLogo;
    }
}