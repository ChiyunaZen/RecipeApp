using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RecipeApp
{
    public partial class Form1 : Form
    {
        List<Recipe> recipes;
        DateManagement dateManagement = new DateManagement();


        public Form1()
        {
            InitializeComponent();

            recipes = new List<Recipe>();


            //string[] hanbulg = new string[] { "ひき肉", "玉ねぎ", "パン粉", "卵", "香辛料", "サラダ油"};
            //recipes.Add(new Recipe("ハンバーグ", 40, hanbulg, 3, "こねる", @"image\\hamburg.png"));
            //string[] takoyaki = new string[] { "タコ", "ネギ", "小麦粉", "卵", "紅ショウガ", "揚げ玉" };
            //recipes.Add(new Recipe("たこ焼き", 20, takoyaki, 2, "焼く",@"image\\takoyaki.png"));
            //string[] omurice = new string[] { "ごはん", "玉ねぎ", "ケチャップ", "卵", "鶏肉" };
            //recipes.Add(new Recipe("オムライス", 30, omurice, 3, "包む",@"image\\omurice.png"));
            //string[] karaage = new string[] { "ひき肉", "玉ねぎ", "パン粉", "卵", "香辛料", "サラダ油" };
            //recipes.Add(new Recipe("唐揚げ", 15, karaage, 2, "揚げる", @"image\\karaage.png"));

            //dateManagement.SaveDate(recipes);

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Recipe recipe = userControl_RecipeListView.GetSelectedRecipe();

            if (recipe != null)
            {
                RecipeWindow recipeView = new RecipeWindow(recipe);
                recipeView.Init(this);
                recipeView.Show();
            }
            else
            {
                MessageBox.Show("レシピが選択されていません");
                return;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            recipes = dateManagement.RoadDate();
            string searchText = serchTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                List<Recipe> searchResult = recipes.FindAll(recipe =>
                recipe.Ingredient.Any(ingredient =>
                    ingredient.Contains(searchText)));


                if (searchResult.Count > 0)
                {
                    userControl_RecipeListView.UpdateListView(searchResult);
                }
                else
                {
                    MessageBox.Show("一致するレシピはありません");
                    serchTextBox.Clear();
                }

            }
            else
            {
                MessageBox.Show("検索したい食材名を入力してください");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dateList = dateManagement.RoadDate();
            var viewList = userControl_RecipeListView.GetListViewList();

            if (dateList.Count > viewList.Count)
            {
                userControl_RecipeListView.InitializeListView();
                serchTextBox.Clear();
            }
        }

        private void recipeEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            RecipeEditWindow recipeEditWindow = new RecipeEditWindow();
            recipeEditWindow.Show();
        }
    }


}
