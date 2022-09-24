using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;

namespace HospiEnCasa.App.WebApp
{
    public class LoginModel : PageModel
    {

        public string _sessionIdUser = "_idUser";
        public string _sessionIdRol = "_idRol";
        private IHttpContextAccessor _httpContextAccessor;

        public LoginModel(IHttpContextAccessor httpContextAccessor){
            _httpContextAccessor = httpContextAccessor;
        }

        public void OnGet(string cerrar = "")
        {
            if(cerrar == "1"){
                _httpContextAccessor.HttpContext.Session.Remove(_sessionIdRol);
                _httpContextAccessor.HttpContext.Session.Remove(_sessionIdUser);
                _httpContextAccessor.HttpContext.Session.Clear();
            }
        }

        public IActionResult OnPostValidateLogin(string Usuario, string Password){

            //Consultar el repositorio, van a enviar el usuario y password como parametro
            if( Usuario == "Juank" && Password == "1234" ){
                //Le doy acceso de session
                var rol = "2";
                var idUser = "1000";

                _httpContextAccessor.HttpContext.Session.SetString(_sessionIdUser, idUser);
                _httpContextAccessor.HttpContext.Session.SetString(_sessionIdRol, rol);

                Console.WriteLine("Contenido idUser: " + _httpContextAccessor.HttpContext.Session.GetString(_sessionIdUser) );
                Console.WriteLine("Contenido idRol: " +_httpContextAccessor.HttpContext.Session.GetString(_sessionIdRol) );

                switch (rol)
                {
                    case "2": return Content("Index"); break;
                    case "3": return Content("GestionPersonas/List"); break;
                    default: return Content("");
                }
            }else{
                //Refresca el sitio
                return Content("");
            }

        }
    }
}
