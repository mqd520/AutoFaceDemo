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
        private IUserRepository UserRepository { get { return AutoFacHelper.Resolve<IUserRepository>(); } }

        private IUserService UserService { get { return AutoFacHelper.Resolve<IUserService>(); } }

        public IUserRepository UserRepository2 { get; set; }

        public IUserService UserService2 { get; set; }


        public HomeController()
        {

        }

        public ActionResult Index()
        {
            var ls = UserRepository.QueryAll();
            var flag = UserService.IsLogin();

            return View();
        }
    }
}