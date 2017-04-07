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
            this.clm_Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_LowLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_PricePerItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Add_Inv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Barcode,
            this.clm_ItemName,
            this.clm_InStock,
            this.clm_LowLevel,
            this.clm_PricePerItem});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // clm_Barcode
            // 
            this.clm_Barcode.HeaderText = "Barcode";
            this.clm_Barcode.Name = "clm_Barcode";
            // 
            // clm_ItemName
            // 
            this.clm_ItemName.HeaderText = "Item Name";
            this.clm_ItemName.Name = "clm_ItemName";
            // 
            // clm_InStock
            // 
            this.clm_InStock.HeaderText = "InStock";
            this.clm_InStock.Name = "clm_InStock";
            // 
            // clm_LowLevel
            // 
            this.clm_LowLevel.HeaderText = "Low Stock Level";
            this.clm_LowLevel.Name = "clm_LowLevel";
            // 
            // clm_PricePerItem
            // 
            this.clm_PricePerItem.HeaderText = "Price Per Item";
            this.clm_PricePerItem.Name = "clm_PricePerItem";
            // 
            // bt_Add_Inv
            // 
            this.bt_Add_Inv.Location = new System.Drawing.Point(559, 12);
            this.bt_Add_Inv.Name = "bt_Add_Inv";
            this.bt_Add_Inv.Size = new System.Drawing.Size(100, 23);
            this.bt_Add_Inv.TabIndex = 1;
            this.bt_Add_Inv.Text = "Add Inventory";
            this.bt_Add_Inv.UseVisualStyleBackColor = true;
            this.bt_Add_Inv.Click += new System.EventHandler(this.bt_Add_Inv_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 286);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button bt_Add_Inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_LowLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_PricePerItem;
        private System.Windows.Forms.Button button1;
    }
}