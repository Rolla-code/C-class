using System;

namespace InheritanceDemo_Posts
{
    class Program
    {
        static void Main(string[] args)
        {
            Posts post1 = new Posts(); //calling default constructor
            Posts post2 = new Posts("Knives out is really a nice movie", true, "Rolla Code");//calling instant. construct.
            Console.WriteLine(post1.ToString());
            Console.WriteLine(post2.ToString());

            ImagePost firstPost = new ImagePost("Poster image of knives out", "Rolla Code", 
                "http//:hdpopcorns/adventure/knivesout", true);
            Console.WriteLine(firstPost.ToString());

            VideoPost Vid1 = new VideoPost("Knives out", "Rolla Code", "http//:hdpopcorns/adventure/knivesout", true, 8);
            Console.WriteLine(Vid1.ToString());

            Vid1.Play();
            Console.WriteLine("Press any key to pause");
           Console.ReadKey();
            Vid1.Stop();

        }
    }
}
