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
            #region Q3
            int[] Num = new int[3];
            int max, min = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Number " + $"{i + 1}" + " : ");
                Num[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = Math.Max(Num[0], Math.Max(Num[1], Num[2]));
            min = Math.Min(Num[0], Math.Min(Num[1], Num[2]));
            Console.WriteLine("Maximum Number is : " + max);
            Console.WriteLine("Minimum Number is : " + min);
            #endregion
            #region Q4
            int Num_Check;
            Console.Write("Enter Number : ");
            Num_Check = Convert.ToInt32(Console.ReadLine());
            if (Num_Check % 2 == 0)
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");
            #endregion
            Console.ReadKey();
        }
    }
}
