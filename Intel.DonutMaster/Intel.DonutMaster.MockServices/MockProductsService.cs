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

        private IList<Product> _Products = new List<Product>
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
                ProductId = 1,
                Name = "Faworki",
                Calories = 300,
                IsGlutenFree = false,
                Recipe = new Recipe
                {
                    RecipeId = 1,
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

        public IList<Product> Get()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
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
    }
}
