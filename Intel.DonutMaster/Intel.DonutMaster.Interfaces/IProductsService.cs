using Intel.DonutMaster.Interfaces;
using Intel.DonutMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intel.DonutMaster.Interfaces
{
    public interface IProductsService : IBaseService<Product, int>
    {
        Product Get(string symbol);

        Recipe GetByProduct(int productId);

        IList<RecipeStep> GetRecipeSteps(int productId);

    }
}
