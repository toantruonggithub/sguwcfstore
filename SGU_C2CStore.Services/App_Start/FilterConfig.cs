﻿using System.Web;
using System.Web.Mvc;

namespace SGU_C2CStore.Services
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
