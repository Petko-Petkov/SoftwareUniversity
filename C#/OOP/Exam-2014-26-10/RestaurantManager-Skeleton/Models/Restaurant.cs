namespace RestaurantManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Restaurant : IRestaurant
    {
        #region Fields

        private string name;

        private string location;

        #endregion

        #region Constructors

        public Restaurant(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            this.Recipes = new List<IRecipe>();

        }
        #endregion

        #region Properties

        public string Name
        {
            get 
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty", this.Name);
                }

                this.name = value;
            }
        }

        public string Location
        {
            get { return this.location; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Location cannot be null or empty", this.Location);
                }

                this.location = value;
            }
        }

        public IList<IRecipe> Recipes { get; private set; }

        #endregion

        #region Methods

        public void AddRecipe(IRecipe recipe)
        {
            this.Recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            this.Recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            StringBuilder menu = new StringBuilder();
            menu.AppendLine(string.Format("***** {0} - {1} *****", this.Name, this.Location));

            if (this.Recipes.Count > 0)
            {
                foreach (var recipe in this.Recipes)
                {
                    Console.WriteLine(recipe);
                }

                var drinks = this.Recipes.Where(r => r.GetType().Name == "Drink").OrderBy(r => r.Name);

                if (drinks.Count() > 0)
                {
                    Console.WriteLine("~~~~~ DRINKS ~~~~~");
                    foreach (var drink in drinks)
                    {
                        Console.WriteLine(drink);
                    }
                }

                var salads = this.Recipes.Where(r => r.GetType().Name == "Salad").OrderBy(r => r.Name);

                if (salads.Count() > 0)
                {
                    Console.WriteLine("~~~~~ SALADS ~~~~~");
                    foreach (var salad in salads)
                    {
                        Console.WriteLine(salad);
                    }
                }

                var main = this.Recipes.Where(r => r.GetType().Name == "MainCourse").OrderBy(r => r.Name);

                if (main.Count() > 0)
                {
                    Console.WriteLine("~~~~~ MAIN COURSES ~~~~~");

                    foreach (var m in main)
                    {
                        Console.WriteLine(m);
                    }
                }

                var desserts = this.Recipes.Where(r => r.GetType().Name == "Dessert").OrderBy(r => r.Name);

                if (desserts.Count() > 0)
                {
                    Console.WriteLine("~~~~~ DESSERTS ~~~~~");

                    foreach (var dessert in desserts)
                    {
                        Console.WriteLine(dessert);
                    }
                }
            }
            else
            {
                menu.AppendLine("No recipes... yet");
            }

            return menu.ToString();
        }

        public override string ToString()
        {
            return this.PrintMenu();
        }

        #endregion
    }
}
