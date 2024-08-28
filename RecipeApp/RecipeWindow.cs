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

            recipeNameLabel.Text = recipe.RecipeName;
            IngredientCheckList_Show(recipe);
            MenuPictureBox.Image = recipeImage;

        }

        

        private void ingredientCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // チェックが変更される前に選択状態を解除する
            // チェックが追加される場合に、選択状態を解除
            if (e.NewValue == CheckState.Checked||e.NewValue==CheckState.Unchecked)
            {
                for (int i = 0; i < ingredientCheckedListBox.Items.Count; i++)
                {
                    ingredientCheckedListBox.SetSelected(i, false);
                }
            }
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


        public void Init(Form1 form1)
        {
            this.form1 = form1;
        }


    }
}


