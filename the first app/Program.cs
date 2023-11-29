namespace the_first_app
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double num1, num2;
            char again;
            Console.WriteLine("Welcome and Hello to my app, please choose what you want");
            Console.WriteLine("--------------------------------------------------------");
            do
            {
                Console.WriteLine("                     1- ADDTION ");
                Console.WriteLine("                     2- SUBTRACTION");
                Console.WriteLine("                     3- MULTIPLCATION");
                Console.WriteLine("                     4- DEVIDETION");
                Console.WriteLine("                     5- REMINDER");
                Console.WriteLine("                     6- BREAK YOUR NAME INTO LETTERS");
                Console.WriteLine("                     7- DATE AFTER YOU ADD");
                Console.WriteLine("                     8- GENERATE RANDOM NUMBER");
                Console.WriteLine("                     9- CHANGE THE STYLE LOWER AND UPPER");
                Console.WriteLine("                     10- SPLIT YOUR NAME");
                Console.WriteLine("                     11- REVERSE ANY TEXT");
                Console.WriteLine("                     12- HOW THE LENGTH OF DATA TYPE OF C#");
                Console.Write("Enter Your Choose: ");
                int choose = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------");
                switch (choose)
                {

                    case 1:
                        {
                            Console.WriteLine("                     1- ADDTION ");
                            Console.Write("Enter the first number: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Enter the secound number: ");
                            num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine($"{num1 + num2}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("                     2- SUBTRACTION");
                            Console.Write("Enter the first number: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Enter the secound number: ");
                            num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine($"{num1 - num2}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("                     3- MULTIPLCATION");
                            Console.Write("Enter the first number: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Enter the secound number: ");
                            num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine($"{num1 * num2}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("                     4- DEVIDETION");
                            Console.Write("Enter the first number: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Enter the secound number not equal ZERO: ");
                            num2 = double.Parse(Console.ReadLine());
                            if (num2 == 0)
                            {
                                Console.WriteLine("can't divided by ZERO");
                                while (num2 == 0)
                                {
                                    Console.WriteLine("Enter the secound number again: ");
                                    num2 = int.Parse(Console.ReadLine());
                                }
                                Console.WriteLine($"{num1 / num2}");
                            }
                            else
                            {
                                Console.WriteLine($"{num1 / num2}");
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("                     5- REMINDER");
                            Console.Write("Enter the first number: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Enter the secound number not equal ZERO: ");
                            num2 = double.Parse(Console.ReadLine());
                            if (num2 == 0)
                            {
                                Console.WriteLine("can't divided by ZERO");
                                while (num2 == 0)
                                {
                                    Console.Write("Enter the secound number again: ");
                                    num2 = int.Parse(Console.ReadLine());
                                }
                                Console.WriteLine($"{num1 % num2}");
                            }
                            else
                            {
                                Console.WriteLine($"{num1 % num2}");
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Enter your name");
                            string name1 = Console.ReadLine();
                            char[] cname = name1.ToCharArray();
                            for (int i = 0; i < cname.Length; i++)
                            {
                                Console.WriteLine($"{cname[i]}");
                            }
                            foreach (char c in name1)
                            {
                                Console.Write($"{c} ");
                            }
                            break;
                        }
                    case 7:
                        {
                            do
                            {
                                Console.WriteLine("                     1- THE DATE AFTER ADD MINUTES");
                                Console.WriteLine("                     2- THE DATE AFTER ADD HOURS");
                                Console.WriteLine("                     3- THE DATE AFTER ADD DAYS");
                                Console.WriteLine("                     4- THE DATE AFTER ADD MONTHS");
                                Console.WriteLine("                     5- THE DATE AFTER ADD YEARS");
                                Console.Write("CHOOSE WHAT YOU WANT TO ADD?: ");
                                int adddmy = int.Parse(Console.ReadLine());
                                int youradd;
                                Console.WriteLine("--------------------------------------------------------");
                                switch (adddmy)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("ENTER NUMBER OF THE MINUTES YOU WANT TO ADD: ");
                                            youradd = int.Parse(Console.ReadLine());
                                            Console.WriteLine($"{DateTime.Now.AddMinutes(youradd)} ");
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("ENTER NUMBER OF THE HOURS YOU WANT TO ADD: ");
                                            youradd = int.Parse(Console.ReadLine());
                                            Console.WriteLine($"{DateTime.Now.AddHours(youradd)}");
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("ENTER NUMBER OF THE DAYS YOU WANT TO ADD: ");
                                            youradd = int.Parse(Console.ReadLine());
                                            Console.WriteLine($"{DateTime.Now.AddDays(youradd)}");
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.WriteLine("ENTER NUMBER OF THE MONTHS YOU WANT TO ADD: ");
                                            youradd = int.Parse(Console.ReadLine());
                                            Console.WriteLine($"{DateTime.Now.AddMonths(youradd)}");
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.WriteLine("ENTER NUMBER OF THE YEARS YOU WANT TO ADD: ");
                                            youradd = int.Parse(Console.ReadLine());
                                            Console.WriteLine($"{DateTime.Now.AddYears(youradd)}");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("ENTER NUMBER OF THE MINUTES YOU WANT TO ADD: ");
                                            youradd = int.Parse(Console.ReadLine());
                                            Console.WriteLine($"{DateTime.Now.AddMinutes(youradd)}");
                                            break;
                                        }
                                }
                                Console.Write("Do you want to do ADD again? (Y/N) : ");
                                again = char.Parse(Console.ReadLine());
                            } while (again is 'y' or 'Y');
                            Console.WriteLine("--------------------------------------------------------");
                            break;
                        }
                    case 8:
                        {
                            Random rannum = new();
                            double rn = rannum.Next(0, 999999999);
                            Console.WriteLine($"{rn} :THIS IS A RANDOM NUMBER");
                            break;
                        }
                    case 9:
                        {
                            do
                            {
                                Console.WriteLine("                     1- LOWER CASE");
                                Console.WriteLine("                     2- UPPER CASE");
                                Console.WriteLine("                     3- SPECIFIC LETTER");
                                Console.Write("CHOOSE THE FORMAT: ");
                                int formatUL = int.Parse(Console.ReadLine());
                                switch (formatUL)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("ENTER THE WORD IN UPPER CASE: ");
                                            string namelu = Console.ReadLine();
                                            Console.WriteLine($"{namelu.ToLower()}");
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("ENTER THE WORD IN LOWER CASE: ");
                                            string namelu = Console.ReadLine();
                                            Console.WriteLine($"{namelu.ToUpper()}");
                                            break;
                                        }
                                    case 3:
                                        {
                                            do
                                            {
                                                Console.WriteLine("                     1- SPICIFIC LOWER CASE");
                                                Console.WriteLine("                     2- SPICIFIC UPPER CASE");
                                                Console.Write("CHOOSE THE FORMAT: ");
                                                int speclet = int.Parse(Console.ReadLine());
                                                switch (speclet)
                                                {
                                                    case 1:
                                                        {
                                                            Console.Write("ENTER THE WORD IN UPPER CASE: ");
                                                            string namelu = Console.ReadLine();
                                                            string namelu2 = "";
                                                            char[] clette = namelu.ToCharArray();
                                                            Console.Write("ENTER THE LETTER YOU WANT: ");
                                                            int WHATlet = int.Parse(Console.ReadLine());
                                                            for (int i = 0; i < namelu.Length; i++)
                                                            {
                                                                if (i == (WHATlet - 1))
                                                                {
                                                                    namelu2 += clette[i].ToString().ToLower();
                                                                }
                                                                else
                                                                {
                                                                    namelu2 += clette[i];
                                                                }
                                                            }
                                                            Console.WriteLine(namelu2);
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            Console.Write("ENTER THE WORD IN LOWER CASE: ");
                                                            string namelu = Console.ReadLine();
                                                            string namelu2 = "";
                                                            char[] clette = namelu.ToCharArray();
                                                            Console.Write("ENTER THE LETTER YOU WANT: ");
                                                            int WHATlet = int.Parse(Console.ReadLine());
                                                            for (int i = 0; i < namelu.Length; i++)
                                                            {
                                                                if (i == (WHATlet - 1))
                                                                {
                                                                    namelu2 += clette[i].ToString().ToUpper();
                                                                }
                                                                else
                                                                {
                                                                    namelu2 += clette[i];
                                                                }
                                                            }
                                                            Console.WriteLine(namelu2);
                                                            break;
                                                        }
                                                }
                                                Console.Write("Do you want to do SPECIFIC LOWER OR UPPER again? (Y/N) : ");
                                                again = char.Parse(Console.ReadLine());
                                            } while (again is 'y' or 'Y');
                                            Console.WriteLine("--------------------------------------------------------");
                                            break;
                                        }
                                }
                                Console.Write("Do you want to do LOWER OR UPPER again? (Y/N) : ");
                                again = char.Parse(Console.ReadLine());
                            } while (again is 'y' or 'Y');
                            Console.WriteLine("--------------------------------------------------------");
                            break;
                        }
                    case 10:
                        {
                            Console.Write("ENTER YOUR NAME: ");
                            string strname = Console.ReadLine();
                            string[] allname = strname.Split(' ');
                            foreach (string s in allname)
                            {
                                Console.WriteLine(s);
                            }
                            break;
                        }
                    case 11:
                        {
                            Console.Write("ENTER ANY WORD: ");
                            string strname = Console.ReadLine();
                            string str_reverse = "";
                            for (int x = strname.Length - 1; x >= 0; x--)
                            {
                                str_reverse += strname[x];
                            }
                            Console.WriteLine(str_reverse);
                            break;
                        }
                    case 12:
                        {
                            do
                            {
                                Console.WriteLine("                     1- INT");
                                Console.WriteLine("                     2- SHORT");
                                Console.WriteLine("                     3- LONG");
                                Console.WriteLine("                     4- DECIMAL");
                                Console.WriteLine("                     5- FLOAT");
                                Console.WriteLine("                     6- DOUBLE");
                                Console.WriteLine("                     7- BYTE");
                                Console.Write("CHOOSE DATA TYPE: ");
                                int LenghthOfDataType = int.Parse(Console.ReadLine());
                                switch (LenghthOfDataType)
                                {
                                    case 1:
                                        {
                                            int min = int.MinValue;
                                            int max = int.MaxValue;
                                            Console.WriteLine($"THE MIN VALUE IS: {min}");
                                            Console.WriteLine($"THE MAX VALUE IS: +{max}");
                                            break;
                                        }
                                    case 2:
                                        {
                                            short min = short.MinValue;
                                            short max = short.MaxValue;
                                            Console.WriteLine($"THE MIN VALUE IS: {min}");
                                            Console.WriteLine($"THE MAX VALUE IS: +{max}");
                                            break;
                                        }
                                    case 3:
                                        {
                                            long min = long.MinValue;
                                            long max = long.MaxValue;
                                            Console.WriteLine($"THE MIN VALUE IS: {min}");
                                            Console.WriteLine($"THE MAX VALUE IS: +{max}");
                                            break;
                                        }
                                    case 4:
                                        {
                                            decimal min = decimal.MinValue;
                                            decimal max = decimal.MaxValue;
                                            Console.WriteLine($"THE MIN VALUE IS: {min}");
                                            Console.WriteLine($"THE MAX VALUE IS: +{max}");
                                            break;
                                        }
                                    case 5:
                                        {
                                            float min = float.MinValue;
                                            float max = float.MaxValue;
                                            Console.WriteLine($"THE MIN VALUE IS: {min}");
                                            Console.WriteLine($"THE MAX VALUE IS: +{max}");
                                            break;
                                        }
                                    case 6:
                                        {
                                            double min = double.MinValue;
                                            double max = double.MaxValue;
                                            Console.WriteLine($"THE MIN VALUE IS: {min}");
                                            Console.WriteLine($"THE MAX VALUE IS: +{max}");
                                            break;
                                        }
                                    case 7:
                                        {
                                            byte min = byte.MinValue;
                                            byte max = byte.MaxValue;
                                            Console.WriteLine($"THE MIN VALUE IS: {min}");
                                            Console.WriteLine($"THE MAX VALUE IS: +{max}");
                                            break;
                                        }

                                };

                                Console.Write("Do you want to do SPECIFIC LOWER OR UPPER again? (Y/N) : ");
                                again = char.Parse(Console.ReadLine());
                            } while (again is 'y' or 'Y');
                            Console.WriteLine("--------------------------------------------------------");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("                     1- ADDTION ");
                            Console.Write("Enter the first number: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Enter the secound number: ");
                            num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine(num1 + num2);
                            break;
                        }
                }
                Console.WriteLine("--------------------------------------------------------");
                Console.Write("Do you want to do it again? (Y/N) : ");
                again = char.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------");
            }
            while (again is 'y' or 'Y');
            DateTime dati = Convert.ToDateTime("09/02/2023 10:15:22 AM");
            string thedate = string.Format("{0:dddd, MMMM d, yyyy hh:mm:ss AM}", dati);
            string DT = DateTime.Now.ToString("F");
            Console.WriteLine("THIS PROGRAM WAS MADE AT " + thedate);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Last Update On " + DT);
            Console.WriteLine("--------------------------------------------------------");

        }
    }
}
