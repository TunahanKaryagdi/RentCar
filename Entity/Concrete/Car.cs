using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        
        [Column("Brand_Id")]
        public int BrandId { get; set; }
        [Column("Color_Id")]
        public int ColorId { get; set; }
        [Column("Model_Year")]
        public string ModelYear { get; set; }
        [Column("Daily_Price")]
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }

}
