using System.ComponentModel.DataAnnotations;

namespace CalculatorCOM
{
    public class BusinessObj
    {
        public string BusinessName { get; set; }
        public string RegistrationNumber { get; set; }
        public SubmissionDate SubmissionDate { get; set; }
    }

    public class SubmissionDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }
}
