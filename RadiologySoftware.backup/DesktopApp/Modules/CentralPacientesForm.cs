using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibraryBackup.Bussiness;
using ClassLibraryBackup.Model;
//susing FaceDetecte;

namespace DesktopApp.Modules
{
    public partial class CentralPacientesForm : Form
    {
        private CBussinesLayer bussinesLayer;
        private string __filtroByRostro;
        public CentralPacientesForm(string filtro = null)
        {
            InitializeComponent();
            bussinesLayer = new CBussinesLayer();
            this.__filtroByRostro = filtro;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CPaciente cPaciente = new CPaciente();
            Modules.PacientesForms pacientesForms = new Modules.PacientesForms();
            pacientesForms.ShowDialog();
        }

        private void CentralPacientesForm_Load(object sender, EventArgs e)
        {
            cboxFilter.SelectedIndex = 0;
            List<CPacienteDAL> listEjemplo = bussinesLayer.GetCentralPacientes(cboxFilter.SelectedItem.ToString(),this.__filtroByRostro);

            //listEjemplo.Add(cPaciente);
            dataGridViewCentralPacientes.DataSource = listEjemplo;

        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCentralPacientes.DataSource =  bussinesLayer.GetCentralPacientes((cboxFilter.SelectedItem) == null?"nombre": cboxFilter.SelectedItem.ToString(), tboxSearch.Text);
        }

        private void btnFacial_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Esta funcionalidad esta deshabilitada por ahora.");
        }

        private void dataGridViewCentralPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Salvaguardandome de que haya un valor row pretederminado, cuando solo el usuario elija un column value.
            int rowIndexSolutionError = e.RowIndex < 0 ? 0 : e.RowIndex;



            var cell = dataGridViewCentralPacientes.Rows[rowIndexSolutionError].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "✏️")
            {

                MessageBox.Show("Tranquilo 😁 pronto podra ejecutar esta funcionalidad.");

            }
            else if (cell.Value.ToString() == "🗑️")
            {
                DialogResult result = MessageBox.Show
                    (
                        this,
                        "¿Esta seguro de querer eliminar este registro?",
                        "Confirmar eliminación:",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );


                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Tranquilo 😁 pronto podra ejecutar esta funcionalidad.");
                }

            }
            if (cell.Value.ToString() == "Mas Detalles")
            {
                PacientesForms showPacienteData = new PacientesForms(dataGridViewCentralPacientes.Rows[rowIndexSolutionError].Cells[3].Value.ToString());
                showPacienteData.ShowDialog();
            }



        }
    }
}
