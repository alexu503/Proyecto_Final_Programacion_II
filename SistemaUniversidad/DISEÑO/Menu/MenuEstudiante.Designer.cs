namespace SistemaUniversidad.DISEÑO.Menu
{
    partial class MenuEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEstudiante));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.pnlConte = new System.Windows.Forms.Panel();
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.dragControl1 = new SistemaUniversidad.LOGICA.DragControl();
            this.imgVision = new System.Windows.Forms.PictureBox();
            this.btnGestionarCalificaciones = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.imgMision = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.imgMasOpciones = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.imgLogoTipo = new System.Windows.Forms.PictureBox();
            this.pnlSuperior.SuspendLayout();
            this.pnlConte.SuspendLayout();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMasOpciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlSuperior.Controls.Add(this.btnRestaurar);
            this.pnlSuperior.Controls.Add(this.btnMaximizar);
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.imgMasOpciones);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1050, 35);
            this.pnlSuperior.TabIndex = 0;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(962, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(45, 35);
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // pnlConte
            // 
            this.pnlConte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConte.Controls.Add(this.imgVision);
            this.pnlConte.Controls.Add(this.pnlMenuLateral);
            this.pnlConte.Controls.Add(this.imgMision);
            this.pnlConte.Controls.Add(this.pnlSuperior);
            this.pnlConte.Controls.Add(this.imgLogoTipo);
            this.pnlConte.Location = new System.Drawing.Point(0, 0);
            this.pnlConte.Name = "pnlConte";
            this.pnlConte.Size = new System.Drawing.Size(1052, 618);
            this.pnlConte.TabIndex = 3;
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.pnlMenuLateral.Controls.Add(this.btnGestionarCalificaciones);
            this.pnlMenuLateral.Controls.Add(this.pnlHome);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 35);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(206, 581);
            this.pnlMenuLateral.TabIndex = 3;
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.btnCerrarSesion);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(206, 50);
            this.pnlHome.TabIndex = 1;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.pnlSuperior;
            // 
            // imgVision
            // 
            this.imgVision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgVision.Image = ((System.Drawing.Image)(resources.GetObject("imgVision.Image")));
            this.imgVision.Location = new System.Drawing.Point(341, 450);
            this.imgVision.Name = "imgVision";
            this.imgVision.Size = new System.Drawing.Size(558, 126);
            this.imgVision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVision.TabIndex = 6;
            this.imgVision.TabStop = false;
            // 
            // btnGestionarCalificaciones
            // 
            this.btnGestionarCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionarCalificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarCalificaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionarCalificaciones.FlatAppearance.BorderSize = 2;
            this.btnGestionarCalificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionarCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarCalificaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarCalificaciones.ForeColor = System.Drawing.Color.White;
            this.btnGestionarCalificaciones.Image = global::SistemaUniversidad.Properties.Resources.CalificacionP;
            this.btnGestionarCalificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarCalificaciones.Location = new System.Drawing.Point(0, 50);
            this.btnGestionarCalificaciones.Name = "btnGestionarCalificaciones";
            this.btnGestionarCalificaciones.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnGestionarCalificaciones.Size = new System.Drawing.Size(206, 35);
            this.btnGestionarCalificaciones.TabIndex = 25;
            this.btnGestionarCalificaciones.Text = "    Calificaciones";
            this.btnGestionarCalificaciones.UseVisualStyleBackColor = true;
            this.btnGestionarCalificaciones.Click += new System.EventHandler(this.btnGestionarCalificaciones_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::SistemaUniversidad.Properties.Resources.Cerrar_sesion;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1, 0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(205, 50);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "      Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // imgMision
            // 
            this.imgMision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgMision.Image = ((System.Drawing.Image)(resources.GetObject("imgMision.Image")));
            this.imgMision.Location = new System.Drawing.Point(341, 298);
            this.imgMision.Name = "imgMision";
            this.imgMision.Size = new System.Drawing.Size(558, 126);
            this.imgMision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMision.TabIndex = 5;
            this.imgMision.TabStop = false;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(962, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(45, 35);
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(922, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 35);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // imgMasOpciones
            // 
            this.imgMasOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMasOpciones.Image = global::SistemaUniversidad.Properties.Resources.imgBarra;
            this.imgMasOpciones.Location = new System.Drawing.Point(7, 0);
            this.imgMasOpciones.Name = "imgMasOpciones";
            this.imgMasOpciones.Size = new System.Drawing.Size(36, 34);
            this.imgMasOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMasOpciones.TabIndex = 3;
            this.imgMasOpciones.TabStop = false;
            this.imgMasOpciones.Click += new System.EventHandler(this.imgMasOpciones_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1006, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 35);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // imgLogoTipo
            // 
            this.imgLogoTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLogoTipo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoTipo.Image")));
            this.imgLogoTipo.Location = new System.Drawing.Point(472, 69);
            this.imgLogoTipo.Name = "imgLogoTipo";
            this.imgLogoTipo.Size = new System.Drawing.Size(254, 188);
            this.imgLogoTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoTipo.TabIndex = 4;
            this.imgLogoTipo.TabStop = false;
            // 
            // MenuEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 618);
            this.Controls.Add(this.pnlConte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuEstudiante";
            this.Load += new System.EventHandler(this.MenuEstudiante_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlConte.ResumeLayout(false);
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgVision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMasOpciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoTipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlConte;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.PictureBox imgMasOpciones;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Button btnGestionarCalificaciones;
        private System.Windows.Forms.Button btnCerrarSesion;
        private LOGICA.DragControl dragControl1;
        private System.Windows.Forms.PictureBox imgVision;
        private System.Windows.Forms.PictureBox imgMision;
        private System.Windows.Forms.PictureBox imgLogoTipo;
    }
}