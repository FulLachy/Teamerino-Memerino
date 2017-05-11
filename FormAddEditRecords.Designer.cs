namespace Teamerino_Memerino
{
    partial class FormAddEditRecords
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
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.DGV_AddEditSales = new System.Windows.Forms.DataGridView();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.button_move_item = new System.Windows.Forms.Button();
            this.listBox_items = new System.Windows.Forms.ListBox();
            this.label_Total = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label_total_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddEditSales)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(1058, 171);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(190, 52);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_cancel.Location = new System.Drawing.Point(1058, 583);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(190, 52);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // DGV_AddEditSales
            // 
            this.DGV_AddEditSales.AllowUserToAddRows = false;
            this.DGV_AddEditSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_AddEditSales.BackgroundColor = System.Drawing.Color.Bisque;
            this.DGV_AddEditSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AddEditSales.Location = new System.Drawing.Point(290, 111);
            this.DGV_AddEditSales.Name = "DGV_AddEditSales";
            this.DGV_AddEditSales.Size = new System.Drawing.Size(762, 524);
            this.DGV_AddEditSales.TabIndex = 2;
            this.DGV_AddEditSales.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_AddEditSales_CellEndEdit);
            this.DGV_AddEditSales.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGV_AddEditSales_CellValidating);
            // 
            // bt_Remove
            // 
            this.bt_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove.Location = new System.Drawing.Point(1058, 111);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(190, 53);
            this.bt_Remove.TabIndex = 3;
            this.bt_Remove.Text = "Remove Row";
            this.bt_Remove.UseVisualStyleBackColor = true;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_Search.Location = new System.Drawing.Point(14, 111);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(208, 29);
            this.txt_Search.TabIndex = 4;
            this.txt_Search.Text = "Search Here... U+1F50D";
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // button_move_item
            // 
            this.button_move_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_move_item.Location = new System.Drawing.Point(229, 151);
            this.button_move_item.Name = "button_move_item";
            this.button_move_item.Size = new System.Drawing.Size(54, 53);
            this.button_move_item.TabIndex = 6;
            this.button_move_item.Text = "->";
            this.button_move_item.UseVisualStyleBackColor = true;
            this.button_move_item.Click += new System.EventHandler(this.button_move_item_Click);
            // 
            // listBox_items
            // 
            this.listBox_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox_items.FormattingEnabled = true;
            this.listBox_items.ItemHeight = 20;
            this.listBox_items.Location = new System.Drawing.Point(14, 151);
            this.listBox_items.Name = "listBox_items";
            this.listBox_items.Size = new System.Drawing.Size(208, 484);
            this.listBox_items.TabIndex = 7;
            this.listBox_items.SelectedIndexChanged += new System.EventHandler(this.listBox_items_SelectedIndexChanged);
            // 
            // label_Total
            // 
            this.label_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.Location = new System.Drawing.Point(1135, 552);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(93, 29);
            this.label_Total.TabIndex = 8;
            this.label_Total.Text = "Total: $";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(356, 13);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(561, 85);
            this.lbl_Title.TabIndex = 9;
            this.lbl_Title.Text = "People Health Pharmacy";
            // 
            // label_total_text
            // 
            this.label_total_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_total_text.AutoSize = true;
            this.label_total_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_total_text.Location = new System.Drawing.Point(1058, 554);
            this.label_total_text.Name = "label_total_text";
            this.label_total_text.Size = new System.Drawing.Size(83, 26);
            this.label_total_text.TabIndex = 10;
            this.label_total_text.Text = "Total: $";
            // 
            // FormAddEditRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1255, 639);
            this.ControlBox = false;
            this.Controls.Add(this.label_total_text);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.listBox_items);
            this.Controls.Add(this.button_move_item);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.DGV_AddEditSales);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.MinimizeBox = false;
            this.Name = "FormAddEditRecords";
            this.ShowIcon = false;
            this.Text = "People Health Pharmacy (Add or Edit Sales Record)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddEditRecord_FormClosing);
            this.Load += new System.EventHandler(this.FormEditRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddEditSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.DataGridView DGV_AddEditSales;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button button_move_item;
        private System.Windows.Forms.ListBox listBox_items;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label_total_text;
    }
}