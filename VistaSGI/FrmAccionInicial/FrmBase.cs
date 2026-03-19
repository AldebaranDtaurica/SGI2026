using System;
using System.Windows.Forms;


namespace VistaSGI
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
            this.Load += FrmBase_Load;
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            ConfigurarDataGrids(this);
        }

        /// <summary>
        /// Recorre todos los controles del formulario y configura los DataGridView.
        /// </summary>
        /// <param name="control">Control raíz (normalmente el formulario).</param>
        private void ConfigurarDataGrids(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is DataGridView dgv)
                {
                    ConfigurarDataGridView(dgv);
                }
                else if (ctrl.HasChildren)
                {
                    ConfigurarDataGrids(ctrl); // Recursivo para contenedores como Panel, GroupBox, etc.
                }
            }
        }

        /// <summary>
        /// Aplica configuración estándar a un DataGridView.
        /// </summary>
        /// <param name="dgv">El DataGridView a configurar.</param>
        protected void ConfigurarDataGridView(DataGridView dgv)
        {
            dgv.Dock = DockStyle.Fill;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
        }

        /// <summary>
        /// Desactiva el botón de cerrar (X) del formulario.
        /// </summary>
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
    }
}
