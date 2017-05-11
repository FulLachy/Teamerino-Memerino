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
            this.bt_close = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inv)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Inv
            // 
            this.DGV_Inv.AllowUserToAddRows = false;
            this.DGV_Inv.AllowUserToDeleteRows = false;
            this.DGV_Inv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Inv.BackgroundColor = System.Drawing.Color.Bisque;
            this.DGV_Inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Inv.Location = new System.Drawing.Point(12, 108);
            this.DGV_Inv.Name = "DGV_Inv";
            this.DGV_Inv.Size = new System.Drawing.Size(921, 526);
            this.DGV_Inv.TabIndex = 0;
            this.DGV_Inv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Inv_CellContentClick);
            this.DGV_Inv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Inv_CellEndEdit);
            this.DGV_Inv.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_Cell_Validating);
            this.DGV_Inv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGV_Inv_KeyDown);
            // 
            // bt_Add_Inv
            // 
            this.bt_Add_Inv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Add_Inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bt_Add_Inv.Location = new System.Drawing.Point(943, 107);
            this.bt_Add_Inv.Name = "bt_Add_Inv";
            this.bt_Add_Inv.Size = new System.Drawing.Size(221, 48);
            this.bt_Add_Inv.TabIndex = 1;
            this.bt_Add_Inv.Text = "Add Blank Line";
            this.bt_Add_Inv.UseVisualStyleBackColor = true;
            this.bt_Add_Inv.Click += new System.EventHandler(this.bt_Add_Inv_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(943, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete Selected Line";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.remove_Click);
            // 
            // bt_close
            // 
            this.bt_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bt_close.Location = new System.Drawing.Point(943, 586);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(221, 48);
            this.bt_close.TabIndex = 6;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(304, 14);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(561, 85);
            this.lbl_Title.TabIndex = 8;
            this.lbl_Title.Text = "People Health Pharmacy";
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1175, 646);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Add_Inv);
            this.Controls.Add(this.DGV_Inv);
            this.MinimizeBox = false;
            this.Name = "FormInventory";
            this.Text = "People Health Pharmacy (Inventory)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inventory_FormClosing);
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Inv;
        private System.Windows.Forms.Button bt_Add_Inv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label lbl_Title;
    }
}