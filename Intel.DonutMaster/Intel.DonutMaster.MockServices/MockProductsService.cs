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
                Symbol = "P001",
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
                Symbol = "F099",
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
            var products = _Products.Select(p => new Product
            {
                Name = p.Name,
                Symbol = p.Symbol,
                Calories = p.Calories,
                IsGlutenFree = p.IsGlutenFree,
                ProductId = p.ProductId
            }).ToList();

            return products;
        }

        public Product Get(string symbol) => _Products.SingleOrDefault(p => p.Symbol == symbol);

        public Product Get(int id)
        {
            var products = Get();

            var product = products.SingleOrDefault(p => p.ProductId == id);

            return product;
        }

        public Task<IList<Product>> GetAsync()
        {
            return Task.Run(() => Get());
        }

        public Task<Product> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Recipe GetByProduct(int productId)
        {
            var recipe = _Products
                    .SingleOrDefault(p => p.ProductId == productId)
                    ?.Recipe;

            var result = new Recipe { RecipeId = recipe.RecipeId, Name = recipe.Name };

            return result;
        }

        public IList<RecipeStep> GetRecipeSteps(int productId)
        {
            var recipeSteps = _Products
                    .SingleOrDefault(p => p.ProductId == productId)
                    ?.Recipe.RecipeSteps;

            return recipeSteps;
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

        public Task UpdateAsync(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
