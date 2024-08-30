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


namespace RecipeApp
{

    public partial class PicturePreviewWindow : Form
    {
        public static PicturePreviewWindow Instance { get; private set; }
        //フォームがnull(開かれていない)可を公開するプロパティ
        public string currentFilePath {  get; private set; }
        //表示している画像のファイルパス
        public string copiedFilePath {  get; private set; }
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

                File.Copy(currentFilePath, destinationFilePath, true);
                //(コピーするファイル名、コピー後のファイル名）上書きを許可する場合はtrue

                copiedFilePath = destinationFilePath;

                this.Hide();
                //ウィンドウを隠す（リストに保存されるまでは終了はしない）
            }
            catch { MessageBox.Show("画像のコピーに失敗しました"); }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void ClearPreviewWindow()
        {
            Instance = null;
            this.Close();
        }

        
    }
}
