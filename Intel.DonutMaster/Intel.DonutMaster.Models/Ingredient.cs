using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intel.DonutMaster.Models
{
    public class Ingredient : Base
    {
        public int IngredientId { get; set; }

        public string Name { get; set; }

        public float Quantity { get; set; }

        public Unit Unit { get; set; }
    }
}
