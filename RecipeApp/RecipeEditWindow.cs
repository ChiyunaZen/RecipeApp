using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace RecipeApp
{
    public partial class RecipeEditWindow : Form
    {
        public string filePath;　//読み込んだファイルのパスを一時的に保存する変数
        PicturePreviewWindow picturePreviewWindow;

        UserControl_RecipeListView userControl_RecipeListView;

        public RecipeEditWindow(UserControl_RecipeListView userControl_RecipeListView)
        {
            InitializeComponent();
            this.userControl_RecipeListView = userControl_RecipeListView; ;
        }



        private void loadImageButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            //選択させるファイルのフィルタリング設定
            openFileDialog.Title = "PNGファイルを選択";
            //フォルダ表示ダイアログの表示タイトル

            if (PicturePreviewWindow.Instance == null)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                //ダイアログを表示し、ファイルを選択した場合の処理
                {
                    filePath = openFileDialog.FileName;
                    //選択されたファイルのパスを取得

                    picturePreviewWindow = new PicturePreviewWindow(filePath);
                    picturePreviewWindow.Show();
                }
            }
            else
            {
                picturePreviewWindow.Show();
            }

        }
        private void levelTrackBar_Scroll(object sender, EventArgs e)
        {
            int value = levelTrackBar.Value;
            string fullStar = new string('★', value);
            string emptyStar = new string('☆', 5 - value);

            levelStarLabel.Text = fullStar + emptyStar;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string recipeName = recipeNameTextBox.Text;
            int cookingTime = int.Parse(cookingTimeComboBox.Text);

            string ingredientText = ingredienTextBox.Text;
            string[] ingredient = Regex.Split(ingredientText, @"[\s\r\n、，,]+");

            int level = levelTrackBar.Value;
            
            string recipeSentence = recipeSentenceTextBox.Text;

            string recipeImagePath = "";

            MessageBox.Show($"{recipeName}\n{cookingTime}分\n{level}");

            Recipe recipe = new Recipe(recipeName,cookingTime,ingredient,level,recipeSentence,recipeImagePath);

            DateManagement dateManagement = new DateManagement(userControl_RecipeListView);
            dateManagement.AddRecipeList(recipe);



           // picturePreviewWindow.ClearPreviewWindow();
        }
    }
}
