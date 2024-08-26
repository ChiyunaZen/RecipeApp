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
    public partial class Form1 : Form
    {
        List<Recipe> recipes;

        public Form1()
        {
            InitializeComponent();
            //InitializeListBox();
        }

        //private void InitializeListBox() //リストボックスにリストの中身を表示するメソッド
        //{
        //    recipes = new List<Recipe>();
        //    {

        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            RecipeView recipeView = new RecipeView();
            recipeView.Show();
        }


    }
}
