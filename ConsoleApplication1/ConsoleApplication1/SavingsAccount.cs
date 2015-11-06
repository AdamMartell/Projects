using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SavingsAccount : BankAccount
    {
        private double principal;
        private double rate;
        public decimal calculateCharges()
        {

        }
        public double calculateInterest(double time)
        {
            double interest;
            interest = this.principal * this.rate * time;
            return interest;
        }
    }
}
