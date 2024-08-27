using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            UserControl_RecipeListView userControl_RecipeListView = new UserControl_RecipeListView();
            //InitializeListView();

            //dateManagement.SaveDate(recipes);

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
