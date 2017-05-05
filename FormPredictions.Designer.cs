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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_results)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_weekly
            // 
            this.radioButton_weekly.AutoSize = true;
            this.radioButton_weekly.Location = new System.Drawing.Point(12, 39);
            this.radioButton_weekly.Name = "radioButton_weekly";
            this.radioButton_weekly.Size = new System.Drawing.Size(61, 17);
            this.radioButton_weekly.TabIndex = 0;
            this.radioButton_weekly.TabStop = true;
            this.radioButton_weekly.Text = "Weekly";
            this.radioButton_weekly.UseVisualStyleBackColor = true;
            // 
            // radioButton_monthly
            // 
            this.radioButton_monthly.AutoSize = true;
            this.radioButton_monthly.Location = new System.Drawing.Point(158, 39);
            this.radioButton_monthly.Name = "radioButton_monthly";
            this.radioButton_monthly.Size = new System.Drawing.Size(62, 17);
            this.radioButton_monthly.TabIndex = 1;
            this.radioButton_monthly.TabStop = true;
            this.radioButton_monthly.Text = "Monthly";
            this.radioButton_monthly.UseVisualStyleBackColor = true;
            // 
            // listBox_items
            // 
            this.listBox_items.FormattingEnabled = true;
            this.listBox_items.Location = new System.Drawing.Point(12, 100);
            this.listBox_items.Name = "listBox_items";
            this.listBox_items.Size = new System.Drawing.Size(208, 134);
            this.listBox_items.TabIndex = 2;
            // 
            // txt_search_items
            // 
            this.txt_search_items.Location = new System.Drawing.Point(12, 74);
            this.txt_search_items.Name = "txt_search_items";
            this.txt_search_items.Size = new System.Drawing.Size(208, 20);
            this.txt_search_items.TabIndex = 5;
            this.txt_search_items.Text = "Search Items Here... U+1F50D";
            this.txt_search_items.TextChanged += new System.EventHandler(this.txt_Search_items_TextChanged);
            this.txt_search_items.Enter += new System.EventHandler(this.txt_Search_items_Enter);
            this.txt_search_items.Leave += new System.EventHandler(this.txt_Search_items_Leave);
            // 
            // listBox_tags
            // 
            this.listBox_tags.FormattingEnabled = true;
            this.listBox_tags.Location = new System.Drawing.Point(12, 289);
            this.listBox_tags.Name = "listBox_tags";
            this.listBox_tags.Size = new System.Drawing.Size(208, 147);
            this.listBox_tags.TabIndex = 6;
            // 
            // txt_search_tags
            // 
            this.txt_search_tags.Location = new System.Drawing.Point(12, 263);
            this.txt_search_tags.Name = "txt_search_tags";
            this.txt_search_tags.Size = new System.Drawing.Size(208, 20);
            this.txt_search_tags.TabIndex = 7;
            this.txt_search_tags.Text = "Search Tags Here... U+1F50D";
            this.txt_search_tags.TextChanged += new System.EventHandler(this.txt_Search_items_TextChanged);
            this.txt_search_tags.Enter += new System.EventHandler(this.txt_Search_tags_Enter);
            this.txt_search_tags.Leave += new System.EventHandler(this.txt_Search_tags_Leave);
            // 
            // dgv_results
            // 
            this.dgv_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Quantity,
            this.Profit});
            this.dgv_results.Location = new System.Drawing.Point(247, 74);
            this.dgv_results.Name = "dgv_results";
            this.dgv_results.ReadOnly = true;
            this.dgv_results.Size = new System.Drawing.Size(367, 362);
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
            this.button_close.Location = new System.Drawing.Point(628, 412);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(138, 23);
            this.button_close.TabIndex = 9;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_predict_items
            // 
            this.button_predict_items.Location = new System.Drawing.Point(628, 74);
            this.button_predict_items.Name = "button_predict_items";
            this.button_predict_items.Size = new System.Drawing.Size(138, 23);
            this.button_predict_items.TabIndex = 10;
            this.button_predict_items.Text = "Predict Items";
            this.button_predict_items.UseVisualStyleBackColor = true;
            // 
            // button_predict_tags
            // 
            this.button_predict_tags.Location = new System.Drawing.Point(628, 112);
            this.button_predict_tags.Name = "button_predict_tags";
            this.button_predict_tags.Size = new System.Drawing.Size(138, 23);
            this.button_predict_tags.TabIndex = 11;
            this.button_predict_tags.Text = "Predict Tags";
            this.button_predict_tags.UseVisualStyleBackColor = true;
            // 
            // FormPredictions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 459);
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
            this.Name = "FormPredictions";
            this.Text = "FormPredictions";
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
    }
}