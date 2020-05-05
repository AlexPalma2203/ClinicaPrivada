using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public abstract class ConexionSQL
    {

        private readonly string CadenaConexion;
        public ConexionSQL()
        {
            CadenaConexion = "Server=.;DataBase=SistemaClinica; integrated security = true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(CadenaConexion);
        }

    }
}
