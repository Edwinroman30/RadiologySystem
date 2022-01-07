using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBackup.Data;
using ClassLibraryBackup.Model;

namespace ClassLibraryBackup.Bussiness
{
    public class CBussinesLayer
    {

        private DataAccess dataAccess;

        public CBussinesLayer()
        {
            dataAccess = new DataAccess();
        }


        public List<CPacienteDAL> GetCentralPacientes(string filtro = null, string valorFiltro = null)
        {
            return dataAccess.GetCentralPacientes(filtro, valorFiltro);
        }

        public List<CPaciente> GetPacientes(string cedula)
        {
            return dataAccess.GetPacientes(cedula);
        }


        public List<CPais> GetPaises(string filtro = null)
        {
            return dataAccess.GetPaises();
        }

        public List<CSeguro> GetSeguros(string filtro = null)
        {
            return dataAccess.GetSeguros();
        }

        public List<CSexo> GetSexo(string filtro = null)
        {
            return dataAccess.GetSexo();
        }


        public List<CSangre> GetSangre(string filtro = null)
        {
            return dataAccess.GetSangre();
        }

        public List<CSector> GetSectores(string filtro = null)
        {
            return dataAccess.GetSectores();
        }

        public List<CFacturacion> GetAllFacturaciones(string filtro = null)
        {
            return dataAccess.GetAllFacturaciones(filtro);
        }
        

    }
}
