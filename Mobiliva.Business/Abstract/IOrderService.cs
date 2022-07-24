using Mobiliva.Core.Utilities.Results;
using Mobiliva.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliva.Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetList();
        IDataResult<Order> GetById(int id);
        IResult Add(Order order);
        IResult Delete(Order order);
        IResult Update(Order order);

    }
}
