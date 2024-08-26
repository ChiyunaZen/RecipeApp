using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Recipe
    {
        public string RecipeName { get; set; }
        public int CookingTime { get; set; }

        public Recipe(string recipeName, int cookingTime)
        {
            RecipeName = recipeName;
            CookingTime = cookingTime;  
        }

    }
}
