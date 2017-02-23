using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intel.DonutMaster.Models
{
    public class RecipeStep : Base
    {
        public int RecipeStepId { get; set; }

        public string Description { get; set; }

        public IList<Ingredient> Ingredients { get; set; }

    }
}
