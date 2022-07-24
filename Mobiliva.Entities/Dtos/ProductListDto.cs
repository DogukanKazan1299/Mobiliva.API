using Mobiliva.Core.Entities;
using Mobiliva.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliva.Entities.Dtos
{
    public class ProductListDto : IDto
    {
        public IList<Product> Products { get; set; }
    }
}
