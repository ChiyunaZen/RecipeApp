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

        public Form1()
        {
            InitializeComponent();

            //仮でリスト登録してるだけです↓
            var recipes = new List<Recipe>();
            recipes.Add(new Recipe("たこやき", 30));
            recipes.Add(new Recipe("オムライス", 30));

            InitializeListView();

        }


        private void InitializeListView() //リストボックスにリストの中身を表示するメソッド
        {
           
            recipes = new List<Recipe>();
            
            foreach (var recipe in recipes)
            {
                string name = recipe.RecipeName;
                int time = recipe.CookingTime;
                RecipeView.Columns.Add(name, time);
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RecipeView recipeView = new RecipeView();
            recipeView.Show();
        }

    }

    public class DateManagement
    {
        public void SaveDate()
        {
           
            var recipes  = new List<Recipe>();
            
                var json = JsonConvert.SerializeObject(recipes, Newtonsoft.Json.Formatting.Indented);
            


            //JSON文字列（json変数の値）をファイルに書き込む
            File.WriteAllText(@"..\..\レシピリスト.json", json);

        }
    }
}
