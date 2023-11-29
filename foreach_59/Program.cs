namespace foreach_59
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            {
                string[] names = { "amar", "amar", "sama", "omar", "ammar" };
                foreach (string num in names)
                {
                    Console.WriteLine(num);
                }
            }
            {
                string name = "abdollah";
                {
                    char[] nam = name.ToCharArray();
                    Console.WriteLine(nam);
                }
                {
                    foreach (char c in name)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
        }
    }
}

