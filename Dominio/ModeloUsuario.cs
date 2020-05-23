using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using CapaComun.Cache;

namespace Dominio
{
    public class ModeloUsuario

    {

        private string nombre, usuario, contraseña, cargo, apellido;
        UsuarioD usuarioD = new UsuarioD();

        public ModeloUsuario(string nombre, string usuario, string contraseña, string apellido)
        {
            this.nombre = nombre;
            this.usuario = usuario;
            this.contraseña = contraseña;
            
            this.apellido = apellido;
        }
        public ModeloUsuario() { }

        public bool AccesoUsuario(string usuario, string contraseña)
        {
            return usuarioD.Acceso(usuario, contraseña);
        }

        public string editarUsuario(){
            try
            {
                usuarioD.EditarUsuario(usuario, nombre, apellido, contraseña);
                AccesoUsuario(usuario, contraseña);
                return "Tu perfil se ha actualizado correctamente";
            } catch (SqlException) {

                return "El nombre de usuario ya esta registrado";
            }
           
            
        }


    }
    public class ModeloPaciente
    {
        private int Dui, numeroTeleP;
        private string Antecedentes;
        private string medicamentos;
        private string tipoSangre;
        private string nombreP,apellidosP,  SexoP, DireccionP, EstadoCivilP, FechaNaciemientoP;


        PacienteD pacienteD = new PacienteD();

        public ModeloPaciente(int dui, string antecedentes, string medicamentos, string tipoSangre, string nombreP, string apellidosP, string sexoP, int numeroTeleP, string direccionP, string estadoCivilP, string fechaNaciemientoP)
        {
            Dui = dui;
            Antecedentes = antecedentes;
            this.medicamentos = medicamentos;
            this.tipoSangre = tipoSangre;
            this.nombreP = nombreP;
            this.apellidosP = apellidosP;
            SexoP = sexoP;
            this.numeroTeleP = numeroTeleP;
            DireccionP = direccionP;
            EstadoCivilP = estadoCivilP;
            FechaNaciemientoP = fechaNaciemientoP;
        }
        public ModeloPaciente() { }

        

        public bool BusquedadPaciente(int dui)
        {
            return pacienteD.BusquedadPaciente(dui);
        }
        public bool BusquedadPacienteCita(int dui) {

            return pacienteD.BusquedadPacienteCita(dui);
        }

        public string ActualizarExpediente()
        {
            try {
                pacienteD.actualizarPaciente(Dui,nombreP, apellidosP, SexoP, numeroTeleP, DireccionP, EstadoCivilP, FechaNaciemientoP);
                pacienteD.actualizarExpedinte(Antecedentes, medicamentos, tipoSangre, Dui);
                BusquedadPaciente(Dui);
                return "Expediente Actualizado";
            }
            catch
            {
                return "Error al actulizar datos";
            }
            
        }

        public string CrearExpediente()
        {
            try {
                pacienteD.crearPaciente(Dui, nombreP, apellidosP, SexoP, numeroTeleP, DireccionP, EstadoCivilP, FechaNaciemientoP);
                pacienteD.crearExpedinte(Antecedentes, medicamentos, tipoSangre, Dui);
                return "Expediente Creado";
            } catch (Exception) {
                return "El numero de Dui ya esta registrado";
            }
                
            
            
            
        }

        public void EliminarExp()
        {
            pacienteD.EliminarExp(CachePaciente.Dui);

        }


    }

    //nueva clase

    public class ModeloDianostPacie {
        private string EnfermP,EstaP,DetallP,RecomendaP;
        private float PesoP, EstatuP, PresiP, TempoP;
        private int numeE;
        public ModeloDianostPacie(string EnfermedadP, string EstadoP, float pesoP, float estaturaP, float presionP, float temperaturaP, string detallesP, string recomendacionesP,int NumExped) {
            EnfermP = EnfermedadP;
            EstaP = EstadoP;
            PesoP= pesoP;
            EstatuP = estaturaP;
            PresiP = presionP;
            TempoP = temperaturaP;
            DetallP= detallesP;
            RecomendaP = recomendacionesP;
            numeE = NumExped;
        }
        PacienteD pacienteD = new PacienteD();

        public ModeloDianostPacie() { }
        public string Dianostico() {
            pacienteD.CrearDianostico(numeE,EnfermP, EstaP, PesoP, EstatuP, PresiP, TempoP, DetallP, RecomendaP );
            return "Dianostico creado";
            }
        }
    public class ModeloCita {
        private int numCita;
        private string motivo, CreadoPor;
        private DateTime fechaCreacion;
        private DateTime fechaCita;
        private int dui;
        private double Precio;

        public ModeloCita(string motivo, DateTime fechaCita, string CreadoPor, double Precio, int dui) {
            this.motivo = motivo;
            this.fechaCita = fechaCita;
            this.dui = dui;
            this.Precio = Precio;
            this.CreadoPor = CreadoPor;

        }
        public ModeloCita(int dui, DateTime fechaCita)
        {
            
            this.fechaCita = fechaCita;
            this.dui = dui;
          

        }
        PacienteD C1 = new PacienteD();
        public string Cita()
        {
            try {
                C1.CrearCita(motivo, fechaCita, CreadoPor, Precio, dui);
                return "Cita Creada";
            } catch (SqlException) {
                return "Ya tiene cita agendada a esa hora y fecha";

            }

        }
        public string ActCita() {

            C1.actualizarCita(motivo, fechaCita, CreadoPor, Precio, dui);
            return "Cita Actualizada";
        }
        public int eliminarCita (){

            return C1.eliminarcita(dui, fechaCita); 
        }

    
    
    
    
    }
    
    
}
