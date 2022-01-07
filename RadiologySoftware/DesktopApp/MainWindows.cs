using System;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            Modules.CentralPacientesForm centralPacientes = new Modules.CentralPacientesForm();
            centralPacientes.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modules.FacturacionForm facturacionForm = new Modules.FacturacionForm();
            facturacionForm.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modules.CentralRadiografia centralRadiografia = new Modules.CentralRadiografia();
            centralRadiografia.ShowDialog(this);
        }
    }
}
