using System;
using System.Collections.Generic;
using System.Drawing;
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
            UserControl_RecipeListView userControl_RecipeListView = new UserControl_RecipeListView();
            //InitializeListView();

            recipes = new List<Recipe>();

            
            string[] hanbulg = new string[] { "ひき肉", "玉ねぎ", "パン粉", "卵", "香辛料", "サラダ油"};
            recipes.Add(new Recipe("ハンバーグ", 40, hanbulg, 3, "こねる", "hamburg.png"));
            //string[] takoyaki = new string[] { "タコ", "ネギ", "小麦粉", "卵", "紅ショウガ", "揚げ玉" };
            //recipes.Add(new Recipe("たこ焼き", 20, takoyaki, 2, "焼く"));
            //string[] omurice = new string[] { "ごはん", "玉ねぎ", "ケチャップ", "卵", "鶏肉" };
            //recipes.Add(new Recipe("オムライス", 30, omurice, 3, "包む"));
            //string[] karaage = new string[] { "ひき肉", "玉ねぎ", "パン粉", "卵", "香辛料", "サラダ油" };
            //recipes.Add(new Recipe("唐揚げ", 15, karaage, 2, "揚げる"));

            dateManagement.SaveDate(recipes);

        }


        //private void InitializeListView() 
        //    //リストボックスにリストの中身を表示するメソッド
        //{
        //    recipes =  dateManagement.RoadDate();

        //    foreach (var recipe in recipes)
        //    {
        //        var listViewItem = new ListViewItem(recipe.RecipeName);
        //        listViewItem.SubItems.Add(recipe.CookingTime + "分");

        //        recipeView.Items.Add(listViewItem);
        //    }

        //}

        private void button3_Click(object sender, EventArgs e)
        {
            RecipeWindow recipeView = new RecipeWindow();
            recipeView.Show();
        }

    }


}
