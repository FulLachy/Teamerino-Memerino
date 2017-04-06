namespace Teamerino_Memerino
{
    partial class FormAddEditInv
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
            this.DGV_AddEditInv = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_PricePerItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_RemoveRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddEditInv)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_AddEditInv
            // 
            this.DGV_AddEditInv.AllowUserToOrderColumns = true;
            this.DGV_AddEditInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AddEditInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.ItemName,
            this.clm_Stock,
            this.clm_PricePerItem});
            this.DGV_AddEditInv.Location = new System.Drawing.Point(12, 39);
            this.DGV_AddEditInv.Name = "DGV_AddEditInv";
            this.DGV_AddEditInv.Size = new System.Drawing.Size(446, 317);
            this.DGV_AddEditInv.TabIndex = 1;
            this.DGV_AddEditInv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_AddEditInv_CellContentClick);
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            // 
            // clm_Stock
            // 
            this.clm_Stock.HeaderText = "Stock";
            this.clm_Stock.Name = "clm_Stock";
            // 
            // clm_PricePerItem
            // 
            this.clm_PricePerItem.HeaderText = "Price Per Item";
            this.clm_PricePerItem.Name = "clm_PricePerItem";
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(359, 10);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(99, 23);
            this.bt_exit.TabIndex = 7;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(254, 10);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(99, 23);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_RemoveRow
            // 
            this.bt_RemoveRow.Location = new System.Drawing.Point(12, 10);
            this.bt_RemoveRow.Name = "bt_RemoveRow";
            this.bt_RemoveRow.Size = new System.Drawing.Size(99, 23);
            this.bt_RemoveRow.TabIndex = 8;
            this.bt_RemoveRow.Text = "Remove Row";
            this.bt_RemoveRow.UseVisualStyleBackColor = true;
            // 
            // FormAddEditInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 368);
            this.Controls.Add(this.bt_RemoveRow);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.DGV_AddEditInv);
            this.Name = "FormAddEditInv";
            this.Text = "AddEditInv";
            this.Load += new System.EventHandler(this.AddEditInv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddEditInv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_AddEditInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_PricePerItem;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_RemoveRow;
    }
}