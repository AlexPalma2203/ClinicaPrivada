using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.Cache
{
    public static class CacheDeUsuario
    {
        public static string idUser { get; set; }
        public static string NonbreUsuario{ get; set; }
        public static string ApellidoUsuario { get; set; }
        public static string CargoUsuario { get; set; }
        public static string Contraseña { get; set; }
    }

    public static class CachePaciente
    {
        //Paciente
        public static int Dui { get; set; }
        public static string NombrePaciente { get; set; }
        public static string ApellidoPaciente { get; set; }
        public static string SexoPaciente { get; set; }
        public static int TelefonoPaciente { get; set; }
        public static string DirrecionPaciente { get; set; }
        public static string EstadoCivilPaciente { get; set; }
        public static string FechaNacimientoPaciente { get; set; }

    }

    public static class CacheExpediente
    {
        public static int NumExpediente  { get; set; }
        public static DateTime FechaCreacionExpediente { get; set; }
        public static string AntecedentesClinicos { get; set; }
        public static string MedicamentosPreEscritos  { get; set; }
        public static string TipoSangre { get; set; }
    }

    
}
