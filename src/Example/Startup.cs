﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Example.Models;
using Umbraco.Core;
using Umbraco.Core.Persistence;

namespace Example
{
    public class Startup : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            var db = applicationContext.DatabaseContext.Database;
            //if (!db.TableExist("DateTest"))
            //    db.CreateTable<DateTest>(false);
        }
    }
}