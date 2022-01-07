using System.Windows.Forms;
using ClassLibraryBackup;
using ClassLibraryBackup.Model;
using ClassLibraryBackup.Bussiness;

namespace DesktopApp.Modules
{
    public partial class PacientesForms : Form
    {
        private string __cedulaIdentificadora;
        private CBussinesLayer bussinesLayer;
        public PacientesForms(string cedula = null)
        {
            InitializeComponent();
            this.__cedulaIdentificadora = cedula;
            this.bussinesLayer = new CBussinesLayer();
        }

        private void LoadComboBoxes()
        {
            //Cargando los comboBox de paises.
            var paisesSources = bussinesLayer.GetPaises();
            cboxPaises.DataSource = paisesSources;
            cboxPaises.DisplayMember = "NomPais";
            cboxPaises.ValueMember = "Idpais";

            //Cargando los comboBox de seguros.
            var segurosSources = bussinesLayer.GetSeguros();
            cboxSeguro.DataSource = segurosSources;
            cboxSeguro.DisplayMember = "NomSeguro";
            cboxSeguro.ValueMember = "idenSeguro";

            //Cargando los comboBox de sexos.
            var sexoSources = bussinesLayer.GetSexo();
            cboxSexo.DataSource = sexoSources;
            cboxSexo.DisplayMember = "TipoSexo";
            cboxSexo.ValueMember = "IdSexo";

            //Cargando los comboBox de sangre.

            var sangreSources = bussinesLayer.GetSangre();
            cboxSangre.DataSource = sangreSources;
            cboxSangre.DisplayMember = "Tiposangre";
            cboxSangre.ValueMember = "idTipoSangre";

            //Cargando los comboBox de sectores.
            var sectorSources = bussinesLayer.GetSectores();
            cboxSector.DataSource = sectorSources;
            cboxSector.DisplayMember = "Localidad";
            cboxSector.ValueMember = "IdSector";
        }

        private void PacientesForms_Load(object sender, System.EventArgs e)
        {

            LoadComboBoxes();

            if (!string.IsNullOrEmpty( __cedulaIdentificadora) )
            {
                var resultPacientes = bussinesLayer.GetPacientes(__cedulaIdentificadora);

                tboxCedula.Text = resultPacientes[0].Cedula.ToString();
                tboxNombre.Text = resultPacientes[0].Nombre.ToString();
                tboxApeMaterno.Text = resultPacientes[0].Mapellido.ToString();
                tboxApePaterno.Text = resultPacientes[0].Papellido.ToString();
                tboxImail.Text = resultPacientes[0].Email.ToString();
                tboxTelefono.Text = resultPacientes[0].Telefono.ToString();

                //Matching de los comboBoxes con los valores traidos de la base de datos.

                cboxPaises.SelectedValue = resultPacientes[0].Pais;

                cboxSeguro.SelectedValue = resultPacientes[0].IdSeguro;

                cboxSexo.SelectedValue = resultPacientes[0].Sexo;

                cboxSangre.SelectedValue = resultPacientes[0].IdSangre;

                cboxSector.SelectedValue = resultPacientes[0].Sector;
            }
            else
            {
                tboxCedula.Clear();
                tboxNombre.Clear();
                tboxApeMaterno.Clear();
                tboxApePaterno.Clear();
                tboxImail.Clear();
                tboxTelefono.Clear();
            }


        }





        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
