using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Grocery.DataAccess.Model
{
    [Table("branch_master", Schema = "dbo")]
    public partial class branch_master
    {
        [Key]
        public string branchid { get; set; }
        public string branchname { get; set; }
        public string location { get; set; }
        public string Address { get; set; }
        public string contactperson { get; set; }
        public string trnNo { get; set; }
        public string shopnameL1 { get; set; }
        public string shopnameL2 { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public string UserID { get; set; }
    }
}
