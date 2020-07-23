using System;

namespace SerialisationApp
{
    [Serializable()]
    public class Loan
    {
        public double LoanAmount { get; set; }
        public double InterestRatePercent { get; set; }
        [field: NonSerialized()]
        public DateTime TimeLastLoaded { get; set; }
        public int Term { get; set; }
        public string Customer { get; set; }

        public Loan(double loanAmount, double interestRatePercent, int term, string customer)
        {
            LoanAmount = loanAmount;
            InterestRatePercent = interestRatePercent;
            Term = term;
            Customer = customer;
            TimeLastLoaded = DateTime.Now;
        }
    }
}
