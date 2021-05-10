using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Filtrowanie.Utils;

/*Napisz filtr asynchroniczny zapisujący w zmiennej viewData adres IP odwiedzającego stronę. Filtr powinien działać tylko na modelu strony Index. Zapisaną wartość wyświetl na stronie głównej aplikacji.

Link do projektu na GitHub umieść na CEZie.*/
namespace Filtrowanie.Pages
{
    [Custom_Filtr]
    public class IndexModel : PageModel
    {public string IP { get; set; }


        private readonly ILogger<IndexModel> _logger;
       
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

       
    
    public void OnGet()
        {
            
        IP = Request.HttpContext.Connection.RemoteIpAddress.ToString();

        }
    }
}
