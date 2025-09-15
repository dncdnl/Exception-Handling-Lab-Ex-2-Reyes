using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exception_Handling_Lab_Ex_2_Reyes
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }
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
        }
    }
}
