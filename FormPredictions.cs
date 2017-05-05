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
    }
}
