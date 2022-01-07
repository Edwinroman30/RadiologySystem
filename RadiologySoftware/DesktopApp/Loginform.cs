using System;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            //Claro esto es de prueba.
            Program.userAuthentication = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Claro esto es de prueba.
            Program.userAuthentication = false;
            this.Close();
        }
    }
}
