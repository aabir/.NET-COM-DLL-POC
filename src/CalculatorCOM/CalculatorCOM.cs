using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace CalculatorCOM
{
    [ComVisible(true)]
    [Guid("3FD21873-9C26-4F3E-A3EB-31992D13B353")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("CalculatorCOM.CalculatorCOM")]
    public class CalculatorCOM : ICalculatorCOM
    {
        public int Sum(int val1, int val2)
        {
            try
            {
                if (val1 < 0)
                    throw new ArgumentException();

                if (val2 < 0)
                    throw new ArgumentException();

                return val1 + val2;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
        }

        public void ToJSON(BusinessObj businessObj, string outputPath)
        {
            var jsonString = JsonSerializer.Serialize(businessObj);
            File.WriteAllText(outputPath, jsonString);
        }
    }
}
