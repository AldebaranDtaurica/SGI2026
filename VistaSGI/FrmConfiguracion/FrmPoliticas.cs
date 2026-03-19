using CapaSistema;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmPoliticas : Form
    {
        private CSI_Politicas politicas;

        private static FrmPoliticas instancia = null;

        public static FrmPoliticas ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FrmPoliticas();
                return instancia;
            }
            return instancia;
        }

        public FrmPoliticas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            politicas = new CSI_Politicas();

            // Cargar configuraciones al iniciar el formulario
            this.Load += new EventHandler(FrmPoliticas_Load);
        }

        private void FrmPoliticas_Load(object sender, EventArgs e)
        {
            CargarConfiguraciones();
        }

        private void btnIrMenu_Click(object sender, EventArgs e)
        {
            CargarConfiguraciones();
            this.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                GuardarConfiguracion();
                MessageBox.Show("Configuración guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GuardarConfiguracion()
        {
            List<bool> configuraciones = new List<bool>
                    {
                        chcMinimo.Checked,chcMayuscula.Checked,chcMinuscula.Checked,chcEspecial.Checked,
                        chcPswAnterior.Checked,chcDatosPersonales.Checked,chcNumero.Checked,chcFallidos.Checked,
                        chcDiasDesbloqueo.Checked
                    };

            // Convertir la lista de bool a una lista de tuplas de int y bool - Llamar al método GuardarConfiguracion prueba con Tuplas
            List<Tuple<int, bool>> configuracionesTuplas = configuraciones.Select((value, index) => new Tuple<int, bool>(index, value)).ToList();
            politicas.GuardarConfiguracion(configuracionesTuplas);
        }

        private void CargarConfiguraciones()
        {
            DataTable dtConfiguraciones = politicas.ObtenerConfiguraciones();

            foreach (DataRow row in dtConfiguraciones.Rows)
            {
                int idPol = (int)row["IdPol"];
                bool activo = (bool)row["Activo"];

                switch (idPol)
                {
                    case 1:
                        chcMinimo.Checked = activo;
                        break;
                    case 2:
                        chcMayuscula.Checked = activo;
                        break;
                    case 3:
                        chcMinuscula.Checked = activo;
                        break;
                    case 4:
                        chcEspecial.Checked = activo;
                        break;
                    case 5:
                        chcPswAnterior.Checked = activo;
                        break;
                    case 6:
                        chcDatosPersonales.Checked = activo;
                        break;
                    case 7:
                        chcNumero.Checked = activo;
                        break;
                    case 8:
                        chcFallidos.Checked = activo;
                        break;
                    case 9:
                        chcDiasDesbloqueo.Checked = activo;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            CargarConfiguraciones();
            this.Hide();
        }
    }
}
