using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AutoFacUtils;
using AutoFacDemo.IRepository;
using AutoFacDemo.IService;

namespace AutoFacDemo.Web.MVC.Controllers
{
    public class HomeController : Controller
    {
        private IMyRepository MyRepository { get { return AutoFacHelper.Get<IMyRepository>(); } }

        private IMyService MyService { get { return AutoFacHelper.Get<IMyService>(); } }


        public HomeController()
        {

        }

        public ActionResult Index()
        {
            MyRepository.MyRepository1();
            MyService.MyService1();

            return View();
        }
    }
}