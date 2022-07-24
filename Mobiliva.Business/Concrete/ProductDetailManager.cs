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
    public class ProductDetailManager : IProductDetailService
    {
        private readonly IProductDetailDal _productDetailDal;

        public ProductDetailManager(IProductDetailDal productDetailDal)
        {
            _productDetailDal = productDetailDal;
        }

        public IResult Add(ProductDetail productDetail)
        {
            _productDetailDal.Add(productDetail);
            return new SuccessResult(Messages.AddProductDetail);
        }

        public IResult Delete(ProductDetail productDetail)
        {
            _productDetailDal.Delete(productDetail);
            return new SuccessResult(Messages.DeleteProductDetail);
        }

        public IDataResult<ProductDetail> GetById(int id)
        {
            return new SuccessDataResult<ProductDetail>(_productDetailDal.Get(x => x.Id == id));
        }

        public IDataResult<List<ProductDetail>> GetList()
        {
            return new SuccessDataResult<List<ProductDetail>>(_productDetailDal.GetList().ToList());
        }

        public IResult Update(ProductDetail productDetail)
        {
            _productDetailDal.Update(productDetail);
            return new SuccessResult(Messages.UpdateProductDetail);
        }
    }
}
