using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void SearchCust_Click(object sender, EventArgs e)
        {
            // Note we are converting the text of type string to the matching type of int32 in the database

            firstNameDataGridViewTextBoxColumn.CustomerRow customerRow = firstNameDataGridViewTextBoxColumn.Customer.FindByID(Int32.Parse(textBox1.Text));
        }
    }
}
