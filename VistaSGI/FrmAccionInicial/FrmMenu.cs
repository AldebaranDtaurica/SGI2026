using CapaLogica;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VistaSGI.FrmConfiguracion;
using VistaSGI.FrmDatosMestros;



namespace VistaSGI
{
    public partial class FrmMenu : FrmBase
    {

        private int contadorInactividad = 0;
        private int tiempoTotalSegundos = 5 * 60; // 5 minutos en segundos
        private int tiempoRestanteSegundos;
        private CL_UsuarioPermiso permisoUsuario = new CL_UsuarioPermiso();
        DataTable dtAsignados;
        DataTable dtDisponibles;

        public DataTable ConsultarRolUsuarios2()
        {
            CL_UsuarioPermiso permisoUsuario = new CL_UsuarioPermiso();
            _ = permisoUsuario.ObtenerPermisos();
            DataTable datos = permisoUsuario.ObtenerPermisos();
            DataTable datosRoldescricion = new DataTable();
            _ = datosRoldescricion.Columns.Add(datos.Columns[4].ColumnName);
            foreach (DataRow row in datos.Rows)
            {
                _ = datosRoldescricion.Rows.Add(row[4]);
            }

            return datos;
        }

        public FrmMenu(FrmInicioSesion frmInicioSesion = null)
        {

            //frmCerrar = login;
            InitializeComponent();
            // Inicializar el Timer 20 MIN Y Suscribirse a los eventos de actividad
            timer1.Interval = 12000000;
            timer1.Start();
            KeyDown += FrmMenu_KeyDown;
            MouseMove += FrmMenu_MouseMove;


            this.StartPosition = FormStartPosition.CenterScreen;
            DataTable rolesVerificar = permisoUsuario.ObtenerPermisos();
            string usuario = CSE_UserCache.usuario;
            List<CL_UsuarioFamilia> rolesList = CL_UsuarioFamilia.ConsultarFamilia(usuario);
            string[] roles = rolesList.Select(r => r.Fdescripcion).ToArray();

            //AGREGO ROLES AL CON LAS FAMILIAS
            foreach (string rol in roles)
            {
                DataRow nuevaFila = rolesVerificar.NewRow();
                nuevaFila["Rdescripcion"] = rol;
                nuevaFila["Username"] = CSE_UserCache.usuario;
                nuevaFila["IdRol"] = -1;
                nuevaFila["IdUser"] = CSE_UserCache.id;
                rolesVerificar.Rows.Add(nuevaFila);
            }
            FiltrarMenuPorRoles(rolesVerificar);
        }

        private void PolíticaContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPoliticas frmPoliticas = new frmPoliticas();
            //frmPoliticas.ShowDialog(this);
            FrmPoliticas FrmPoliticas = FrmPoliticas.ventana_unica();
            FrmPoliticas.MdiParent = this;
            FrmPoliticas.Show();
            FrmPoliticas.BringToFront();
        }

        private void ContactoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmContacto frmContacto = new FrmContacto();
            _ = frmContacto.ShowDialog(this);
        }

        private void UsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = FrmUsuarios.ventana_unica();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
            frmUsuarios.BringToFront();
        }

        private void PreinscripciónCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumnosPreInscripcionA frmAlumnoPreinsc = new FrmAlumnosPreInscripcionA();
            _ = frmAlumnoPreinsc.ShowDialog(this);
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FiltrarMenuPorRoles(ToolStripMenuItem menuItem, DataTable rolesVerificar)
        {
            // Verificar si el rol está en la lista de roles permitidos
            bool rolPermitido = rolesVerificar.AsEnumerable().Any(row => row.Field<string>("Rdescripcion") == menuItem.Text);

            // Habilitar o deshabilitar el elemento de menú según el rol
            menuItem.Enabled = rolPermitido;
            menuItem.Visible = rolPermitido;

            // Explorar submenús
            foreach (ToolStripItem subMenuItem in menuItem.DropDownItems)
            {
                if (subMenuItem is ToolStripMenuItem subMenu)
                { FiltrarMenuPorRoles(subMenu, rolesVerificar); }
            }
        }

        // Llamada inicial a la función
        private void FiltrarMenuPorRoles(DataTable rolesVerificar)
        {
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items.OfType<ToolStripMenuItem>())
            {
                FiltrarMenuPorRoles(menuItem, rolesVerificar);
            }
        }

        private void LEGAJOS_Click(object sender, EventArgs e)
        {
            //FrmValidaPreinscripcion frmAlumnoPreinsc = new FrmValidaPreinscripcion();
            //_ = frmAlumnoPreinsc.ShowDialog(this);

            FrmMenuDatos frmMenuDatos = new FrmMenuDatos();
            _ = frmMenuDatos.ShowDialog(this);
        }

        //private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //Comprobar si evitamos que se continúe ejecutando al cerrar app
        //    FrmInicioSesion FrmInicioSesion = new FrmInicioSesion();
        //    FrmInicioSesion.Close();
        //    this.Close();
        // }

        private void REPORTES_CURSADA_Click(object sender, EventArgs e)
        {
            FrmInscripcionCursada frmInscripcionCursada = new FrmInscripcionCursada();
            _ = frmInscripcionCursada.ShowDialog(this);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            tiempoRestanteSegundos--;
            if (tiempoRestanteSegundos >= 0)
            {
                //lblContador.Text = TimeSpan.FromSeconds(tiempoRestanteSegundos).ToString(@"mm\:ss");
                // Agregar mensaje de advertencia cuando falte 2 minuto
                if (tiempoRestanteSegundos == 120)
                {
                    MessageBox.Show("Su sesión cerrará en 2 minutos.", "Advertencia");
                }
            }
            else
            {
                // Tiempo agotado, cerrar sesión

                tiempoRestanteSegundos = 1200;
                this.Hide();
                CloseAllForms();
                MessageBox.Show("Sesión cerrada por inactividad.");
                FrmInicioSesion frmInicioSesion = new FrmInicioSesion();
                frmInicioSesion.Show();
            }

        }

        private void FrmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            contadorInactividad = 0;
        }

        private void FrmMenu_MouseMove(object sender, MouseEventArgs e)
        {
            contadorInactividad = 0;
        }

        private void CONFIGURACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoBD frmMantenimientoBD = new FrmMantenimientoBD();
            _ = frmMantenimientoBD.ShowDialog(this);
        }

        private void VALIDACION_Click(object sender, EventArgs e)
        {
            FrmValidaPreinscripcion frmValidaPreinscripcion = new FrmValidaPreinscripcion();
            _ = frmValidaPreinscripcion.ShowDialog(this);
        }

        private void ADMIN_PERSONAS_Click(object sender, EventArgs e)
        {
            //Secretaria // Pruena de formulario
            FrmAsignaciones frmAsignaciones = new FrmAsignaciones();
            _ = frmAsignaciones.ShowDialog(this);

        }

        private void REPORTES_ALUMNOS_Click(object sender, EventArgs e)
        {
            //Preceptor
        }

        private void REPORTES_ALUMNO_Click(object sender, EventArgs e)
        {
            //Preceptor
        }

        private void CERTIFICADOS_Click(object sender, EventArgs e)
        {
            //Preceptor
        }

        private void CURSADAS_Click(object sender, EventArgs e)
        {
            //Preceptor
        }

        private void FINALES_Click(object sender, EventArgs e)
        {
            //Preceptor
        }

        private void PREINSCRIPCION_CURSADA_Click(object sender, EventArgs e)
        {
            //Alumno
        }

        private void FORM_PRECARGADOS_Click(object sender, EventArgs e)
        {
            //Alumno
        }

        private void INSCRIPCION_FINALES_Click(object sender, EventArgs e)
        {
            //Alumno
        }

        private void REPORTES_Click(object sender, EventArgs e)
        {
            //Pofres
        }

        private void INSTITUCION_Click(object sender, EventArgs e)
        {
            //Director-Secretaria
        }

        private void CARRERAS_Click(object sender, EventArgs e)
        {
            //Director-Secretaria
        }

        private void MATERIAS_Click(object sender, EventArgs e)
        {
            //Director-Secretaria
        }

        private void CORRELATIVIDADES_Click(object sender, EventArgs e)
        {
            //Director-Secretaria
        }


        private void PROVINCIAS_Click(object sender, EventArgs e)
        {
            //Director-Secretaria-Preceptor
        }

        private void GRUPO_PERSONAS_Click(object sender, EventArgs e)
        {
            //Director-Secretaria
        }

        private void NACIONALIDADES_Click(object sender, EventArgs e)
        {
            FrmAbmNacionalidades frmAbmNacionalidades = new FrmAbmNacionalidades();
            _ = frmAbmNacionalidades.ShowDialog(this);
        }

        private void PARTIDOS_Click(object sender, EventArgs e)
        {
            frmAbmPartido frmAbmPartido = new frmAbmPartido();
            _ = frmAbmPartido.ShowDialog(this);
        }

        private void LOCALIDADES_Click(object sender, EventArgs e)
        {
            FrmAbmLocalidad frmAbmLocalidad = new FrmAbmLocalidad();
            _ = frmAbmLocalidad.ShowDialog(this);
        }

        private void TIPO_CONTACTO_Click(object sender, EventArgs e)
        {
            FrmAbmTipoContacto frmAbmTipoContacto = new FrmAbmTipoContacto();
            _ = frmAbmTipoContacto.ShowDialog(this);
        }

        private void TIPO_DOCUMENTO_Click(object sender, EventArgs e)
        {
            FrmAbmTipoDoc frmAbmTipoDoc = new FrmAbmTipoDoc();
            _ = frmAbmTipoDoc.ShowDialog(this);
        }

        private void TIPO_ADJUNTO_Click(object sender, EventArgs e)
        {
            FrmAbmCateogoriaAdj frmAbmCateogoriaAdj = new FrmAbmCateogoriaAdj();
            _ = frmAbmCateogoriaAdj.ShowDialog(this);
        }

        private void ESTADO_CIVIL_Click(object sender, EventArgs e)
        {
            FrmAbmEstCivil frmAbmEstCivil = new FrmAbmEstCivil();
            _ = frmAbmEstCivil.ShowDialog(this);
        }

        private void GENEROS_Click(object sender, EventArgs e)
        {
            FrmAbmGenero frmAbmGenero = new FrmAbmGenero();
            _ = frmAbmGenero.ShowDialog(this);
        }

        private void INSTITUCIONAL_Click(object sender, EventArgs e)
        {
            FrmAbmInstitucional frmAbmInstitucional = new FrmAbmInstitucional();
            _ = frmAbmInstitucional.ShowDialog(this);
        }

        private void ACTIVIDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbmActividades frmAbmActividades = new FrmAbmActividades();
            _ = frmAbmActividades.ShowDialog(this);
        }

        private void OBRASSOCIALES_Click(object sender, EventArgs e)
        {
            FrmAbmObrasSociales frmAbmObrasSociales = new FrmAbmObrasSociales();
            _ = frmAbmObrasSociales.ShowDialog(this);
        }

        private void TELEFONOSUTILES_Click(object sender, EventArgs e)
        {
            FrmAbmTelefonosUtiles frmAbmTelefonosUtiles = new FrmAbmTelefonosUtiles();
            _ = frmAbmTelefonosUtiles.ShowDialog(this);
        }

        private void TITULOSSECToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbmTitulo frmAbmTitulo = new FrmAbmTitulo();
            _ = frmAbmTitulo.ShowDialog(this);
        }

        private void TITULOSSUPERIORES_Click(object sender, EventArgs e)
        {
            FrmAbmTituloGrado frmAbmTituloGrado = new FrmAbmTituloGrado();
            _ = frmAbmTituloGrado.ShowDialog(this);
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión? " +
            "Asegúrate de haber guardado tu trabajo.", "Confirmar cierre de sesión",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                CerrarSesionYSalir();
            }
            else
            {
                return;
            }
        }

        public void CerrarSesionYSalir()
        {
            //foreach (Form form in Application.OpenForms)
            //{
            this.Close();
            this.Dispose();
            // }
            CSE_UserCache.Clear();
            CSE_PermisoCache.Clear();
            Application.Exit();
        }

        public static void CloseAllForms(bool exitApplication = false)
        {
            // Copiamos la lista porque Application.OpenForms se modifica al cerrar formularios.
            var openForms = Application.OpenForms.Cast<Form>().ToList();

            foreach (var form in openForms)
            {
                try
                {
                    // Si el formulario requiere invocación en el hilo UI, la usamos.
                    if (form.InvokeRequired)
                    {
                        form.Invoke(new Action(() =>
                        {
                            if (!form.IsDisposed && form.Visible)
                                form.Close();
                        }));
                    }
                    else
                    {
                        if (!form.IsDisposed && form.Visible)
                            form.Close();
                    }
                }
                catch
                {
                    // Ignorar excepciones individuales para no interrumpir el cierre masivo.
                    // Puedes registrar el error si lo deseas.
                }
            }

            if (exitApplication)
            {
                Application.Exit();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CP_NOCLOSE_BUTTON = 0x200;
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle |= CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

