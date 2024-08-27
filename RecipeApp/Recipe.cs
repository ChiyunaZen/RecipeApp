using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    public class Recipe
    {
        public string RecipeName { get; set; }
        public string CookingTime { get; set; }

        public Recipe(string recipeName, string cookingTime)
        {
            RecipeName = recipeName;
            CookingTime = cookingTime;  
        }

    }
}
