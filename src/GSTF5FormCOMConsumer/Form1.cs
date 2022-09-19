using Access.SG.GST.JsonConverter;
using Access.SG.GST.JsonConverter.Model;

namespace GSTF5FormCOMConsumer;

public partial class Form1 : Form
{
    GSTF5FormJsonConverter jsonConverter = new GSTF5FormJsonConverter();
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var gstF5Form = new GSTF5Form()
        {
            FilingInfo = new FilingInfo()
            {
                TaxRefNo = "XXXXXXXXXX",
                FormType = "F5",
                DtPeriodStart = "2023-01-01",
                DtPeriodEnd = "2023-03-31"
            },
            Supplies = new Supplies()
            {
                TotStdSupply = 503,
                TotZeroSupply = 454533,
                TotExemptSupply = 326723
            },
            Purchases = new Purchases()
            {
                TotTaxPurchase = 700824
            }
        };

        jsonConverter.ConvertToJson(gstF5Form, "C:\\01WORKSPACE\\04IRASSG\\GSTF5FormPayload.json");
    }
}
