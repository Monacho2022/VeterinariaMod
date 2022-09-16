using System;
using System.Collections.Generic;
using System.Linq;
using HostiEnCasa.App.Dominio;

namespace HostiEnCasa.App.Persistencia
{
    public interface IRepositorioMedico
    {
        List<Medico> GetAllMedicos();
        int AddMedico(Medico medico);
        int UpdateMedico(Medico medico);
        int DeleteMedico(Medico medico);
        Medico GetMedico(int idMedico);        
    }

}