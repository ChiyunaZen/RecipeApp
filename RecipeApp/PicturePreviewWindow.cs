using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace RecipeApp
{

    public partial class PicturePreviewWindow : Form
    {
        public static PicturePreviewWindow Instance { get; private set; }
        //フォームがnull(開かれていない)可を公開するプロパティ
        public string currentFilePath {  get; private set; }
        //表示している画像のファイルパス
        public string copiedFilePath {  get;set; }
        //コピーして保存された画像のファイルパス（リストに登録する方）

        public PicturePreviewWindow(string filePath)
        {
            InitializeComponent();
            Instance=this;
            currentFilePath=filePath;
            //最初に開いた場合の処理
            pictureBox1.Image = Image.FromFile(filePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string destinationFolder = @"image\";
                //画像保存先のフォルダのパス指定

                string destinationFilePath = Path.Combine(destinationFolder, Path.GetFileName(currentFilePath));
                //コピーする画像のパス（"image\ファイル名"になる）

                // imageフォルダが存在しない場合は作成
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                if (File.Exists(destinationFilePath))
                {
                    File.Delete(destinationFilePath);
                }
                
                File.Copy(currentFilePath, destinationFilePath);
                copiedFilePath = destinationFilePath;

                this.Hide();
                //ウィンドウを隠す（リストに保存されるまでは終了はしない）
            }
            catch 
            {
                MessageBox.Show("画像のコピーに失敗しました"); 
                ClearPreviewWindow();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) 
            {
                openFileDialog.Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                //選択させるファイルのフィルタリング設定
                openFileDialog.Title = "PNGファイルを選択";
                //フォルダ表示ダイアログの表示タイトル

                // ダイアログを表示してユーザーがファイルを選択した場合の処理
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 選択されたファイルのパスを取得
                        string newFilePath = openFileDialog.FileName;

                        // pictureBox1に新しい画像を設定
                        pictureBox1.Image = Image.FromFile(newFilePath);

                        // currentFilePathとcopiedFilePathを更新
                        currentFilePath = newFilePath;
                        copiedFilePath = null; // 画像が新しく選択されたので、以前のコピーは無効になる
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"画像の読み込みに失敗しました: {ex.Message}");
                    }
                }
            }
        }

        public void ClearPreviewWindow()
        {
            Instance = null;
            this.Close();
        }

        
    }
}
