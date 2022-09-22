using System;
using System.ComponentModel.DataAnnotations;

namespace HostiEnCasa.App.Dominio
{
    public class ReportePaciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NumeroTelefono { get; set; }
        public DateTime FechaHora  { get; set; }
        public float Valor {get;set;}
        public TipoSigno Signo { get; set; }
    }
}