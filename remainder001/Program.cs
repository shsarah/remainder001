namespace remainder01;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Birinci ededi daxil edin:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ikinci ededi daxil edin:");
        int b = Convert.ToInt32(Console.ReadLine());
        int c = a % b;
        Console.WriteLine("Qaliq:" + c);
    }
}
