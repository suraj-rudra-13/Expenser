using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sprint1yuvi
{
    public partial class Form1 : Form
    {
        //Declaring a List of Travels and Accomodations to use it in the View Table Part
        List<Travel> Tr = new List<Travel>();
        List<Accomodation> Ac = new List<Accomodation>();
        public Form1()
        {
            InitializeComponent();
            //Adding manual data on initializing of form
            Data();
        }

        private void Data()
        {
            //Data
            Tr.Add(new Travel(1, new DateTime(2020, 12, 31), "Charan", "Honeymoon", "Train", 300));
            Tr.Add(new Travel(2, new DateTime(2015, 12, 31), "Suraj", "Family Vacation", "Cruise", 500));
            Tr.Add(new Travel(3, new DateTime(2015, 12, 31), "Shantha", "Trip", "Plane", 400));
            Tr.Add(new Travel(4, new DateTime(2015, 12, 31), "Vivek", "Honeymoon", "Car", 300));
            Tr.Add(new Travel(5, new DateTime(2015, 12, 31), "Yuvi", "Trek", "Car", 350));
            Ac.Add(new Accomodation(6, new DateTime(2015, 12, 31), "Rishita", "Honeymoon", 4, 200, true, 0));
            Ac.Add(new Accomodation(7, new DateTime(2015, 12, 31), "Tabu", "Trip", 6, 100, true, 0));
            Ac.Add(new Accomodation(8, new DateTime(2015, 12, 31), "Sonu", "Wedding", 3, 150, false, 250));
            Ac.Add(new Accomodation(9, new DateTime(2015, 12, 31), "Shyam", "Family Reunion", 2, 500, true, 0));
            Ac.Add(new Accomodation(10, new DateTime(2015, 12, 31), "Keerthi", "Family Trip", 4, 200, false, 150));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr;
            DataTable Travdata = new DataTable();
            //Adding first column to Travel
            Travdata.Columns.Add("Claimnum");
            Travdata.Columns.Add("Date");
            Travdata.Columns.Add("Staff Name");
            Travdata.Columns.Add("Reason");
            Travdata.Columns.Add("Travel Type");
            Travdata.Columns.Add("Cost");

            foreach (Travel A in Tr)
            {
                dr = Travdata.NewRow();
                dr[0] = A.Claimnum;
                dr[1] = Convert.ToString(A.Date).Split(" ")[0];
                dr[2] = A.Staffname;
                dr[3] = A.Reason;
                dr[4] = A.Type;
                dr[5] = A.Cost;
                Travdata.Rows.Add(dr);
            }
            dataGrid.DataSource = Travdata;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow dr;
            DataTable Accdata = new DataTable();
            //Adding first column to Accomodation
            Accdata.Columns.Add("Claimnum");
            Accdata.Columns.Add("Date");
            Accdata.Columns.Add("Staff Name");
            Accdata.Columns.Add("Reason");
            Accdata.Columns.Add("Total Nights");
            Accdata.Columns.Add("Cost per Night");
            Accdata.Columns.Add("Meals Included");
            Accdata.Columns.Add("Cost of Meal");

            foreach (Accomodation A in Ac)
            {
                dr = Accdata.NewRow();
                dr[0] = A.Claimnum;
                dr[1] = Convert.ToString(A.Date).Split(" ")[0];
                dr[2] = A.Staffname;
                dr[3] = A.Reason;
                dr[4] = A.Nights;
                dr[5] = A.Costpernight;
                dr[6] = A.Meals;
                dr[7] = A.Mealcost;
                Accdata.Rows.Add(dr);
            }
            dataGrid.DataSource = Accdata;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow dr;
            DataTable Expdata = new DataTable();
            //Adding first column to Accomodation
            Expdata.Columns.Add("Claimnum");
            Expdata.Columns.Add("Date");
            Expdata.Columns.Add("Staff Name");
            Expdata.Columns.Add("Reason");

            foreach(Expense E in Ac)
            {
                dr = Expdata.NewRow();
                dr[0] = E.Claimnum;
                dr[1] = Convert.ToString(E.Date).Split(" ")[0];
                dr[2] = E.Staffname;
                dr[3] = E.Reason;
                Expdata.Rows.Add(dr);
            }
            foreach (Expense E in Tr)
            {
                dr = Expdata.NewRow();
                dr[0] = E.Claimnum;
                dr[1] = Convert.ToString(E.Date).Split(" ")[0];
                dr[2] = E.Staffname;
                dr[3] = E.Reason;
                Expdata.Rows.Add(dr);
            }
            dataGrid.DataSource = Expdata;
        }
    }
}
