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
        public string[] Ingredient {  get; set; }
        public string RecipeSentence {  get; set; }

        public Recipe(string recipeName, string cookingTime, string[] ingredient,string recipeSentence)
        {
            RecipeName = recipeName;
            CookingTime = cookingTime;  
            Ingredient = ingredient;
            RecipeSentence = recipeSentence;
        }

    }
}
