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
        public int CookingTime { get; set; }
        public string[] Ingredient {  get; set; }
        public int Level { get; set; }
        public string RecipeSentence {  get; set; }

        public Recipe(string recipeName, int cookingTime, string[] ingredient,int level, string recipeSentence)
        {
            RecipeName = recipeName;
            CookingTime = cookingTime;  
            Ingredient = ingredient;
            Level = level;
            RecipeSentence = recipeSentence;
        }

    }
}
