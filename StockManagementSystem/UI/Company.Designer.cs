namespace StockManagementSystem.UI
{
    partial class Company
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
            this.companyGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyGroupBox
            // 
            this.companyGroupBox.Controls.Add(this.SaveButton);
            this.companyGroupBox.Controls.Add(this.companyNameTextBox);
            this.companyGroupBox.Controls.Add(this.companyNameLabel);
            this.companyGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyGroupBox.Location = new System.Drawing.Point(25, 23);
            this.companyGroupBox.Name = "companyGroupBox";
            this.companyGroupBox.Size = new System.Drawing.Size(507, 383);
            this.companyGroupBox.TabIndex = 1;
            this.companyGroupBox.TabStop = false;
            this.companyGroupBox.Enter += new System.EventHandler(this.companyGroupBox_Enter);
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
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(179, 64);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(273, 22);
            this.companyNameTextBox.TabIndex = 1;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(80, 70);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(57, 16);
            this.companyNameLabel.TabIndex = 0;
            this.companyNameLabel.Text = "Name :";
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.companyGroupBox);
            this.Name = "Company";
            this.Text = "Company";
            this.companyGroupBox.ResumeLayout(false);
            this.companyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox companyGroupBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Label companyNameLabel;
    }
}