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
         * Code is stored at:
         * https://github.com/ahyou-mug/CityGymRegistrationApp
         
             * * RunTime NOTE 1:
             * * Please set file path to appropriate location
             * * in constant variable 'path' below
             * * RunTime NOTE 2:
             * * This program writes headers out every time
             * * If being used in production then OpenXML should be used.
             * * OpenXML is outside the scope of this assignment.
         */




        // ------------------------------------------------------------------------------------ Methods & Classes separated from controls for cleanliness
        bool conf = false; // variable for ensuring confirm button has been used & form is valid
        const string path = @"C:\Users\Local user\OneDrive - TOPNZ STUDENT (MYOPENPOLYTECHNIC)\Desktop\Customers.csv"; // set path for file

        /// Customer = Class of details
        /// Contains dict of prices & variations
        /// Contains dict of Customer details
        /// Customer details added on Confirm/Sign Up
        public class Customer
        {
            Dictionary<string, dynamic> cust = new Dictionary<string, dynamic>()
            {
                {"Customer Number", null },
                {"First Name", null},// assign fname text box to customer.fname property
                {"Last Name", null},// same
                {"Phone", null},
                {"Birthday", null},
                {"Street Number", null},
                {"Street Name", null},
                {"City", null},
                {"District", null},
                {"Post Code", null},
                {"Emergency Contact", null},
                {"Emergency Phone", null},
                {"Emergency Relationship", null},
                {"Membership Type", null},
                {"Membership Duration", null},
                {"Payment Frequency", null},
                {"Payment Method", null},
                {"Weekly Price", null},
                {"Weekly Amount", null},
                {"Payment Amount", null},
                {"Extras 1", null},
                {"Extras 2", null},
                {"Extras 3", null},
                {"Extras 4", null}
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

            Dictionary<string, dynamic> terms = new Dictionary<string, dynamic>()
        {
            {"Basic", "Basic"},
            {"Regular","Regular"},
            {"Premium","Premium"},
            {"alltime", "24 Hour Access"},
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
            public Dictionary<string, dynamic> Terms { get => terms; set => terms = value; }
        }
        Customer oCust = new Customer(); // Create new object oCust of class Customer(), accessible to all buttons/methods


        /* Validation()
        // Method to validate control inputs
        // for cleanliness have separated from Calculate/Confirm
        // returns conf = false if form not complete
        */
        private void Validation()
        {
            int errorCount = 0; // error counter
            bool noError = false; // error bool
            foreach (var cont in PersonalDetails.Controls.OfType<TextBox>())
            {
                if (cont.Text == "") // if textbox empty color red
                { 
                    cont.BackColor = System.Drawing.Color.Aqua;
                    errorCount++; // increment error count
                }
            }
            foreach (var cont in PersonalDetails.Controls.OfType<ComboBox>())
            {
                if (cont.SelectedItem == null) // something has not been entered in combobox
                {
                    cont.BackColor = System.Drawing.Color.Aqua;
                    errorCount++; // increment error count
                }
            }
            foreach (var cont in PersonalDetails.Controls.OfType<DateTimePicker>())
            {
                var max = DateTime.Today.Year - 16; // Todays date -16 years, excludes people too young
                var min = DateTime.Today.Year - 100; // todays date - 100 years, excludes people too old
                if (cont.Value.Year < min || cont.Value.Year > max)
                {
                    cont.BackColor = System.Drawing.Color.Aqua;
                    errorCount++; // increment error count
                    System.Windows.Forms.MessageBox.Show("Birthday is incorrect, must be older than 16 or younger than 100.");
                }
            }

            foreach (var cont in MembershipType.Controls.OfType<RadioButton>()) // checks membership type
            {
                if (cont.Checked)
                {
                    noError = true; // if any of the items are checked then j = true
                }
            }
            if (!noError)
            {
                MembershipType.BackColor = System.Drawing.Color.Aqua; // if not checked color groupbox
                errorCount++; // increment error count
            }
            noError = false;
            foreach (var cont in Duration.Controls.OfType<RadioButton>())
            {
                if (cont.Checked)
                {
                    noError = true; // if any of items checked then j = true
                }
            }
            if (!noError)
            {
                Duration.BackColor = System.Drawing.Color.Aqua; // if not checked color groupbox
                errorCount++; // increment error count
            }
            noError = false;
            foreach (var cont in payFreq.Controls.OfType<RadioButton>())
            {
                if (cont.Checked)
                {
                    noError = true; // if any of items checked then j = true
                }
            }
            if (!noError)
            {
                payFreq.BackColor = System.Drawing.Color.Aqua; // if not checked color groupbox
                errorCount++; // increment error count
            }
            noError = false;
            foreach (var cont in payMethod.Controls.OfType<RadioButton>())
            {
                if (cont.Checked)
                {
                    noError = true; // if any of items checked then j = true
                }
            }
            if (!noError)
            {
                payMethod.BackColor = System.Drawing.Color.Aqua; // if not checked color groupbox
                errorCount++; // increment error count
            }
            if (errorCount > 0 || noError == false) // if error count > 0 or error bool false
            {
                System.Windows.Forms.MessageBox.Show("There are empty sections in registration - please complete to proceed");
                Reset(); // empties customer.dict to prevent value double ups on resubmission
            }
            else if (errorCount == 0 && noError == true) // if error count =0 and noerror = true
            {
                conf = true; // form is valid and ready to submit
            }
        }



        /* Rest
         * Resets values in dictionary
         * Leaves Keys
         * Ensures that file always has the same headers
         */
        private void Reset()
        {   
            oCust.Cust.Keys.ToList().ForEach (x => oCust.Cust[x] = null) ;
        }



        /* ClearForm
        // Checks the controls in the form
        // If has been marked in red sets bg to white
        // Clears text boxes if not empty
        */
        private void clearForm()
        {
            // clear text boxes
            foreach (Control x in PersonalDetails.Controls.OfType<TextBox>())
            {
                x.Text = "";
                x.BackColor = System.Drawing.Color.White;// reset color to white for new form
            }
            // reset datetimepicker
            foreach (var x in PersonalDetails.Controls.OfType<DateTimePicker>())
            {
                x.Value = DateTime.Today;
                x.BackColor = System.Drawing.Color.White;
            }
            // reset combo box
            foreach (var x in PersonalDetails.Controls.OfType<ComboBox>())
            {
                x.SelectedIndex = -1;
                x.BackColor = System.Drawing.Color.White;
            }
            // reset controls in MembershipType groupbox
            foreach (var rdo in MembershipType.Controls.OfType<RadioButton>())
            {
                //rdo.Checked = false; // commented to stop tab stops from changing
                rdo.BackColor = SystemColors.Control;
            }
            // reset buttons in Duration groupbox
            foreach (var rdo in Duration.Controls.OfType<RadioButton>())
            {
                //rdo.Checked = false; // commented to stop tab stops from changing
                rdo.BackColor = SystemColors.Control;
            }
            // reset payment frequency buttons
            foreach (var rdo in payFreq.Controls.OfType<RadioButton>())
            {
                //rdo.Checked = false; // commented to stop tab stops from changing
                rdo.BackColor = SystemColors.Control;
            }
            // reset pay method buttons
            foreach (var rdo in payMethod.Controls.OfType<RadioButton>())
            {
                //rdo.Checked = false; // commented to stop tab stops from changing
                rdo.BackColor = SystemColors.Control;
            }
            // reset checkboxes
            foreach (var x in extras.Controls.OfType<CheckBox>())
            {
                x.Checked = false;
                x.BackColor = SystemColors.Control;
            }
            // reset Customer details box
            foreach (var x in orderdeets.Controls.OfType<RichTextBox>())
            {
                x.Text = "";
                x.BackColor = SystemColors.Control;
            }
            Reset(); // Clears customer dict as no values in form, prevents exception
        }

        



        /* GetData - gets data from form
        // Runs through boxes and outputs text in 'order details'
        // for user to confirm before sign up. Checks for empty
        // boxes and highlights. Calculates weekly price and
        // payment amount.
        */
        public void GetData()
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
            //oCust.Cust.Add("Weekly Price", 0);
            // loop through buttons in MembershipType groupbox
            foreach (var rdo in MembershipType.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)// if button is checked
                {
                    oCust.Cust["Membership Type"] = oCust.Terms[rdo.Name];// assign value of box to customer.membershipType property
                    oCust.Cust["Weekly Price"] = oCust.Prices[oCust.Cust["Membership Type"]];// add corresponding value from customer.prices dict to weekly price
                }
            }
            // loop through buttons in Duration groupbox
            foreach (var rdo in Duration.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)// if button is checked
                {
                    oCust.Cust["Membership Duration"] = oCust.Terms[rdo.Name];// add membership duration value to customer class
                    oCust.Cust["Weekly Price"] += oCust.Prices[rdo.Name];// add value to weekly price (add -nums for discounts)
                }
            }
            // loop through payment frequency buttons
            foreach (var rdo in payFreq.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)// if button is checked
                {
                    oCust.Cust["Payment Frequency"] = oCust.Terms[rdo.Name];// asssign value to payment frequency property
                }
            }
            // loop through pay method buttons
            foreach (var rdo in payMethod.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)// if button is checked
                {
                    oCust.Cust["Payment Method"] = oCust.Terms[rdo.Name];// assign payment method to customer
                }
            }
            // Calculate base memeberhips 1%
            if (oCust.Cust["Payment Method"] == "Direct Debit")// if customer is paying by direct debit
            {
                oCust.Cust["Weekly Amount"] = oCust.Cust["Weekly Price"] * 0.99;// multiply their weekly total by .99 to apply 1% discount
            }
            else
            {
                oCust.Cust["Weekly Amount"] = oCust.Cust["Weekly Price"];
            }
            // Loop through extras and add to base
            int i = 1;// Only for counter iteration
            foreach (var rdo in extras.Controls.OfType<CheckBox>())
            {
                if (rdo.Checked)// if the box is checked
                {
                    oCust.Cust["Weekly Price"] += (oCust.Prices[rdo.Name]);// adds price to weekly total
                    oCust.Cust["Extras " + i] = oCust.Terms[rdo.Name];
                    i++;
                }
            }
            // Multiplies the weekly amount for the appropriate payment frequencey
            if (oCust.Cust["Payment Frequency"] == "Fortnightly")
            {
                oCust.Cust["Payment Amount"] = oCust.Cust["Weekly Amount"] * 2; // double for fortnightly
            }
            else if (oCust.Cust["Payment Frequency"] == "Monthly")
            {
                oCust.Cust["Payment Amount"] = oCust.Cust["Weekly Amount"] * 4; // *4 for monthly
            }
            else if (oCust.Cust["Payment Frequency"] == "Annually")
            {
                // if membership is 12 months or more then * 52
                if (oCust.Cust["Membership Duration"] == "12 Months" || oCust.Cust["Membership Duration"] == "2 Years")
                {
                    oCust.Cust["Payment Amount"] = oCust.Cust["Weekly Amount"] * 52;
                }
                // else multiply by 26 weeks/6 months
                else if (oCust.Cust["Membership Duration"] == "6 Months")
                {
                    oCust.Cust["Payment Amount"] = oCust.Cust["Weekly Amount"] * 26;
                }
                // else multiply by 12 weeks/3 months
                else if (oCust.Cust["Membership Duration"] == "3 Months")
                {
                    oCust.Cust["Payment Amount"] = oCust.Cust["Weekly Amount"] * 12;
                }
            }
        }





        // DisplayInfo
        // Outputs info to the Display box
        public void DisplayInfo()
        {
            // display order subtotal and details for checking before submission
            foreach (var key in oCust.Cust.Keys)
            {
                display1.SelectionFont = new Font(display1.Font, FontStyle.Bold);
                display1.SelectedText += key + ":\n";
                display1.SelectionFont = new Font(display1.Font, FontStyle.Regular);
                display1.SelectedText += oCust.Cust[key] + "\n";
            }
        }





        /* FileOpen
        // Checks if file is open
        // Displays message if file open
        // returns false if file closed
        */
        private bool FileOpen()
        {
            if (File.Exists(path))
            {
                try // try to access file
                {
                    FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Close();
                }
                catch
                {
                    return true;
                }
            }
            return false; // if can access file then file not open
        }




        /* ExportData
        // Checks if file exists, if not creates it
        // Takes input from dictionary
        // Stores in text file in .csv format
        // Sends alert box confirming successful operation
        */
        public void ExportData()
        {
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
                sw.Dispose();
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
                    sw.WriteLine(line2); // write customer dict on line below
                    sw.Close(); // close file
                    sw.Dispose();
                    System.Windows.Forms.MessageBox.Show("Success! New Customer Added."); // display successful message
                    this.clearForm(); //clearform
                    Reset();
                }
            }
        }
//-------------------------------------------------------------------------- Button controls

        /// Confirm Order Button
        /// Calculates values and stores in dict
        private void calculate_Click(object sender, EventArgs e)
        {
            Validation(); // validate form
            if (conf) // if form validated then add data to customer.dict
            {
                Reset(); // clear values in dict
                GetData(); // assign form values to dict
                DisplayInfo(); // display key:value pairs formatted in RTB
            }
        }



        /// Confirm Registration
        /// Exports to file
        private void confirm_Click(object sender, EventArgs e)
        {
            if (conf == true && FileOpen() == false)
            {
                System.Threading.Thread.Sleep(500);// Time for closure to register on system, prevents exception when opening the file
                ExportData();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("File is open already or order has not been confirmed");
            }
        }

        // Clear Form
        // Clears form content/Resets form
        private void form_clear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        /// Cancel
        /// Exits the application
        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


