using Mobiliva.Core.DataAccess.EntityFramework;
using Mobiliva.DataAccess.Abstract;
using Mobiliva.DataAccess.Concrete.EntityFramework.Contexts;
using Mobiliva.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliva.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order,MobilivaContext> , IOrderDal
    {
    }
}
