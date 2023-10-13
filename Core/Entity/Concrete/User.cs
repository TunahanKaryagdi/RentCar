using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        [Column("First_Name")]
        public string FirstName { get; set; }
        [Column("Last_Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Column("Password_Hash")]
        public byte[] PasswordHash { get; set; }
        [Column("Password_Salt")]
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
    }
}
