using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBackup.Model
{
    public class CPaciente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Papellido { get; set; }

        public string Mapellido { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public int IdSangre { get; set; }

        public int Sexo { get; set; }

        public int Pais { get; set; }

        public int Sector { get; set; }

        public int IdSeguro { get; set; }

        public byte[] fotoPaciente { get; set; }

    }
}
