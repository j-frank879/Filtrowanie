﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Filtr.Utils
{
    public class CustomPageFilter : IPageFilter
    {
        public CustomPageFilter(IConfiguration _config)
        {
            int a = 0;
        }
        public void OnPageHandlerSelected(PageHandlerSelectedContext pageContext)
        {
            int a = 0;

        }
        public void OnPageHandlerExecuting(PageHandlerExecutingContext pageContext)
        {
            int a = 0;
        }
        public void OnPageHandlerExecuted(PageHandlerExecutedContext pageContext)
        {
            int a = 0;
        }
    }
}
