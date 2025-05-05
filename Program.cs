namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of the small ones : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of the large ones : ");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = (x * 25) + (y * 35);
            Console.WriteLine($"the totle price after the tax : {((z * 0.06) + z)}");
        }
    }
}
