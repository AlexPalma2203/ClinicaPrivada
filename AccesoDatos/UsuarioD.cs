using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaComun;
using CapaComun.Cache;

namespace AccesoDatos
{
    public class UsuarioD : ConexionSQL
    {
        public bool Acceso(string usuario, string contraseña)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {


                    comando.Connection = conexion;
                    comando.CommandText = "Select * from Usuario where Id_Usuario = @usuario and Contraseña_Usuasio = @contraseña ";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);

                    comando.CommandType = CommandType.Text;
                    SqlDataReader lectura = comando.ExecuteReader();
                    if (lectura.HasRows)
                    {
                        while (lectura.Read())
                        {
                            CacheDeUsuario.idUser = lectura.GetString(0);
                            CacheDeUsuario.NonbreUsuario = lectura.GetString(1);
                            CacheDeUsuario.ApellidoUsuario = lectura.GetString(2);
                            CacheDeUsuario.CargoUsuario = lectura.GetString(3);
                            CacheDeUsuario.Contraseña = lectura.GetString(4);

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
