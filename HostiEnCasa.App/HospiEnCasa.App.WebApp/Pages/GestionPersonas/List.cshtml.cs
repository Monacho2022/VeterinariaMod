using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HostiEnCasa.App.Dominio;
using HostiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;

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
        public string _sessionIdUser = "_idUser";
        public string _sessionIdRol = "_idRol";
        private IHttpContextAccessor _httpContextAccessor;

        public ListModel(IHttpContextAccessor httpContextAccessor){
            //Validar el rol que tenga y determinar si puede ver la página o no
            //return RedirectToPage("./Home");
            Console.WriteLine("Constructor List"); 
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult OnGet()
        {
            listadoPersonas = new List<Persona>();
            listadoPersonas = _personaRepository.ObtenerTodo();
            listadoMedicos = new List<Medico>();
            listadoMedicos = _repositorioMedico.GetAllMedicos();

            if( string.IsNullOrEmpty( _httpContextAccessor.HttpContext.Session.GetString(_sessionIdUser) ) 
                || string.IsNullOrEmpty( _httpContextAccessor.HttpContext.Session.GetString(_sessionIdRol) ) ){                
                Console.WriteLine("Acceso ilegal no esta logueado");
                return RedirectToPage("/Login");
            }else{
                Console.WriteLine("Tiene permiso");
                return Page();
            }

            if(ViewData["mensaje"] != null)
                mensaje = ViewData["mensaje"].ToString();
            else
                mensaje = "";

            HttpContext.Session.SetInt32("Test Int", 1);
            HttpContext.Session.Set("Test Byte Array", BitConverter.GetBytes(true));
            HttpContext.Session.Remove("Name");
            HttpContext.Session.Clear();
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

            //Agregar relación de inserción
            paciente.SignosVitales = new List<SignoVital>{
                new SignoVital{ 
                    FechaHora = new DateTime(2022, 09, 17),
                    Valor = 95F,
                    Signo = TipoSigno.SaturacionOxigeno
                }
            };
            
            //Utilizar en la actuliación
            paciente.SignosVitales.Add( 
                new SignoVital{ 
                    FechaHora = new DateTime(2022, 09, 16),
                    Valor = 38.5F,
                    Signo = TipoSigno.TemperaturaCorporal
                }
            );

            var result = _repositorioPaciente.AddPaciente(paciente);

            if( result > 0){
                return Content("Se inserto el paciente con exito");
            }else{
                return Content("No se logro insertar el paciente");
            }
        }

        public IActionResult OnPostCreateMedico([FromBody]Medico medico){

            //Validar el objeto que reciben via ajax

            var result = _repositorioMedico.AddMedico(medico);

            if( result > 0){
                return Content("Se inserto el médico con exito");
            }else{
                return Content("No se logro insertar el médico");
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

        public IActionResult OnPostAsignarMedico(string IdPaciente, string IdMedico){

            //Validar el objeto que reciben via ajax

            var medico = _repositorioMedico.GetMedico( Int32.Parse(IdMedico) );
            var paciente = _repositorioPaciente.GetPaciente( Int32.Parse(IdPaciente) );

            if(paciente != null && medico != null){

                paciente.Medico = medico;

                var result = _repositorioPaciente.AsignarMedicoDirecto(paciente);

                if( result > 0){
                    return Content("Se asignó el médico con exito");
                }else{
                    return Content("No se logro asignar el médico");
                }
            }else{
                return Content("No existe el médico o paciente");
            }
            
        }

        public IActionResult OnPostObtenerSignosVitales(string IdPaciente){

            //Validar el objeto que reciben via ajax

            var signos = _repositorioPaciente.GetSignosPaciente( Int32.Parse(IdPaciente) );

            if(signos != null){     
                return new JsonResult(signos);
            }else{
                return null;
            }
            
        }

        public IActionResult OnPostAgregarSignos([FromBody]List<SignoVital> listado){

            //Validar el objeto que reciben via ajax
            var IdPaciente = 0;
            
            foreach (var signo in listado)
            {
                IdPaciente = signo.PacienteId;
                break;
            }

            var paciente = _repositorioPaciente.GetPaciente(IdPaciente);

            if( paciente != null){

                if( paciente.SignosVitales.Count > 0 ){
                    paciente.SignosVitales.AddRange(listado);
                }else{
                    paciente.SignosVitales = listado;
                }

                var result = _repositorioPaciente.Update(paciente);

                if( result > 0 )
                    return Content("Se agregaron los signos vitales con exito");
                else
                    return Content("No se logro agregar los signos vitales");

            }else{
                return Content("El paciente no existe");
            }
            
        }

    }
}
