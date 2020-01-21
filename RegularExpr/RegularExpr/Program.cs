using System;
using System.Text.RegularExpressions;

namespace RegularExpr
{
    class Program
    {
        //You can use the internet(google) to find some standard secure regular expressions(regex)
        static void Main(string[] args)
        {
            string pattern = @"\w+\@\w+\.\w+";
            Regex regex = new Regex(pattern);

            string text = "Hi there, these are some emails, aster1@gmail.com, techro@gmail.com";
            MatchCollection matchCollection = regex.Matches(text);
            Console.WriteLine("{0} hits found:\n{1}", matchCollection.Count, text);
            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }
        }
    }
}
