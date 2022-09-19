using System.IO.Abstractions;
using System.IO.Abstractions.TestingHelpers;
using CalculatorCOM;
using Moq;

namespace CalculatorCOMTest
{
    public class CalculatorCOMTest
    {
        //readonly Mock<IFileIOWrapper> _mockFileSystemMock;
        readonly Mock<IFileSystem> _fileSystemMock;

        private readonly CalculatorCOM.CalculatorCOM _calculator;
        private readonly Mock<ICalculatorCOM> _mock;

        public CalculatorCOMTest()
        {
            //_mockFileSystemMock = new Mock<IFileIOWrapper>();
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
            var path = "C:\\01WORKSPACE\\04IRASSG\\BusinessObj.json";

            var mockFileIO = new Mock<IFileSystem>();
            var mockFileSystem = new MockFileSystem();
            mockFileSystem.AddFile(path, businessObj.ToString());

            var sut = new CalculatorCOM.CalculatorCOM(mockFileSystem);
            sut.ToJSON(businessObj, path);

            MockFileData mockOutputFile = mockFileSystem.GetFile(path);
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
