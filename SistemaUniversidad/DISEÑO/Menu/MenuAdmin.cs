using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaUniversidad.LOGICA;

namespace SistemaUniversidad.DISEÑO.Menu {
    public partial class MenuAdmin : Form {
        //Ayudan a expandir el menú lateral
        public Form menuAdmin;
        private const int AnchoNormal = 200;
        private const int AnchoIconos = 62;
        public MenuAdmin() {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//Solo maximice al area de trabajo y no a la pantalla completa
        }
        private void MenuAdmin_Load(object sender, EventArgs e) {
            OcultarSubMenus();
        }

        #region Ocultar-Mostrar Sub-Menús
        //Oculta los subMenus si están visibles
        private void OcultarSubMenus() {
            //MENU LATERAL -> 32; 33; 51
            //Fondo panel -> DarkSlateBlue
            //Flat Button -> MediumSlateBlue
            if (pnlSubMenuAlumnos.Visible == true) {
                pnlSubMenuAlumnos.Visible = false;
            }
            if (pnlSubMenuAsignaturas.Visible == true) {
                pnlSubMenuAsignaturas.Visible = false;
            }
        }
        //Muestra el panel de Sub Menú indicado como parámetro
        private void MostrarSubMenu(Panel mostrar) {
            if (mostrar.Visible == false)//Si el su-menu no está visible
            {
                OcultarSubMenus();//Oculta todos los submenús
                mostrar.Visible = true;//Pone visible el menú indicado
                //btn.BackColor = Color.FromArgb(0, 80, 200);
            } else//Si el sub-menu ya está visible
              {
                mostrar.Visible = false;
                //btn.BackColor = Color.FromArgb(32, 48, 68);
            }
        }//49; 66; 82

        #endregion

        #region Redimensionar Panel

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m) {
            switch (m.Msg) {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e) {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        #endregion

        #region Botones Minimizar Maximizar Cerrar
        private void btnMinimizar_Click(object sender, EventArgs e) {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Minimizar(this, sender, e);
        }

        private void btnMaximizar_Click(object sender, EventArgs e) {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Maximizar(this, sender, e, btnMaximizar, btnRestaurar);
        }

        private void btnRestaurar_Click(object sender, EventArgs e) {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Restaurar(this, sender, e, btnRestaurar, btnMaximizar);
        }
        private void btnCerrar_Click(object sender, EventArgs e) {

            if (MessageBox.Show("¿SEGURO QUE DESEA CERRAR LA APLICACIÓN?", "¡ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                Application.Exit();
            }
        }
        private void pnlSuperiorMenuAdmin_MouseDown(object sender, MouseEventArgs e) {

        }

        #endregion

        #region Eventos Click

        #region Cerrar Sesión
        private void btnCerrarSesion_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿SEGURO QUE DESEA CERRAR SESION?", "¡ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Login.Login FormLogIn = new Login.Login();
                this.Hide();
                FormLogIn.logIn = this;
                FormLogIn.Show();
            }
        }
        #endregion

        #region Más opciones
        private void imgMasOpciones_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            imgMasOpciones.Enabled = false;
            if (pnlMenuLateral.Width != AnchoIconos) {
                pnlMenuLateral.Width = AnchoIconos;
                //Acá debe ir el código de ocultar los submenús.
                OcultarSubMenus();
                pnlHome.Width = AnchoIconos;
            } else {
                OcultarSubMenus();
                pnlMenuLateral.Width = AnchoNormal;
                pnlHome.Width = AnchoNormal;
            }
            this.Cursor = Cursors.Default;
            imgMasOpciones.Enabled = true;
        }
        #endregion

        #region Abrir Sub-Menú
        private void btnGestionarAlumnos_Click(object sender, EventArgs e) {
            MostrarSubMenu(pnlSubMenuAlumnos);
        }
        private void btnGestionarAsignaturas_Click(object sender, EventArgs e) {
            MostrarSubMenu(pnlSubMenuAsignaturas);
        }
        #endregion

        #region Alumnos
        //----> Agregar nuevo alumno
        private void btnAgregarAlumno_Click(object sender, EventArgs e) {
            Administrador.NuevoAlumno NuevoAlumno = new Administrador.NuevoAlumno();
            this.Hide();
            NuevoAlumno.Show();
        }
        //----> Eliminar alumno
        private void btnEliminarAlumno_Click(object sender, EventArgs e) {
            Administrador.EliminarAlumno EliminarAlumno = new Administrador.EliminarAlumno();
            this.Hide();
            EliminarAlumno.eliminarAlumno = this;
            EliminarAlumno.Show();
        }
        //----> Modificar datos de alumno
        private void btnModificarAlumno_Click(object sender, EventArgs e) {
            Administrador.ModificarAlumno ModificarAlumno = new Administrador.ModificarAlumno();
            this.Hide();
            ModificarAlumno.modificarAlumno = this;
            ModificarAlumno.Show();
        }
        //----> Buscar alumno
        private void btnBuscarAlumno_Click(object sender, EventArgs e) {
            Administrador.BuscarAlumno BuscarAlumno = new Administrador.BuscarAlumno();
            this.Hide();
            BuscarAlumno.buscarAlumno = this;
            BuscarAlumno.Show();

        }

        #endregion

        #endregion

        private void btnAgregarAsignatura_Click(object sender, EventArgs e) {
            Administrador.Asignaturas.AgregarAsignatura aggAsig = new Administrador.Asignaturas.AgregarAsignatura();
            this.Hide();
            aggAsig.agregarAsignatura = this;
            aggAsig.Show();
        }
    }
}
