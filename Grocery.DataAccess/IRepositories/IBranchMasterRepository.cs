using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.DataAccess.IRepositories
{
    public interface IBranchMasterRepository:IRepositories<Model.branch_master>
    {
        List<Model.branch_master> GetBranch_MastersBy(string UserID);
    }
}
