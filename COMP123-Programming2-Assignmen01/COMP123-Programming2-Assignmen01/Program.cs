/*
 * studentName:Bin Liang | studentNumber:300788322
 * Date last Modified:Jan 23th,2015
 * Program description:COMP123_Assignment01,Implement the Hero Class.
 * Revision	History:This is 1st Edition.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero aHero = new Hero("superman");
            aHero.show();
            aHero.fight();

            Console.Write("Press any key to exit");
            Console.ReadKey();

        }
    }
}
