using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoFacUtils;

namespace AutoFacDemo.WinForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutoFacHelper.Init(new string[] { "AutoFacDemo.IService", "AutoFacDemo.Service", "AutoFacDemo.IRepository", "AutoFacDemo.Repository" });

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
