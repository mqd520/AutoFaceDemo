using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoFacDemo.IRepository;

namespace AutoFacDemo.Repository
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<string> QueryAll()
        {
            var ls = new List<string>();
            ls.Add("AAtest001");
            ls.Add("AAtest002");
            ls.Add("AAtest003");

            return ls;
        }
    }
}
