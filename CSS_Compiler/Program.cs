using System.Text.RegularExpressions;

namespace CSSCompiler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string css = File.ReadAllText(@"D:\C#\CSS_Compiler\style.css");
            string html = File.ReadAllText(@"D:\C#\CSS_Compiler\index.html");

            MatchCollection cssClasses = Regex.Matches(css, @"\.(\w+)");
            MatchCollection htmlClasses = Regex.Matches(html, @"class=\""(\w+)\""");

            string customCSS = "";

            foreach (Match cssClass in cssClasses)
            {
                foreach (Match htmlClass in htmlClasses)
                {
                    if (cssClass.Groups[1].Value == htmlClass.Groups[1].Value)
                    {
                        int startIndex = css.IndexOf(cssClass.Value);
                        int endIndex = css.IndexOf("}", startIndex) + 1;
                        customCSS += css[startIndex..endIndex];
                        break;
                    }
                }
            }
            File.WriteAllText("Custom.css", customCSS);
        }
    }
}
