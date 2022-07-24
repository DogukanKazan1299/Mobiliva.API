using Mobiliva.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliva.Entities.Concrete
{
    public class Product : IEntity
    {
        //Id, Description, Category, Unit, UnitPrice, Status, CreateDate, UpdateDate alanlarından
        public int Id { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Unit { get; set; }
        public int UnitPrice { get; set; }
        public bool Status { get; set; } = true;
        public DateTime CreateDate { get; set; }= DateTime.Now;
        public DateTime UpdateDate { get; set; }=DateTime.Now;
       
        public ProductDetail Detail { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
