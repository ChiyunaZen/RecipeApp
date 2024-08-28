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
    public partial class RecipeWindow : Form
    {
        Form1 form1;
        public RecipeWindow(Recipe recipe)
        {
            InitializeComponent();

            Image recipeImage = recipe.GetRecipeImage();

            this.Text = $"{recipe.RecipeName}のレシピ";
            MenuPictureBox.Image = recipeImage;
            recipeNameLabel.Text = "◇"+recipe.RecipeName;
            IngredientCheckList_Show(recipe);
            recipeSentenceTextBox.Text = recipe.RecipeSentence;

        }

      
        //チェックリストボックスに食材を表示するメソッド
        private void IngredientCheckList_Show(Recipe recipe)
        {
            string[] ingredients = recipe.Ingredient;

            foreach (string ingredient in ingredients)
            {
                ingredientCheckedListBox.Items.Add(ingredient);
            }
        }

        
        private void ingredientCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //チェック/解除するたびに選択状態をリセットする
            if (e.NewValue == CheckState.Checked || e.NewValue == CheckState.Unchecked)
            {
                for (int i = 0; i < ingredientCheckedListBox.Items.Count; i++)
                {
                    ingredientCheckedListBox.SetSelected(i, false);
                }
            }
        }

        public void Init(Form1 form1)
        {
            this.form1 = form1;
        }


    }
}


