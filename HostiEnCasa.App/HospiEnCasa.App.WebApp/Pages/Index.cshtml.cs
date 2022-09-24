using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;

namespace HospiEnCasa.App.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string _sessionIdUser = "_idUser";
        public string _sessionIdRol = "_idRol";
        private IHttpContextAccessor _httpContextAccessor;

        public IndexModel(ILogger<IndexModel> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            Console.WriteLine("Constructor Index");    
            Console.WriteLine("Index, Contenido idUser: " + _httpContextAccessor.HttpContext.Session.GetString(_sessionIdUser) );
            Console.WriteLine("Index, Contenido idRol: " + _httpContextAccessor.HttpContext.Session.GetString(_sessionIdRol) );
            
        }

        public IActionResult OnGet()
        {
            if( string.IsNullOrEmpty( _httpContextAccessor.HttpContext.Session.GetString(_sessionIdUser) ) 
                || string.IsNullOrEmpty( _httpContextAccessor.HttpContext.Session.GetString(_sessionIdRol) ) ){                
                Console.WriteLine("Acceso ilegal no esta logueado");
                return RedirectToPage("/Login");
            }else{
                Console.WriteLine("Tiene permiso");
                return Page();
            }
        }
    }
}
