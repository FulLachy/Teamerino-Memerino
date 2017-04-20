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
            this.DGV_Inv = new System.Windows.Forms.DataGridView();
            this.bt_Add_Inv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inv)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Inv
            // 
            this.DGV_Inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Inv.Location = new System.Drawing.Point(12, 13);
            this.DGV_Inv.Name = "DGV_Inv";
            this.DGV_Inv.Size = new System.Drawing.Size(545, 256);
            this.DGV_Inv.TabIndex = 0;
            this.DGV_Inv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Inv_CellEndEdit);
            this.DGV_Inv.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_Cell_Validating);
            // 
            // bt_Add_Inv
            // 
            this.bt_Add_Inv.Location = new System.Drawing.Point(563, 13);
            this.bt_Add_Inv.Name = "bt_Add_Inv";
            this.bt_Add_Inv.Size = new System.Drawing.Size(100, 25);
            this.bt_Add_Inv.TabIndex = 1;
            this.bt_Add_Inv.Text = "Add Inventory";
            this.bt_Add_Inv.UseVisualStyleBackColor = true;
            this.bt_Add_Inv.Click += new System.EventHandler(this.bt_Add_Inv_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.remove_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Add_Inv);
            this.Controls.Add(this.DGV_Inv);
            this.Name = "FormInventory";
            this.Text = "Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inventory_FormClosing);
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Inv;
        private System.Windows.Forms.Button bt_Add_Inv;
        private System.Windows.Forms.Button button1;
    }
}