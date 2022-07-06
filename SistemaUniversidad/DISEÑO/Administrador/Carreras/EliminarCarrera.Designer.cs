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
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancell = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbDeleteCareers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(122, 130);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(262, 21);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Seleccionar la carrera a eliminar:";
            // 
            // btnCancell
            // 
            this.btnCancell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancell.Location = new System.Drawing.Point(537, 253);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(97, 31);
            this.btnCancell.TabIndex = 9;
            this.btnCancell.Text = "Cancelar";
            this.btnCancell.UseVisualStyleBackColor = true;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(126, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 31);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbDeleteCareers
            // 
            this.cmbDeleteCareers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteCareers.FormattingEnabled = true;
            this.cmbDeleteCareers.Location = new System.Drawing.Point(419, 127);
            this.cmbDeleteCareers.Name = "cmbDeleteCareers";
            this.cmbDeleteCareers.Size = new System.Drawing.Size(215, 29);
            this.cmbDeleteCareers.TabIndex = 13;
            this.cmbDeleteCareers.Text = "Seleccionar";
            // 
            // EliminarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 420);
            this.Controls.Add(this.cmbDeleteCareers);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarCarrera";
            this.Load += new System.EventHandler(this.EliminarCarrera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbDeleteCareers;
    }
}