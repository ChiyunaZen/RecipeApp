using RecipeApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeApp
{
    public partial class UserControl_RecipeListView : UserControl
    {
        List<Recipe> recipes;
        DateManagement dateManagement = new DateManagement();

        public UserControl_RecipeListView()
        {
            InitializeComponent();
            InitializeListView();
        }
        private void InitializeListView()
        //リストボックスにリストの中身を表示するメソッド
        {
            recipes = dateManagement.RoadDate();

            foreach (var recipe in recipes)
            {
                var listViewItem = new ListViewItem(recipe.RecipeName);
                listViewItem.SubItems.Add(recipe.CookingTime + "分");

                recipeView.Items.Add(listViewItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recipes = dateManagement.RoadDate();
            recipeView.Items.Clear();


            if (button1.Text == "▼調理時間")
            {
                var descendingRecipe = recipes.OrderByDescending(x => x.CookingTime);

                foreach (var recipe in descendingRecipe)
                {
                    var listViewItem = new ListViewItem(recipe.RecipeName);
                    listViewItem.SubItems.Add(recipe.CookingTime + "分");
                    recipeView.Items.Add(listViewItem);
                }
                button1.Text = "▲調理時間";

            }

            else if (button1.Text == "▲調理時間")
            {
                var ascendingRecipe = recipes.OrderBy(x => x.CookingTime);

                foreach (var recipe in ascendingRecipe)
                {
                    var listViewItem = new ListViewItem(recipe.RecipeName);
                    listViewItem.SubItems.Add(recipe.CookingTime + "分");
                    recipeView.Items.Add(listViewItem);
                }
                button1.Text = "▼調理時間";
            }
        }
    }
}
