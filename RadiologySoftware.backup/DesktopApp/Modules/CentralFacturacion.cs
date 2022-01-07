using System.Windows.Forms;
using System.Collections.Generic;
using ClassLibraryBackup.Model;
using ClassLibraryBackup.Bussiness;

namespace DesktopApp.Modules
{
    public partial class CentralFacturacion : Form
    {
        private CBussinesLayer bussinesLayer;

        public CentralFacturacion()
        {
            InitializeComponent();
            bussinesLayer = new CBussinesLayer();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Modules.FacturacionForm facturacionForm = new Modules.FacturacionForm();
            facturacionForm.ShowDialog(this);
        }

        private void CentralFacturacion_Load(object sender, System.EventArgs e)
        {
            //cboxFilter.SelectedIndex = 0;
            List<CFacturacion> listaFacturacion = bussinesLayer.GetAllFacturaciones(/*cboxFilter.SelectedItem.ToString()*/);


            dataGridViewFacturacion.DataSource = listaFacturacion;
        }

        private void dataGridViewFacturacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Salvaguardandome de que haya un valor row pretederminado, cuando solo el usuario elija un column value.
            int rowIndexSolutionError = e.RowIndex < 0 ? 0 : e.RowIndex;


            var cell = dataGridViewFacturacion.Rows[rowIndexSolutionError].Cells[e.ColumnIndex];

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
                //PacientesForms showPacienteData = new PacientesForms(dataGridViewCentralPacientes.Rows[rowIndexSolutionError].Cells[3].Value.ToString());
                //showPacienteData.ShowDialog();
            }

        }
    }
}
