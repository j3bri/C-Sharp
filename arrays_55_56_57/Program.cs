namespace arrays_55_56_57
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("enter the number of arrays: ");
            //int c = int.Parse(Console.ReadLine());
            //string[] strname = new string[c];
            //strname[0] = "Ammar ";
            //strname[1] = "Omar ";
            //strname[2] = "Khaled ";
            //strname[3] = "Mohamed ";
            //strname[^1] = "El-Jabari ";
            //Console.WriteLine(strname[0] + strname[^1]);
            //int array_count = strname.Length;
            //Console.WriteLine(array_count);

            Console.Write("enter number of employees: ");
            int emcounter = int.Parse(Console.ReadLine());
            string[] stremp = new string[emcounter];
            for (int i = 0; i < stremp.Length; i++)
            {
                Console.Write("enter name of employees: ");
                stremp[i] = Console.ReadLine();
            }

            for (int i = 0; i < stremp.Length; i++)
            {
                Console.WriteLine(stremp[i]);
            }

        }
    }
}