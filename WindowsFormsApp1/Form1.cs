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
    public partial class RegistrationForm : Form
    {

        public RegistrationForm()
        {
            InitializeComponent();
        }

        /* Author: Tony Hart
         * Purpose: OP BIT502 Assignment 2
         * License: GNU
         * Current Version: 5.216 or thereabouts
         * CityGymRegistration is a registration form for a 
         * fake gym. This form enables the collection of
         * customer details and adding to a .csv file.
         */

        /* Construction Notes:
         * Need to fix validation loop control refs
        */

        /// Customer = Class of details
        /// Contains dict of prices & variations
        /// Contains dict of Customer details
        /// Customer details added on Confirm/Sign Up
         

        // ------------------------------------------------------------------------------------ Methods & Classes separated from controls for cleanliness
        bool conf = false; // variable for ensuring confirm button has been used

        /* Customer Object
         * Contains dicts for customer class
         * Allows calculations & data collection
         * */
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
            {"quarter",0},
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
            {"quarter", "3 Months"},
            {"half", "6 Months"},
            {"oneyear", "12 Months"},
            {"twoyear","2 Years"},
            {"DD","Direct Debit"},
            {"BT", "Bank Transfer"},
            {"CC", "Credit Card"},
            {"Cash", "Cash" },
            {"weekly", "Weekly"},
            {"fortnightly","Fortnightly"},
            {"monthly", "Monthly"},
            {"annually", "Annually"}
        };
            public Dictionary<string, string> Terms { get => terms; set => terms = value; }
        }
        Customer oCust = new Customer(); // Create new object oCust of class Customer(), accessible to all buttons/methods


        // Method to validate control inputs
        // for cleanliness have separated from Calculate/Confirm
        private void validation()
        {
            int j = 0;
            bool k = false;
            foreach (var cont in PersonalDetails.Controls.OfType<TextBox>())
            {
                if (cont.Text == "") // if textbox empty color red
                { 
                    cont.BackColor = System.Drawing.Color.Aqua;
                    j++;
                }
            }
            foreach (var cont in PersonalDetails.Controls.OfType<ComboBox>())
            {
                if (cont.SelectedItem == null) // something has not been entered in combobox
                {
                    cont.BackColor = System.Drawing.Color.Aqua;
                    j++;
                }
            }
            foreach (var cont in PersonalDetails.Controls.OfType<DateTimePicker>())
            {
                var max = DateTime.Today.Year - 16; // Todays date -16 years, excludes people too young
                var min = DateTime.Today.Year - 100; // todays date - 100 years, excludes people too old
                if (cont.Value.Year < min || cont.Value.Year > max)
                {
                    cont.CalendarTitleBackColor = System.Drawing.Color.Aqua;
                    j++;
                }
            }

            foreach (var cont in MembershipType.Controls.OfType<RadioButton>()) // checks membership type
            {
                if (cont.Checked)
                {
                    k = true; // if any of the items are checked then j = true
                }
            }
            if (!k)
            {
                MembershipType.BackColor = System.Drawing.Color.Aqua; // if not checked color groupbox
                j++;
            }
            k = false;
            foreach (var cont in Duration.Controls.OfType<RadioButton>())
            {
                if (cont.Checked)
                {
                    k = true; // if any of items checked then j = true
                }
            }
            if (!k)
            {
                Duration.BackColor = System.Drawing.Color.Aqua; // if not checked color groupbox
                j++;
            }
            k = false;
            foreach (var cont in payFreq.Controls.OfType<RadioButton>())
            {
                if (cont.Checked)
                {
                    k = true; // if any of items checked then j = true
                }
            }
            if (!k)
            {
                payFreq.BackColor = System.Drawing.Color.Aqua; // if not checked color groupbox
                j++;
            }
            k = false;
            foreach (var cont in payMethod.Controls.OfType<RadioButton>())
            {
                if (cont.Checked)
                {
                    k = true; // if any of items checked then j = true
                }
            }
            if (!k)
            {
                payMethod.BackColor = System.Drawing.Color.Aqua; // if not checked color groupbox
                j++;
            }
            if (j > 0 || k == false)
            {
                System.Windows.Forms.MessageBox.Show("There are empty sections in registration - please complete to proceed");
                oCust.Cust.Clear(); // empties customer.dict to prevent key double ups on resubmission
            }
            else if (j == 0 && k == true)
            {
                conf = true;
            }
        }

        /// ClearForm
        /// Checks the controls in the form
        /// If has been marked in red sets bg to white
        /// Clears text boxes if not empty
        private void clearForm()
        {
            // clear text boxes
            foreach (var box in PersonalDetails.Controls.OfType<TextBox>())
            {
                box.Text = "";
                box.BackColor = System.Drawing.Color.White;// reset color to white for new form
            }
            // reset datetimepicker
            foreach (Control x in PersonalDetails.Controls.OfType<DateTimePicker>())
            {
                x.Text = "";
                x.BackColor = System.Drawing.Color.White;
            }
            // reset combo box
            foreach (Control x in PersonalDetails.Controls.OfType<ComboBox>())
            {
                x.Text = "";
                x.BackColor = System.Drawing.Color.White;
            }
            // reset controls in MembershipType groupbox
            foreach (var rdo in MembershipType.Controls.OfType<RadioButton>()) // <--------------------------------------------- build errors, cannot cast. need to rewrite throughout loop
            {
                rdo.Checked = false;
                rdo.BackColor = System.Drawing.Color.White;
            }
            // reset buttons in Duration groupbox
            foreach (var rdo in Duration.Controls.OfType<RadioButton>())
            {
                rdo.Checked = false;
                rdo.BackColor = System.Drawing.Color.White;
            }
            // reset payment frequency buttons
            foreach (var rdo in payFreq.Controls.OfType<RadioButton>())
            {
                rdo.Checked = false;
                rdo.BackColor = System.Drawing.Color.White;
            }
            // reset pay method buttons
            foreach (var rdo in payMethod.Controls.OfType<RadioButton>())
            {
                rdo.Checked = false;
                rdo.BackColor = System.Drawing.Color.White;
            }
            // reset checkboxes
            foreach (var x in extras.Controls.OfType<CheckBox>())
            {
                x.Checked = false;
                x.BackColor = System.Drawing.Color.White;
            }
        }

        // AddData
        // Adds customer data to customer dictionary

        //-------------------------------------------------------------------------- Button controls

        /// Confirm Button
        /// Runs through boxes and outputs text in 'order details'
        /// for user to confirm before sign up. Checks for empty
        /// boxes and highlights. Calculates weekly price and
        /// payment amount.
        private void calculate_Click(object sender, EventArgs e)
        {
            validation(); // validate form
            if (conf) // if form validated then add data to customer.dict
            {
                oCust.Cust["Customer Number"] = Guid.NewGuid().ToString("N");
                oCust.Cust["First Name"] = fname.Text;// assign fname text box to customer.fname property
                oCust.Cust["Last Name"] = lname.Text;// same
                oCust.Cust["Phone"] = phone.Text;
                oCust.Cust["Birthday"] = bday.Text;
                oCust.Cust["Street Number"] = addNum.Text;
                oCust.Cust["Street Name"] = addStreet.Text;
                oCust.Cust["City"] = addCity.Text;
                oCust.Cust["District"] = region.Text;
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
                        oCust.Cust["Weekly Price"] += (oCust.Prices[rdo.Name]);// adds price to weekly total
                        oCust.Cust.Add("Extras " + i, oCust.Terms[rdo.Name]);
                        i++;
                    }
                }
                if (oCust.Cust["Payment Method"] == "Direct Debit")// if customer is paying by direct debit
                {
                    oCust.Cust["Weekly Amount"] = oCust.Cust["Weekly Price"] * 0.99;// multiply their weekly total by .99 to apply 1% discount
                }
                else
                {
                    oCust.Cust["Weekly Amount"] = oCust.Cust["Weekly Price"];
                }
                switch (oCust.Cust["Payment Frequency"])
                {
                    case "Fortnightly":
                        oCust.Cust["Payment Amount"] = oCust.Cust["Weekly Amount"] * 2; // double for fortnightly
                        break;
                    case "Monthly":
                        oCust.Cust["Payment Amount"] = oCust.Cust["Weekly Amount"] * 4; // *4 for monthly
                        break;
                    case "Annually":
                        oCust.Cust["Payment Amount"] = oCust.Cust["Weekly Amount"] * 52; // *52 for annually
                        break;
                }
                // display order subtotal and details for checking before submission ***Doesn't print list of customer extras***
                foreach (var key in oCust.Cust.Keys)
                {
                    display1.Text = display1.Text + "\n" + key + ": \n" + oCust.Cust[key];
                }
            }
        }
        


        /// Confirm Registration
        /// Checks if file exists, if not creates it
        /// Takes input from dictionary
        /// Stores in text file in .csv format
        /// Sends alert box confirming successful operation
        private void confirm_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Local user\OneDrive - TOPNZ STUDENT (MYOPENPOLYTECHNIC)\Desktop\Customers.csv"; // set path for file
            string line1 = "";
            string line2 = "";
            if (!File.Exists(path)) // if file does not exist, create & write headers
            {
                StreamWriter sw = File.CreateText(path); // create file
                foreach (var ind in oCust.Cust.Keys)
                {
                    if (line1 == "")
                    {
                        line1 = ind; // first header item (dict keys)
                    }
                    else
                    {
                        line1 = (line1 + "," + ind); // append other header item (dict keys)
                    }
                }
                foreach (var ind in oCust.Cust.Keys)
                {
                    if (line2 == "")
                    {
                        line2 = oCust.Cust[ind]; // first customer item (dict.keys)
                    }
                    else
                    {
                        line2 = (line2 + "," + oCust.Cust[ind]); // append other customer items (dict.keys)
                    }
                }
                sw.WriteLine(line1); // write headers to file
                sw.WriteLine(line2); // write customer to file
                sw.Close(); // close file
                System.Windows.Forms.MessageBox.Show("Success! New Customer Added."); // display success message
                this.clearForm(); //clear form
            }
            else if (File.Exists(path)) // if file exists just write customer to line
            {
                using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (var ind in oCust.Cust.Keys)
                    {
                        if (line2 == "")
                        {
                            line2 = oCust.Cust[ind]; // first customer item with "," to make .csv format
                        }
                        else
                        {
                            line2 = (line2 + "," + oCust.Cust[ind]); // append other customer items with preceeding comma
                        }
                    }
                    sw.WriteLine(line2); // write entire customer dict on one line
                    sw.Close(); // close file
                    System.Windows.Forms.MessageBox.Show("Success! New Customer Added."); // display successful message
                    this.clearForm(); //clearform
                }
            }
        }

        /// Cancel
        /// Exits the application
        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void form_clear_Click(object sender, EventArgs e)
        {
            this.clearForm();
        }
    }
}


