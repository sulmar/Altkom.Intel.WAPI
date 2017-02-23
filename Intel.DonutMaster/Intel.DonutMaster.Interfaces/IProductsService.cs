using Intel.DonutMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intel.DonutMaster.Interfaces
{
    public interface IProductsService
    {
        IList<Product> Get();

        Product Get(int id);

        Product Get(string symbol);

        void Add(Product product);

        void Update(Product product);

        void Remove(int id);
    }
}
