using CalculatorCOM;

namespace CalculatorCOMConsumer
{
    public partial class Form1 : Form
    {
        CalculatorCOM.CalculatorCOM calculator = new CalculatorCOM.CalculatorCOM();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int val1 = Int32.Parse(textVal1.Text);
                int val2 = Int32.Parse(textVal2.Text);

                int sum = calculator.Sum(val1, val2);

                textSumVal.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void buttonGenJson_Click(object sender, EventArgs e)
        {
            var businessObj = new BusinessObj()
            {
                //BusinessName = "Umbrella Corp.",
                RegistrationNumber = "ABC1235",
                SubmissionDate = new SubmissionDate()
                {
                    Day = 08,
                    Month = 09,
                    Year = 2022
                }
            };
            calculator.ToJSON(businessObj, "C:\\01WORKSPACE\\04IRASSG\\BusinessObj.json");
        }
    }
}