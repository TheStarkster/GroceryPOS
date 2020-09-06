using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grocery.BusinessLogic.Repositories;
using Grocery.DataAccess.IRepositories;
using Grocery.DataAccess.Model;

namespace Grocery.BussinessLogic.Repositories
{
    public class BranchMasterRepository : Repository<branch_master>, IBranchMasterRepository
    {
        public BranchMasterRepository(GroceryDBContext context)
           : base(context)
        { }
        public GroceryDBContext GroceryDBContext
        {
            get { return Context as GroceryDBContext; }
        }
        public List<branch_master> GetBranch_MastersBy(string UserID)
        {
           return GroceryDBContext.branch_masters.Where(Item => Item.UserID == UserID).ToList();
        }
    }
}
