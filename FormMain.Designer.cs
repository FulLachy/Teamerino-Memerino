using System;

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
            this.button_edit_record = new System.Windows.Forms.Button();
            this.button_inventory = new System.Windows.Forms.Button();
            this.button_reports = new System.Windows.Forms.Button();
            this.button_add_record = new System.Windows.Forms.Button();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // button_edit_record
            // 
            this.button_edit_record.Location = new System.Drawing.Point(723, 71);
            this.button_edit_record.Margin = new System.Windows.Forms.Padding(4);
            this.button_edit_record.Name = "button_edit_record";
            this.button_edit_record.Size = new System.Drawing.Size(124, 28);
            this.button_edit_record.TabIndex = 0;
            this.button_edit_record.Text = "Edit";
            this.button_edit_record.UseVisualStyleBackColor = true;
            this.button_edit_record.Click += new System.EventHandler(this.button_edit_record_Click);
            // 
            // button_inventory
            // 
            this.button_inventory.Location = new System.Drawing.Point(724, 130);
            this.button_inventory.Margin = new System.Windows.Forms.Padding(4);
            this.button_inventory.Name = "button_inventory";
            this.button_inventory.Size = new System.Drawing.Size(124, 28);
            this.button_inventory.TabIndex = 1;
            this.button_inventory.Text = "Inventory";
            this.button_inventory.UseVisualStyleBackColor = true;
            this.button_inventory.Click += new System.EventHandler(this.button_inventory_Click);
            // 
            // button_reports
            // 
            this.button_reports.Location = new System.Drawing.Point(724, 183);
            this.button_reports.Margin = new System.Windows.Forms.Padding(4);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(124, 28);
            this.button_reports.TabIndex = 2;
            this.button_reports.Text = "Reports";
            this.button_reports.UseVisualStyleBackColor = true;
            this.button_reports.Click += new System.EventHandler(this.button_reports_Click);
            // 
            // button_add_record
            // 
            this.button_add_record.Location = new System.Drawing.Point(723, 26);
            this.button_add_record.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add_record.Name = "button_add_record";
            this.button_add_record.Size = new System.Drawing.Size(125, 25);
            this.button_add_record.TabIndex = 3;
            this.button_add_record.Text = "Add";
            this.button_add_record.UseVisualStyleBackColor = true;
            this.button_add_record.Click += new System.EventHandler(this.button_add_record_Click);
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(5, 12);
            this.dgv_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.ReadOnly = true;
            this.dgv_main.RowTemplate.Height = 24;
            this.dgv_main.Size = new System.Drawing.Size(711, 288);
            this.dgv_main.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(861, 313);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.button_add_record);
            this.Controls.Add(this.button_reports);
            this.Controls.Add(this.button_inventory);
            this.Controls.Add(this.button_edit_record);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);

        }

 
        #endregion

        private System.Windows.Forms.Button button_edit_record;
        private System.Windows.Forms.Button button_inventory;
        private System.Windows.Forms.Button button_reports;
        private System.Windows.Forms.Button button_add_record;
        private System.Windows.Forms.DataGridView dgv_main;
    }
}

