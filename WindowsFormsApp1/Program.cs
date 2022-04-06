using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Customer
    {
        public string fname;
        public string lname;
        public string phone;
        public int addNum;
        public string addStreet;
        public string addCity;
        public string addState;
        public int postCode;
        public string emConName;
        public string emConNum;
        public string emConRel;
        public string memType;
        public string memDuration;
        public string payFreq;
        public string payMethod;
        public int weeklyPrice = 0;
        public int payAmount = 0;
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
            {"fortnight","Fortnightly"},
            {"monthly", "Monthly"},
            {"annually", "Annually"}
        };
        public Dictionary<string, string> Terms { get => terms; set => terms = value; } 
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
