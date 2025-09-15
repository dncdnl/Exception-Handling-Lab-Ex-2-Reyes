using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exception_Handling_Lab_Ex_2_Reyes
{
    public partial class frmAddProduct : Form
    {
        //declaring Variables and adding the Access Modifiers
        //Strings
        private string _ProductName;
        private string _Category;
        private string _MfgDate;
        private string _ExpDate;
        private string _Description;
        //Int
        private int _Quantity;
        //Double
        private double _SellPrice;
        // Declaring the variable showProductList of BindSource
        BindingSource showProductList;

        public frmAddProduct()
        {
            InitializeComponent();
            //Instantiating the variable showProductList
            showProductList = new BindingSource();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            //Creating an array for the Categories
            string[] ListOfproductsCategory =
             {
                "Bevarages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other"
            };
            // Using a Foreach loop to add the items in the array to the combo box
            foreach (string category in ListOfproductsCategory)
            {
                cbCategory.Items.Add(category);
            }
        }
        // pasting the Given code to the setters and getters
        public string Product_Name(string name)
        {
            // using try and catch for Exception Handling
            try
            {
                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    throw new StringFormatException(name);
                }
            }
            catch (StringFormatException sfx)
            {
                MessageBox.Show("String Format input in product name." + sfx.Message);
            }
            finally
            {
                Console.WriteLine("Only input string in the product name.");
            }
                return name;
        }
        public int Quantity(string qty)
        {
            // Using try and catch for Exception Handling
            try
            {
                if (!Regex.IsMatch(qty, @"^[0-9]"))
                {
                    throw new NumberFormatException(qty);
                }
            }
            catch (NumberFormatException nfx)
            {
                MessageBox.Show("Number Format input in quantity." + nfx.Message);
            }
            finally
            {
                return Convert.ToInt32(qty);
            }
        }
        public double SellingPrice(string price)
        {
            // Using try and catch for Exception Handling
            try
            {
                if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                {
                    throw new CurrenceyFormatException(price);
                }
            }
            catch (CurrenceyFormatException cfx)
            {
                MessageBox.Show("Currency Format input in selling price." + cfx.Message);
            }
            finally
            {
                return Convert.ToDouble(price);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //Pasting the given code in step 10
            _ProductName = Product_Name(txtProductName.Text);
            _Category = cbCategory.Text;
            _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
            _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
            _Description = richTxtDescription.Text;
            _Quantity = Quantity(txtQuantity.Text);
            _SellPrice = SellingPrice(txtSellPrice.Text);
            showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
            _ExpDate, _SellPrice, _Quantity, _Description)); gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; gridViewProductList.DataSource = showProductList;
        }
    }
}
