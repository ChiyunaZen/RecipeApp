namespace RecipeApp
{
    partial class RecipeEditWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.recipeNameTextBox = new System.Windows.Forms.TextBox();
            this.ingredienTextBox = new System.Windows.Forms.RichTextBox();
            this.recipeSentenceTextBox = new System.Windows.Forms.RichTextBox();
            this.levelTrackBar = new System.Windows.Forms.TrackBar();
            this.levelStarLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.cookingTimeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userControl_RecipeListView1 = new RecipeApp.UserControl_RecipeListView();
            ((System.ComponentModel.ISupportInitialize)(this.levelTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(339, 290);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(290, 50);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "レシピの登録/編集";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(635, 290);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(178, 50);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "選択レシピの削除";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // recipeNameTextBox
            // 
            this.recipeNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.recipeNameTextBox.Location = new System.Drawing.Point(26, 32);
            this.recipeNameTextBox.Name = "recipeNameTextBox";
            this.recipeNameTextBox.Size = new System.Drawing.Size(186, 29);
            this.recipeNameTextBox.TabIndex = 3;
            // 
            // ingredienTextBox
            // 
            this.ingredienTextBox.Location = new System.Drawing.Point(26, 146);
            this.ingredienTextBox.Name = "ingredienTextBox";
            this.ingredienTextBox.Size = new System.Drawing.Size(276, 41);
            this.ingredienTextBox.TabIndex = 6;
            this.ingredienTextBox.Text = "";
            // 
            // recipeSentenceTextBox
            // 
            this.recipeSentenceTextBox.Location = new System.Drawing.Point(26, 208);
            this.recipeSentenceTextBox.Name = "recipeSentenceTextBox";
            this.recipeSentenceTextBox.Size = new System.Drawing.Size(276, 132);
            this.recipeSentenceTextBox.TabIndex = 7;
            this.recipeSentenceTextBox.Text = "";
            // 
            // levelTrackBar
            // 
            this.levelTrackBar.Location = new System.Drawing.Point(189, 88);
            this.levelTrackBar.Maximum = 5;
            this.levelTrackBar.Minimum = 1;
            this.levelTrackBar.Name = "levelTrackBar";
            this.levelTrackBar.Size = new System.Drawing.Size(113, 56);
            this.levelTrackBar.TabIndex = 16;
            this.levelTrackBar.Value = 1;
            this.levelTrackBar.Scroll += new System.EventHandler(this.levelTrackBar_Scroll);
            // 
            // levelStarLabel
            // 
            this.levelStarLabel.AutoSize = true;
            this.levelStarLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.levelStarLabel.Location = new System.Drawing.Point(196, 113);
            this.levelStarLabel.Name = "levelStarLabel";
            this.levelStarLabel.Size = new System.Drawing.Size(93, 17);
            this.levelStarLabel.TabIndex = 9;
            this.levelStarLabel.Text = "★☆☆☆☆";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(27, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "▼料理名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(27, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "▼調理時間";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(186, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "▼難易度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(27, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "▼食材";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "▼手順";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // loadImageButton
            // 
            this.loadImageButton.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loadImageButton.Location = new System.Drawing.Point(218, 29);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(84, 32);
            this.loadImageButton.TabIndex = 15;
            this.loadImageButton.Text = "画像設定";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // cookingTimeComboBox
            // 
            this.cookingTimeComboBox.FormattingEnabled = true;
            this.cookingTimeComboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "30",
            "45",
            "60",
            "90",
            "120",
            "180",
            "240",
            "300"});
            this.cookingTimeComboBox.Location = new System.Drawing.Point(26, 88);
            this.cookingTimeComboBox.Name = "cookingTimeComboBox";
            this.cookingTimeComboBox.Size = new System.Drawing.Size(92, 23);
            this.cookingTimeComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(124, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "分";
            // 
            // userControl_RecipeListView1
            // 
            this.userControl_RecipeListView1.Location = new System.Drawing.Point(339, 32);
            this.userControl_RecipeListView1.Name = "userControl_RecipeListView1";
            this.userControl_RecipeListView1.Size = new System.Drawing.Size(474, 252);
            this.userControl_RecipeListView1.TabIndex = 0;
            // 
            // RecipeEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 359);
            this.Controls.Add(this.cookingTimeComboBox);
            this.Controls.Add(this.loadImageButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.levelStarLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levelTrackBar);
            this.Controls.Add(this.recipeSentenceTextBox);
            this.Controls.Add(this.ingredienTextBox);
            this.Controls.Add(this.recipeNameTextBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.userControl_RecipeListView1);
            this.Name = "RecipeEditWindow";
            this.Text = "レシピ編集";
            ((System.ComponentModel.ISupportInitialize)(this.levelTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl_RecipeListView userControl_RecipeListView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox recipeNameTextBox;
        private System.Windows.Forms.RichTextBox ingredienTextBox;
        private System.Windows.Forms.RichTextBox recipeSentenceTextBox;
        private System.Windows.Forms.TrackBar levelTrackBar;
        private System.Windows.Forms.Label levelStarLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.ComboBox cookingTimeComboBox;
        private System.Windows.Forms.Label label1;
    }
}