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
    public partial class FormAddEditInv : Form
    {

        public struct Inventory
        {
            int Barcode;
                
        }

        public FormAddEditInv()
        {
            InitializeComponent();
        }

        private void DGV_AddEditInv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            //Clears information
            for (int r = 0; r < DGV_AddEditInv.Rows.Count; r++)
            {
                for (int c = 0; c < DGV_AddEditInv.Columns.Count; c++)
                {
                    DGV_AddEditInv.Rows[r].Cells[c].Value = null;
                }
            }
            Close();
        }

        private void AddEditInv_Load(object sender, EventArgs e)
        {

        }

        private void bt_save_Click(object sender, EventArgs e)
        {

            int ColumnCount = DGV_AddEditInv.Columns.Count;
            int RowCount = DGV_AddEditInv.Rows.Count;

            //This flags make sure you can save
            bool saveflag = true;

            //This compensates for the error that
            //a new row is created every time you 
            //enter into a new line in the DGV
            bool lastrowemptyflag = false;

            int r = 0;
            int c = 0;

            int intparse;
            double doubleparse;

            //makes sure there is nothing empty
            if (RowCount > 1)
            {
                foreach (DataGridViewCell cell in DGV_AddEditInv.Rows[RowCount - 1].Cells)
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


            if (DGV_AddEditInv.Rows.Count == 0)
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


                        if (DGV_AddEditInv.Rows[r].Cells[c].Value == null)
                        {
                            MessageBox.Show(DGV_AddEditInv.Columns[c].HeaderText + " is Empty");
                            saveflag = false;
                        }

                        else if (DGV_AddEditInv.Columns[c].HeaderText == "Barcode" && int.TryParse(DGV_AddEditInv.Rows[r].Cells[c].Value.ToString(), out intparse) == false)
                        {
                            MessageBox.Show(DGV_AddEditInv.Columns[c].HeaderText + " Not an Integer");
                            saveflag = false;
                        }

                        else if (DGV_AddEditInv.Columns[c].HeaderText == "Stock" && int.TryParse(DGV_AddEditInv.Rows[r].Cells[c].Value.ToString(), out ColumnCount) == false)
                        {
                            MessageBox.Show(DGV_AddEditInv.Columns[c].HeaderText + " Not a Number");
                            saveflag = false;
                        }

                        else if (DGV_AddEditInv.Columns[c].HeaderText == "Price Per Item" && double.TryParse(DGV_AddEditInv.Rows[r].Cells[c].Value.ToString(), out doubleparse) == false)
                        {
                            MessageBox.Show(DGV_AddEditInv.Columns[c].HeaderText + "Not a Number, don't include $ at the start");
                            saveflag = false;
                        }
                    }
                }
                if (saveflag == true)
                {


                    //Saving code here; To notepad file???
                }





            }
        }
    }
}
