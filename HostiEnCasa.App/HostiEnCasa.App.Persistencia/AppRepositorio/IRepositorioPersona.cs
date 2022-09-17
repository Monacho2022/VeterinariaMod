using System;
using System.Collections.Generic;
using System.Linq;
using HostiEnCasa.App.Dominio;

namespace HostiEnCasa.App.Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();
        int AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        int DeletePersona(int idPersona);    
        Persona GetPersona(int idPersona);        
        List<Persona> GetAllPersonasList();
        Persona GetPersonaFind(int idPersona);
        List<Persona> GetAllPersonasByGender(Genero genero, string tipoPersona);
        int UpdatePersonaFull(Persona persona);
    }

}