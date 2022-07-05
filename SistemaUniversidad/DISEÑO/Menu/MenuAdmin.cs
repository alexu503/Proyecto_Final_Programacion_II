using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaUniversidad.LOGICA;
using System.Runtime.InteropServices;
using SistemaUniversidad.DISEÑO.Administrador.Asignaturas;
using SistemaUniversidad.DISEÑO.Administrador.Carreras;

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
            if (pnlSubMenuAlumnos.Visible == true) {
                pnlSubMenuAlumnos.Visible = false;
            }
            if (pnlSubMenuAsignaturas.Visible == true) {
                pnlSubMenuAsignaturas.Visible = false;
            }
            if (pnlSubMenuCarreras.Visible == true) {
                pnlSubMenuCarreras.Visible = false;
            }
            if (pnlSubMenuDocentes.Visible == true) {
                pnlSubMenuDocentes.Visible = false;
            }
            if (pnlSubMenuHorarios.Visible == true) {
                pnlSubMenuHorarios.Visible = false;
            }
        }
        //Muestra el panel de Sub Menú indicado como parámetro
        private void MostrarSubMenu(Panel mostrar) {
            //Si el su-menu no está visible
            if (mostrar.Visible == false) {
                //Oculta todos los submenús
                OcultarSubMenus();
                mostrar.Visible = true;//Pone visible el menú indicado
                //btn.BackColor = Color.FromArgb(0, 80, 200);
            } else {//Si el sub-menu ya está visible
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

        private void btnAgregarAsignatura_Click(object sender, EventArgs e) {
            Administrador.Asignaturas.AgregarAsignatura aggAsig = new Administrador.Asignaturas.AgregarAsignatura();
            this.Hide();
            aggAsig.agregarAsignatura = this;
            aggAsig.Show();
        }

        private void btnGestionarAlumnos_Click(object sender, EventArgs e) {
            MostrarSubMenu(pnlSubMenuAlumnos);
        }

        private void btnGestionarAsignaturas_Click(object sender, EventArgs e) {
            MostrarSubMenu(pnlSubMenuAsignaturas);
        }

        private void btnGestionarCarreras_Click(object sender, EventArgs e) {
            MostrarSubMenu(pnlSubMenuCarreras);
        }

        private void btnGestionarDocentes_Click(object sender, EventArgs e) {
            MostrarSubMenu(pnlSubMenuDocentes);
        }

        private void btnGestionarHorarios_Click(object sender, EventArgs e) {
            MostrarSubMenu(pnlSubMenuHorarios);
        }

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

        #region Botones Minimizar Maximizar Cerrar
        private void btnMinimizar_Click(object sender, EventArgs e) {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Minimizar(this, sender, e);
        }
        private void pnlSuperiorMenuAdmin_MouseDown(object sender, MouseEventArgs e) {
            //MostrarSubMenu(pnlSuperiorMenuAdmin);
        }

        #endregion

        #region Eventos Click

        #region Cerrar Sesión
        #endregion

        #region Más opciones
        #endregion

        #region Abrir Sub-Menú

        private void button5_Click(object sender, EventArgs e) {
            //
        }
        private void btnCerrar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿SEGURO QUE DESEA CERRAR SESION?", "¡ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Sesiones.Bienvenido bienvenido = new Sesiones.Bienvenido();
                this.Hide();
                bienvenido.Show();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿SEGURO QUE DESEA CERRAR SESION?", "¡ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Sesiones.Bienvenido bienvenido = new Sesiones.Bienvenido();
                this.Hide();
                bienvenido.Show();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlSuperiorMenuAdmin_MouseDown_1(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        #region Asignaturas

        private void btnAgregarAsignatura_Click_1(object sender, EventArgs e) {
            AgregarAsignatura agregarAsignatura = new AgregarAsignatura();
            this.Hide();
            agregarAsignatura.Show();
        }

        private void btnEliminarAsignatura_Click(object sender, EventArgs e) {
            EliminarAsignatura eliminarAsignatura = new EliminarAsignatura();
            this.Hide();
            eliminarAsignatura.Show();
        }

        private void btnModificarAsignatura_Click(object sender, EventArgs e) {
            ModificarAsignatura modificarAsignatura = new ModificarAsignatura();
            this.Hide();
            modificarAsignatura.Show();
        }

        private void btnBuscarAsignatura_Click(object sender, EventArgs e) {
            BuscarAsignatura buscarAsignatura = new BuscarAsignatura();
            this.Hide();
            buscarAsignatura.Show();
        }


        #endregion

        #region Carreras

        private void btnAgregarCarrera_Click(object sender, EventArgs e) {
            AgregarCarrera agregarCarrera = new AgregarCarrera();
            this.Hide();
            agregarCarrera.Show();
        }

        private void btnEliminarCarrera_Click(object sender, EventArgs e) {
            EliminarCarrera eliminarCarrera = new EliminarCarrera();
            this.Hide();
            eliminarCarrera.Show();
        }

        private void btnModificarCarrera_Click(object sender, EventArgs e) {
            ModificarCarrera modificarCarrera = new ModificarCarrera();
            this.Hide();
            modificarCarrera.Show();
        }

        private void btnBuscarCarrera_Click(object sender, EventArgs e) {
            BuscarCarrera buscarCarrera = new BuscarCarrera();
            this.Hide();
            buscarCarrera.Show();
        }


        #endregion

        #endregion
    }
}
