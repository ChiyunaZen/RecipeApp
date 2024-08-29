namespace RecipeApp
{
    partial class RecipeWindow
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
            this.MenuPictureBox = new System.Windows.Forms.PictureBox();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ingredientCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.recipeSentenceTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPictureBox
            // 
            this.MenuPictureBox.Location = new System.Drawing.Point(39, 52);
            this.MenuPictureBox.Name = "MenuPictureBox";
            this.MenuPictureBox.Size = new System.Drawing.Size(229, 201);
            this.MenuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuPictureBox.TabIndex = 0;
            this.MenuPictureBox.TabStop = false;
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Font = new System.Drawing.Font("メイリオ", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.recipeNameLabel.Location = new System.Drawing.Point(32, 9);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(126, 41);
            this.recipeNameLabel.TabIndex = 1;
            this.recipeNameLabel.Text = "◇料理名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(274, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "●食材";
            // 
            // ingredientCheckedListBox
            // 
            this.ingredientCheckedListBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ingredientCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ingredientCheckedListBox.CausesValidation = false;
            this.ingredientCheckedListBox.CheckOnClick = true;
            this.ingredientCheckedListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ingredientCheckedListBox.FormattingEnabled = true;
            this.ingredientCheckedListBox.Location = new System.Drawing.Point(293, 83);
            this.ingredientCheckedListBox.Name = "ingredientCheckedListBox";
            this.ingredientCheckedListBox.Size = new System.Drawing.Size(208, 170);
            this.ingredientCheckedListBox.TabIndex = 3;
            this.ingredientCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ingredientCheckedListBox_ItemCheck);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(39, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "●手順";
            // 
            // recipeSentenceTextBox
            // 
            this.recipeSentenceTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.recipeSentenceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recipeSentenceTextBox.Location = new System.Drawing.Point(39, 297);
            this.recipeSentenceTextBox.Name = "recipeSentenceTextBox";
            this.recipeSentenceTextBox.Size = new System.Drawing.Size(462, 279);
            this.recipeSentenceTextBox.TabIndex = 5;
            this.recipeSentenceTextBox.Text = "";
            // 
            // RecipeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(545, 603);
            this.Controls.Add(this.recipeSentenceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingredientCheckedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recipeNameLabel);
            this.Controls.Add(this.MenuPictureBox);
            this.Name = "RecipeWindow";
            this.Text = "RecipeWindow";
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MenuPictureBox;
        private System.Windows.Forms.Label recipeNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox ingredientCheckedListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox recipeSentenceTextBox;
    }
}