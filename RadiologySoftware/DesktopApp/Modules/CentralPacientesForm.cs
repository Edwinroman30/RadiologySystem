using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibrary;
using ClassLibrary.Bussiness;

namespace DesktopApp.Modules
{
    public partial class CentralPacientesForm : Form
    {
        private CBussinesLayer bussinesLayer;
        public CentralPacientesForm()
        {
            InitializeComponent();
            bussinesLayer = new CBussinesLayer();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CPaciente cPaciente = new CPaciente();
            Modules.PacientesForms pacientesForms = new Modules.PacientesForms();
            pacientesForms.ShowDialog();
        }

        private void CentralPacientesForm_Load(object sender, EventArgs e)
        {
            List<CPacienteDAL> listEjemplo = bussinesLayer.GetCentralPacientes();

            CPacienteDAL cPaciente = new CPacienteDAL()
            {
                Cedula = "402-4524214-9",
                Nombre = "TUTU",
                Papellido = "Morfhe",
                Mapellido = "Garcias",
                Email = "Tutu@gmail.com",
                Telefono = "0000000",
                Seguro = "Melo"
            };

            listEjemplo.Add(cPaciente);
            dataGridViewCentralPacientes.DataSource = listEjemplo;

        }

    }
}
