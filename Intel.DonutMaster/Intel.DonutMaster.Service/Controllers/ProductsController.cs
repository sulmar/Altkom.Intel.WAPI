﻿using Intel.DonutMaster.Interfaces;
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
    public class ProductsController : ApiController
    {

        private IProductsService _ProductsService;

        public ProductsController()
            : this(new MockProductsService())
        { }

        public ProductsController(IProductsService productsService)
        {
            this._ProductsService = productsService;
        }


        public async Task<IHttpActionResult> Get()
        {
            var products = await _ProductsService.GetAsync();

            return Ok(products);
        }



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

        [Route("api/products/{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var product = _ProductsService.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

       
        public IHttpActionResult Post(Product product)
        {
            _ProductsService.Add(product);

            // return StatusCode(System.Net.HttpStatusCode.Created);

            return CreatedAtRoute("DefaultApi", new { id = product.ProductId}, product);

            // return Created($"http://localhost:52765/api/products/{product.ProductId}", product);
        }

        public IHttpActionResult Put(int id, Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest("Niezgodny identyfikator");
            }

            _ProductsService.Update(product);

            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        public IHttpActionResult Delete(int id)
        {

            if (id == 0)
            {
                return StatusCode(System.Net.HttpStatusCode.Conflict);

                //var response = new HttpResponseMessage
                //{
                //    StatusCode = System.Net.HttpStatusCode.Conflict
                //};

                //return response;
            }

            _ProductsService.Remove(id);

            return Ok();
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