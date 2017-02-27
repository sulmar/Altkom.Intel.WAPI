using Intel.DonutMaster.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intel.DonutMaster.Models;
using System.Net.Http;

namespace Intel.DonutMaster.RestApiServices
{
    public class RestApiProductsService : IProductsService
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Product item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> Get()
        {
            throw new NotImplementedException();
        }

        public Product Get(string symbol)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Product>> GetAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52765");
                client.DefaultRequestHeaders.Add("Secret-Key", "12345");

                var response = await client.GetAsync("api/Products");

                var products = await response.Content.ReadAsAsync<IList<Product>>();

                return products;
            }
        }

        public Task<Product> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Recipe GetByProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public IList<RecipeStep> GetRecipeSteps(int productId)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
