using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Filtrowanie.Utils;


namespace Filtrowanie.Pages
{
    [Custom_Filtr]
    public class IndexModel : PageModel
    {public string viewData { get; set; }


        private readonly ILogger<IndexModel> _logger;
       
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

       
    
    public void OnGet()
        {

            viewData = Request.HttpContext.Connection.RemoteIpAddress.ToString();

        }
    }
}
