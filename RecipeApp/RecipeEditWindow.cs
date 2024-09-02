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
using Newtonsoft.Json.Linq;

namespace RecipeApp
{
    public partial class RecipeEditWindow : Form
    {
        Form1 mainform;
        public string filePath;　//読み込んだファイルのパスを一時的に保存する変数
        PicturePreviewWindow picturePreviewWindow;

        public RecipeEditWindow(Form1 form)
        {
            InitializeComponent();
            mainform = form;
            cookingTimeComboBox.SelectedIndex = 0;

        }

        public void UpdateRecipeDetails(Recipe recipe)
        {
            //選択したレシピの内容を表示させるメソッド

            if (recipe == null) return;

            string allIngredient = string.Join("，", recipe.Ingredient);

            recipeNameTextBox.Text = recipe.RecipeName;
            cookingTimeComboBox.Text = recipe.CookingTime.ToString();
            ingredienTextBox.Text = allIngredient;
            levelTrackBar.Value = recipe.Level;
            int value = levelTrackBar.Value;
            string fullStar = new string('★', value);
            string emptyStar = new string('☆', 5 - value);

            levelStarLabel.Text = fullStar + emptyStar;

            levelStarLabel.Text = fullStar + emptyStar;
            recipeSentenceTextBox.Text = recipe.RecipeSentence;
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
            if (recipeNameTextBox.Text == "")
            {
                MessageBox.Show("料理名を入力してください");
                return;
            }
            if (cookingTimeComboBox == null)
            {
                MessageBox.Show("調理時間を設定してください");
                return;
            }
            if (ingredienTextBox.Text == "")
            {
                MessageBox.Show("食材を入力してください");
                return;
            }
            if (recipeSentenceTextBox.Text == "")
            {
                MessageBox.Show("手順を入力してください");
                return;
            }

            string recipeName = recipeNameTextBox.Text;
            int cookingTime = int.Parse(cookingTimeComboBox.Text);

            string ingredientText = ingredienTextBox.Text;
            string[] ingredient = Regex.Split(ingredientText, @"[\s\r\n、，,]+");

            int level = levelTrackBar.Value;

            string recipeSentence = recipeSentenceTextBox.Text;

            // 画像のパス設定
            string recipeImagePath = @"Image\no_image.png";  // デフォルトの画像パス

            if (picturePreviewWindow != null)
            {
                // picturePreviewWindowがnullでない場合に上書きする
                recipeImagePath = picturePreviewWindow.copiedFilePath ?? recipeImagePath;
                picturePreviewWindow.ClearPreviewWindow();

            }


            Recipe newRecipe = new Recipe(recipeName, cookingTime, ingredient, level, recipeSentence, recipeImagePath);
            //取得した内容でレシピオブジェクトを新規作成

            mainform.recipes.Add(newRecipe);
            //Form1で作成したレシピリストに追加

            DataManagement dateManagement = new DataManagement();
            dateManagement.SaveData(mainform.recipes);　//セーブ

            mainform.userControl_RecipeListView.UpdateListView(mainform.recipes); //Form1のリストを更新
            this.userControl_RecipeListView1.UpdateListView(mainform.recipes);　//このウィンドウのリストを更新
            ClearInputFields();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // メッセージボックスを表示
            DialogResult result = MessageBox.Show(
                "選択中のレシピデータを削除してもよろしいですか？",  // メッセージ
                "確認",           // タイトル
                MessageBoxButtons.YesNo, // ボタンオプション
                MessageBoxIcon.Question // アイコンオプション
            );


            // ユーザーの選択に応じた処理
            if (result == DialogResult.Yes)
            {
               var removeRecipe =this.userControl_RecipeListView1.GetSelectedRecipe();

                DataManagement dateManagement = new DataManagement();

                if (removeRecipe != null && mainform.recipes.Contains(removeRecipe))
                {
                    mainform.recipes.Remove(removeRecipe);
                    dateManagement.SaveData(mainform.recipes);
                    mainform.userControl_RecipeListView.UpdateListView(mainform.recipes); //Form1のリストを更新
                    this.userControl_RecipeListView1.UpdateListView(mainform.recipes); //このウィンドウのリストを更新

                    ClearInputFields();
                }
            }

            else if (result == DialogResult.No)
            {
                // 「いいえ」が選択された場合は処理をスルーする
                return;
            }
        }

        private void ClearInputFields()
        {
            recipeNameTextBox.Text = "";
            cookingTimeComboBox.Text = "5";
            ingredienTextBox.Text = "";
            levelTrackBar.Value = 1;
            levelStarLabel.Text = "★☆☆☆☆";
            recipeSentenceTextBox.Text = "";
            if (picturePreviewWindow != null)
            {
                picturePreviewWindow.ClearPreviewWindow();

            }

        }
    }

}

