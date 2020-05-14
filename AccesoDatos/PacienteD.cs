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
        public void actualizarExpedinte(string Antecedentes, string medicamentos, string tipoSangre, int dui)
        {

            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = "update Expediente set Antecedentes_Clinicos = @antecendetes, Medicamentos_Escritos= @medicamentos, tipo_sangre= @sangre where dui = @dui ";
                    Comando.Parameters.AddWithValue("@antecendetes",Antecedentes);
                    Comando.Parameters.AddWithValue("@medicamentos", medicamentos);
                    Comando.Parameters.AddWithValue("@sangre", tipoSangre);
                    Comando.Parameters.AddWithValue("@dui", dui);
                    Comando.CommandType = CommandType.Text;
                     Comando.ExecuteNonQuery();
                    
                }
            }



        }
        public void actualizarPaciente(int DuiP,string nombreP, string apellidosP, string SexoP, int numeroTeleP, string DireccionP, string EstadoCivilP, string FechaNaciemientoP)
        {

            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = "update Paciente set Nombre_Paciente= @nombre , Apellidos_Paciente = @apellido , Sexo_Paciente = @sexo, Telefono_Paciente = @telefono, Direccion_Paciente = @direccion ,EstadoCivil = @estadocivil , FechaNacimiento =@fechanac where dui = @dui";
                    Comando.Parameters.AddWithValue("@nombre", nombreP);
                    Comando.Parameters.AddWithValue("@apellido", apellidosP);
                    Comando.Parameters.AddWithValue("@sexo", SexoP);
                    Comando.Parameters.AddWithValue("@telefono", numeroTeleP);
                    Comando.Parameters.AddWithValue("@direccion", DireccionP);
                    Comando.Parameters.AddWithValue("@estadocivil", EstadoCivilP);
                    Comando.Parameters.AddWithValue("@fechanac", FechaNaciemientoP);
                    Comando.Parameters.AddWithValue("@dui", DuiP);
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();

                }
            }



        }
        public void crearPaciente(int DuiP, string nombreP, string apellidosP, string SexoP, int numeroTeleP, string DireccionP, string EstadoCivilP, string FechaNaciemientoP)
        {
            using (var Conexion = GetConnection())
            {
                Conexion.Open();
                using (var comando= new SqlCommand()){

                    
                    comando.Connection = Conexion;
                     
                    comando.CommandText = "Insert into Paciente values(@dui,@nombre,@apellido,@sexo,@telefono,@direccion,@estadocivil,@fechanac)";
                    comando.Parameters.AddWithValue("@dui", DuiP);
                    comando.Parameters.AddWithValue("@nombre", nombreP);
                    comando.Parameters.AddWithValue("@apellido", apellidosP);
                    comando.Parameters.AddWithValue("@sexo", SexoP);
                    comando.Parameters.AddWithValue("@telefono", numeroTeleP);
                    comando.Parameters.AddWithValue("@direccion", DireccionP);
                    comando.Parameters.AddWithValue("@estadocivil", EstadoCivilP);
                    comando.Parameters.AddWithValue("@fechanac", FechaNaciemientoP);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();

                }

            }

        }
        public void crearExpedinte(string Antecedentes, string medicamentos, string tipoSangre, int dui)
        {

            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = "insert into Expediente values (SYSDATETIME(),@antecendetes,@medicamentos,@sangre,@dui)";
                    Comando.Parameters.AddWithValue("@antecendetes", Antecedentes);
                    Comando.Parameters.AddWithValue("@medicamentos", medicamentos);
                    Comando.Parameters.AddWithValue("@sangre", tipoSangre);
                    Comando.Parameters.AddWithValue("@dui", dui);
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();

                }
            }
        }

        public void EliminarExp(int dui)
        {

            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = "delete from Expediente where dui = @dui ; delete from Paciente where Dui = @dui";
                    Comando.Parameters.AddWithValue("@dui", dui);
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                }
            }
        }





    }
}
