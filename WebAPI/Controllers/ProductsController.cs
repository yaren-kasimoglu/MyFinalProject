using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]  //attribute bir class ile ilgili bilgi verme-imzalama yöntemi --- java da annotation
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        //Loosely coupled : gevşek bağlılık
        //IoC Container: Inversion of Control
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            //Dependency chain:  bağımlılık zinciri

           
            var result = _productService.GetAll();

           return result.Data;
        }
    }
}
