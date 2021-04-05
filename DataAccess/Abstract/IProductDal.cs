using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal: Core.DataAccess.IEntityRepository<Product>
    {
       

    }
}


//Code Refactoring : Kodun iyileştirilmesi