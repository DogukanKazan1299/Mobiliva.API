using Mobiliva.Core.DataAccess;
using Mobiliva.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliva.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
