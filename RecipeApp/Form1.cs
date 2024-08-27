using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RecipeApp
{
    public partial class Form1 : Form
    {
        List<Recipe> recipes;
        DateManagement dateManagement = new DateManagement();

        public Form1()
        {
            InitializeComponent();

            

            InitializeListView();

            dateManagement.SaveDate(recipes);

        }


        private void InitializeListView() //リストボックスにリストの中身を表示するメソッド
        {

            recipes =  dateManagement.RoadDate();


            ////仮でリスト登録してるだけです↓
            //string[] takoyaki = { "小麦粉", "たこ", "紅ショウガ", "ネギ" };
            //recipes.Add(new Recipe("たこやき", "30", takoyaki, "焼く"));
            //string[] omurice = { "ごはん", "卵" };
            //recipes.Add(new Recipe("オムライス", "30", omurice, "包む"));


            foreach (var recipe in recipes)
            {
                var listViewItem = new ListViewItem(recipe.RecipeName);
                listViewItem.SubItems.Add(recipe.CookingTime + "分");

                recipeView.Items.Add(listViewItem);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            RecipeWindow recipeView = new RecipeWindow();
            recipeView.Show();
        }

    }

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
