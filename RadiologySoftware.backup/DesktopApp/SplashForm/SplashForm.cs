using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;


namespace DesktopApp
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, System.EventArgs e)
        {
            //Creando el hilo
            Thread myThread = new Thread(new ThreadStart(SplashStart));

            //Iniciar el hilo
            myThread.Start();


            //No olvidar cerrar/finalizar el hilo
            //myThread.Abort();
        }


        public void SplashStart()
        {
            // Dormir la forma principal por 5seg, solo fines de prueba, aqui iria lo que queremos cargar.
            Thread.Sleep(5000);

            this.Invoke((MethodInvoker)delegate {

                this.Close();

            });

        }

    }
}
