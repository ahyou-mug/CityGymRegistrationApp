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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public class Customer
        {
            Dictionary<string, dynamic> cust = new Dictionary<string, dynamic>()
            {
                
            };
            public Dictionary<string, dynamic> Cust { get => cust; set => cust = value; }
            Dictionary<string, int> prices = new Dictionary<string, int>()
        {
            {"Basic",10},
            {"Regular",15},
            {"Premium",20},
            {"alltime", 1},
            {"PT",20},
            {"Diet",20},
            {"vids",2},
            {"quater",0},
            {"half", 0},
            {"oneyear",-2},
            {"twoyear",-5},
            {"DD",99}
        };
            public Dictionary<string, int> Prices { get => prices; set => prices = value; }

            Dictionary<string, string> terms = new Dictionary<string, string>()
        {
            {"Basic", "Basic"},
            {"Regular","Regular"},
            {"Premium","Premium"},
            {"alltime", "24/7"},
            {"PT", "Personal Trainer"},
            {"Diet", "Diet Consultation"},
            {"vids", "Online Tutorials"},
            {"quater", "3 Months"},
            {"half", "6 Months"},
            {"oneyear", "12 Months"},
            {"twoyear","2 Years"},
            {"DD","Direct Debit"},
            {"BT", "Bank Transfer"},
            {"CC", "Credit Card"},
            {"cash", "Cash" },
            {"weekly", "Weekly"},
            {"fortnightly","Fortnightly"},
            {"monthly", "Monthly"},
            {"annually", "Annually"}
        };
            public Dictionary<string, string> Terms { get => terms; set => terms = value; }
        }
        Customer oCust = new Customer(); // Create new object oCust of class Customer(), accessible to all buttons/methods

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            oCust.Cust["First Name"] = fname.Text;// assign fname text box to customer.fname property
            oCust.Cust["Last Name"]= lname.Text;// same
            oCust.Cust["Phone"] = phone.Text;
            oCust.Cust["Birthday"] = bday.Text;
            oCust.Cust["Street Number"] = addNum.Text;
            oCust.Cust["Street Name"] = addStreet.Text;
            oCust.Cust["City"] = addCity.Text;
            oCust.Cust["District"] = addState.Text;
            oCust.Cust["Post Code"] = postcode.Text;
            oCust.Cust["Emergency Contact"] = emCon.Text;
            oCust.Cust["Emergency Phone"] = emNum.Text;
            oCust.Cust["Emergency Relationship"] = emRel.Text;
            oCust.Cust.Add("Weekly Price", 0);
            foreach (var rdo in MembershipType.Controls.OfType<RadioButton>())// loop through buttons in MembershipType groupbox
            {
                if (rdo.Checked)// if button is checked
                {
                    oCust.Cust["Membership Type"] = oCust.Terms[rdo.Name];// assign value of box to customer.membershipType property
                    oCust.Cust["Weekly Price"] = oCust.Prices[oCust.Cust["Membership Type"]];// add corresponding value from customer.prices dict to weekly price
                }
            }
            foreach (var rdo in Duration.Controls.OfType<RadioButton>())// loop through buttons in Duration groupbox
            {
                if (rdo.Checked)// if button is checked
                {
                    oCust.Cust["Membership Duration"] = oCust.Terms[rdo.Name];// add membership duration value to customer class
                    oCust.Cust["Weekly Price"] += oCust.Prices[rdo.Name];// add value to weekly price (add -nums for discounts)
                }
            }
            foreach (var rdo in payFreq.Controls.OfType<RadioButton>())// loop through payment frequency buttons
            {
                if (rdo.Checked)// if button is checked
                {
                    oCust.Cust["Payment Frequency"] = oCust.Terms[rdo.Name];// asssign value to payment frequency property
                }
            }
            foreach (var rdo in payMethod.Controls.OfType<RadioButton>())// loop through pay method buttons
            {
                if (rdo.Checked)// if button is checked
                {
                    oCust.Cust["Payment Method"] = oCust.Terms[rdo.Name];// assign payment method to customer
                }
            }

            int i = 1;// Only for counter iteration
            foreach (var rdo in extras.Controls.OfType<CheckBox>())// loop through additional options
            {
                if (rdo.Checked)// if the box is checked
                {
                    oCust.Cust["Weekly Price"] += oCust.Prices[rdo.Name];// adds price to weekly total
                    oCust.Cust.Add("Extras "+i, oCust.Terms[rdo.Name]);
                    i++;
                }
            }
            if (oCust.Cust["Payment Method"] == "Direct Debit")// if customer is paying by direct debit
            {
                oCust.Cust["Weekly Price"] = ToFloat(oCust.Cust["Weekly Price"]) * 0.99;// multiply their weekly total by .99 to apply 1% discount
            }
            switch (oCust.Cust["Payment Frequency"])
            {
                case "Fortnightly":
                    oCust.Cust["Payment Amount"] = oCust.Cust["Weekly Price"] * 2;
                    break;
                case "Monthly":
                    oCust.Cust["Payment Amount"] = oCust.Cust["Weekly Price"] * 4;
                    break;
                case "Annually":
                    oCust.Cust["Payment Amount"] = oCust.Cust["Weekly Price"] * 52;
                    break;
            }
            // display order subtotal and details for checking before submission ***Doesn't print list of customer extras***
            foreach (var key in oCust.Cust.Keys)
            {
                display1.Text = display1.Text + "\n" + key + ": \n" + oCust.Cust[key];
            }

        }
        private void confirm_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Local user\OneDrive - TOPNZ STUDENT (MYOPENPOLYTECHNIC)\Desktop\MyTest.txt"; // set path for file
            if (!File.Exists(path)) // check if file exists
            {
                StreamWriter sw = File.CreateText(path); // create file
            }
            TextWriter wr = new StreamWriter(path);
            {
                foreach (var ind in oCust.Cust.Keys)
                {
                    wr.WriteLine(ind + " = " + oCust.Cust[ind]);
                }
            }
            wr.Close();
        }
    }
}
