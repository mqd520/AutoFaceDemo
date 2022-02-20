using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

using Autofac.Integration.Mvc;

using AutoFacUtils;
using Autofac;

namespace AutoFacDemo.Web.MVC.App_Start
{
    public class AutofacConfig
    {
        public static void Register()
        {
            AutoFacHelper.Init();
            AutoFacHelper.LoadAssembly(new string[] {
                "AutoFacDemo.IService",
                "AutoFacDemo.Service",
                "AutoFacDemo.IRepository",
                "AutoFacDemo.Repository"
            });

            AutoFacHelper.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(AutoFacHelper.Container));
        }
    }
}