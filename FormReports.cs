using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Teamerino_Memerino
{
    public partial class FormReports : Form
    {
        public class ReportItem
        {
            private int _barcode = 0;
            private string _itemname = "";
            private int _number_sold = 0;
            private double _price_per_item;

            public ReportItem(int barcode, string itemname, double price_per_item)
            {
                _barcode = barcode;
                _itemname = itemname;
                _price_per_item = price_per_item;
            }

            public int Barcode
            {
                get
                {
                    return _barcode;
                }
            }

            public string ItemName
            {
                get
                {
                    return _itemname;
                }
            }

            public int NumberSold
            {
                get
                {
                    return _number_sold;
                }
            }

            public double IncomeFromItem
            {
                get
                {
                    return (double)_number_sold * _price_per_item;
                }
            }

            public void incrementNumberSold(int number)
            {
                _number_sold += number;
            }

            public String ToCSV()
            {
                return Barcode.ToString() + "," + ItemName + "," + NumberSold.ToString() + "," + IncomeFromItem.ToString();
            }
        }

        private List<ReportItem> _report_items = new List<ReportItem>();
        private BindingSource _reportBinding = new BindingSource();

        private void generate_from_date_range(DateTime start, DateTime end)
        {
            _report_items.Clear();
            _reportBinding.Clear();
            _reportBinding.DataSource = typeof(ReportItem);
            dgv_Report.DataSource = _reportBinding;
            foreach (SalesRecord sr in Database.Instance.ShowRecord())
            {
                if(sr.isDateBetween(start, end))
                {
                    foreach(SalesRecordItem item in sr.Items)
                    {
                        ReportItem r = _report_items.Find(x => x.Barcode == item.Barcode);
                        if (r == null)
                        {
                            r = new ReportItem(item.Barcode, item.ItemName, item.Price / (double)item.Quantity);
                            _reportBinding.Add(r);
                            _report_items.Add(r);
                        }
                        r.incrementNumberSold(item.Quantity);
                    }
                }
            }
        }


        public FormReports()
        {
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            dgv_Report.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Report.AutoResizeColumns();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV|*.csv";
            sfd.Title = "Save sales report";
            sfd.ShowDialog();

            if (sfd.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();
                StreamWriter sw = new StreamWriter(fs);
                foreach (ReportItem r in _report_items)
                    sw.WriteLine(r.ToCSV());
                sw.Flush();
                fs.Flush();
                fs.Close();
            }
        }

        private void FormReports_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void button_Regenerate_Click(object sender, EventArgs e)
        {
            DateTime maxTime;

            if(radio_Weekly.Checked)
            {
                maxTime = dateTimePicker.Value.AddDays(7);
            }
            else
            {
                maxTime = dateTimePicker.Value.AddMonths(1);
            }
            generate_from_date_range(dateTimePicker.Value, maxTime);

            label_Dates.Text = "Showing items sold between " + String.Format("{0:dd/MM/yyyy}", dateTimePicker.Value) + " to " + String.Format("{0:dd/MM/yyyy}", maxTime);
        }
    }
}
