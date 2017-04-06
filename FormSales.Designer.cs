namespace Teamerino_Memerino
{
    partial class FormSales
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RecordNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_new_sales_record = new System.Windows.Forms.Button();
            this.button_edit_record = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordNumber,
            this.NumberOfItems,
            this.TotalPrice,
            this.Time,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(547, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // RecordNumber
            // 
            this.RecordNumber.HeaderText = "Record Number";
            this.RecordNumber.Name = "RecordNumber";
            this.RecordNumber.ReadOnly = true;
            // 
            // NumberOfItems
            // 
            this.NumberOfItems.HeaderText = "NumberOfItems";
            this.NumberOfItems.Name = "NumberOfItems";
            this.NumberOfItems.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // button_new_sales_record
            // 
            this.button_new_sales_record.Location = new System.Drawing.Point(12, 12);
            this.button_new_sales_record.Name = "button_new_sales_record";
            this.button_new_sales_record.Size = new System.Drawing.Size(114, 23);
            this.button_new_sales_record.TabIndex = 1;
            this.button_new_sales_record.Text = "New Sales Record";
            this.button_new_sales_record.UseVisualStyleBackColor = true;
            this.button_new_sales_record.Click += new System.EventHandler(this.button_new_sales_record_Click);
            // 
            // button_edit_record
            // 
            this.button_edit_record.Location = new System.Drawing.Point(132, 12);
            this.button_edit_record.Name = "button_edit_record";
            this.button_edit_record.Size = new System.Drawing.Size(114, 23);
            this.button_edit_record.TabIndex = 2;
            this.button_edit_record.Text = "Edit Selected";
            this.button_edit_record.UseVisualStyleBackColor = true;
            this.button_edit_record.Click += new System.EventHandler(this.button_edit_record_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(252, 12);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(114, 23);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete Record";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 310);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit_record);
            this.Controls.Add(this.button_new_sales_record);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSales";
            this.Text = "Sales";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSales_FormClosing);
            this.Load += new System.EventHandler(this.FormSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button button_new_sales_record;
        private System.Windows.Forms.Button button_edit_record;
        private System.Windows.Forms.Button button_delete;
    }
}