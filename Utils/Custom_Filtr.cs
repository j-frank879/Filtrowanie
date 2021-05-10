using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using System.Web;
using Filtrowanie.Pages;

namespace Filtrowanie.Utils
{
    public class Custom_Filtr : ResultFilterAttribute
    {
        

        public override void OnResultExecuting(ResultExecutingContext context)
        { 
            
           
            var result = context.Result;
            if (result is PageResult)
            {
                var page = ((PageResult)result);
                page.ViewData["filterMessage"] = "Adres IP : " + ((IndexModel)page.Model).viewData;

               
            }

        }


    } }
