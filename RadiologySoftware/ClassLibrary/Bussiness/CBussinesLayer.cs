using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Data;
using ClassLibrary.Model;

namespace ClassLibrary.Bussiness
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
            return dataAccess.GetCentralPacientes(filtro,valorFiltro);
        }


    }
}
