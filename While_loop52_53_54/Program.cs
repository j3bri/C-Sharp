namespace While_loop52_53_54
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int x = 1;
            //while (x == 1)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}
            {
                char choise;
                int x = 1;
                do
                {
                    Console.WriteLine(x);
                    x++;
                    Console.Write("again Y/N: ");
                    choise = char.Parse(Console.ReadLine());
                }
                while (choise is not ('n' or 'N'));
            }
        }
    }
}