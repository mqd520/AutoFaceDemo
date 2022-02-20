using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoFacUtils;
using AutoFacDemo.IService;

namespace AutoFacDemo.Console
{
    class Program
    {
        private static IUserService MyService { get { return AutoFacHelper.Resolve<IUserService>(); } }


        static void Main(string[] args)
        {
            AutoFacHelper.LoadAssembly(new string[] { "AutoFacDemo.IService", "AutoFacDemo.Service", "AutoFacDemo.IRepository", "AutoFacDemo.Repository" });


            while (true)
            {
                string line = System.Console.ReadLine();
                if (line.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    if (line.Equals("MyService1"))
                    {
                        //MyService.MyService1();
                    }
                }
            }
        }
    }
}
