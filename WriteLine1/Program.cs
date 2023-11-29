////Console.WriteLine("enter the number1: ");
////int num1 = int.Parse(Console.ReadLine());
////Console.WriteLine("enter the number2: ");
////int num2 = int.Parse(Console.ReadLine());
////if (num1 > num2)
////{
////    Console.WriteLine("Number1 > Number2");
////}

////else if (num1 == num2)
////{
////    Console.WriteLine("Number2 = Number1");
////}

////else
////    {
////    Console.WriteLine("Number2 > Number1");
////}


//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Choose what you want");
//        int chos = int.Parse(s: Console.ReadLine());
//        switch (chos)
//        {
//            case 1:
//                Console.Write("Enter your grade: ");
//                int grade = Convert.ToInt32(Console.ReadLine());
//                if (grade < 0)
//                {
//                    Console.WriteLine("No grade");
//                }
//                else if (grade < 50)
//                {
//                    Console.WriteLine("F");

//                }
//                else if (grade < 60)
//                {
//                    Console.WriteLine("E");
//                }
//                else if (grade < 70)
//                {
//                    Console.WriteLine("D");
//                }
//                else if (grade < 80)
//                {
//                    Console.WriteLine("C");
//                }
//                else if (grade < 90)
//                {
//                    Console.WriteLine("B");
//                }
//                else if (grade <= 100)
//                {
//                    Console.WriteLine("A+");
//                }
//                else
//                {
//                    Console.WriteLine("No grade");
//                }
//                break;

//            case 2:
//                Console.WriteLine("thanks for treat with us");
//                break;

//            default:
//                Console.WriteLine("bye");
//                break;
//        }
//    }
//}

//Console.WriteLine("enter the number: ");
//int num = int.Parse(Console.ReadLine());
//switch (num)
//{
//    case 1:
//        Console.WriteLine(500);
//        break;
//    case 2:
//        Console.WriteLine(600);
//        break;
//    case 3:
//        Console.WriteLine(650);
//        break;
//    case 4:
//        Console.WriteLine(700);
//        break;
//    default:
//        Console.WriteLine("No product");
//        break;  
//}

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Enter your number: ");
//        int cc = int.Parse(s: Console.ReadLine());
//        for (int x = cc; x <= cc; x++)
//        {
//            for (int y = cc; y <= 25 + cc; y++)
//            {
//                Console.WriteLine(x + " * " + y + " = " + (x * y) + " ");
//            }
//            Console.WriteLine("");
//        }
//    }
//} 
//string strtd = DateTime.Now.ToString();
//Console.WriteLine(strtd);

//Console.WriteLine(DateTime.Now);

//DateTime dt;
//dt = DateTime.Now;
//dt = dt.AddDays(1);
//Console.WriteLine(dt);

//DateTime dt2 = Convert.ToDateTime("06/25/2004 04:15:30");
//Console.WriteLine(dt2);

//string strtD;
//strtD = DateTime.Now.ToString("F");
//Console.WriteLine(strtD);

//Console.WriteLine(DateTime.Now.AddYears(9).AddMonths(12).AddDays(962));

//DateTime dt = Convert.ToDateTime("08/29/2004");
//for (int i = 1; i <= 31; i++)
//{
//    Console.WriteLine(dt.ToString("yyyy"));
//    dt = dt.AddYears(1);
//}
