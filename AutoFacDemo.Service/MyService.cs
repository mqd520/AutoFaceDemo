using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoFacUtils;
using AutoFacDemo.IService;
using AutoFacDemo.IRepository;

namespace AutoFacDemo.Service
{
    public class MyService : IMyService
    {
        private IMyRepository MyRepository { get { return AutoFacHelper.Get<IMyRepository>(); } }


        public void MyService1()
        {
            System.Diagnostics.Debug.WriteLine("MyService.MyService1");
            Console.WriteLine("MyService.MyService1");

            MyRepository.MyRepository1();
        }
    }
}
