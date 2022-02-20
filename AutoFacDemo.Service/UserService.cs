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
    /// <summary>
    /// User Service
    /// </summary>
    public class UserService : IUserService
    {
        private IUserRepository UserRepository { get { return AutoFacHelper.Resolve<IUserRepository>(); } }

        public IUserRepository UserRepository2 { get; set; }


        public bool IsLogin()
        {
            return true;
        }
    }
}
