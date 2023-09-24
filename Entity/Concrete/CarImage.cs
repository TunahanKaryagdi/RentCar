using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class CarImage : IEntity
    {

        public int Id { get; set; }
        [Column("Car_Id")]
        public int CarId { get; set; }
        [Column("Image_Path")]
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
