using System.Runtime.InteropServices;


namespace CalculatorCOM
{
    [ComVisible(true)]
    [Guid("e1b4bafa-8300-4336-87f5-d191fc71ff47")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ICalculatorCOM
    {
        [DispId(3)]
        int Sum(int val1, int val2);
        [DispId(5)]
        void ToJSON(BusinessObj businessObj, string outputPath);
    }
}
