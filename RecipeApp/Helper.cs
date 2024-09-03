﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RecipeApp
{
    public static class RecipeHelper
    //レシピ表示で共通している処理をまとめたクラ
    //静的クラスなのでインスタンスを生成せずにメソッドを複数クラスで扱えるようになる
    {

        public static string GenerateStarRating(int level)
        {
            //難易度により星の色分けをする処理
            // new string(文字,繰り返し回数)の文字列を生成できる
            string fullStar = new string('★', level);
            string emptyStar = new string('☆', 5 - level);
            return fullStar + emptyStar;
        }
    }

    public static class FileHelper
    {
        private static void DeleteImage(string imagePath)
        {
            

            try
            {
                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"画像の削除に失敗しました: {ex.Message}");
            }
        }
    }
}
