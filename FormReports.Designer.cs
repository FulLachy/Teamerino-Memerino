namespace Teamerino_Memerino
{
    partial class FormReports
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
            this.button_back = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label_dateStarting = new System.Windows.Forms.Label();
            this.dgv_Report = new System.Windows.Forms.DataGridView();
            this.groupBox_StartingMode = new System.Windows.Forms.GroupBox();
            this.radio_Weekly = new System.Windows.Forms.RadioButton();
            this.radio_Monthly = new System.Windows.Forms.RadioButton();
            this.button_Export = new System.Windows.Forms.Button();
            this.button_Regenerate = new System.Windows.Forms.Button();
            this.label_Dates = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Report)).BeginInit();
            this.groupBox_StartingMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_back.Location = new System.Drawing.Point(956, 571);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(169, 52);
            this.button_back.TabIndex = 0;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker.Location = new System.Drawing.Point(966, 144);
            this.dateTimePicker.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(270, 26);
            this.dateTimePicker.TabIndex = 1;
            // 
            // label_dateStarting
            // 
            this.label_dateStarting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_dateStarting.AutoSize = true;
            this.label_dateStarting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_dateStarting.Location = new System.Drawing.Point(952, 119);
            this.label_dateStarting.Name = "label_dateStarting";
            this.label_dateStarting.Size = new System.Drawing.Size(120, 24);
            this.label_dateStarting.TabIndex = 2;
            this.label_dateStarting.Text = "Date Starting:";
            // 
            // dgv_Report
            // 
            this.dgv_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Report.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgv_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Report.Location = new System.Drawing.Point(12, 119);
            this.dgv_Report.Name = "dgv_Report";
            this.dgv_Report.Size = new System.Drawing.Size(931, 504);
            this.dgv_Report.TabIndex = 3;
            // 
            // groupBox_StartingMode
            // 
            this.groupBox_StartingMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_StartingMode.Controls.Add(this.radio_Weekly);
            this.groupBox_StartingMode.Controls.Add(this.radio_Monthly);
            this.groupBox_StartingMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox_StartingMode.Location = new System.Drawing.Point(956, 194);
            this.groupBox_StartingMode.Name = "groupBox_StartingMode";
            this.groupBox_StartingMode.Size = new System.Drawing.Size(255, 62);
            this.groupBox_StartingMode.TabIndex = 4;
            this.groupBox_StartingMode.TabStop = false;
            this.groupBox_StartingMode.Text = "Mode";
            // 
            // radio_Weekly
            // 
            this.radio_Weekly.AutoSize = true;
            this.radio_Weekly.Checked = true;
            this.radio_Weekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radio_Weekly.Location = new System.Drawing.Point(23, 26);
            this.radio_Weekly.Name = "radio_Weekly";
            this.radio_Weekly.Size = new System.Drawing.Size(78, 24);
            this.radio_Weekly.TabIndex = 0;
            this.radio_Weekly.TabStop = true;
            this.radio_Weekly.Text = "Weekly";
            this.radio_Weekly.UseVisualStyleBackColor = true;
            // 
            // radio_Monthly
            // 
            this.radio_Monthly.AutoSize = true;
            this.radio_Monthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radio_Monthly.Location = new System.Drawing.Point(121, 26);
            this.radio_Monthly.Name = "radio_Monthly";
            this.radio_Monthly.Size = new System.Drawing.Size(82, 24);
            this.radio_Monthly.TabIndex = 0;
            this.radio_Monthly.Text = "Monthly";
            this.radio_Monthly.UseVisualStyleBackColor = true;
            // 
            // button_Export
            // 
            this.button_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_Export.Location = new System.Drawing.Point(956, 335);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(169, 52);
            this.button_Export.TabIndex = 0;
            this.button_Export.Text = "Export";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // button_Regenerate
            // 
            this.button_Regenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Regenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_Regenerate.Location = new System.Drawing.Point(956, 277);
            this.button_Regenerate.Name = "button_Regenerate";
            this.button_Regenerate.Size = new System.Drawing.Size(169, 52);
            this.button_Regenerate.TabIndex = 5;
            this.button_Regenerate.Text = "Regenerate";
            this.button_Regenerate.UseVisualStyleBackColor = true;
            this.button_Regenerate.Click += new System.EventHandler(this.button_Regenerate_Click);
            // 
            // label_Dates
            // 
            this.label_Dates.AutoSize = true;
            this.label_Dates.Location = new System.Drawing.Point(12, 9);
            this.label_Dates.Name = "label_Dates";
            this.label_Dates.Size = new System.Drawing.Size(0, 13);
            this.label_Dates.TabIndex = 6;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(327, 17);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(561, 85);
            this.lbl_Title.TabIndex = 9;
            this.lbl_Title.Text = "People Health Pharmacy";
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1246, 635);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.label_Dates);
            this.Controls.Add(this.button_Regenerate);
            this.Controls.Add(this.groupBox_StartingMode);
            this.Controls.Add(this.dgv_Report);
            this.Controls.Add(this.label_dateStarting);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.button_back);
            this.MinimizeBox = false;
            this.Name = "FormReports";
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReports_FormClosing);
            this.Load += new System.EventHandler(this.FormReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Report)).EndInit();
            this.groupBox_StartingMode.ResumeLayout(false);
            this.groupBox_StartingMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label_dateStarting;
        private System.Windows.Forms.DataGridView dgv_Report;
        private System.Windows.Forms.GroupBox groupBox_StartingMode;
        private System.Windows.Forms.RadioButton radio_Weekly;
        private System.Windows.Forms.RadioButton radio_Monthly;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Button button_Regenerate;
        private System.Windows.Forms.Label label_Dates;
        private System.Windows.Forms.Label lbl_Title;
    }
}