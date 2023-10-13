using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.Concrete
{
    public class UserOperationClaim
    {
        public int Id { get; set; }
        [Column("Operation_Claim_Id")]
        public int OperationClaimId { get; set; }
        [Column("User_Id")]
        public int UserId { get; set; }
    }
}
