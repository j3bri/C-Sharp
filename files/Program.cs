namespace files
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //////string rootPath = @"D:\Back-End";
            //////string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            //////foreach (string dir in dirs)
            //////{
            //////    Console.WriteLine(dir);
            //////}
            //////Console.WriteLine("==============================================================");
            //////_ = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            //////foreach (string file in files)
            //////{
            //////    Console.WriteLine(file);
            //////    Console.WriteLine(Path.GetFileName(file));
            //////    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //////    Console.WriteLine(Path.GetDirectoryName(file));
            //////    FileInfo info = new(file)
            //////    {
            //////        LastAccessTime = DateTime.Now
            //////    };
            //////    Console.WriteLine(info);
            //////    Console.WriteLine($"{Path.GetFileName(file)}:{info.Length} bytes");

            //////}
            //////bool directoryExists = Directory.Exists(newPath);
            //////if (directoryExists)
            //////{
            //////    Console.WriteLine("Directory Exists");
            //////}
            //////else
            //////{
            //////    Console.WriteLine("Directory Does not Exist");
            //////    _ = Directory.CreateDirectory(newPath);
            //////    string[] files = Directory.GetFiles(rootPath);
            //////    string Destanisionfolder = @"D:\Back-End\SubFolderA\SubFolderE";

            //////    for (int i = 0; i < files.Length; i++)
            //////    {
            //////        File.Copy(files[i], $"{Destanisionfolder}{i}", true);

            //////    }

            //////    _ = Console.ReadLine();.
            ///ffsd

            //_ = Directory.CreateDirectory("عمر");
            //Directory.Delete("عمر");

            //////string rootPath = @"D:\Back-End";
            //////string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            //////foreach (string dir in dirs)
            //////{
            //////    Console.WriteLine(dir);
            //////}
            //////Console.WriteLine("==============================================================");
            //////_ = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            //////foreach (string file in files)
            //////{
            //////    Console.WriteLine(file);
            //////    Console.WriteLine(Path.GetFileName(file));
            //////    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //////    Console.WriteLine(Path.GetDirectoryName(file));
            //////    FileInfo info = new(file)
            //////    {
            //////        LastAccessTime = DateTime.Now
            //////    };
            //////    Console.WriteLine(info);
            //////    Console.WriteLine($"{Path.GetFileName(file)}:{info.Length} bytes");

            //////}
            //////bool directoryExists = Directory.Exists(newPath);
            //////if (directoryExists)
            //////{
            //////    Console.WriteLine("Directory Exists");
            //////}
            //////else
            //////{
            //////    Console.WriteLine("Directory Does not Exist");
            //////    _ = Directory.CreateDirectory(newPath);
            //////    string[] files = Directory.GetFiles(rootPath);
            //////    string Destanisionfolder = @"D:\Back-End\SubFolderA\SubFolderE";

            //////    for (int i = 0; i < files.Length; i++)
            //////    {
            //////        File.Copy(files[i], $"{Destanisionfolder}{i}", true);

            //////    }

            //////    _ = Console.ReadLine();.
            ///ffsd

            //_ = Directory.CreateDirectory("عمر");
            //Directory.Delete("عمر");

            //StreamWriter sw = new("myfiles.txt", true);
            //sw.Write("hello ");
            //sw.WriteLine("guys");
            //sw.Close();


            StreamWriter sw = new("myfiles.txt", true);
            sw.Write(".");
            sw.Close();
            StreamReader sr = new("myfiles.txt");
            string str = sr.ReadToEnd();
            Console.WriteLine(str);



            Console.WriteLine();
        }

    }
}
