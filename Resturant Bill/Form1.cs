using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Resturant_Bill
{
    public partial class Form1 : Form
    {
        //for Listing all items in the gridView
        List<String> items = new List<String>();
        //By Default Bill set to 0
        private double SubTotal = 0.0;
        private double Total = 0.0;
        private double Tax = 0.0;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        private void InitializeDataTable()
        {
            // Create DataTable
            dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Price", typeof(double));
        }
        private void AddItemToDataGridView(string itemName, string category, double price)
        {
            // Add item and price to DataTable
            dt.Rows.Add(itemName, category, price);

            // Display DataTable in DataGridView
            dataGridView1.DataSource = dt;
        }

        private void CalculateBill(double price)
        {
            SubTotal += price;
            textBox1.Text = SubTotal.ToString("N2");
            Tax = 0.75 * SubTotal;
            textBox2.Text = Tax.ToString("N2");
            Total = SubTotal + Tax;
            textBox3.Text = Total.ToString("N2");
        }
        private void AppetizerscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Price = getPrice(AppetizerscomboBox.SelectedIndex, "Appetizers");
            items.Add(AppetizerscomboBox.Text + "\t" + Price.ToString());
            AddItemToDataGridView(AppetizerscomboBox.Text, "Appetizers", Price);
            CalculateBill(Price);
        }
        private void BeveragescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Price = getPrice(BeveragescomboBox.SelectedIndex, "Beverages");
            items.Add(BeveragescomboBox.Text + "\t" + Price.ToString());
            AddItemToDataGridView(BeveragescomboBox.Text, "Beverages", Price);
            CalculateBill(Price);
        }
        private void DessertdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Price = getPrice(DessertdcomboBox.SelectedIndex, "Desserts");
            items.Add(DessertdcomboBox.Text + "\t" + Price.ToString());
            AddItemToDataGridView(DessertdcomboBox.Text, "Desserts", Price);
            CalculateBill(Price);

        }
        private void MaincoursecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Price = getPrice(MaincoursecomboBox.SelectedIndex, "Main Courses");
            items.Add(MaincoursecomboBox.Text + "\t" + Price.ToString());
           AddItemToDataGridView(MaincoursecomboBox.Text, "Main Courses", Price);
            CalculateBill(Price);
        }
        public double getPrice(int indexNum, string itemType)
        {
            double price = 0.0;
            if (itemType == "beverage")
            {
                switch (indexNum)
                {
                    case 0:
                        price = 1.95;
                        break;
                    case 1:
                        price = 1.50;
                        break;
                    case 2:
                        price = 1.25;
                        break;
                    case 3:
                        price = 2.95;
                        break;
                    case 4:
                        price = 2.50;
                        break;
                    case 5:
                        price = 1.50;
                        break;
                }
            }
            else if (itemType == "appetizer")
            {
                switch (indexNum)
                {
                    case 0:
                        price = 5.95;
                        break;
                    case 1:
                        price = 6.95;
                        break;
                    case 2:
                        price = 8.95;
                        break;
                    case 3:
                        price = 8.95;
                        break;
                    case 4:
                        price = 10.95;
                        break;
                    case 5:
                        price = 12.95;
                        break;
                    case 6:
                        price = 6.95;
                        break;
                    case 7:
                        price = 4.45;
                        break;
                    case 8:
                        price = 5.45;
                        break;
                }
            }
            else if (itemType == "dessert")
            {
                switch (indexNum)
                {
                    case 0:
                        price = 5.95;
                        break;
                    case 1:
                        price = 3.95;
                        break;
                    case 2:
                        price = 5.95;
                        break;
                    case 3:
                        price = 4.95;
                        break;
                    case 4:
                        price = 5.95;
                        break;
                }
            }
            else
            {
                switch (indexNum)
                {
                    case 0:
                        price = 13.95;
                        break;
                    case 1:
                        price = 13.95;
                        break;
                    case 2:
                        price = 11.95;
                        break;
                    case 3:
                        price = 19.95;
                        break;
                    case 4:
                        price = 20.95;
                        break;
                    case 5:
                        price = 18.95;
                        break;
                    case 6:
                        price = 13.95;
                        break;
                    case 7:
                        price = 14.45;
                        break;
                    case 8:
                        price = 15.45;
                        break;
                }
            }

            return price;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubTotal = 0.0;
            Tax = 0.0;
            Total = 0.0;
            items.Clear();
            dataGridView1.DataSource = dt;
            dt.Rows.Clear();
            textBox1.Text = SubTotal.ToString("N2");
            textBox2.Text = Tax.ToString("N2");
            textBox3.Text = Total.ToString("N2");
        }
    }
}
