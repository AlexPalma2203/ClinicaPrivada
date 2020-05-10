using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using CapaComun.Cache;

namespace Dominio
{
    public class ModeloUsuario
    {
        UsuarioD usuarioD = new UsuarioD();
       
        public bool AccesoUsuario(string usuario, string contraseña)
        {
            return usuarioD.Acceso(usuario, contraseña);
        }
        PacienteD pacienteD = new PacienteD();
        public bool BusquedadPaciente(int dui)
        {
            return pacienteD.BusquedadPaciente(dui);
        }


    }
    
}
