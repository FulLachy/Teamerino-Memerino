namespace Teamerino_Memerino
{
    partial class FormAddSalesRecord
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
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddEditSales)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(724, 39);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(93, 25);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(724, 200);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(93, 25);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // DGV_AddEditSales
            // 
            this.DGV_AddEditSales.AllowUserToAddRows = false;
            this.DGV_AddEditSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AddEditSales.Location = new System.Drawing.Point(266, 12);
            this.DGV_AddEditSales.Name = "DGV_AddEditSales";
            this.DGV_AddEditSales.Size = new System.Drawing.Size(452, 213);
            this.DGV_AddEditSales.TabIndex = 2;
            this.DGV_AddEditSales.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_AddEditSales_CellEndEdit);
            this.DGV_AddEditSales.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGV_AddEditSales_CellValidating);
            // 
            // bt_Remove
            // 
            this.bt_Remove.Location = new System.Drawing.Point(724, 8);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(93, 25);
            this.bt_Remove.TabIndex = 3;
            this.bt_Remove.Text = "Remove Row";
            this.bt_Remove.UseVisualStyleBackColor = true;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(13, 13);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(208, 20);
            this.txt_Search.TabIndex = 4;
            this.txt_Search.Text = "Search Here... U+1F50D";
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // button_move_item
            // 
            this.button_move_item.Location = new System.Drawing.Point(231, 109);
            this.button_move_item.Name = "button_move_item";
            this.button_move_item.Size = new System.Drawing.Size(29, 23);
            this.button_move_item.TabIndex = 6;
            this.button_move_item.Text = "->";
            this.button_move_item.UseVisualStyleBackColor = true;
            this.button_move_item.Click += new System.EventHandler(this.button_move_item_Click);
            // 
            // listBox_items
            // 
            this.listBox_items.FormattingEnabled = true;
            this.listBox_items.Location = new System.Drawing.Point(13, 43);
            this.listBox_items.Name = "listBox_items";
            this.listBox_items.Size = new System.Drawing.Size(208, 173);
            this.listBox_items.TabIndex = 7;
            // 
            // FormAddSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 257);
            this.ControlBox = false;
            this.Controls.Add(this.listBox_items);
            this.Controls.Add(this.button_move_item);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.DGV_AddEditSales);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddSalesRecord";
            this.ShowIcon = false;
            this.Text = "People Health Pharmacy (Add or Edit Sales Record)";
            this.TopMost = true;
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
    }
}