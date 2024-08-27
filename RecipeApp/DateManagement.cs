using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace RecipeApp
{
    public class DateManagement
    {
        public void SaveDate(List<Recipe> recipes)
        {
            var json = JsonConvert.SerializeObject(recipes, Newtonsoft.Json.Formatting.Indented);

            //JSON文字列（json変数の値）をファイルに書き込む
            File.WriteAllText(@"..\..\レシピリスト.json", json);

        }

        public List<Recipe> RoadDate()
        {
            List<Recipe> recipes = new List<Recipe>();

            if (File.Exists(@"..\..\レシピリスト.json"))
            {
                //jsonファイル内のデータを読み込んで文字列型としてjson変数に代入
                var json = File.ReadAllText(@"..\..\レシピリスト.json");
                //読み取ったJSON文字列をRecipe型のリストrecipeにデシリアライズ
                recipes = JsonConvert.DeserializeObject<List<Recipe>>(json);
            }

            return recipes;
        }
    }


}
