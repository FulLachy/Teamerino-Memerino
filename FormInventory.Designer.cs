namespace Teamerino_Memerino
{
    partial class FormInventory
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
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Add_Inv = new System.Windows.Forms.Button();
            this.bt_Edit_Inv = new System.Windows.Forms.Button();
            this.bt_Remove_Inv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.ItemName,
            this.InStock,
            this.LowLevel,
            this.PricePerItem});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 286);
            this.dataGridView1.TabIndex = 0;
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
            // InStock
            // 
            this.InStock.HeaderText = "InStock";
            this.InStock.Name = "InStock";
            // 
            // LowLevel
            // 
            this.LowLevel.HeaderText = "Low Stock Level";
            this.LowLevel.Name = "LowLevel";
            // 
            // PricePerItem
            // 
            this.PricePerItem.HeaderText = "Price Per Item";
            this.PricePerItem.Name = "PricePerItem";
            // 
            // bt_Add_Inv
            // 
            this.bt_Add_Inv.Location = new System.Drawing.Point(563, 12);
            this.bt_Add_Inv.Name = "bt_Add_Inv";
            this.bt_Add_Inv.Size = new System.Drawing.Size(100, 23);
            this.bt_Add_Inv.TabIndex = 1;
            this.bt_Add_Inv.Text = "Add Inventory";
            this.bt_Add_Inv.UseVisualStyleBackColor = true;
            // 
            // bt_Edit_Inv
            // 
            this.bt_Edit_Inv.Location = new System.Drawing.Point(564, 42);
            this.bt_Edit_Inv.Name = "bt_Edit_Inv";
            this.bt_Edit_Inv.Size = new System.Drawing.Size(99, 23);
            this.bt_Edit_Inv.TabIndex = 2;
            this.bt_Edit_Inv.Text = "Edit Inventory";
            this.bt_Edit_Inv.UseVisualStyleBackColor = true;
            // 
            // bt_Remove_Inv
            // 
            this.bt_Remove_Inv.Location = new System.Drawing.Point(564, 72);
            this.bt_Remove_Inv.Name = "bt_Remove_Inv";
            this.bt_Remove_Inv.Size = new System.Drawing.Size(99, 23);
            this.bt_Remove_Inv.TabIndex = 3;
            this.bt_Remove_Inv.Text = "Remove Item";
            this.bt_Remove_Inv.UseVisualStyleBackColor = true;
            this.bt_Remove_Inv.Click += new System.EventHandler(this.bt_Remove_Inv_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 310);
            this.Controls.Add(this.bt_Remove_Inv);
            this.Controls.Add(this.bt_Edit_Inv);
            this.Controls.Add(this.bt_Add_Inv);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormInventory";
            this.Text = "Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inventory_FormClosing);
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerItem;
        private System.Windows.Forms.Button bt_Add_Inv;
        private System.Windows.Forms.Button bt_Edit_Inv;
        private System.Windows.Forms.Button bt_Remove_Inv;
    }
}