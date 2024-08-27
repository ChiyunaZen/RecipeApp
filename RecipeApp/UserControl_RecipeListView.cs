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
            //recipes = new List<Recipe>();
            recipes = dateManagement.RoadDate();

            foreach (var recipe in recipes)
            {
                var listViewItem = new ListViewItem(recipe.RecipeName);
                listViewItem.SubItems.Add(recipe.CookingTime + "分");
                listViewItem.SubItems.Add("★"+recipe.Level.ToString());

                recipeView.Items.Add(listViewItem);
            }
        }

        private void recipeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recipeView.SelectedItems.Count > 0)
            {
                int select = recipeView.SelectedItems[0].Index;
                Image recipeImage = recipes[select].GetRecipeImage();

                menuNameLabel.Text = $"◇{recipes[select].RecipeName}";
                menuTimeLabel.Text=$"調理時間：{recipes[select].CookingTime}分";
                menuLevelLabel.Text = "難易度："+UpdateLebelStar(recipes[select].Level);
                menuImageBox.Image = recipeImage;
            }
        }

        private string UpdateLebelStar(int level)
        {
            //難易度により星の色分けをする処理
            // new string(文字,繰り返し回数)の文字列を生成できる
            string fullStar =new string('★', level);
            string emptyStar = new string('☆', 5-level);
            
            return fullStar+emptyStar;
        }

        private void button1_Click(object sender, EventArgs e)
            //ボタンで調理時間のソートをするメソッド
        {
            recipes = dateManagement.RoadDate();
            recipeView.Items.Clear();

            if (timeSortButton.Text == "▼調理時間")
            {
                var descendingRecipe = recipes.OrderByDescending(x => x.CookingTime);

                foreach (var recipe in descendingRecipe)
                {
                    var listViewItem = new ListViewItem(recipe.RecipeName);
                    listViewItem.SubItems.Add(recipe.CookingTime + "分");
                    listViewItem.SubItems.Add("★" + recipe.Level.ToString());

                    recipeView.Items.Add(listViewItem);
                }
                timeSortButton.Text = "▲調理時間";

            }

            else if (timeSortButton.Text == "▲調理時間")
            {
                var ascendingRecipe = recipes.OrderBy(x => x.CookingTime);

                foreach (var recipe in ascendingRecipe)
                {
                    var listViewItem = new ListViewItem(recipe.RecipeName);
                    listViewItem.SubItems.Add(recipe.CookingTime + "分");
                    listViewItem.SubItems.Add("★" + recipe.Level.ToString());

                    recipeView.Items.Add(listViewItem);
                }
                timeSortButton.Text = "▼調理時間";
            }
        }

      

        private void lebelSortButton_Click(object sender, EventArgs e)
        //ボタンで難易度のソートをするメソッド
        {
            recipes = dateManagement.RoadDate();
            recipeView.Items.Clear();

            if (lebelSortButton.Text == "▼難易度")
            {
                var descendingRecipe = recipes.OrderByDescending(x => x.Level);

                foreach (var recipe in descendingRecipe)
                {
                    var listViewItem = new ListViewItem(recipe.RecipeName);
                    listViewItem.SubItems.Add(recipe.CookingTime + "分");
                    listViewItem.SubItems.Add("★" + recipe.Level.ToString());

                    recipeView.Items.Add(listViewItem);
                }
                lebelSortButton.Text = "▲難易度";

            }

            else if (lebelSortButton.Text == "▲難易度")
            {
                var ascendingRecipe = recipes.OrderBy(x => x.CookingTime);

                foreach (var recipe in ascendingRecipe)
                {
                    var listViewItem = new ListViewItem(recipe.RecipeName);
                    listViewItem.SubItems.Add(recipe.CookingTime + "分");
                    listViewItem.SubItems.Add("★" + recipe.Level.ToString());

                    recipeView.Items.Add(listViewItem);
                }
                lebelSortButton.Text = "▼難易度";
            }
        }
        public Recipe GetSelectedRecipe()
        {
            if (recipeView.SelectedItems.Count > 0)
            {
                int select = recipeView.SelectedItems[0].Index;
                return recipes[select];
            }
            return null;
            
        }
    }
}
