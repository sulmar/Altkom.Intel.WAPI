using Intel.DonutMaster.Interfaces;
using Intel.DonutMaster.MockServices;
using Intel.DonutMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Intel.DonutMaster.Service.Controllers
{
    public class ProductsController : ApiController
    {

        private IProductsService _ProductsService = new MockProductsService();

        public IList<Product> Get()
        {
            return _ProductsService.Get();
        }

        public Product Get(int id)
        {
            return _ProductsService.Get(id);
        }


        public void Post(Product product)
        {
            _ProductsService.Add(product);
        }

        public void Put(Product product)
        {
            _ProductsService.Update(product);
        }

        public void Delete(int id)
        {
            _ProductsService.Remove(id);
        }

        public void Head()
        {
            throw new NotImplementedException();
        }
    }
}