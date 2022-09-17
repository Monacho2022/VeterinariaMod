using System.Collections.Generic;
using System.Linq;
using HostiEnCasa.App.Dominio;

namespace HostiEnCasa.App.Persistencia
{

    public class RepositorioPersona : IRepositorioPersona
    {
        /// <summary>
        /// Referencia al contexto de Persona
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }


        int IRepositorioPersona.AddPersona(Persona persona)
        {
            var PersonaAdicionado = _appContext.Personas.Add(persona);
            return _appContext.SaveChanges();
        }

        int IRepositorioPersona.DeletePersona(int idPersona)
        {
            var PersonaEncontrado = _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
            if (PersonaEncontrado == null)
                return 0;

            _appContext.Personas.Remove(PersonaEncontrado);
            return _appContext.SaveChanges();
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.Personas;
        }

        List<Persona> IRepositorioPersona.GetAllPersonasList()
        {
            return _appContext.Personas.ToList();
        }

        Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
        }

        Persona IRepositorioPersona.GetPersonaFind(int idPersona)
        {
            return _appContext.Personas.Find(idPersona);
        }

        List<Persona> IRepositorioPersona.GetAllPersonasByGender(Genero genero, string tipoPersona){
            return _appContext.Personas.Where(p => p.Genero == genero 
                                                && p.Discriminator == tipoPersona).ToList();
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var PersonaEncontrado = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
            if (PersonaEncontrado != null)
            {
                PersonaEncontrado.Nombre = persona.Nombre;
                PersonaEncontrado.Apellidos = persona.Apellidos;
                PersonaEncontrado.NumeroTelefono = persona.NumeroTelefono;
                PersonaEncontrado.Genero = persona.Genero;
                PersonaEncontrado.Discriminator = persona.Discriminator;
                
                _appContext.SaveChanges();
            }
            return PersonaEncontrado;
        }

        int IRepositorioPersona.UpdatePersonaFull(Persona persona){
            _appContext.Personas.Update(persona);
            return _appContext.SaveChanges();
        }
        
    }
}