using Mobiliva.Business.Abstract;
using Mobiliva.Business.Constants;
using Mobiliva.Core.Utilities.Results;
using Mobiliva.DataAccess.Abstract;
using Mobiliva.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliva.Business.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailDal;
        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal= orderDetailDal;
        }
        public IResult Add(OrderDetail orderDetail)
        {
            _orderDetailDal.Add(orderDetail);
            return new SuccessResult(Messages.AddOrderDetail);
        }

        public IResult Delete(OrderDetail orderDetail)
        {
            _orderDetailDal.Delete(orderDetail);
            return new SuccessResult(Messages.DeleteOrderDetail);
        }

        public IDataResult<OrderDetail> GetById(int id)
        {
            return new SuccessDataResult<OrderDetail>(_orderDetailDal.Get(x => x.Id == id));
        }

        public IDataResult<List<OrderDetail>> GetList()
        {
            return new SuccessDataResult<List<OrderDetail>>(_orderDetailDal.GetList().ToList());
        }

        public IResult Update(OrderDetail orderDetail)
        {
            _orderDetailDal.Update(orderDetail);
            return new SuccessResult(Messages.UpdateOrderDetail);
        }
    }
}
