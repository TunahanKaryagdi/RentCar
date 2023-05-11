using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Customer : IEntity
    {
        [Column("User_Id")]
        [Key]
        public int UserId { get; set; }
        [Column("Company_Name")]
        public string CompanyName { get; set; }
    }
}
