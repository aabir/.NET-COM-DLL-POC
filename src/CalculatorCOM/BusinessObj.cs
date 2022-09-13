namespace CalculatorCOM
{
    public class BusinessObj
    {
        public string BusinessName { get; set; }
        public string RegistrationNumber { get; set; }
        private decimal _amount;
        public decimal Amount { get => _amount; set => _amount = decimal.Truncate(value); }
        public SubmissionDate SubmissionDate { get; set; }
    }

    public class SubmissionDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }
}
