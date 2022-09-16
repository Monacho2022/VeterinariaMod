using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HostiEnCasa.App.Dominio;
using HostiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.WebApp
{
    public class ListModel : PageModel
    {
        private IPersonaRepository _personaRepository = new PersonaRepository( new HostiEnCasa.App.Persistencia.AppContext() );
        private IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente( new HostiEnCasa.App.Persistencia.AppContext()); 
        private IRepositorioMedico _repositorioMedico = new RepositorioMedico( new HostiEnCasa.App.Persistencia.AppContext()); 

        public List<Persona> listadoPersonas { get; set;}
        public List<Medico> listadoMedicos { get; set;}
        public string mensaje;

        /*
        public List(){
            //Validar el rol que tenga y determinar si puede ver la página o no
            //return RedirectToPage("./Home");
        }*/

        public void OnGet()
        {
            listadoPersonas = new List<Persona>();
            listadoPersonas = _personaRepository.ObtenerTodo();
            listadoMedicos = new List<Medico>();
            listadoMedicos = _repositorioMedico.GetAllMedicos();

            if(ViewData["mensaje"] != null)
                mensaje = ViewData["mensaje"].ToString();
            else
                mensaje = "";
        }

        public IActionResult OnPostUpdateJson([FromBody]Persona persona)
        {
            var personaResult = _personaRepository.Buscar( persona.Id );
            var mensaje = "";

            if( personaResult != null){

                personaResult.Nombre = persona.Nombre;
                personaResult.Apellidos = persona.Apellidos;
                personaResult.NumeroTelefono = persona.NumeroTelefono;
                personaResult.Genero = (persona.Genero == 0 ? Genero.Femenino : Genero.Masculino);
            
                var result = _personaRepository.Update(personaResult);

                if( result > 0){
                    mensaje = "Se actualizo correctamente";
                }else{
                    mensaje = "No se pudo actualizar";
                }

            }else{
                mensaje = "La persona a actualizar no existe";
            }

            //return new JsonResult(persona);

            return Content(mensaje);

        } 

        public IActionResult OnPostCreate([FromBody]Persona persona){
            
            //Validar los datos recibidos
        
            var result = _personaRepository.AdicionarPersona(persona);

            //Mostrar al front el resultado de la operación
            if( result > 0){
                return Content("Se inserto la persona con exito");
            }else{
                return Content("No se logro insertar la persona");
            }

        }

        public IActionResult OnPostCreatePaciente([FromBody]Paciente paciente){

            //Validar el objeto paciente que reciben via ajax

            var result = _repositorioPaciente.AddPaciente(paciente);

            if( result > 0){
                return Content("Se inserto el paciente con exito");
            }else{
                return Content("No se logro insertar el paciente");
            }
        }

        public IActionResult OnPostDelete(string Id, string TipoPersona){
            
            if(TipoPersona == "Persona"){

                var persona = _personaRepository.Buscar( Int32.Parse(Id) );

                if( persona != null){
                    
                    var result = _personaRepository.Delete(persona);    

                    if( result > 0){
                        return Content("Se eliminó la persona con exito");
                    }else{
                        return Content("No se logro eliminar la persona");
                    }

                }else{
                    return Content("No existe la persona a eliminar");
                }

            }
            if(TipoPersona == "Paciente"){
                
                var paciente = _repositorioPaciente.GetPaciente( Int32.Parse(Id) );

                if( paciente != null){
                    
                    //Validar si tiene signos vitales asociados
                    if( paciente.SignosVitales.Count > 0 ){
                        return Content("El paciente a eliminar tiene signos vitales asociados");
                    }

                    var result = _repositorioPaciente.DeletePaciente(paciente);    

                    if( result > 0){
                        return Content("Se eliminó el paciente con exito");
                    }else{
                        return Content("No se logro eliminar el paciente");
                    }

                }else{
                    return Content("No existe el paciente a eliminar");
                }
                
            }

            return Content("No existe un tipo de persona asociada");
            
            
        }

    }
}
