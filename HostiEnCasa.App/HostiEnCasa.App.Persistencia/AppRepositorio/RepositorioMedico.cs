using System.Collections.Generic;
using System.Linq;
using HostiEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HostiEnCasa.App.Persistencia
{

    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly AppContext _appContext;
        
        public RepositorioMedico(AppContext appContext)
        {
            _appContext = appContext;
        }

        int IRepositorioMedico.AddMedico(Medico medico)
        {
            var medicoAdicionado = _appContext.Medicos.Add(medico);

            return _appContext.SaveChanges();

        }

        int IRepositorioMedico.DeleteMedico(Medico medico)
        {
            _appContext.Medicos.Remove(medico);
            return _appContext.SaveChanges();
        }

        List<Medico> IRepositorioMedico.GetAllMedicos()
        {
            return _appContext.Medicos.ToList();
        }

        Medico IRepositorioMedico.GetMedico(int idMedico)
        {
            return _appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);
        }

        int IRepositorioMedico.UpdateMedico(Medico medico)
        {
            _appContext.Medicos.Update(medico);
            return _appContext.SaveChanges();
        }        
        
    }
}