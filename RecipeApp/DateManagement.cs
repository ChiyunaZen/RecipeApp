using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RecipeApp
{
    public class DateManagement
    {
        List<Recipe> recipes = new List<Recipe>();
        UserControl_RecipeListView userControl_RecipeListView;

        public DateManagement(UserControl_RecipeListView recipeListView)
        {
            this.userControl_RecipeListView = recipeListView;
        }

        public void SaveDate(List<Recipe> recipes)
        {
            var json = JsonConvert.SerializeObject(recipes, Newtonsoft.Json.Formatting.Indented);

            //JSON文字列（json変数の値）をファイルに書き込む
            File.WriteAllText(@"..\..\レシピリスト.json", json);

        }

        public List<Recipe> RoadDate()
        {
            if (File.Exists(@"..\..\レシピリスト.json"))
            {
                try
                {
                    //jsonファイル内のデータを読み込んで文字列型としてjson変数に代入
                    var json = File.ReadAllText(@"..\..\レシピリスト.json");

                    //読み取ったJSON文字列をRecipe型のリストrecipeにデシリアライズ
                    recipes = JsonConvert.DeserializeObject<List<Recipe>>(json);
                }

                catch
                {
                    MessageBox.Show("データの読み込みでエラーが発生しました。");
                    recipes = new List<Recipe>();
                }
            }
            else
            {
                recipes = new List<Recipe>();
            }

            return recipes;
        }

        public void AddRecipeList(Recipe recipe)
        {
            RoadDate();
            recipes.Add(recipe);
            SaveDate(recipes);
            userControl_RecipeListView.UpdateListView(recipes);
        }

       
    }
}
