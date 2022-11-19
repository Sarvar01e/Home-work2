namespace Home_work2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");

            string str1;

            str1 = Console.ReadLine();

            Console.WriteLine("Enter number 2");

            string str2;

            str2 = Console.ReadLine();

            Console.WriteLine("Enter number 3");
            string str3;

            str3 = Console.ReadLine();

            int a = Convert.ToInt32(str1);
            int b = Convert.ToInt32(str2);
            int d = Convert.ToInt32(str3);

            int result1 = a + b + d;
            int result2 = a * b * d;

            Console.WriteLine("summ is\t" + result1);
            Console.WriteLine("product of numbers is\t" + result2);
        }
    }
}