using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intel.DonutMaster.Models
{
    public class Recipe : Base
    {
        public int RecipeId { get; set; }

        public string Name { get; set; }

        public IList<RecipeStep> RecipeSteps { get; set; }
    }
}
