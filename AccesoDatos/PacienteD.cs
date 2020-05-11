using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaComun.Cache;
using CapaComun;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class PacienteD:ConexionSQL
    {
        public bool BusquedadPaciente(int dui)
        {
            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand()) {

                    Comando.Connection = Conexion;
                    Comando.CommandText = "select * from Expediente E inner join Paciente P on E.dui = P.Dui where E.dui = @dui and P.Dui=@dui";
                    Comando.Parameters.AddWithValue("@dui",dui);
                    Comando.CommandType = CommandType.Text;

                    SqlDataReader Lectura = Comando.ExecuteReader();
                    
                    if (Lectura.HasRows) {
                        while (Lectura.Read())
                        {
                            CacheExpediente.NumExpediente = Lectura.GetInt32(0);
                            CacheExpediente.FechaCreacionExpediente = Lectura.GetDateTime (1);
                            CacheExpediente.AntecedentesClinicos = Lectura.GetString(2);
                            CacheExpediente.MedicamentosPreEscritos = Lectura.GetString(3);
                            CacheExpediente.TipoSangre = Lectura.GetString(4);
                            CachePaciente.Dui = Lectura.GetInt32(6);
                            CachePaciente.NombrePaciente = Lectura.GetString(7);
                            CachePaciente.ApellidoPaciente = Lectura.GetString(8);
                            CachePaciente.SexoPaciente = Lectura.GetString(9);
                            CachePaciente.TelefonoPaciente = Lectura.GetInt32(10);
                            CachePaciente.DirrecionPaciente = Lectura.GetString(11);
                            CachePaciente.EstadoCivilPaciente = Lectura.GetString(12);
                            CachePaciente.FechaNacimientoPaciente = Lectura.GetString(13);

                        }
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                }

            }


        }

    }
}
