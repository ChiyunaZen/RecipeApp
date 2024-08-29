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

    public partial class PicturePreviewWindow : Form
    {
        public static PicturePreviewWindow Instance { get; private set; }
        //フォームがnull(開かれていない)可を公開するプロパティ

        public PicturePreviewWindow(string filePath)
        {
            InitializeComponent();
            Instance=this;
            //最初に開いた場合の処理
            pictureBox1.Image = Image.FromFile(filePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void ClearPreviewWindow()
        {
            Instance = null;
            this.Close();
        }
        
    }
}
