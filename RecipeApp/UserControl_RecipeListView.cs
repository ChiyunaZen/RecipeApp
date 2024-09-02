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
        public List<Recipe> recipes;
        DataManagement dateManagement = new DataManagement();
        private Form1 form1;
        List<ListViewItem> listViewItems;

        public UserControl_RecipeListView()
        {
            InitializeComponent();
            InitializeListView();
        }


        public void InitializeListView()
        //リストビューにリストの中身を表示するメソッド(リストビューの初期化)
        {
            //recipes = new List<Recipe>();
            recipes = dateManagement.LoadData();

            UpdateListView(recipes);
        }

        public List<ListViewItem> GetListViewList()
        {
            listViewItems = new List<ListViewItem>();
            foreach (ListViewItem item in recipeView.Items)
            {
                listViewItems.Add(item);
            }
            return listViewItems;
        }
        public void SetDateManagement(DateManagement dateManagement)
        {
            this.dateManagement = dateManagement;
            recipes = dateManagement.RoadDate(); // データの読み込み
            UpdateListView(recipes);
        }
        public void UpdateListView(List<Recipe> recipes)
        {
            if (recipeView.Items.Count > 0)
            {
                recipeView.Items.Clear();
            }

            foreach (var recipe in recipes)
            {
                var listViewItem = new ListViewItem(recipe.RecipeName);
                listViewItem.SubItems.Add(recipe.CookingTime + "分");
                listViewItem.SubItems.Add("★" + recipe.Level.ToString());

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
                menuTimeLabel.Text = $"調理時間：{recipes[select].CookingTime}分";
                menuLevelLabel.Text = "難易度：" + UpdateLebelStar(recipes[select].Level);
                menuImageBox.Image = recipeImage;
            }
        }

        private string UpdateLebelStar(int level)
        {
            //難易度により星の色分けをする処理
            // new string(文字,繰り返し回数)の文字列を生成できる
            string fullStar = new string('★', level);
            string emptyStar = new string('☆', 5 - level);

            return fullStar + emptyStar;
        }

        private void button1_Click(object sender, EventArgs e)
        //ボタンで調理時間のソートをするメソッド
        {
            bool descending = timeSortButton.Text == "▼調理時間";
            SortRecipes(r => r.CookingTime, descending);
            timeSortButton.Text = descending ? "▲調理時間" : "▼調理時間";
            //descendingがtrueかfalseかで処理を分ける三項演算子
        }



        private void lebelSortButton_Click(object sender, EventArgs e)
        //ボタンで難易度のソートをするメソッド
        {
            bool descending = timeSortButton.Text == "▼難易度";
            SortRecipes(r => r.Level, descending);
            timeSortButton.Text = descending ? "▲難易度" : "▼難易度";
            //descendingがtrueかfalseかで処理を分ける三項演算子
        }

        private void SortRecipes(Func<Recipe, int> sortKey, bool descending)
        //リストビューのソート用の共通メソッド
        //引数「Func<Recipe, int> 」はRecipe型のから特定のint型の数値を取り出す(cookingTimeかLevelを指定)
        //bool descending は、trueなら降順、falseなら昇順にソートの並び順を決める　
        {
            recipes = dateManagement.LoadData();
            recipeView.Items.Clear();

            var sortedRecipes = descending
                    ? recipes.OrderByDescending(sortKey)
                    : recipes.OrderBy(sortKey);
            //三項演算子　descendingの値がTrueの場合に前項、falseの場合に後項の処理を行う
            //sortRecipeに引数sortKeyでわたされた基準で並び替えたリストを設定する

            foreach (var recipe in sortedRecipes)
            {
                var listViewItem = new ListViewItem(recipe.RecipeName);
                listViewItem.SubItems.Add($"{recipe.CookingTime} 分");
                listViewItem.SubItems.Add($"★{recipe.Level}");
                recipeView.Items.Add(listViewItem);
            }
        }

        //public void Init(Form1 form1)
        //{
        //    this.form1 = form1;
        //}

        public Recipe GetSelectedRecipe()
        {
            if (recipeView.SelectedItems.Count > 0)
            {
                var selectedRecipe = recipeView.SelectedItems[0];
                int index = selectedRecipe.Index;
                return recipes[index];
            }
            return null;

        }
    }
}
