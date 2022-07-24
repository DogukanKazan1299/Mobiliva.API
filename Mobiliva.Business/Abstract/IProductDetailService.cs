using Mobiliva.Core.Utilities.Results;
using Mobiliva.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliva.Business.Abstract
{
    public interface IProductDetailService
    {
        IDataResult<List<ProductDetail>> GetList();
        IDataResult<ProductDetail> GetById(int id);
        IResult Add(ProductDetail productDetail);
        IResult Delete(ProductDetail productDetail);
        IResult Update(ProductDetail productDetail);
    }
}
