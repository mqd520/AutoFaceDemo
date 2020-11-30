using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoFacDemo.IRepository;

namespace AutoFacDemo.Repository
{
    public class MyRepository : IMyRepository
    {
        public void MyRepository1()
        {
            System.Diagnostics.Debug.WriteLine("MyRepository.MyRepository1");
        }
    }
}
