using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacDemo.IRepository
{
    public interface IUserRepository
    {
        IEnumerable<string> QueryAll();
    }
}
