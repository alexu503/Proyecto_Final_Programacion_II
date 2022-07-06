namespace SistemaUniversidad.DISEÑO.Sesiones
{
    partial class Bienvenido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenido));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblLineaDivisora = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.groupBoxIniciarSesión = new System.Windows.Forms.GroupBox();
            this.pnlContBienve = new System.Windows.Forms.Panel();
            this.pnlSuperiorBienvenido = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.dragControlBienvenido = new SistemaUniversidad.LOGICA.DragControl();
            this.groupBoxIniciarSesión.SuspendLayout();
            this.pnlContBienve.SuspendLayout();
            this.pnlSuperiorBienvenido.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblBienvenido.ForeColor = System.Drawing.Color.Black;
            this.lblBienvenido.Location = new System.Drawing.Point(133, 94);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(160, 31);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenid@";
            this.lblBienvenido.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBienvenido_MouseDown);
            // 
            // lblLineaDivisora
            // 
            this.lblLineaDivisora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLineaDivisora.AutoSize = true;
            this.lblLineaDivisora.ForeColor = System.Drawing.Color.Black;
            this.lblLineaDivisora.Location = new System.Drawing.Point(38, 151);
            this.lblLineaDivisora.Name = "lblLineaDivisora";
            this.lblLineaDivisora.Size = new System.Drawing.Size(325, 13);
            this.lblLineaDivisora.TabIndex = 1;
            this.lblLineaDivisora.Text = "_____________________________________________________";
            this.lblLineaDivisora.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblLineaDivisora_MouseDown);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciarSesion.Image")));
            this.btnIniciarSesion.Location = new System.Drawing.Point(6, 18);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(129, 130);
            this.btnIniciarSesion.TabIndex = 2;
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // groupBoxIniciarSesión
            // 
            this.groupBoxIniciarSesión.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxIniciarSesión.Controls.Add(this.btnIniciarSesion);
            this.groupBoxIniciarSesión.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIniciarSesión.ForeColor = System.Drawing.Color.Black;
            this.groupBoxIniciarSesión.Location = new System.Drawing.Point(41, 240);
            this.groupBoxIniciarSesión.Name = "groupBoxIniciarSesión";
            this.groupBoxIniciarSesión.Size = new System.Drawing.Size(141, 154);
            this.groupBoxIniciarSesión.TabIndex = 4;
            this.groupBoxIniciarSesión.TabStop = false;
            this.groupBoxIniciarSesión.Text = "Iniciar sesión";
            // 
            // pnlContBienve
            // 
            this.pnlContBienve.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContBienve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContBienve.Controls.Add(this.pnlSuperiorBienvenido);
            this.pnlContBienve.Controls.Add(this.lblBienvenido);
            this.pnlContBienve.Controls.Add(this.lblLineaDivisora);
            this.pnlContBienve.Controls.Add(this.groupBox1);
            this.pnlContBienve.Controls.Add(this.groupBoxIniciarSesión);
            this.pnlContBienve.Location = new System.Drawing.Point(0, 0);
            this.pnlContBienve.Name = "pnlContBienve";
            this.pnlContBienve.Size = new System.Drawing.Size(403, 526);
            this.pnlContBienve.TabIndex = 7;
            this.pnlContBienve.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlContBienve_MouseDown);
            // 
            // pnlSuperiorBienvenido
            // 
            this.pnlSuperiorBienvenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlSuperiorBienvenido.Controls.Add(this.btnCerrar);
            this.pnlSuperiorBienvenido.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorBienvenido.Name = "pnlSuperiorBienvenido";
            this.pnlSuperiorBienvenido.Size = new System.Drawing.Size(402, 35);
            this.pnlSuperiorBienvenido.TabIndex = 7;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(358, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 35);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnSignup);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(222, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 154);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrarme";
            // 
            // btnSignup
            // 
            this.btnSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.Image = ((System.Drawing.Image)(resources.GetObject("btnSignup.Image")));
            this.btnSignup.Location = new System.Drawing.Point(6, 18);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(129, 130);
            this.btnSignup.TabIndex = 2;
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // dragControlBienvenido
            // 
            this.dragControlBienvenido.SelectControl = this.pnlSuperiorBienvenido;
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 526);
            this.Controls.Add(this.pnlContBienve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(613, 765);
            this.MinimumSize = new System.Drawing.Size(383, 485);
            this.Name = "Bienvenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.groupBoxIniciarSesión.ResumeLayout(false);
            this.pnlContBienve.ResumeLayout(false);
            this.pnlContBienve.PerformLayout();
            this.pnlSuperiorBienvenido.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblLineaDivisora;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.GroupBox groupBoxIniciarSesión;
        private System.Windows.Forms.Panel pnlContBienve;
        private System.Windows.Forms.Panel pnlSuperiorBienvenido;
        private LOGICA.DragControl dragControlBienvenido;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSignup;
    }
}