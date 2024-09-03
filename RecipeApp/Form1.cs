using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RecipeApp
{
    public partial class Form1 : Form
    {
        public List<Recipe> recipes;
        DataManagement dateManagement = new DataManagement();


        public Form1()
        {
            InitializeComponent();

            recipes = dateManagement.LoadData();


            userControl_RecipeListView.InitializeListView(recipes);


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
            recipes = dateManagement.LoadData();
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
            var dateList = dateManagement.LoadData();
            var viewList = userControl_RecipeListView.GetListViewList();

            if (dateList.Count > viewList.Count)
            {
                userControl_RecipeListView.InitializeListView(recipes);
                serchTextBox.Clear();
            }
        }

        private void recipeEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            RecipeEditWindow recipeEditWindow = new RecipeEditWindow(this);
            recipeEditWindow.UpdateListViews(recipes);
            recipeEditWindow.Show();
        }
    }


}
