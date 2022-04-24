using System;
using System.Collections.Generic;
using System.Text;

namespace sprint1yuvi
{
    abstract class Expense
    {
        // private attributes of the base class Expense
        private int claimnum;
        private DateTime date;
        private string staffname;
        private string reason;

        // public getters and setters
        // have set all attributes to read-write access
        public int Claimnum { get => claimnum; set => claimnum = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Staffname { get => staffname; set => staffname = value; }
        public string Reason { get => reason; set => reason = value; }

        // constructor without parameters
        public Expense()
        {
            Claimnum = 0;
            Date = new DateTime();
            Staffname = "";
            Reason = "";
        }

        // Parameterised Constructors
        public Expense(int pClaimnum, DateTime pDate,
             string pStaffname, string pReason)
        {
            Claimnum = pClaimnum;
            Date = pDate;
            Staffname = pStaffname;
            Reason = pReason;
        }

        //ToString Function
        public override string ToString()
        {
            string ans = Convert.ToString(this.Claimnum)  + Convert.ToString(this.Date).Split(" ")[0] 
                 + this.Staffname + this.Reason;
            return ans;
        }

    }

    //Travel class with base class Expense
    class Travel : Expense
    {
        //private attributes
        private String type;
        private int cost;

        //properties getters and setters
        public string Type { get => type; set => type = value; }
        public int Cost { get => cost; set => cost = value; }

        //Constructors without Parameters
        public Travel()
        {
            Type = "";
            Cost = 0;
        }

        //Parameterised Constructors
        public Travel(int pClaimnum, DateTime pDate,
             string pStaffname, string pReason, string pType, int pCost) :
            base(pClaimnum, pDate, pStaffname, pReason)
        {
            Type = pType;
            Cost = pCost;
        }

        //overriding ToString()
        public override string ToString()
        {
            string ans = base.ToString() + this.Type + "£" + Convert.ToString(this.Cost);
            return ans;
        }
    }
    class Accomodation : Expense
    {
        // private attributes
        private int nights;
        private int costpernight;
        private bool meals;
        private int mealcost;

        //properties getters and setters
        public int Nights { get => nights; set => nights = value; }
        public int Costpernight { get => costpernight; set => costpernight = value; }
        public bool Meals { get => meals; set => meals = value; }
        public int Mealcost { get => mealcost; set => mealcost = value; }

        //Constructors without Parameters
        public Accomodation()
        {
            Nights = 0;
            Costpernight = 0;
            Meals = false;
            Mealcost = 0;
        }

        //Parameterised Constructors
        public Accomodation(int pClaimnum, DateTime pDate, string pStaffname, string pReason, int pNights, int pCostpernights, bool pMeals, int pMealcost) :
            base(pClaimnum, pDate, pStaffname, pReason)
        {
            Nights = pNights;
            Costpernight = pCostpernights;
            Meals = pMeals;
            if (!Meals) Mealcost = pMealcost;
            else Mealcost = 0;
        }
        //overriding Tostring()
        public override string ToString()
        {
            string ans = base.ToString() + Convert.ToString(this.Nights) + "£" + Convert.ToString(this.Costpernight) + Convert.ToString(Meals)+ "£" + Convert.ToString(Mealcost);
            return ans;
        }

    }
}
