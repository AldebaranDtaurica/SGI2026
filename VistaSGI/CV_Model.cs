using CapaLogica;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace VistaSGI
{
    public class CV_Model
    {
        public ComboBox _cmbFamilia;
        public ToolStripMenuItem menuPrincipal;
        public List<string> list;
        public readonly CL_CargaBox _clBoxCarga;

        public CV_Model(ComboBox cmbFamilia)
        {
            _cmbFamilia = cmbFamilia;
            _clBoxCarga = new CL_CargaBox(); // Instancia de la capa lógica
        }

        public CV_Model(ToolStripMenuItem menuPrincipal, List<string> list)
        {
            this.menuPrincipal = menuPrincipal;
            this.list = list;
        }

        /*public CV_Model()
        {
        }*/

        public DataTable CargarFamilia()
        {
            DataTable dtFamilia = _clBoxCarga.BoxFamilia(); //cmbFamilia.Items.Clear();
            foreach (DataRow row in dtFamilia.Rows)
            {
                _cmbFamilia.Items.Add(row[1].ToString()); // Columna 2
            }

            // Opcionalmente, establecer un valor por defecto si hay items
            if (_cmbFamilia.Items.Count > 0)
            {
                _cmbFamilia.SelectedIndex = 0;
            }

            return dtFamilia;
        }


    }
}