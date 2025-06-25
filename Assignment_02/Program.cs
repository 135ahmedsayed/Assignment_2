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
            #region Q5
            char ch;
            Console.Write("Enter Character Please : ");
            ch = Convert.ToChar(Console.ReadLine()!);
            //I will use Switch
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }
            #endregion
            #region Q6
            int n;
            Console.Write("Enter Number : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}" + ' ');
            }
            #endregion
            #region Q7
            Console.WriteLine("\n");
            int NumMultiplication;
            Console.Write("Enter Number : ");
            NumMultiplication = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 13; i++)
            {
                int result = NumMultiplication * i;
                Console.Write($"{result}" + ' ');
            }
            Console.WriteLine("\n");
            #endregion
            #region Q8
            int Even;
            Console.Write("Enter Number : ");
            Even = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= Even; i++)
            {
                if (i % 2 == 0)
                    Console.Write($"{i}" + ' ');
            }
            #endregion
            #region Q9
            Console.WriteLine("\n");
            int num1, power, t;
            Console.Write("Enter Number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Power: ");
            power = Convert.ToInt32(Console.ReadLine());
            t = num1;
            for (int i = 1; i < power; i++)
                num1 *= t;
            Console.WriteLine("Result is : " + $"{num1}");
            #endregion
            #region Q10
            Console.WriteLine("\n");
            double[] grads = new double[5];
            double Total_marks = 0, Average = 0, Percentage = 0;
            for (int i = 1; i <= grads.Length; i++)
            {
                Console.Write("Enter First Subject " + i + ':');
                grads[i - 1] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < grads.Length; i++)
            {
                Total_marks += grads[i];
            }
            Average = Total_marks / grads.Length;
            Percentage = (Total_marks / (grads.Length * 100)) * 100;
            Console.WriteLine("Total Marks is : " + $"{Total_marks}");
            Console.WriteLine("Average Marks is : " + $"{Average}");
            Console.WriteLine("Percentage is : " + $"{Percentage}");
            Console.WriteLine("\n");
            #endregion
            #region Q11
            int Month;
            Console.Write("Enter Month Number : ");
            Month = Convert.ToInt32(Console.ReadLine());
            switch (Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Days in Month: 31");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Days in Month: 30");
                    break;
                case 2:
                    Console.WriteLine("Days in Month: 28");
                    break;
                default:
                    Console.WriteLine("That is not Month");
                    break;
            }
            Console.WriteLine("\n");
            #endregion
            #region Q12
            int[,] matrix_Identity = new int[n, n];
            Console.Write("Enter Size of Identity Matrix : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write("1");
                    else
                        Console.Write("0");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            #endregion
            #region Q13
            int[,] Sum = new int[2, 2] { { 2, 2 }, { 3, 3 } };
            int temp = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    temp += Sum[i, j];  //{{(0,0),(0,1)},{(1,0),(1,1)}}
                }
            }
            Console.WriteLine("the sum of all elements : " + $"{temp}"); //  = 10
            Console.WriteLine("\n");
            #endregion
            Console.ReadKey();
        }
    }
}
