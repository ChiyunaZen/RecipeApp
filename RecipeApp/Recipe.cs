using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RecipeApp
{
    public class Recipe
    {
        public string RecipeName { get; set; }
        public int CookingTime { get; set; }
        public string[] Ingredient { get; set; }
        public int Level { get; set; }
        public string RecipeSentence { get; set; }
        public string RecipeImagePath { get; set; }

        public Recipe(string recipeName, int cookingTime, string[] ingredient, 
                        int level, string recipeSentence, string recipeImagePath)
        {
            RecipeName = recipeName;
            CookingTime = cookingTime;
            Ingredient = ingredient;
            Level = level;
            RecipeSentence = recipeSentence;
            RecipeImagePath = recipeImagePath;
        }

        public Image GetRecipeImage()
        //Imageパス文字列からImageオブジェクトに変更するメソッド
        {
            try
            {
                return Image.FromFile(RecipeImagePath);
            }
            catch
            {
                return Image.FromFile(@"image\no_image.png");
            }
        }
    }
}
