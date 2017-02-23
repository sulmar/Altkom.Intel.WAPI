using Intel.DonutMaster.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intel.DonutMaster.Models;

namespace Intel.DonutMaster.MockServices
{
    public class MockProductsService : IProductsService
    {

        private static IList<Product> _Products = new List<Product>
        {
            new Product
            {
                ProductId = 1,
                Name = "Pączek",
                Calories = 300,
                IsGlutenFree = false,
                Recipe = new Recipe
                {
                    RecipeId = 1,
                    Name = "Przepis na początek",
                    RecipeSteps = new List<RecipeStep>
                    {
                        new RecipeStep
                        {
                            RecipeStepId = 1,
                            Description = "Krok 1",
                            Ingredients = new List<Ingredient>
                            {
                                new Ingredient
                                {
                                    IngredientId = 1,
                                    Name = "Mąka",
                                    Quantity = 200,
                                    Unit = Unit.Grams,
                                }
                            }
                        },

                          new RecipeStep
                        {
                            RecipeStepId = 2,
                            Description = "Krok 2",
                            Ingredients = new List<Ingredient>
                            {
                                new Ingredient
                                {
                                    IngredientId = 1,
                                    Name = "Woda",
                                    Quantity = 10,
                                    Unit = Unit.Tablespoons,
                                }
                            }
                        },

                    } 
                }
            },

            new Product
            {
                ProductId = 2,
                Name = "Faworki",
                Calories = 300,
                IsGlutenFree = false,
                Recipe = new Recipe
                {
                    RecipeId = 2,
                    Name = "Przepis na pączek 2",
                    RecipeSteps = new List<RecipeStep>
                    {
                        new RecipeStep
                        {
                            RecipeStepId = 1,
                            Description = "Krok 1",
                            Ingredients = new List<Ingredient>
                            {
                                new Ingredient
                                {
                                    IngredientId = 1,
                                    Name = "Mąka",
                                    Quantity = 300,
                                    Unit = Unit.Grams,
                                }
                            }
                        },

                          new RecipeStep
                        {
                            RecipeStepId = 2,
                            Description = "Krok 2",
                            Ingredients = new List<Ingredient>
                            {
                                new Ingredient
                                {
                                    IngredientId = 1,
                                    Name = "Woda",
                                    Quantity = 20,
                                    Unit = Unit.Tablespoons,
                                }
                            }
                        },

                    }
                }
            },


        };

        public void Add(Product product)
        {

            var productId = _Products.Max(p => p.ProductId);

            product.ProductId = ++productId;

            _Products.Add(product);
        }

        public IList<Product> Get()
        {
            return _Products;
        }

        public Product Get(int id)
        {
            var product = _Products.SingleOrDefault(p => p.ProductId == id);

            return product;
        }

        public void Remove(int id)
        {
            var product = Get(id);

            _Products.Remove(product);
        }

        public void Update(Product product)
        {
            Remove(product.ProductId);

            Add(product);

        }
    }
}
