namespace StockManagementSystem.UI
{
    partial class StockIn
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
            this.categoryGroupBox = new System.Windows.Forms.GroupBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.reorderLabel = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.stockInQuantityTextBox = new System.Windows.Forms.TextBox();
            this.stockInQuantityLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.aveilableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.aveilableQuantityLable = new System.Windows.Forms.Label();
            this.categoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.Controls.Add(this.aveilableQuantityTextBox);
            this.categoryGroupBox.Controls.Add(this.aveilableQuantityLable);
            this.categoryGroupBox.Controls.Add(this.itemComboBox);
            this.categoryGroupBox.Controls.Add(this.itemLabel);
            this.categoryGroupBox.Controls.Add(this.reorderLevelTextBox);
            this.categoryGroupBox.Controls.Add(this.reorderLabel);
            this.categoryGroupBox.Controls.Add(this.companyComboBox);
            this.categoryGroupBox.Controls.Add(this.companyLabel);
            this.categoryGroupBox.Controls.Add(this.categoryComboBox);
            this.categoryGroupBox.Controls.Add(this.categoryLabel);
            this.categoryGroupBox.Controls.Add(this.SaveButton);
            this.categoryGroupBox.Controls.Add(this.stockInQuantityTextBox);
            this.categoryGroupBox.Controls.Add(this.stockInQuantityLabel);
            this.categoryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryGroupBox.Location = new System.Drawing.Point(30, 34);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(507, 383);
            this.categoryGroupBox.TabIndex = 2;
            this.categoryGroupBox.TabStop = false;
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(179, 194);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(273, 22);
            this.reorderLevelTextBox.TabIndex = 8;
            // 
            // reorderLabel
            // 
            this.reorderLabel.AutoSize = true;
            this.reorderLabel.Location = new System.Drawing.Point(38, 197);
            this.reorderLabel.Name = "reorderLabel";
            this.reorderLabel.Size = new System.Drawing.Size(107, 16);
            this.reorderLabel.TabIndex = 7;
            this.reorderLabel.Text = "Reorder Level";
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(179, 102);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(273, 24);
            this.companyComboBox.TabIndex = 6;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(38, 103);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(73, 16);
            this.companyLabel.TabIndex = 5;
            this.companyLabel.Text = "Company";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(357, 330);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(95, 28);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // stockInQuantityTextBox
            // 
            this.stockInQuantityTextBox.Location = new System.Drawing.Point(179, 278);
            this.stockInQuantityTextBox.Name = "stockInQuantityTextBox";
            this.stockInQuantityTextBox.Size = new System.Drawing.Size(273, 22);
            this.stockInQuantityTextBox.TabIndex = 1;
            // 
            // stockInQuantityLabel
            // 
            this.stockInQuantityLabel.AutoSize = true;
            this.stockInQuantityLabel.Location = new System.Drawing.Point(38, 281);
            this.stockInQuantityLabel.Name = "stockInQuantityLabel";
            this.stockInQuantityLabel.Size = new System.Drawing.Size(123, 16);
            this.stockInQuantityLabel.TabIndex = 0;
            this.stockInQuantityLabel.Text = "Stock In Quantity";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(179, 54);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(273, 24);
            this.categoryComboBox.TabIndex = 4;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(38, 55);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(71, 16);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Category";
            // 
            // itemComboBox
            // 
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(179, 149);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(273, 24);
            this.itemComboBox.TabIndex = 10;
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(38, 152);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(37, 16);
            this.itemLabel.TabIndex = 9;
            this.itemLabel.Text = "Item";
            // 
            // aveilableQuantityTextBox
            // 
            this.aveilableQuantityTextBox.Location = new System.Drawing.Point(179, 237);
            this.aveilableQuantityTextBox.Name = "aveilableQuantityTextBox";
            this.aveilableQuantityTextBox.Size = new System.Drawing.Size(273, 22);
            this.aveilableQuantityTextBox.TabIndex = 12;
            // 
            // aveilableQuantityLable
            // 
            this.aveilableQuantityLable.AutoSize = true;
            this.aveilableQuantityLable.Location = new System.Drawing.Point(38, 240);
            this.aveilableQuantityLable.Name = "aveilableQuantityLable";
            this.aveilableQuantityLable.Size = new System.Drawing.Size(134, 16);
            this.aveilableQuantityLable.TabIndex = 11;
            this.aveilableQuantityLable.Text = "Aveilable Quantity";
            // 
            // StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.categoryGroupBox);
            this.Name = "StockIn";
            this.Text = "Stock In";
            this.categoryGroupBox.ResumeLayout(false);
            this.categoryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox categoryGroupBox;
        private System.Windows.Forms.TextBox aveilableQuantityTextBox;
        private System.Windows.Forms.Label aveilableQuantityLable;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.Label reorderLabel;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox stockInQuantityTextBox;
        private System.Windows.Forms.Label stockInQuantityLabel;
    }
}