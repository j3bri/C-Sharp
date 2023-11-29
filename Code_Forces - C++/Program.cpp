#include "Program.h"

namespace Code_Forces
{

	void Program::Main(std::vector<std::wstring> &args)
	{
		{
		//1- Say Hello With C#
			//    Console.WriteLine("Hello, World!");
		}

		{
		//2- Basic Data Types
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

		{
		//3- Simple Calculator
			//int num1 = int.Parse(Console.ReadLine());
			//int num2 = int.Parse(Console.ReadLine());

			//Console.WriteLine(num1 + num2);
			//Console.WriteLine(num1 * num2);
			//Console.WriteLine(num1 - num2);
		}

		{
		//4- Difference
			//decimal num1 = decimal.Parse(Console.ReadLine());
			//decimal num2 = decimal.Parse(Console.ReadLine());
			//decimal num3 = decimal.Parse(Console.ReadLine());
			//decimal num4 = decimal.Parse(Console.ReadLine());
			//decimal Difference = (num1 * num2) - (num3 * num4);
			//Console.WriteLine(Difference);
		}

		{
		//5- Area of a Circle
			//float raduis = float.Parse(Console.ReadLine());
			//double area = 3.141592653 * raduis * raduis;
			//Console.WriteLine(area);
		}

		{
		//6-  Digits Summation
			//int dig1 = int.Parse(Console.ReadLine());
			//int dig2 = int.Parse(Console.ReadLine());
			//Console.WriteLine($"{(dig1 % 10) + (dig2 % 10)}");
		}

		{
		//7- Summation from 1 to N
			//int num = int.Parse(Console.ReadLine());
			//Console.WriteLine($"{num * (num + 1) / 2}");
		}

		{
		//8- Two numbers floor ceil round
			//double num1 = double.Parse(Console.ReadLine());
			//double num2 = double.Parse(Console.ReadLine());
			//double floor1 = (double)Math.Floor(num1 / num2);
			//double ceil1 = (double)Math.Ceiling(num1 / num2);
			//double round1 = (double)Math.Round(num1 / num2);
			//Console.WriteLine($"floor {num1} / {num2} = {floor1}");
			//Console.WriteLine($"ceil {num1} / {num2} = {ceil1}");
			//Console.WriteLine($"round {num1} / {num2} = {round1}");
		}

		{
		//9- Welcome for you with Conditions
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

		{
		//10- Multiples
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

		{
		//11- Max and Min
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

		{
		//12- The Brothers
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

		{
		//13- The Brothers
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

		{
		//14- Char
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

		{
		//15- Calculator
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

		{
		//- 16 First digit !
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

		{
		//17- Coordinates of a Point
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

		{
		//18- Age in Days
			//int nr1 = int.Parse(Console.ReadLine());
			//int toYears = nr1 / 365;
			//int resultDays = nr1 - (toYears * 365);
			//int toMonths = resultDays / 30;
			//int toDays = resultDays - (toMonths * 30);
			//Console.WriteLine($"{toYears} years");
			//Console.WriteLine($"{toMonths} months");
			//Console.WriteLine($"{toDays} days");
		}

		{
		//19- Interval
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

		{
		//20- Sort Numbers
			int a = int.Parse(Console.ReadLine());
			int s = int.Parse(Console.ReadLine());
			int d = int.Parse(Console.ReadLine());
			if (a >= s && a >= d && s <= d)
			{
			   Console.WriteLine($" ");
			   Console.WriteLine($"{s}");
			   Console.WriteLine($"{d}");
			   Console.WriteLine($"{a}");
			   Console.WriteLine($" ");
			   Console.WriteLine($"{a}");
			   Console.WriteLine($"{s}");
			   Console.WriteLine($"{d}");
			}
			else if (s >= a && s >= d && a <= d)
			{
			   Console.WriteLine($" ");
			   Console.WriteLine($"{a}");
			   Console.WriteLine($"{d}");
			   Console.WriteLine($"{s}");
			   Console.WriteLine($" ");
			   Console.WriteLine($"{a}");
			   Console.WriteLine($"{s}");
			   Console.WriteLine($"{d}");
			}
			else if (d >= a && d >= s && s <= a)
			{
			   Console.WriteLine($" ");
			   Console.WriteLine($"{s}");
			   Console.WriteLine($"{a}");
			   Console.WriteLine($"{d}");
			   Console.WriteLine($" ");
			   Console.WriteLine($"{a}");
			   Console.WriteLine($"{s}");
			   Console.WriteLine($"{d}");
			}
			else if (a >= s && a >= d && s >= d)
			{
			   Console.WriteLine($" ");
			   Console.WriteLine($"{d}");
			   Console.WriteLine($"{s}");
			   Console.WriteLine($"{a}");
			   Console.WriteLine($" ");
			   Console.WriteLine($"{a}");
			   Console.WriteLine($"{s}");
			   Console.WriteLine($"{d}");
			}
			else if (s >= a && s >= d && a >= d)
			{
			   Console.WriteLine($" ");
			   Console.WriteLine($"{d}");
			   Console.WriteLine($"{a}");
			   Console.WriteLine($"{s}");
			   Console.WriteLine($" ");
			   Console.WriteLine($"{a}");
			   Console.WriteLine($"{s}");
			   Console.WriteLine($"{d}");
			}
			else
			{
			   Console.WriteLine($" ");
			   Console.WriteLine($"{a}");
			   Console.WriteLine($"{s}");
			   Console.WriteLine($"{d}");
			   Console.WriteLine($" ");
			   Console.WriteLine($"{a}");
			   Console.WriteLine($"{s}");
			   Console.WriteLine($"{d}");
			}
		}

		{
		//21- Float or int

		}
	}
}
