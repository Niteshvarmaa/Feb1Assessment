﻿using System.Web;
using System.Web.Mvc;

namespace Feb1Assessment
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}