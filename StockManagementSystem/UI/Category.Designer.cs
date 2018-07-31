namespace StockManagementSystem.UI
{
    partial class Category
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
            this.UpdatedButton = new System.Windows.Forms.Button();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.DeletedButton = new System.Windows.Forms.Button();
            this.categoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.Controls.Add(this.DeletedButton);
            this.categoryGroupBox.Controls.Add(this.UpdatedButton);
            this.categoryGroupBox.Controls.Add(this.categoryDataGridView);
            this.categoryGroupBox.Controls.Add(this.SaveButton);
            this.categoryGroupBox.Controls.Add(this.categoryNameTextBox);
            this.categoryGroupBox.Controls.Add(this.categoryNameLabel);
            this.categoryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryGroupBox.Location = new System.Drawing.Point(35, 26);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(507, 383);
            this.categoryGroupBox.TabIndex = 0;
            this.categoryGroupBox.TabStop = false;
            // 
            // UpdatedButton
            // 
            this.UpdatedButton.Location = new System.Drawing.Point(357, 346);
            this.UpdatedButton.Name = "UpdatedButton";
            this.UpdatedButton.Size = new System.Drawing.Size(95, 28);
            this.UpdatedButton.TabIndex = 4;
            this.UpdatedButton.Text = "Updated";
            this.UpdatedButton.UseVisualStyleBackColor = true;
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AllowUserToAddRows = false;
            this.categoryDataGridView.AllowUserToDeleteRows = false;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Location = new System.Drawing.Point(83, 146);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.ReadOnly = true;
            this.categoryDataGridView.Size = new System.Drawing.Size(369, 179);
            this.categoryDataGridView.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(357, 101);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(95, 28);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(179, 64);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(273, 22);
            this.categoryNameTextBox.TabIndex = 1;
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(80, 70);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(57, 16);
            this.categoryNameLabel.TabIndex = 0;
            this.categoryNameLabel.Text = "Name :";
            // 
            // DeletedButton
            // 
            this.DeletedButton.Location = new System.Drawing.Point(83, 346);
            this.DeletedButton.Name = "DeletedButton";
            this.DeletedButton.Size = new System.Drawing.Size(95, 28);
            this.DeletedButton.TabIndex = 5;
            this.DeletedButton.Text = "Deleted";
            this.DeletedButton.UseVisualStyleBackColor = true;
            this.DeletedButton.Click += new System.EventHandler(this.DeletedButton_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.categoryGroupBox);
            this.Name = "Category";
            this.Text = "Category";
            this.categoryGroupBox.ResumeLayout(false);
            this.categoryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox categoryGroupBox;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.Button UpdatedButton;
        private System.Windows.Forms.Button DeletedButton;
    }
}