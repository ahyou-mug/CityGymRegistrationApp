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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            var oCust = new Customer();// Create new class_customer()
            oCust.fname = fname.Text;// assign fname text box to customer.fname property
            oCust.lname = lname.Text;// same
            oCust.phone = phone.Text;
            int.TryParse(addNum.Text, out oCust.addNum);// tryparse - ensure input is valid int
            oCust.addStreet = addStreet.Text;
            oCust.addCity = addCity.Text;
            oCust.addState = addState.Text;
            int.TryParse(postcode.Text, out oCust.postCode);// ensure input is valid int
            oCust.emConName = emCon.Text;
            oCust.emConNum = emNum.Text;
            oCust.emConRel = emRel.Text;
            foreach (var rdo in MembershipType.Controls.OfType<RadioButton>())// loop through buttons in MembershipType groupbox
            {
                if (rdo.Checked)// if button is checked
                {
                    oCust.memType = oCust.Terms[rdo.Name];// assign value of box to customer.membershipType property
                    oCust.weeklyPrice += oCust.Prices[oCust.memType];// add corresponding value from customer.prices dict to weekly price
                }
            }
            foreach (var rdo in Duration.Controls.OfType<RadioButton>())// loop through buttons in Duration groupbox
            {
                if (rdo.Checked)// if button is checked
                {
                    oCust.memDuration = oCust.Terms[rdo.Name];// add membership duration value to customer class
                    oCust.weeklyPrice += oCust.Prices[oCust.memDuration];// add value to weekly price (add -nums for discounts)
                }
            }
            foreach (var rdo in payFreq.Controls.OfType<RadioButton>())// loop through payment frequency buttons
            {
                if (rdo.Checked)// if button is checked
                {
                    oCust.payFreq = oCust.Terms[rdo.Name];// asssign value to payment frequency property
                }
            }
            foreach (var rdo in payMethod.Controls.OfType<RadioButton>())// loop through pay method buttons
            {
                if (rdo.Checked)// if button is checked
                {
                    oCust.payMethod = oCust.Terms[rdo.Name];// assign payment method to customer
                }
            }
            foreach (var rdo in extras.Controls.OfType<CheckBox>())// loop through additional options
            {
                if (rdo.Checked)// if the box is checked
                {
                    oCust.weeklyPrice += oCust.Prices[rdo.Name];// adds price to weekly total
                }
            }
            if (oCust.payMethod == "DD")// if customer is paying by direct debit
            {
                oCust.weeklyPrice = oCust.weeklyPrice * (oCust.Prices[oCust.payMethod] / 100);// multiply their weekly total by .99 to apply 1% discount
            }
            switch (oCust.payFreq)
            {
                case "Fortnightly":
                    oCust.payAmount = oCust.weeklyPrice * 2;
                    break;
                case "Monthly":
                    oCust.payAmount = oCust.weeklyPrice * 4;
                    break;
                case "Annually":
                    oCust.payAmount = oCust.weeklyPrice * 52;
                    break;
            }
            // display order subtotal and details for checking before submission
            display1.Text = "First Name: " + oCust.fname;
            display1.Text = "Last Name: " + oCust.lname;
            display1.Text = "Phone: " + oCust.phone;
            display1.Text = "Emergency Contact: " + oCust.emConName;// Not printing to Display Box
            display1.Text = "Emergency Contact Phone: " + oCust.emConNum;
            display1.Text = "Membership Duration: " + oCust.memDuration;
            display1.Text = "Membership Type: " + oCust.memType;
            display1.Text = "Payment Frequency: " + oCust.payFreq;
            display1.Text = "Payment Method: " + oCust.payMethod;
            display1.Text = "Additional Options: ";
            foreach (var rdo in extras.Controls.OfType<CheckBox>())// loop through additional options
            {
                if (rdo.Checked)// if the box is checked
                {
                    display1.Text = oCust.Terms[rdo.Name];// adds price to weekly total
                }
            }
            display1.Text = "Customer subtotal:\n" + oCust.payAmount;
        }
    }
}
