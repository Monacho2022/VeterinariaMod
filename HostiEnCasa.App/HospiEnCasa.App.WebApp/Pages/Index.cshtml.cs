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
        public string _sessionUsuario = "_usuario";

        public IndexModel(ILogger<IndexModel> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            Console.WriteLine("Constructor Index");    
            httpContextAccessor.HttpContext.Session.SetString(_sessionUsuario, "Creado desde index");
            Console.WriteLine(httpContextAccessor.HttpContext.Session.GetString(_sessionUsuario));
        }

        public void OnGet()
        {

        }
    }
}
