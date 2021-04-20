using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal: Core.DataAccess.IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();

    }
}


//Code Refactoring : Kodun iyileştirilmesi