using CalculatorCOM;
using Moq;

namespace CalculatorCOMTest
{
    public class CalculatorCOMTest
    {
        private readonly CalculatorCOM.CalculatorCOM _calculator;
        private readonly Mock<ICalculatorCOM> _mock;

        public CalculatorCOMTest()
        {
            _calculator = new CalculatorCOM.CalculatorCOM();
            _mock = new Mock<ICalculatorCOM>();
        }
        [Fact]
        public void Sum_With_Expected_Result()
        {
            var val1 = 5;
            var val2 = 2;
            var expected = 7;
            var result = _calculator.Sum(val1, val2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, -5)]
        [InlineData(-5, 5)]
        public void Sum_Throws_Exception(int val1, int val2)
        {
            Assert.Throws<ArgumentException>(() => _calculator.Sum(val1, val2));
        }

        [Fact]
        public void Sum_With_Incorrect_Result()
        {
            var val1 = 8;
            var val2 = 5;
            var expected = 11;
            var result = _calculator.Sum(val1, val2);
            Assert.NotEqual(expected, result);
        }

        [Fact]
        public void ToJSON_With_Correct_Object()
        {
            var businessObj = SampleBusinessObj();
            var path = @"C:\\01WORKSPACE\\04IRASSG\\BusinessObj.json";

            //_mock.Setup(x => x.ToJSON(businessObj, path)).Verifiable();
        }

        [Fact]
        public void ToJSON_With_Invalid_Object()
        {
            var businessObj = InvalidBusinessObj();
            var path = "C:\\01WORKSPACE\\04IRASSG\\BusinessObj.json";
            _mock.Setup(x => x.ToJSON(businessObj, path)).Verifiable();
        }

        private BusinessObj SampleBusinessObj()
        {
            var businessObj = new BusinessObj()
            {
                BusinessName = "November Rain Corp.",
                RegistrationNumber = "XYZ987",
                SubmissionDate = new SubmissionDate()
                {
                    Day = 09,
                    Month = 09,
                    Year = 2024
                }
            };
            return businessObj;
        }

        private BusinessObj InvalidBusinessObj()
        {
            var businessObj = new BusinessObj()
            {
                RegistrationNumber = "XYZ987",
                SubmissionDate = new SubmissionDate()
                {
                    Day = 09,
                    Month = 09,
                    Year = 2024
                }
            };
            return businessObj;
        }
    }
}
