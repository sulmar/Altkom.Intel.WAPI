using Intel.DonutMaster.Interfaces;
using Intel.DonutMaster.MockServices;
using Intel.DonutMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Intel.DonutMaster.Service.Controllers
{
    public class ProductsController : BaseApiController<Product, IProductsService, int>
    {

        private IProductsService _ProductsService;

        public ProductsController()
            : base(new MockProductsService())
        { }



        [Route("api/products/{symbol}")]
        public IHttpActionResult Get(string symbol)
        {
            var product = _ProductsService.Get(symbol);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

     

        public void Head()
        {
            throw new NotImplementedException();
        }


        [Route("api/Products/{productId}/recipe")]
        public IHttpActionResult GetRecipeByProduct(int productId)
        {
            var recipe = _ProductsService.GetByProduct(productId);

            return Ok(recipe);
        }


        [Route("api/Products/{productId}/recipe/steps")]
        public IHttpActionResult GetRecipeSteps(int productId)
        {
            var steps = _ProductsService.GetRecipeSteps(productId);

            return Ok(steps);
        }
    }
}