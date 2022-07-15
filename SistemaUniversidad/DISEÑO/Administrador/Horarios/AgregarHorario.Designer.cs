using System;
using System.Windows.Forms;
using System.Data.SQLite;
using SistemaUniversidad.LOGICA.DATABASE;
using SistemaUniversidad.LOGICA.DATABASE.Queries;

namespace SistemaUniversidad.DISEÑO.Administrador.Horarios {
    partial class AgregarHorario {
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
                        cmbGetCareerList.Items.Add(dr.GetString(0));
                    }
                } else {
                    MessageBox.Show("No hay carreras para mostrar");
                    cmbGetCareerList.Text = "Seleccionar";
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                connection.Close();
            }
        }

        void LoadSubjects(string selectedCareer) {
            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;

            try {
                //Execute query:
                query.CommandText = "SELECT Subject FROM Subjects WHERE Career = @CareerA OR Career = @CareerB";
                query.Parameters.Add(new SQLiteParameter("@CareerA", selectedCareer));
                query.Parameters.Add(new SQLiteParameter("@CareerB", selectedCareer));
                SQLiteDataReader dr = query.ExecuteReader();

                if (dr.HasRows) {
                    while (dr.Read()) {
                        cmbSelectSubject.Items.Add(dr.GetString(0));
                    }
                } else {
                    MessageBox.Show("No hay materias para mostrar");
                    cmbSelectSubject.Text = "Seleccionar";
                }
            } catch (Exception ex) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarHorario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSubjectList = new System.Windows.Forms.Label();
            this.cmbSelectSubject = new System.Windows.Forms.ComboBox();
            this.cmbGetCareerList = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancell = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnReturnToMainForm = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSecondSurname = new System.Windows.Forms.Label();
            this.cmbGetSecondMinuteA = new System.Windows.Forms.ComboBox();
            this.cmbGetSecondHourA = new System.Windows.Forms.ComboBox();
            this.cmbGetFirstMinuteA = new System.Windows.Forms.ComboBox();
            this.cmbGetFirstHourA = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGetSecondMinuteB = new System.Windows.Forms.ComboBox();
            this.cmbGetSecondHourB = new System.Windows.Forms.ComboBox();
            this.cmbGetFirstMinuteB = new System.Windows.Forms.ComboBox();
            this.cmbGetFirstHourB = new System.Windows.Forms.ComboBox();
            this.lblSelectDay = new System.Windows.Forms.Label();
            this.cmbSelectFirstDay = new System.Windows.Forms.ComboBox();
            this.cmbSelectSecondDay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSubjectList);
            this.groupBox1.Controls.Add(this.cmbSelectSubject);
            this.groupBox1.Controls.Add(this.cmbGetCareerList);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(152, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 145);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // lblSubjectList
            // 
            this.lblSubjectList.AutoSize = true;
            this.lblSubjectList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectList.Location = new System.Drawing.Point(49, 98);
            this.lblSubjectList.Name = "lblSubjectList";
            this.lblSubjectList.Size = new System.Drawing.Size(170, 21);
            this.lblSubjectList.TabIndex = 30;
            this.lblSubjectList.Text = "Seleccionar materia:";
            // 
            // cmbSelectSubject
            // 
            this.cmbSelectSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectSubject.FormattingEnabled = true;
            this.cmbSelectSubject.Location = new System.Drawing.Point(531, 90);
            this.cmbSelectSubject.Name = "cmbSelectSubject";
            this.cmbSelectSubject.Size = new System.Drawing.Size(215, 29);
            this.cmbSelectSubject.TabIndex = 24;
            this.cmbSelectSubject.Text = "Seleccionar";
            // 
            // cmbGetCareerList
            // 
            this.cmbGetCareerList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetCareerList.FormattingEnabled = true;
            this.cmbGetCareerList.Location = new System.Drawing.Point(531, 17);
            this.cmbGetCareerList.Name = "cmbGetCareerList";
            this.cmbGetCareerList.Size = new System.Drawing.Size(215, 29);
            this.cmbGetCareerList.TabIndex = 24;
            this.cmbGetCareerList.Text = "Seleccionar";
            this.cmbGetCareerList.SelectedValueChanged += new System.EventHandler(this.cmbGetCareerList_SelectedValueChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(49, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(165, 21);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Seleccionar carrera:";
            // 
            // btnCancell
            // 
            this.btnCancell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancell.Location = new System.Drawing.Point(663, 631);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(98, 37);
            this.btnCancell.TabIndex = 34;
            this.btnCancell.Text = "Cancelar";
            this.btnCancell.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(321, 631);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 37);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnReturnToMainForm
            // 
            this.btnReturnToMainForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainForm.Location = new System.Drawing.Point(1011, 18);
            this.btnReturnToMainForm.Name = "btnReturnToMainForm";
            this.btnReturnToMainForm.Size = new System.Drawing.Size(48, 35);
            this.btnReturnToMainForm.TabIndex = 28;
            this.btnReturnToMainForm.Text = "X";
            this.btnReturnToMainForm.UseVisualStyleBackColor = true;
            this.btnReturnToMainForm.Click += new System.EventHandler(this.btnReturnToMainForm_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 18);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(125, 90);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 29;
            this.imgLogo.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSelectDay);
            this.groupBox2.Controls.Add(this.cmbSelectFirstDay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblSecondSurname);
            this.groupBox2.Controls.Add(this.cmbGetSecondMinuteA);
            this.groupBox2.Controls.Add(this.cmbGetSecondHourA);
            this.groupBox2.Controls.Add(this.cmbGetFirstMinuteA);
            this.groupBox2.Controls.Add(this.cmbGetFirstHourA);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(152, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 207);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Primer horario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Hora de fin:";
            // 
            // lblSecondSurname
            // 
            this.lblSecondSurname.AutoSize = true;
            this.lblSecondSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondSurname.Location = new System.Drawing.Point(49, 101);
            this.lblSecondSurname.Name = "lblSecondSurname";
            this.lblSecondSurname.Size = new System.Drawing.Size(116, 21);
            this.lblSecondSurname.TabIndex = 35;
            this.lblSecondSurname.Text = "Hora de inico:";
            // 
            // cmbGetSecondMinuteA
            // 
            this.cmbGetSecondMinuteA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetSecondMinuteA.FormattingEnabled = true;
            this.cmbGetSecondMinuteA.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmbGetSecondMinuteA.Location = new System.Drawing.Point(668, 153);
            this.cmbGetSecondMinuteA.Name = "cmbGetSecondMinuteA";
            this.cmbGetSecondMinuteA.Size = new System.Drawing.Size(78, 29);
            this.cmbGetSecondMinuteA.TabIndex = 29;
            // 
            // cmbGetSecondHourA
            // 
            this.cmbGetSecondHourA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetSecondHourA.FormattingEnabled = true;
            this.cmbGetSecondHourA.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cmbGetSecondHourA.Location = new System.Drawing.Point(531, 153);
            this.cmbGetSecondHourA.Name = "cmbGetSecondHourA";
            this.cmbGetSecondHourA.Size = new System.Drawing.Size(78, 29);
            this.cmbGetSecondHourA.TabIndex = 30;
            // 
            // cmbGetFirstMinuteA
            // 
            this.cmbGetFirstMinuteA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetFirstMinuteA.FormattingEnabled = true;
            this.cmbGetFirstMinuteA.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmbGetFirstMinuteA.Location = new System.Drawing.Point(668, 98);
            this.cmbGetFirstMinuteA.Name = "cmbGetFirstMinuteA";
            this.cmbGetFirstMinuteA.Size = new System.Drawing.Size(78, 29);
            this.cmbGetFirstMinuteA.TabIndex = 31;
            // 
            // cmbGetFirstHourA
            // 
            this.cmbGetFirstHourA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetFirstHourA.FormattingEnabled = true;
            this.cmbGetFirstHourA.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cmbGetFirstHourA.Location = new System.Drawing.Point(531, 98);
            this.cmbGetFirstHourA.Name = "cmbGetFirstHourA";
            this.cmbGetFirstHourA.Size = new System.Drawing.Size(78, 29);
            this.cmbGetFirstHourA.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbSelectSecondDay);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbGetSecondMinuteB);
            this.groupBox3.Controls.Add(this.cmbGetSecondHourB);
            this.groupBox3.Controls.Add(this.cmbGetFirstMinuteB);
            this.groupBox3.Controls.Add(this.cmbGetFirstHourB);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(152, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(790, 202);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Segundo horario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Hora de fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Hora de inico:";
            // 
            // cmbGetSecondMinuteB
            // 
            this.cmbGetSecondMinuteB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetSecondMinuteB.FormattingEnabled = true;
            this.cmbGetSecondMinuteB.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmbGetSecondMinuteB.Location = new System.Drawing.Point(668, 150);
            this.cmbGetSecondMinuteB.Name = "cmbGetSecondMinuteB";
            this.cmbGetSecondMinuteB.Size = new System.Drawing.Size(78, 29);
            this.cmbGetSecondMinuteB.TabIndex = 29;
            // 
            // cmbGetSecondHourB
            // 
            this.cmbGetSecondHourB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetSecondHourB.FormattingEnabled = true;
            this.cmbGetSecondHourB.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cmbGetSecondHourB.Location = new System.Drawing.Point(531, 150);
            this.cmbGetSecondHourB.Name = "cmbGetSecondHourB";
            this.cmbGetSecondHourB.Size = new System.Drawing.Size(78, 29);
            this.cmbGetSecondHourB.TabIndex = 30;
            // 
            // cmbGetFirstMinuteB
            // 
            this.cmbGetFirstMinuteB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetFirstMinuteB.FormattingEnabled = true;
            this.cmbGetFirstMinuteB.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmbGetFirstMinuteB.Location = new System.Drawing.Point(668, 95);
            this.cmbGetFirstMinuteB.Name = "cmbGetFirstMinuteB";
            this.cmbGetFirstMinuteB.Size = new System.Drawing.Size(78, 29);
            this.cmbGetFirstMinuteB.TabIndex = 31;
            // 
            // cmbGetFirstHourB
            // 
            this.cmbGetFirstHourB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGetFirstHourB.FormattingEnabled = true;
            this.cmbGetFirstHourB.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cmbGetFirstHourB.Location = new System.Drawing.Point(531, 95);
            this.cmbGetFirstHourB.Name = "cmbGetFirstHourB";
            this.cmbGetFirstHourB.Size = new System.Drawing.Size(78, 29);
            this.cmbGetFirstHourB.TabIndex = 32;
            // 
            // lblSelectDay
            // 
            this.lblSelectDay.AutoSize = true;
            this.lblSelectDay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDay.Location = new System.Drawing.Point(49, 43);
            this.lblSelectDay.Name = "lblSelectDay";
            this.lblSelectDay.Size = new System.Drawing.Size(133, 21);
            this.lblSelectDay.TabIndex = 37;
            this.lblSelectDay.Text = "Seleccionar día:";
            // 
            // cmbSelectFirstDay
            // 
            this.cmbSelectFirstDay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectFirstDay.FormattingEnabled = true;
            this.cmbSelectFirstDay.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado"});
            this.cmbSelectFirstDay.Location = new System.Drawing.Point(531, 35);
            this.cmbSelectFirstDay.Name = "cmbSelectFirstDay";
            this.cmbSelectFirstDay.Size = new System.Drawing.Size(215, 29);
            this.cmbSelectFirstDay.TabIndex = 36;
            this.cmbSelectFirstDay.Text = "Seleccionar";
            // 
            // cmbSelectSecondDay
            // 
            this.cmbSelectSecondDay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectSecondDay.FormattingEnabled = true;
            this.cmbSelectSecondDay.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado"});
            this.cmbSelectSecondDay.Location = new System.Drawing.Point(531, 38);
            this.cmbSelectSecondDay.Name = "cmbSelectSecondDay";
            this.cmbSelectSecondDay.Size = new System.Drawing.Size(215, 29);
            this.cmbSelectSecondDay.TabIndex = 36;
            this.cmbSelectSecondDay.Text = "Seleccionar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Seleccionar día:";
            // 
            // AgregarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 686);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.btnReturnToMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarHorario";
            this.Text = "AgregarHorario";
            this.Load += new System.EventHandler(this.AgregarHorario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblSubjectList;
        private System.Windows.Forms.ComboBox cmbGetCareerList;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnReturnToMainForm;
        private System.Windows.Forms.ComboBox cmbSelectSubject;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSecondSurname;
        private System.Windows.Forms.ComboBox cmbGetSecondMinuteA;
        private System.Windows.Forms.ComboBox cmbGetSecondHourA;
        private System.Windows.Forms.ComboBox cmbGetFirstMinuteA;
        private System.Windows.Forms.ComboBox cmbGetFirstHourA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGetSecondMinuteB;
        private System.Windows.Forms.ComboBox cmbGetSecondHourB;
        private System.Windows.Forms.ComboBox cmbGetFirstMinuteB;
        private System.Windows.Forms.ComboBox cmbGetFirstHourB;
        private Label lblSelectDay;
        private ComboBox cmbSelectFirstDay;
        private Label label4;
        private ComboBox cmbSelectSecondDay;
    }
}