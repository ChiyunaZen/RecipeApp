using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RecipeApp
{
    public partial class Form1 : Form
    {
        List<Recipe> recipes;
        
       // UserControl_RecipeListView userControl_RecipeListView;
        DateManagement dateManagement = new DateManagement();

        public Form1()
        {
            InitializeComponent();
            //userControl_RecipeListView = new UserControl_RecipeListView();
            //userControl_RecipeListView.Init(this);

           // userControl_RecipeListView.InitializeListView();

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

    }


}
