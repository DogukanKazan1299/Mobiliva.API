using Mobiliva.Business.Abstract;
using Mobiliva.Business.Constants;
using Mobiliva.Core.Aspects.Caching;
using Mobiliva.Core.Utilities.Results;
using Mobiliva.DataAccess.Abstract;
using Mobiliva.Entities.Concrete;
using Mobiliva.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliva.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult Add(ProductDto productDto)
        {
            _productDal.Add(new Product { 
            
                Description= productDto.Description,
                Category=productDto.Category,
                Unit=productDto.Unit,
                UnitPrice=productDto.UnitPrice
            });
            return new SuccessResult(Messages.AddProduct);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.DeleteProduct);
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(x => x.Id == id));
        }

        [CacheAspect]
        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
        }

       

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.UpdateProduct);
        }

        

        public IDataResult<ProductListDto> GetAllByDto()
        {
            var products = _productDal.GetList();
            if (products.Count > -1)
            {
                return new SuccessDataResult<ProductListDto>(new ProductListDto
                {
                    Products = products
                });
            }
            return new ErrorDataResult<ProductListDto>(Messages.ErrorProduct);
        }
    }
}
