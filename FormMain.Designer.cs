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
            this.bt_quit = new System.Windows.Forms.Button();
            this.button_prediction = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // button_edit_record
            // 
            this.button_edit_record.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_edit_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_edit_record.Location = new System.Drawing.Point(899, 163);
            this.button_edit_record.Name = "button_edit_record";
            this.button_edit_record.Size = new System.Drawing.Size(190, 49);
            this.button_edit_record.TabIndex = 0;
            this.button_edit_record.Text = "Edit";
            this.button_edit_record.UseVisualStyleBackColor = true;
            this.button_edit_record.Click += new System.EventHandler(this.button_edit_record_Click);
            // 
            // button_inventory
            // 
            this.button_inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_inventory.Location = new System.Drawing.Point(899, 269);
            this.button_inventory.Name = "button_inventory";
            this.button_inventory.Size = new System.Drawing.Size(190, 49);
            this.button_inventory.TabIndex = 1;
            this.button_inventory.Text = "Inventory";
            this.button_inventory.UseVisualStyleBackColor = true;
            this.button_inventory.Click += new System.EventHandler(this.button_inventory_Click);
            // 
            // button_reports
            // 
            this.button_reports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_reports.Location = new System.Drawing.Point(899, 324);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(190, 49);
            this.button_reports.TabIndex = 2;
            this.button_reports.Text = "Reports";
            this.button_reports.UseVisualStyleBackColor = true;
            this.button_reports.Click += new System.EventHandler(this.button_reports_Click);
            // 
            // button_add_record
            // 
            this.button_add_record.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_add_record.Location = new System.Drawing.Point(899, 109);
            this.button_add_record.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_record.Name = "button_add_record";
            this.button_add_record.Size = new System.Drawing.Size(190, 49);
            this.button_add_record.TabIndex = 3;
            this.button_add_record.Text = "Add";
            this.button_add_record.UseVisualStyleBackColor = true;
            this.button_add_record.Click += new System.EventHandler(this.button_add_record_Click);
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            this.dgv_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_main.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(11, 110);
            this.dgv_main.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.ReadOnly = true;
            this.dgv_main.RowTemplate.Height = 24;
            this.dgv_main.Size = new System.Drawing.Size(883, 517);
            this.dgv_main.TabIndex = 4;
            this.dgv_main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_main_CellContentClick);
            // 
            // bt_quit
            // 
            this.bt_quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bt_quit.Location = new System.Drawing.Point(899, 578);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(190, 49);
            this.bt_quit.TabIndex = 5;
            this.bt_quit.Text = "Quit";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // button_prediction
            // 
            this.button_prediction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_prediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_prediction.Location = new System.Drawing.Point(899, 443);
            this.button_prediction.Name = "button_prediction";
            this.button_prediction.Size = new System.Drawing.Size(190, 49);
            this.button_prediction.TabIndex = 6;
            this.button_prediction.Text = "Predictions";
            this.button_prediction.UseVisualStyleBackColor = true;
            this.button_prediction.Click += new System.EventHandler(this.button_prediction_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(270, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(561, 85);
            this.lbl_Title.TabIndex = 7;
            this.lbl_Title.Text = "People Health Pharmacy";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1098, 635);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.button_prediction);
            this.Controls.Add(this.bt_quit);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.button_add_record);
            this.Controls.Add(this.button_reports);
            this.Controls.Add(this.button_inventory);
            this.Controls.Add(this.button_edit_record);
            this.Name = "FormMain";
            this.Text = "People Health Pharmacy (Main Menu)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

 
        #endregion

        private System.Windows.Forms.Button button_edit_record;
        private System.Windows.Forms.Button button_inventory;
        private System.Windows.Forms.Button button_reports;
        private System.Windows.Forms.Button button_add_record;
        private System.Windows.Forms.Button button_prediction;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.Label lbl_Title;
    }
}

