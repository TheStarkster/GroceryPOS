using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.DataAccess.IRepositories
{
    public interface IUnitofWorkMaster : IDisposable
    {
        IBranchMasterRepository BranchMasters { get; }
        int Complete();
    }
}
