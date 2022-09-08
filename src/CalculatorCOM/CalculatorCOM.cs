using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Windows.Forms;

namespace CalculatorCOM
{
    [ClassInterface(ClassInterfaceType.None)]
    [ComSourceInterfaces(typeof(ICalculatorCOM))]
    [ComVisible(true)]
    [ProgId("CalculatorCOM.CalculatorCOM")]
    [Guid("3FD21873-9C26-4F3E-A3EB-31992D13B353")]
    public class CalculatorCOM : ICalculatorCOM
    {
        public CalculatorCOM()
        {

        }

        public int Sum(int val1, int val2)
        {
            try
            {
                return val1 + val2;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void ToJSON(BusinessObj businessObj, string outputPath)
        {
            if (string.IsNullOrEmpty(businessObj.BusinessName))
                MessageBox.Show("Business Name can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

            var jsonString = JsonSerializer.Serialize(businessObj);
            File.WriteAllText(outputPath, jsonString);
        }
    }
}
