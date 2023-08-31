namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            OVERLODE.Add(4,3);
            OVERLODE.Add(4.6, 3.9);
            Console.WriteLine("how much money did you have");
            int yestMon = int.Parse(Console.ReadLine());
            Console.WriteLine("how much money do you have");
            int todayMon = int.Parse(Console.ReadLine());
            OVERLODE.Add(true, yestMon, todayMon);
        }
    }
}
