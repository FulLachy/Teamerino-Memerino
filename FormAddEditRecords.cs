using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teamerino_Memerino
{
    public partial class FormAddSalesRecord : Form
    {
        public FormAddSalesRecord()
        {
            InitializeComponent();
        }

        private void FormAddEditRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            int ColumnCount = DGV_AddEditSales.Columns.Count;
            int RowCount = DGV_AddEditSales.Rows.Count;
            bool saveflag = true;
            bool lastrowemptyflag = false;

            int r = 0;
            int c = 0;

            int intparse;
            double doubleparse;

            //makes sure there is nothing empty
            if (RowCount > 1)
            {
                foreach (DataGridViewCell cell in DGV_AddEditSales.Rows[RowCount - 1].Cells)
                {
                    if (cell.Value == null)
                    {
                        lastrowemptyflag = true;
                    }
                }
            }

            if (lastrowemptyflag == true)
            {
                RowCount -= 1;
            }


            if (DGV_AddEditSales.Rows.Count == 0)
            {
                MessageBox.Show("There is nothing to Save");
            }

            
            //Checks for the right data type
            else
            {
                for (r = 0; r < RowCount; r++)
                {
                    for (c = 0; c < ColumnCount; c++)
                    {
                   

                            if (DGV_AddEditSales.Rows[r].Cells[c].Value == null)
                            {
                                MessageBox.Show(DGV_AddEditSales.Columns[c].HeaderText + " is Empty");
                                saveflag = false;
                            }

                            else if (DGV_AddEditSales.Columns[c].HeaderText == "Barcode" && int.TryParse(DGV_AddEditSales.Rows[r].Cells[c].Value.ToString(), out intparse) == false)
                            {
                                MessageBox.Show(DGV_AddEditSales.Columns[c].HeaderText + " Not an Integer");
                                saveflag = false;
                            }

                            else if (DGV_AddEditSales.Columns[c].HeaderText == "Amount" && int.TryParse(DGV_AddEditSales.Rows[r].Cells[c].Value.ToString(), out ColumnCount) == false)
                            {
                                MessageBox.Show(DGV_AddEditSales.Columns[c].HeaderText + " Not a Number");
                                saveflag = false;
                            }

                            else if (DGV_AddEditSales.Columns[c].HeaderText == "Price" && double.TryParse(DGV_AddEditSales.Rows[r].Cells[c].Value.ToString(), out doubleparse) == false)
                            {
                                MessageBox.Show(DGV_AddEditSales.Columns[c].HeaderText + " Not a Proper Number, no $ at the start");
                                saveflag = false;
                            }
                    }
                }
                if (saveflag == true)
                {


                    //Enter THE ACTUAL Saving code here
                }

            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            //Clears information
            for (int r = 0; r < DGV_AddEditSales.Rows.Count; r++)
            {
                for (int c = 0; c < DGV_AddEditSales.Columns.Count; c++)
                {
                    DGV_AddEditSales.Rows[r].Cells[c].Value = null;
                }
            }
            Close();
        }

        private void DGV_AddEditSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormEditRecord_Load(object sender, EventArgs e)
        {
            
        }

    }
}