namespace StockManagementSystem.UI
{
    partial class ViewSales
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.toDateTextBox = new System.Windows.Forms.TextBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTextBox = new System.Windows.Forms.TextBox();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.Controls.Add(this.fromDateTimePicker);
            this.categoryGroupBox.Controls.Add(this.fromDateTextBox);
            this.categoryGroupBox.Controls.Add(this.toDateTimePicker);
            this.categoryGroupBox.Controls.Add(this.toDateTextBox);
            this.categoryGroupBox.Controls.Add(this.dataGridView1);
            this.categoryGroupBox.Controls.Add(this.toDateLabel);
            this.categoryGroupBox.Controls.Add(this.fromDateLabel);
            this.categoryGroupBox.Controls.Add(this.SearchButton);
            this.categoryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryGroupBox.Location = new System.Drawing.Point(27, 34);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(507, 383);
            this.categoryGroupBox.TabIndex = 4;
            this.categoryGroupBox.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.Location = new System.Drawing.Point(38, 103);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(64, 16);
            this.toDateLabel.TabIndex = 5;
            this.toDateLabel.Text = "To Date";
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Location = new System.Drawing.Point(38, 55);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(80, 16);
            this.fromDateLabel.TabIndex = 3;
            this.fromDateLabel.Text = "From Date";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(357, 159);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(95, 28);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // toDateTextBox
            // 
            this.toDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateTextBox.Location = new System.Drawing.Point(179, 103);
            this.toDateTextBox.Name = "toDateTextBox";
            this.toDateTextBox.Size = new System.Drawing.Size(273, 20);
            this.toDateTextBox.TabIndex = 9;
            this.toDateTextBox.Text = "Datepicker";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(431, 102);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(21, 22);
            this.toDateTimePicker.TabIndex = 11;
            // 
            // fromDateTextBox
            // 
            this.fromDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateTextBox.Location = new System.Drawing.Point(179, 55);
            this.fromDateTextBox.Name = "fromDateTextBox";
            this.fromDateTextBox.Size = new System.Drawing.Size(273, 20);
            this.fromDateTextBox.TabIndex = 12;
            this.fromDateTextBox.Text = "Datepicker";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(431, 54);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(21, 22);
            this.fromDateTimePicker.TabIndex = 13;
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.categoryGroupBox);
            this.Name = "ViewSales";
            this.Text = "View Sales Between Two Datas";
            this.categoryGroupBox.ResumeLayout(false);
            this.categoryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox categoryGroupBox;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.TextBox toDateTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label toDateLabel;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.TextBox fromDateTextBox;
    }
}