namespace Code_Forces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //1- Say Hello With C#
            {
                //    Console.WriteLine("Hello, World!");
            }

            //2- Basic Data Types
            {
                //int int1 = int.Parse(Console.ReadLine());
                //long long2 = long.Parse(Console.ReadLine());
                //decimal decimal3 = decimal.Parse(Console.ReadLine());
                //char char4 = char.Parse(Console.ReadLine());
                //float float5 = float.Parse(Console.ReadLine());
                //double double6 = double.Parse(Console.ReadLine());
                //Console.WriteLine(int1);
                //Console.WriteLine(long2);
                //Console.WriteLine(decimal3);
                //Console.WriteLine(char4);
                //Console.WriteLine(float5);
                //Console.WriteLine(double6);
            }

            //3- Simple Calculator
            {
                //int num1 = int.Parse(Console.ReadLine());
                //int num2 = int.Parse(Console.ReadLine());

                //Console.WriteLine(num1 + num2);
                //Console.WriteLine(num1 * num2);
                //Console.WriteLine(num1 - num2);
            }

            //4- Difference
            {
                //decimal num1 = decimal.Parse(Console.ReadLine());
                //decimal num2 = decimal.Parse(Console.ReadLine());
                //decimal num3 = decimal.Parse(Console.ReadLine());
                //decimal num4 = decimal.Parse(Console.ReadLine());
                //decimal Difference = (num1 * num2) - (num3 * num4);
                //Console.WriteLine(Difference);
            }

            //5- Area of a Circle
            {
                //float raduis = float.Parse(Console.ReadLine());
                //double area = 3.141592653 * raduis * raduis;
                //Console.WriteLine(area);
            }

            //6-  Digits Summation
            {
                //int dig1 = int.Parse(Console.ReadLine());
                //int dig2 = int.Parse(Console.ReadLine());
                //Console.WriteLine($"{(dig1 % 10) + (dig2 % 10)}");
            }

            //7- Summation from 1 to N
            {
                //int num = int.Parse(Console.ReadLine());
                //Console.WriteLine($"{num * (num + 1) / 2}");
            }

            //8- Two numbers floor ceil round
            {
                //double num1 = double.Parse(Console.ReadLine());
                //double num2 = double.Parse(Console.ReadLine());
                //double floor1 = (double)Math.Floor(num1 / num2);
                //double ceil1 = (double)Math.Ceiling(num1 / num2);
                //double round1 = (double)Math.Round(num1 / num2);
                //Console.WriteLine($"floor {num1} / {num2} = {floor1}");
                //Console.WriteLine($"ceil {num1} / {num2} = {ceil1}");
                //Console.WriteLine($"round {num1} / {num2} = {round1}");
            }

            //9- Welcome for you with Conditions
            {
                //    int nr1 = int.Parse(Console.ReadLine());
                //    int nr2 = int.Parse(Console.ReadLine());
                //    if (nr1 >= nr2)
                //    {
                //        Console.WriteLine($"Yes");
                //    }
                //    else
                //    {
                //        Console.WriteLine($"No");
                //    }
                //}
            }

            //10- Multiples
            {
                //int nr1 = int.Parse(Console.ReadLine());
                //int nr2 = int.Parse(Console.ReadLine());
                //if (nr1 < nr2)
                //{
                //    (nr2, nr1) = (nr1, nr2);
                //}

                //if (nr1 % nr2 == 0)
                //{
                //    Console.WriteLine($"Multiples");
                //}
                //else
                //{
                //    Console.WriteLine($"No Multiples");
                //}
            }

            //11- Max and Min
            {
                //int a = int.Parse(Console.ReadLine());
                //int s = int.Parse(Console.ReadLine());
                //int d = int.Parse(Console.ReadLine());
                //if (a >= s && a >= d && s <= d)
                //{
                //    Console.WriteLine($"{s} {a}");
                //}
                //else if (s >= a && s >= d && a <= d)
                //{
                //    Console.WriteLine($"{a} {s}");
                //}
                //else if (d >= a && d >= s && s <= a)
                //{
                //    Console.WriteLine($"{s} {d}");
                //}
                //else if (a >= s && a >= d && s >= d)
                //{
                //    Console.WriteLine($"{d} {a}");
                //}
                //else if (s >= a && s >= d && a >= d)
                //{
                //    Console.WriteLine($"{d} {s}");
                //}
                //else
                //{
                //    Console.WriteLine($"{a} {d}");
                //}
            }

            //12- The Brothers
            {
                //_ = Console.ReadLine();
                //string Last1 = Console.ReadLine();
                //_ = Console.ReadLine();
                //string Last2 = Console.ReadLine();

                //if (Last1 == Last2)
                //{
                //    Console.WriteLine($"ARE Brothers");
                //}
                //else
                //{
                //    Console.WriteLine($"Not");
                //}
            }

            //13- Capital or Small or Digit
            {
                //char enterChar = char.Parse(Console.ReadLine());
                //if (char.IsAsciiLetterUpper(enterChar))
                //{
                //    Console.WriteLine($"ALPHA");
                //    Console.WriteLine($"IS CAPITAL");
                //}
                //else if (char.IsAsciiLetterLower(enterChar))
                //{
                //    Console.WriteLine($"ALPHA");
                //    Console.WriteLine($"IS SMALL");
                //}
                //else
                //{
                //    Console.WriteLine($"IS DIGIT");
                //}
            }

            //14- Char
            {
                //char enterChar = char.Parse(Console.ReadLine());
                //string enterCharrStirng = Convert.ToString(enterChar);
                //if (char.IsAsciiLetterLower(enterChar))
                //{

                //    Console.WriteLine($"{enterCharrStirng.ToUpper()}");
                //}
                //else
                //{
                //    Console.WriteLine($"{enterCharrStirng.ToLower()}");
                //}
            }

            //15- Calculator
            {
                //int nr1 = int.Parse(Console.ReadLine());
                //char signOfCalculate = char.Parse(Console.ReadLine());
                //int nr2 = int.Parse(Console.ReadLine());
                //switch (signOfCalculate)
                //{
                //    case '+':
                //        {
                //            Console.WriteLine($"{nr1 + nr2}");
                //            break;
                //        }
                //    case '-':
                //        {
                //            Console.WriteLine($"{nr1 - nr2}");
                //            break;
                //        }
                //    case '*':
                //        {
                //            Console.WriteLine($"{nr1 * nr2}");
                //            break;
                //        }
                //    case '/':
                //        {
                //            if (nr2 == 0)
                //            {
                //                break;
                //            }
                //            else
                //            {
                //                Console.WriteLine($"{nr1 / nr2}");
                //            }
                //            break;
                //        }
                //}
            }

            //- 16 First digit !
            {
                //int nr1 = int.Parse(Console.ReadLine());
                //int result = nr1 / 1000;
                //if (result % 2 == 0)
                //{
                //    Console.WriteLine($"EVEN");
                //}
                //else
                //{
                //    Console.WriteLine($"ODD");
                //}
            }

            //17- Coordinates of a Point
            {
                //double q1 = double.Parse(Console.ReadLine());
                //double q2 = double.Parse(Console.ReadLine());
                //if (q1 >= 0 && q2 >= 0)
                //{
                //    Console.WriteLine($"Q1");
                //}
                //else if (q1 < 0 && q2 >= 0)
                //{
                //    Console.WriteLine($"Q2");
                //}
                //else if (q1 < 0 && q2 < 0)
                //{
                //    Console.WriteLine($"Q3");
                //}
                //if (q1 >= 0 && q2 < 0)
                //{
                //    Console.WriteLine($"Q4");
                //}
            }

            //18- Age in Days
            {
                //int nr1 = int.Parse(Console.ReadLine());
                //int toYears = nr1 / 365;
                //int resultDays = nr1 - (toYears * 365);
                //int toMonths = resultDays / 30;
                //int toDays = resultDays - (toMonths * 30);
                //Console.WriteLine($"{toYears} years");
                //Console.WriteLine($"{toMonths} months");
                //Console.WriteLine($"{toDays} days");
            }

            //19- Interval
            {
                //double number = double.Parse(Console.ReadLine());
                //if (number is >= 0 and <= 25)
                //{
                //    Console.WriteLine($"Interval [0, 25]");
                //}
                //else if (number is > 25 and <= 50)
                //{
                //    Console.WriteLine($"Interval (25, 50]");
                //}
                //else if (number is > 50 and <= 75)
                //{
                //    Console.WriteLine($"Interval (50, 75]");
                //}
                //else if (number is > 75 and <= 100)
                //{
                //    Console.WriteLine($"Interval (75, 100]");
                //}
                //else
                //{
                //    Console.WriteLine($"Out of Intervals");
                //}
            }

            //20- Sort Numbers
            {
                //int a = int.Parse(Console.ReadLine());
                //int s = int.Parse(Console.ReadLine());
                //int d = int.Parse(Console.ReadLine());
                //if (a >= s && a >= d && s <= d)
                //{
                //    Console.WriteLine($"{s}");
                //    Console.WriteLine($"{d}");
                //    Console.WriteLine($"{a}");
                //    Console.WriteLine($"");
                //    Console.WriteLine($"{a}");
                //    Console.WriteLine($"{s}");
                //    Console.WriteLine($"{d}");
                //}
                //else if (s >= a && s >= d && a <= d)
                //{
                //    Console.WriteLine($"{a}");
                //    Console.WriteLine($"{d}");
                //    Console.WriteLine($"{s}");
                //    Console.WriteLine($"");
                //    Console.WriteLine($"{a}");
                //    Console.WriteLine($"{s}");
                //    Console.WriteLine($"{d}");
                //}
                //else if (d >= a && d >= s && s <= a)
                //{
                //    Console.WriteLine($"{s}");
                //    Console.WriteLine($"{a}");
                //    Console.WriteLine($"{d}");
                //    Console.WriteLine($"");
                //    Console.WriteLine($"{a}");
                //    Console.WriteLine($"{s}");
                //    Console.WriteLine($"{d}");
                //}
                //else if (a >= s && a >= d && s >= d)
                //{
                //    Console.WriteLine($"{d}");
                //    Console.WriteLine($"{s}");
                //    Console.WriteLine($"{a}");
                //    Console.WriteLine($"");
                //    Console.WriteLine($"{a}");
                //    Console.WriteLine($"{s}");
                //    Console.WriteLine($"{d}");
                //}
                //else if (s >= a && s >= d && a >= d)
                //{
                //    Console.WriteLine($"{d}");
                //    Console.WriteLine($"{a}");
                //    Console.WriteLine($"{s}");
                //    Console.WriteLine($"");
                //    Console.WriteLine($"{a}");
                //    Console.WriteLine($"{s}");
                //    Console.WriteLine($"{d}");
                //}
                //else
                //{
                //    Console.WriteLine($"{a}");
                //    Console.WriteLine($"{s}");
                //    Console.WriteLine($"{d}");
                //    Console.WriteLine($"");
                //    Console.WriteLine($"{a}");
                //    Console.WriteLine($"{s}");
                //    Console.WriteLine($"{d}");
                //}
            }

            //21- Float or int
            {
                //float nr1 = float.Parse(Console.ReadLine());
                //int nr2 = (int)nr1;
                //float nr3 = nr1 - nr2;
                //if (nr3 == 0)
                //{
                //    Console.WriteLine($"int {nr2}");
                //}
                //else
                //{
                //    Console.WriteLine($"float {nr2} {nr3}");
                //}
            }

            //22- Comparison
            {
                //int nr1 = int.Parse(Console.ReadLine());
                //char symbol1 = char.Parse(Console.ReadLine());
                //int nr2 = int.Parse(Console.ReadLine());
                //switch (symbol1)
                //{
                //    case '>':
                //        {
                //            if (nr1 > nr2)
                //            {
                //                Console.WriteLine($"Right");
                //            }
                //            else
                //            {
                //                Console.WriteLine($"Wrong");
                //            }
                //            break;
                //        }
                //    case '<':
                //        {
                //            if (nr1 < nr2)
                //            {
                //                Console.WriteLine($"Right");
                //            }
                //            else
                //            {
                //                Console.WriteLine($"Wrong");
                //            }
                //            break;
                //        }
                //    case '=':
                //        {
                //            if (nr1 == nr2)
                //            {
                //                Console.WriteLine($"Right");
                //            }
                //            else
                //            {
                //                Console.WriteLine($"Wrong");
                //            }
                //            break;
                //        }

                //}
            }

            //23- Mathematical Expression
            {
                //int nr1 = int.Parse(Console.ReadLine());
                //char symbol1 = char.Parse(Console.ReadLine());
                //int nr2 = int.Parse(Console.ReadLine());
                //_ = char.Parse(Console.ReadLine());
                //int nr3 = int.Parse(Console.ReadLine());
                //int nr4;
                //if ((nr1 + nr2) == nr3 || (nr1 - nr2) == nr3 || (nr1 * nr2) == nr3 || (nr1 / nr2) == nr3)
                //{
                //    Console.WriteLine($"Yes");
                //}
                //else
                //{
                //    switch (symbol1)
                //    {
                //        case '+':
                //            {
                //                nr4 = nr1 + nr2;
                //                Console.WriteLine(nr4);
                //                break;
                //            }
                //        case '-':
                //            {
                //                nr4 = nr1 - nr2;
                //                Console.WriteLine(nr4);
                //                break;
                //            }
                //        case '*':
                //            {
                //                if (nr2 == 0 && nr1 == 0)
                //                {
                //                    Console.WriteLine($"0");
                //                }
                //                else
                //                {
                //                    nr4 = nr1 * nr2;
                //                    Console.WriteLine(nr4);
                //                }
                //                break;
                //            }
                //        case '/':
                //            {
                //                if (nr2 == 0 && nr1 == 0)
                //                {
                //                    break;
                //                }
                //                else
                //                {
                //                    nr4 = nr1 / nr2;
                //                    Console.WriteLine(nr4);
                //                }
                //                break;
                //            }
                //    }
                //}

            }

            //24- Two intervals
            {
                //    int nr1 = int.Parse(Console.ReadLine());
                //    int nr2 = int.Parse(Console.ReadLine());
                //    int nr3 = int.Parse(Console.ReadLine());
                //    int nr4 = int.Parse(Console.ReadLine());

                //    if (nr2 >= nr3)
                //    {
                //        if (nr1 > nr3 && nr1 < nr4)
                //        {
                //            if (nr2 > nr4)
                //            {
                //                Console.WriteLine($"{nr1} {nr4}");
                //            }
                //            else
                //            {
                //                Console.WriteLine($"{nr1} {nr2}");
                //            }
                //        }
                //        else if (nr2 >= nr3 && nr2 >= nr4)
                //        {
                //            Console.WriteLine($"{nr3} {nr4}");
                //        }
                //        else
                //        {
                //            Console.WriteLine($"{nr3} {nr2}");
                //        }
                //    }
                //    else
                //    {
                //        Console.WriteLine($"-1");
                //    }

            }

            //25-
            {

            }

            //26-Hard Compare
            {
                //decimal nr1 = decimal.Parse(Console.ReadLine());
                //decimal nr2 = decimal.Parse(Console.ReadLine());
                //decimal nr3 = decimal.Parse(Console.ReadLine());
                //decimal nr4 = decimal.Parse(Console.ReadLine());
                //Console.WriteLine(Math.Pow((double)nr1, (double)nr2));
                //if ((Math.Pow((double)nr1, (double)nr2) > Math.Pow((double)nr3, (double)nr4)) || ((nr1 > nr2) && (nr3 > nr4)))
                //{
                //    Console.WriteLine($"YES");
                //}
                //else
                //{
                //    Console.WriteLine($"NO");
                //}

                //27-
                {

                }
            }

            //27-
            {
                List<decimal> fibonacciNumbers = new() { 1, 1 };

                while (fibonacciNumbers.Count < 139)
                {
                    decimal previous = fibonacciNumbers[^1];
                    decimal previous2 = fibonacciNumbers[^2];

                    fibonacciNumbers.Add(previous + previous2);
                }
                foreach (decimal item in fibonacciNumbers)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
