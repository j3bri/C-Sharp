namespace parallelogram_area
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float a, b, h;
            b = float.Parse(Console.ReadLine());
            h = float.Parse(Console.ReadLine());
            a = b * h;
            Console.WriteLine(a);
        }
    }
}