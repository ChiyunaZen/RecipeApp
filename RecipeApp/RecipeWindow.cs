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
        public RecipeWindow(Recipe recipe)
        {
            InitializeComponent();

            recipeNameLabel.Text =recipe.RecipeName;
        }
    }
}
