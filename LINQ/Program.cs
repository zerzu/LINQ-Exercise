using System.Collections.Generic;
using System.Xml.Linq;

namespace LINQ
{
    public class Program
    {
        //Create a list of video game names...      !!DONE!!
        //Order the list of games by length of the game name.   !!DONE!!   
        //Use the lambda expression in this exercise as well.   !!DONE!!
        //Use Method Syntax for this exercise   !!DONE!!
        static void Main(string[] args)
        {
            var videoGames = new List<string>();

            videoGames.AddRange(new List<string>
        {
            @"Super Mario Bros",
            @"Castlevania: Symphony of the Night",
            @"Final Fantasy",
            @"Mike Tyson's PunchOut",
            @"Metroid",
        });
            var sortedGames = videoGames.OrderBy(word => word.Length);

            foreach (var word in sortedGames)
            {
                Console.WriteLine(word);
            }
            
        }
    }
}
