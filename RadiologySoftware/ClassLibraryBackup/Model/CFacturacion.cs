using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBackup.Model
{
    public class CFacturacion
    {

        public int IdenFactura { get; set; }

        public int Doctor { get; set; }

        public string TipoEstudio { get; set; }

        public string CedulaPaciente { get; set; }

        public DateTime fechafactura { get; set; }


        public string Observacion { get; set; }

    }
}
