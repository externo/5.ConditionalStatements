using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BonusScore
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"program that applies bonus score to given score in the range [1…9] by the following rules:
•	If the score is between 1 and 3, the program multiplies it by 10.
•	If the score is between 4 and 6, the program multiplies it by 100.
•	If the score is between 7 and 9, the program multiplies it by 1000.
•	If the score is 0 or more than 9, the program prints “invalid score”.
                              ");
            Console.WriteLine("Write bonus score = ");
            int bonusScore = Int16.Parse(Console.ReadLine());
            bool multipliesBy10 = (1 <= bonusScore) && (bonusScore <= 3);
            bool multipliesBy100 = (4 <= bonusScore) && (bonusScore <= 6);
            bool multipliesBy1000 = (7 <= bonusScore) && (bonusScore <= 9);
            bool invalidScore = (0 >= bonusScore) || (bonusScore >= 10);
            if (multipliesBy10)
            {
                Console.WriteLine("The new score is {0}", bonusScore*10);
            }
            else if (multipliesBy100)
            {
                Console.WriteLine("The new score is {0}", bonusScore * 100);
            }
            else if (multipliesBy1000)
            {
                Console.WriteLine("The new score is {0}", bonusScore * 1000);
            }
            else
            {
                Console.WriteLine(@"The new score is “invalid score”.");
            }
        }
    }
}
