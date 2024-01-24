internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Fórmula da equação: ax + b = 0");
        Console.WriteLine("=================================");

        Console.WriteLine("Defina o valor de A:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("=================================");

        Console.WriteLine("Defina o valor de B");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("=================================");


        if(a == 0)
        {
            Console.WriteLine("A equação nao é do primeiro grau pois A nao pode ser = 0 ");
        }
        else
        {
            double x = -b / a;
            Console.WriteLine($"{a}x + {b} = 0 -> {Math.Abs(x)}");

        }
       



        












    }
}