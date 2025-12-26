using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class CreditCard
    {
        public string Name {  get; set; }
        public decimal AmountOwed {  get; set; }
        public double InterestRate {  get; set; }

        public CreditCard(string name, decimal amountOwed, double interestRate)
        {
            Name = name;
            AmountOwed = amountOwed;
            InterestRate = interestRate;
        }
    }
}
