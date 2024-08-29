namespace RecipeApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchButton = new System.Windows.Forms.Button();
            this.recipeViewButton = new System.Windows.Forms.Button();
            this.serchTextBox = new System.Windows.Forms.TextBox();
            this.sortClearButton = new System.Windows.Forms.Button();
            this.userControl_RecipeListView = new RecipeApp.UserControl_RecipeListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // メニューToolStripMenuItem
            // 
            this.メニューToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipeEditToolStripMenuItem});
            this.メニューToolStripMenuItem.Name = "メニューToolStripMenuItem";
            this.メニューToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.メニューToolStripMenuItem.Text = "メニュー";
            // 
            // recipeEditToolStripMenuItem
            // 
            this.recipeEditToolStripMenuItem.Name = "recipeEditToolStripMenuItem";
            this.recipeEditToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.recipeEditToolStripMenuItem.Text = "レシピ管理";
            this.recipeEditToolStripMenuItem.Click += new System.EventHandler(this.recipeEditToolStripMenuItem_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(290, 369);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(115, 31);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "食材名で検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // recipeViewButton
            // 
            this.recipeViewButton.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.recipeViewButton.Location = new System.Drawing.Point(47, 306);
            this.recipeViewButton.Name = "recipeViewButton";
            this.recipeViewButton.Size = new System.Drawing.Size(471, 50);
            this.recipeViewButton.TabIndex = 6;
            this.recipeViewButton.Text = "レシピを見る";
            this.recipeViewButton.UseVisualStyleBackColor = true;
            this.recipeViewButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // serchTextBox
            // 
            this.serchTextBox.Location = new System.Drawing.Point(47, 374);
            this.serchTextBox.Name = "serchTextBox";
            this.serchTextBox.Size = new System.Drawing.Size(237, 22);
            this.serchTextBox.TabIndex = 9;
            // 
            // sortClearButton
            // 
            this.sortClearButton.Location = new System.Drawing.Point(411, 369);
            this.sortClearButton.Name = "sortClearButton";
            this.sortClearButton.Size = new System.Drawing.Size(107, 31);
            this.sortClearButton.TabIndex = 10;
            this.sortClearButton.Text = "検索をクリア";
            this.sortClearButton.UseVisualStyleBackColor = true;
            this.sortClearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl_RecipeListView
            // 
            this.userControl_RecipeListView.Location = new System.Drawing.Point(47, 48);
            this.userControl_RecipeListView.Name = "userControl_RecipeListView";
            this.userControl_RecipeListView.Size = new System.Drawing.Size(471, 252);
            this.userControl_RecipeListView.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 426);
            this.Controls.Add(this.sortClearButton);
            this.Controls.Add(this.serchTextBox);
            this.Controls.Add(this.userControl_RecipeListView);
            this.Controls.Add(this.recipeViewButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RecipeApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メニューToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipeEditToolStripMenuItem;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button recipeViewButton;
        private UserControl_RecipeListView userControl_RecipeListView;
        private System.Windows.Forms.TextBox serchTextBox;
        private System.Windows.Forms.Button sortClearButton;
    }
}

