﻿using System.Web;
using System.Web.Mvc;

namespace Web_Ban_QA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
