using System;
using System.Collections.Generic;
using System.Linq;
using HostiEnCasa.App.Dominio;

namespace HostiEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        int AddPaciente(Paciente paciente);
        int UpdatePaciente(Paciente paciente);
        int DeletePaciente(Paciente paciente);
        Paciente GetPaciente(int idPaciente);
        Medico AsignarMedico(int idPaciente, int idMedico);
        List<Paciente> GetPacienteSignoFrecuencia();
        List<SignoVital> GetSignosPaciente(int idPaciente);
        Paciente GetSignosPacienteOnly(int idPaciente);
        List<SignoVital> GetSignosPacienteQuery(int idPaciente);
        int AsignarMedicoDirecto(Paciente paciente);
        List<ReportePaciente> ReportSignosPaciente(int idPaciente);
    }

}