internal class Program
{
    private static void Main(string[] args)
    {
        string textAge = "23";
        int age = Convert.ToInt32(textAge);
        Console.WriteLine(age);

        string textBigNumber = "-900000000";
        long BigNumber = Convert.ToInt64(textBigNumber);
        Console.WriteLine(BigNumber);

        string textNegative = "-55,2";
        double Negative = Convert.ToDouble(textNegative);
        Console.WriteLine(Negative);

        string textPrecision = "5,000001";
        float Precision = Convert.ToSingle(textPrecision);
        Console.WriteLine(Precision);

        string textMonay = "14,99M";
        decimal monay = Convert.ToDecimal(textMonay);
        Console.WriteLine(monay);

        Console.ReadKey();
    }
}