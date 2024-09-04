using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RecipeApp
{
    public class DataManagement
    {
        List<Recipe> recipes;
        public void SaveData(List<Recipe> recipes)
        {
            var json = JsonConvert.SerializeObject(recipes, Newtonsoft.Json.Formatting.Indented);

            //JSON文字列（json変数の値）をファイルに書き込む
            File.WriteAllText("レシピリスト.json", json);

        }

        public List<Recipe> LoadData()
        {
            if (File.Exists("レシピリスト.json"))
            {
                try
                {
                    //jsonファイル内のデータを読み込んで文字列型としてjson変数に代入
                    var json = File.ReadAllText("レシピリスト.json");

                    //読み取ったJSON文字列をRecipe型のリストrecipeにデシリアライズ
                    recipes = JsonConvert.DeserializeObject<List<Recipe>>(json);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("ファイルの読み込みでエラーが発生しました。");
                }
                catch 
                {
                    MessageBox.Show("予期しないエラーが発生しました。");
                    recipes =new List<Recipe>();
                }
            }
            else
            {
                recipes= new List<Recipe>();
            }

            return recipes;
        }
    }


}
