namespace Teamerino_Memerino
{
    partial class FormMain
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
            this.button_sales_records = new System.Windows.Forms.Button();
            this.button_inventory = new System.Windows.Forms.Button();
            this.button_reports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_sales_records
            // 
            this.button_sales_records.Location = new System.Drawing.Point(12, 12);
            this.button_sales_records.Name = "button_sales_records";
            this.button_sales_records.Size = new System.Drawing.Size(93, 23);
            this.button_sales_records.TabIndex = 0;
            this.button_sales_records.Text = "Sales Records";
            this.button_sales_records.UseVisualStyleBackColor = true;
            this.button_sales_records.Click += new System.EventHandler(this.button_sales_records_Click);
            // 
            // button_inventory
            // 
            this.button_inventory.Location = new System.Drawing.Point(111, 12);
            this.button_inventory.Name = "button_inventory";
            this.button_inventory.Size = new System.Drawing.Size(93, 23);
            this.button_inventory.TabIndex = 1;
            this.button_inventory.Text = "Inventory";
            this.button_inventory.UseVisualStyleBackColor = true;
            this.button_inventory.Click += new System.EventHandler(this.button_inventory_Click);
            // 
            // button_reports
            // 
            this.button_reports.Location = new System.Drawing.Point(210, 12);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(93, 23);
            this.button_reports.TabIndex = 2;
            this.button_reports.Text = "Reports";
            this.button_reports.UseVisualStyleBackColor = true;
            this.button_reports.Click += new System.EventHandler(this.button_reports_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(324, 46);
            this.Controls.Add(this.button_reports);
            this.Controls.Add(this.button_inventory);
            this.Controls.Add(this.button_sales_records);
            this.Name = "FormMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_sales_records;
        private System.Windows.Forms.Button button_inventory;
        private System.Windows.Forms.Button button_reports;
    }
}

