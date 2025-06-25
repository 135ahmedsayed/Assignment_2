namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int Number;
            Console.Write("Enter Number : ");
            Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 3 == 0 && Number % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            #endregion
            #region Q2
            int num;
            Console.Write("Enter Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
                Console.WriteLine("Negative Number");
            else
                Console.WriteLine("Positive Number");
            #endregion
            Console.ReadKey();
        }
    }
}
