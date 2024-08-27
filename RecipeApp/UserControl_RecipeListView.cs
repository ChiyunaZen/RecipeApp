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
    }
}
