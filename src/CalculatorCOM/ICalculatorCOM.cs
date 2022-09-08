using System.Runtime.InteropServices;


namespace CalculatorCOM
{
    [ComVisible(true)]
    [Guid("00BD7975-AFE0-4C57-BBFA-7EEB6E815BF7")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface ICalculatorCOM
    {
        [DispId(3)]
        int Sum(int val1, int val2);
        [DispId(5)]
        void ToJSON(BusinessObj businessObj, string outputPath);
    }
}
