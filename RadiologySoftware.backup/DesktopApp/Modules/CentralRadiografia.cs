using ClassLibraryBackup.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DesktopApp.Modules
{
    public partial class CentralRadiografia : Form
    {
        public CentralRadiografia()
        {
            InitializeComponent();
        }

        private void CentralRadiografia_Load(object sender, System.EventArgs e)
        {
            List<CPacienteDAL> listEjemplo = new List<CPacienteDAL>();

            CPacienteDAL cPaciente = new CPacienteDAL()
            {
                Cedula = "402-4504214-9",
                Nombre = "Francisca",
                Papellido = "Morfhe",
                Mapellido = "Garcias",
                Email = "Morfhe@gmail.com",
                Telefono = "809432123"
            };

            listEjemplo.Add(cPaciente);
            dataGridView1.DataSource = listEjemplo;
            
        }
    }
}
