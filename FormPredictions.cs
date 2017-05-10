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
    public partial class FormPredictions : Form
    {
        public FormPredictions()
        {
            InitializeComponent();

        }

        private void FormPredictions_Load(object sender, EventArgs e)
        {
            BringToFront();
            Database.Instance.BindInventoryToListBox(listBox_items);
            List<InventoryItem> itemList = Database.Instance.ShowItem();

            txt_search_tags.Text = "";
            for (int i = 0; i< itemList.Count; i++)
            {
                string temp = itemList[i].Tag;
                if(listBox_tags.Items.Contains(temp) != true)
                    listBox_tags.Items.Add(temp);
            }


            txt_search_items.ForeColor = SystemColors.GrayText;
            txt_search_items.Text = "Search Items Here...";
            txt_search_tags.ForeColor = SystemColors.GrayText;
            txt_search_tags.Text = "Search Tags Here...";
        }

        private void FormPredictions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void txt_Search_items_Leave(object sender, EventArgs e)
        {
            if (txt_search_items.Text.Length == 0)
            {
                txt_search_items.ForeColor = SystemColors.GrayText;
                txt_search_items.Text = "Search Items Here...";
            }
        }

        private void txt_Search_items_Enter(object sender, EventArgs e)
        {
            if (txt_search_items.Text == "Search Items Here...")
            {
                txt_search_items.Text = "";
                txt_search_items.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_Search_items_TextChanged(object sender, EventArgs e)
        {
            BindingSource tempSource = new BindingSource();
            tempSource.DataSource = typeof(InventoryItem);

            //Only items that have the same name in the text box will be shown
            if (txt_search_items.Text != "Search Items Here...")
            {
                foreach (InventoryItem item in Database.Instance.ShowItem())
                {
                    if (item.ItemName.Contains(txt_search_items.Text))
                    {
                        tempSource.Add(item);
                    }
                }

                listBox_items.DataSource = tempSource;
            }
        }

        private void txt_Search_tags_TextChanged(object sender, EventArgs e)
        {
            BindingSource tempSource = new BindingSource();
            tempSource.DataSource = typeof(String);
            List<InventoryItem> itemList = Database.Instance.ShowItem();            
            
            //Only items that have the same name in the text box will be shown
            if (txt_search_tags.Text != "Search Tags Here...")
            {
                foreach (InventoryItem item in Database.Instance.ShowItem())
                {
                    if (item.Tag.Contains(txt_search_tags.Text))
                    {
                        {
                            if (tempSource.Contains(item.Tag) != true)
                            {
                                tempSource.Add(item.Tag);
                            }
                            
                        }
                        
                    }
                }

                listBox_tags.DataSource = tempSource;
            }
        }


        private void txt_Search_tags_Leave(object sender, EventArgs e)
        {
            if (txt_search_tags.Text.Length == 0)
            {
                txt_search_tags.ForeColor = SystemColors.GrayText;
                txt_search_tags.Text = "Search Tags Here...";
            }
        }

        private void txt_Search_tags_Enter(object sender, EventArgs e)
        {
            if (txt_search_tags.Text == "Search Tags Here...")
            {
                txt_search_tags.Text = "";
                txt_search_tags.ForeColor = SystemColors.WindowText;
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_results_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// When clicked it will predict the sales of the selected item
        /// </summary>

        private void button_predict_items_Click(object sender, EventArgs e)
        {
            InventoryItem invItem = (InventoryItem)listBox_items.SelectedItem;
            if (invItem != null)
            {
                //Clear the table and then predict
                ClearResults();
                PredictSales(invItem);
            }
            else
            {
                MessageBox.Show("Please select an item to predict");
            }
        }

        /// <summary>
        /// Clears the results dgv
        /// </summary>
        private void ClearResults()
        {
            dgv_results.Rows.Clear();
        }

        /// <summary>
        /// Predicts the salse of one item and inserts it into the table
        /// </summary>
        /// <param name="theItem">The item to be predicted</param>
        private void PredictSales(InventoryItem theItem)
        {
            DateTime lastMonth = DateTime.Today;
            lastMonth = lastMonth.AddMonths(-1);
            List<SalesRecord> theSales = Database.Instance.ShowRecord().FindAll(x => DateTime.Compare(DateTime.Parse(x.Date), lastMonth) > -1);

            int quantity = 0;

            foreach (SalesRecord sales in theSales)
            {
                SalesRecordItem itemRecord = sales.Items.Find(x => x.Barcode == theItem.Barcode);
                if (itemRecord != null)
                {
                    quantity += itemRecord.Quantity;
                }
            }

            if (radioButton_weekly.Checked)
            {
                quantity /= 4;
            }

            double price = quantity * theItem.PricePerUnit;

            dgv_results.Rows.Add(theItem.ItemName, quantity, price);
        }

        private Tuple<int, double> PredictTagSales(InventoryItem theItem, string theTag )
        {
            int quantity = 0;
            double price = 0;
            if(theItem.Tag == theTag)
            {
                DateTime lastMonth = DateTime.Today;
                lastMonth = lastMonth.AddMonths(-1);
                List<SalesRecord> theSales = Database.Instance.ShowRecord().FindAll(x => DateTime.Compare(DateTime.Parse(x.Date), lastMonth) > -1);

                foreach (SalesRecord sales in theSales)
                {
                    SalesRecordItem itemRecord = sales.Items.Find(x => x.Barcode == theItem.Barcode);
                    if (itemRecord != null)
                    {
                        quantity += itemRecord.Quantity;
                    }
                }

                if (radioButton_weekly.Checked)
                {
                    quantity /= 4;
                }

                price = quantity * theItem.PricePerUnit;
            }            

            return Tuple.Create(quantity, price);
            
        }

        private void button_predict_tags_Click(object sender, EventArgs e)
        {
            string theTag = (string)listBox_tags.SelectedItem;
            int quantity = 0;
            double price = 0;
            InventoryItem invItem;
            List<InventoryItem> itemList = new List<InventoryItem>();
            itemList = Database.Instance.ShowItem();
            //Clear the table and then predict
            ClearResults();
            for (int i = 0; i < itemList.Count; i++)
            {
                invItem = itemList[i];
                Tuple<int, double> result = PredictTagSales(invItem, theTag);
                quantity = quantity + result.Item1;
                price = price + result.Item2;
            }
            dgv_results.Rows.Add(theTag, quantity, price);

        }

        private void listBox_tags_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
