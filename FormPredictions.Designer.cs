namespace Teamerino_Memerino
{
    partial class FormPredictions
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
            this.radioButton_weekly = new System.Windows.Forms.RadioButton();
            this.radioButton_monthly = new System.Windows.Forms.RadioButton();
            this.listBox_items = new System.Windows.Forms.ListBox();
            this.txt_search_items = new System.Windows.Forms.TextBox();
            this.listBox_tags = new System.Windows.Forms.ListBox();
            this.txt_search_tags = new System.Windows.Forms.TextBox();
            this.dgv_results = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_close = new System.Windows.Forms.Button();
            this.button_predict_items = new System.Windows.Forms.Button();
            this.button_predict_tags = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_results)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_weekly
            // 
            this.radioButton_weekly.AutoSize = true;
            this.radioButton_weekly.Checked = true;
            this.radioButton_weekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radioButton_weekly.Location = new System.Drawing.Point(13, 119);
            this.radioButton_weekly.Name = "radioButton_weekly";
            this.radioButton_weekly.Size = new System.Drawing.Size(179, 28);
            this.radioButton_weekly.TabIndex = 0;
            this.radioButton_weekly.TabStop = true;
            this.radioButton_weekly.Text = "For the next week";
            this.radioButton_weekly.UseVisualStyleBackColor = true;
            // 
            // radioButton_monthly
            // 
            this.radioButton_monthly.AutoSize = true;
            this.radioButton_monthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radioButton_monthly.Location = new System.Drawing.Point(200, 119);
            this.radioButton_monthly.Name = "radioButton_monthly";
            this.radioButton_monthly.Size = new System.Drawing.Size(187, 28);
            this.radioButton_monthly.TabIndex = 1;
            this.radioButton_monthly.Text = "For the next month";
            this.radioButton_monthly.UseVisualStyleBackColor = true;
            this.radioButton_monthly.CheckedChanged += new System.EventHandler(this.radioButton_monthly_CheckedChanged);
            // 
            // listBox_items
            // 
            this.listBox_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox_items.FormattingEnabled = true;
            this.listBox_items.ItemHeight = 20;
            this.listBox_items.Location = new System.Drawing.Point(12, 192);
            this.listBox_items.Name = "listBox_items";
            this.listBox_items.Size = new System.Drawing.Size(238, 184);
            this.listBox_items.TabIndex = 2;
            // 
            // txt_search_items
            // 
            this.txt_search_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_search_items.Location = new System.Drawing.Point(12, 157);
            this.txt_search_items.Name = "txt_search_items";
            this.txt_search_items.Size = new System.Drawing.Size(238, 29);
            this.txt_search_items.TabIndex = 5;
            this.txt_search_items.Text = "Search Items Here... U+1F50D";
            this.txt_search_items.TextChanged += new System.EventHandler(this.txt_Search_items_TextChanged);
            this.txt_search_items.Enter += new System.EventHandler(this.txt_Search_items_Enter);
            this.txt_search_items.Leave += new System.EventHandler(this.txt_Search_items_Leave);
            // 
            // listBox_tags
            // 
            this.listBox_tags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox_tags.FormattingEnabled = true;
            this.listBox_tags.ItemHeight = 20;
            this.listBox_tags.Location = new System.Drawing.Point(12, 434);
            this.listBox_tags.Name = "listBox_tags";
            this.listBox_tags.Size = new System.Drawing.Size(238, 184);
            this.listBox_tags.TabIndex = 6;
            // 
            // txt_search_tags
            // 
            this.txt_search_tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_search_tags.Location = new System.Drawing.Point(12, 399);
            this.txt_search_tags.Name = "txt_search_tags";
            this.txt_search_tags.Size = new System.Drawing.Size(238, 29);
            this.txt_search_tags.TabIndex = 7;
            this.txt_search_tags.Text = "Search Tags Here... U+1F50D";
            this.txt_search_tags.TextChanged += new System.EventHandler(this.txt_Search_tags_TextChanged);
            this.txt_search_tags.Enter += new System.EventHandler(this.txt_Search_tags_Enter);
            this.txt_search_tags.Leave += new System.EventHandler(this.txt_Search_tags_Leave);
            // 
            // dgv_results
            // 
            this.dgv_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_results.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgv_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Quantity,
            this.Profit});
            this.dgv_results.Location = new System.Drawing.Point(262, 157);
            this.dgv_results.Name = "dgv_results";
            this.dgv_results.ReadOnly = true;
            this.dgv_results.Size = new System.Drawing.Size(671, 478);
            this.dgv_results.TabIndex = 8;
            this.dgv_results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_results_CellContentClick);
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Predicted Quantity Sold";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Predicted Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_close.Location = new System.Drawing.Point(944, 590);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(191, 45);
            this.button_close.TabIndex = 9;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_predict_items
            // 
            this.button_predict_items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_predict_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_predict_items.Location = new System.Drawing.Point(944, 156);
            this.button_predict_items.Name = "button_predict_items";
            this.button_predict_items.Size = new System.Drawing.Size(191, 45);
            this.button_predict_items.TabIndex = 10;
            this.button_predict_items.Text = "Predict Items";
            this.button_predict_items.UseVisualStyleBackColor = true;
            this.button_predict_items.Click += new System.EventHandler(this.button_predict_items_Click);
            // 
            // button_predict_tags
            // 
            this.button_predict_tags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_predict_tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_predict_tags.Location = new System.Drawing.Point(944, 207);
            this.button_predict_tags.Name = "button_predict_tags";
            this.button_predict_tags.Size = new System.Drawing.Size(191, 45);
            this.button_predict_tags.TabIndex = 11;
            this.button_predict_tags.Text = "Predict Tags";
            this.button_predict_tags.UseVisualStyleBackColor = true;
            this.button_predict_tags.Click += new System.EventHandler(this.button_predict_tags_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_title.Location = new System.Drawing.Point(7, 90);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(155, 26);
            this.lbl_title.TabIndex = 12;
            this.lbl_title.Text = "Predict sales...";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 85);
            this.label1.TabIndex = 13;
            this.label1.Text = "People Health Pharmacy";
            // 
            // FormPredictions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1144, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.button_predict_tags);
            this.Controls.Add(this.button_predict_items);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.dgv_results);
            this.Controls.Add(this.txt_search_tags);
            this.Controls.Add(this.listBox_tags);
            this.Controls.Add(this.txt_search_items);
            this.Controls.Add(this.listBox_items);
            this.Controls.Add(this.radioButton_monthly);
            this.Controls.Add(this.radioButton_weekly);
            this.MinimizeBox = false;
            this.Name = "FormPredictions";
            this.Text = "FormPredictions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPredictions_FormClosing);
            this.Load += new System.EventHandler(this.FormPredictions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_weekly;
        private System.Windows.Forms.RadioButton radioButton_monthly;
        private System.Windows.Forms.ListBox listBox_items;
        private System.Windows.Forms.TextBox txt_search_items;
        private System.Windows.Forms.ListBox listBox_tags;
        private System.Windows.Forms.TextBox txt_search_tags;
        private System.Windows.Forms.DataGridView dgv_results;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_predict_items;
        private System.Windows.Forms.Button button_predict_tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
    }
}