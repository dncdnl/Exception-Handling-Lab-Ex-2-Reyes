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
        private string _description;
        //Int
        private int _Quantity;
        //Double
        private double _SellingPrice;
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
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                //Exception here
                return name;
        }
        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
                //Exception here
                return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                //Exception here
                return Convert.ToDouble(price);
        }
    }
}
