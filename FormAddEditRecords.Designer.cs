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
            this.clm_Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddEditSales)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(463, 11);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(93, 25);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(463, 40);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(93, 25);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // DGV_AddEditSales
            // 
            this.DGV_AddEditSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AddEditSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Barcode,
            this.clm_ItemName,
            this.clm_Amount,
            this.clm_Price});
            this.DGV_AddEditSales.Location = new System.Drawing.Point(12, 12);
            this.DGV_AddEditSales.Name = "DGV_AddEditSales";
            this.DGV_AddEditSales.Size = new System.Drawing.Size(445, 213);
            this.DGV_AddEditSales.TabIndex = 2;
            this.DGV_AddEditSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_AddEditSales_CellContentClick);
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
            // clm_Amount
            // 
            this.clm_Amount.HeaderText = "Amount";
            this.clm_Amount.Name = "clm_Amount";
            // 
            // clm_Price
            // 
            this.clm_Price.HeaderText = "Price";
            this.clm_Price.Name = "clm_Price";
            // 
            // FormAddSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 257);
            this.ControlBox = false;
            this.Controls.Add(this.DGV_AddEditSales);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddSalesRecord";
            this.ShowIcon = false;
            this.Text = "Add Sales Record";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddEditRecord_FormClosing);
            this.Load += new System.EventHandler(this.FormEditRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddEditSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.DataGridView DGV_AddEditSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Price;
    }
}