using CalculatorCOM;
using Moq;

namespace CalculatorCOMTest
{
    public class CalculatorCOMTest
    {
        private readonly Mock<ICalculatorCOM> _mock;
        public CalculatorCOMTest()
        {
            _mock = new Mock<ICalculatorCOM>();
        }
        [Fact]
        public void Sum_With_Expected_Result()
        {
            int val1 = 5;
            int val2 = 2;
            int expected = 7;

            //arrange
            _mock.Setup(x => x.Sum(val1, val2)).Returns(7);

            //act 
            int result = _mock.Object.Sum(val1, val2);

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Sum_With_Incorrect_Result()
        {
            int val1 = 8;
            int val2 = 5;
            int expected = 11;

            //arrange
            _mock.Setup(x => x.Sum(val1, val2)).Returns(13);

            //act 
            int result = _mock.Object.Sum(val1, val2);

            //assert
            Assert.NotEqual(expected, result);
        }

        [Fact]
        public void ToJSON_With_Correct_Object()
        {
            var businessObj = SampleBusinessObj();
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
    }
}