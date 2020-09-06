using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grocery.DataAccess.IRepositories;
using Grocery.DataAccess.Model;
namespace Grocery.BussinessLogic
{
    public class UnitofWorkMaster : IUnitofWorkMaster
    {
        private readonly GroceryDBContext _context;
        public UnitofWorkMaster()
        {
            GroceryDBContext contect = new GroceryDBContext();
            _context = contect;
            BranchMasters = new Repositories.BranchMasterRepository(_context);
        }
       public IBranchMasterRepository BranchMasters { get; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
