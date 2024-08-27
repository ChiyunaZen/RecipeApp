namespace RecipeApp
{
    partial class UserControl_RecipeListView
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.timeSortButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.recipeView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuImageBox = new System.Windows.Forms.PictureBox();
            this.menuNameLabel = new System.Windows.Forms.Label();
            this.menuTimeLabel = new System.Windows.Forms.Label();
            this.menuLevelLabel = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lebelSortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timeSortButton
            // 
            this.timeSortButton.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeSortButton.Location = new System.Drawing.Point(104, 3);
            this.timeSortButton.Name = "timeSortButton";
            this.timeSortButton.Size = new System.Drawing.Size(95, 30);
            this.timeSortButton.TabIndex = 7;
            this.timeSortButton.Text = "▼調理時間";
            this.timeSortButton.UseVisualStyleBackColor = true;
            this.timeSortButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(-2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "レシピ";
            // 
            // recipeView
            // 
            this.recipeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.recipeView.FullRowSelect = true;
            this.recipeView.GridLines = true;
            this.recipeView.HideSelection = false;
            this.recipeView.Location = new System.Drawing.Point(3, 38);
            this.recipeView.Name = "recipeView";
            this.recipeView.Size = new System.Drawing.Size(286, 209);
            this.recipeView.TabIndex = 5;
            this.recipeView.UseCompatibleStateImageBehavior = false;
            this.recipeView.View = System.Windows.Forms.View.Details;
            this.recipeView.SelectedIndexChanged += new System.EventHandler(this.recipeView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "料理名";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "調理時間";
            // 
            // menuImageBox
            // 
            this.menuImageBox.Location = new System.Drawing.Point(295, 97);
            this.menuImageBox.Name = "menuImageBox";
            this.menuImageBox.Size = new System.Drawing.Size(164, 150);
            this.menuImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuImageBox.TabIndex = 8;
            this.menuImageBox.TabStop = false;
            // 
            // menuNameLabel
            // 
            this.menuNameLabel.AutoSize = true;
            this.menuNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menuNameLabel.Location = new System.Drawing.Point(295, 38);
            this.menuNameLabel.Name = "menuNameLabel";
            this.menuNameLabel.Size = new System.Drawing.Size(96, 22);
            this.menuNameLabel.TabIndex = 9;
            this.menuNameLabel.Text = "◇メニュー";
            // 
            // menuTimeLabel
            // 
            this.menuTimeLabel.AutoSize = true;
            this.menuTimeLabel.Location = new System.Drawing.Point(305, 64);
            this.menuTimeLabel.Name = "menuTimeLabel";
            this.menuTimeLabel.Size = new System.Drawing.Size(75, 15);
            this.menuTimeLabel.TabIndex = 10;
            this.menuTimeLabel.Text = "調理時間：";
            // 
            // menuLevelLabel
            // 
            this.menuLevelLabel.AutoSize = true;
            this.menuLevelLabel.Location = new System.Drawing.Point(305, 79);
            this.menuLevelLabel.Name = "menuLevelLabel";
            this.menuLevelLabel.Size = new System.Drawing.Size(135, 15);
            this.menuLevelLabel.TabIndex = 11;
            this.menuLevelLabel.Text = "難易度：☆☆☆☆☆";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "難易度";
            this.columnHeader3.Width = 50;
            // 
            // lebelSortButton
            // 
            this.lebelSortButton.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lebelSortButton.Location = new System.Drawing.Point(205, 3);
            this.lebelSortButton.Name = "lebelSortButton";
            this.lebelSortButton.Size = new System.Drawing.Size(84, 30);
            this.lebelSortButton.TabIndex = 12;
            this.lebelSortButton.Text = "▼難易度";
            this.lebelSortButton.UseVisualStyleBackColor = true;
            this.lebelSortButton.Click += new System.EventHandler(this.lebelSortButton_Click);
            // 
            // UserControl_RecipeListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lebelSortButton);
            this.Controls.Add(this.menuLevelLabel);
            this.Controls.Add(this.menuTimeLabel);
            this.Controls.Add(this.menuNameLabel);
            this.Controls.Add(this.menuImageBox);
            this.Controls.Add(this.timeSortButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recipeView);
            this.Name = "UserControl_RecipeListView";
            this.Size = new System.Drawing.Size(466, 252);
            ((System.ComponentModel.ISupportInitialize)(this.menuImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timeSortButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView recipeView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox menuImageBox;
        private System.Windows.Forms.Label menuNameLabel;
        private System.Windows.Forms.Label menuTimeLabel;
        private System.Windows.Forms.Label menuLevelLabel;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button lebelSortButton;
    }
}
