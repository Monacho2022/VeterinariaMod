using System.Collections.Generic;
using System.Linq;
using HostiEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HostiEnCasa.App.Persistencia
{

    public class RepositorioPaciente : IRepositorioPaciente
    {
        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioPaciente(AppContext appContext)
        {
            _appContext = appContext;
        }


        int IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);

            return _appContext.SaveChanges();

        }

        int IRepositorioPaciente.DeletePaciente(Paciente paciente)
        {
            _appContext.Pacientes.Remove(paciente);
            return _appContext.SaveChanges();
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;
        }

        Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.Include( p => p.SignosVitales ).FirstOrDefault(p => p.Id == idPaciente);
        }

        int IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);

            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellidos = paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono = paciente.NumeroTelefono;
                pacienteEncontrado.Genero = paciente.Genero;
                pacienteEncontrado.Direccion = paciente.Direccion;
                pacienteEncontrado.Latitud = paciente.Latitud;
                pacienteEncontrado.Longitud = paciente.Longitud;
                pacienteEncontrado.Ciudad = paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                pacienteEncontrado.Familiar = paciente.Familiar;
                pacienteEncontrado.Enfermera = paciente.Enfermera;
                pacienteEncontrado.Medico = paciente.Medico;
                pacienteEncontrado.Historia = paciente.Historia;
                pacienteEncontrado.SignosVitales = paciente.SignosVitales;

                return _appContext.SaveChanges();
            }
            return 0;
        }

        List<Paciente> IRepositorioPaciente.GetPacienteSignoFrecuencia(){
            return _appContext.Pacientes.Where(p => 
                p.SignosVitales.Any(s => s.Signo == TipoSigno.FrecuenciaCardica && s.Valor > 90)
                //&& p.NoDocumento == ""
            ).ToList();
        }

        List<SignoVital> IRepositorioPaciente.GetSignosPaciente(int idPaciente){
            var paciente = _appContext.Pacientes
                        .Where(p => p.Id == idPaciente)
                        .Include( p => p.SignosVitales )
                        .FirstOrDefault();

            return paciente.SignosVitales;
        }

        List<SignoVital> IRepositorioPaciente.GetSignosPacienteQuery(int idPaciente){
            
            var signosVitales = from paciente in _appContext.Pacientes
                                join signos in _appContext.SignosVitales
                                on paciente.Id equals signos.PacienteId
                                where 
                                paciente.Id == idPaciente
                                select new SignoVital{
                                    Id = signos.Id,
                                    FechaHora = signos.FechaHora,
                                    Valor = signos.Valor,
                                    Signo = signos.Signo                                    
                                };

            return signosVitales.ToList();            
        }

        Medico IRepositorioPaciente.AsignarMedico(int idPaciente, int idMedico)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m => m.Id == idMedico);
                if (medicoEncontrado != null)
                {
                    pacienteEncontrado.Medico = medicoEncontrado;
                    _appContext.SaveChanges();
                }
                return medicoEncontrado;
            }
            return null;

        }

        int IRepositorioPaciente.AsignarMedicoDirecto(Paciente paciente)
        {
            _appContext.Pacientes.Update(paciente);
            return _appContext.SaveChanges();
        }
        
    }
}