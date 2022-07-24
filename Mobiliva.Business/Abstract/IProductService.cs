using Mobiliva.Core.Utilities.Results;
using Mobiliva.Entities.Concrete;
using Mobiliva.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliva.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetList();
        IDataResult<Product> GetById(int id);
        IResult Add(ProductDto productDto);
        IResult Delete(Product product);
        IResult Update(Product product);
        IDataResult<ProductListDto> GetAllByDto();
    }
}
