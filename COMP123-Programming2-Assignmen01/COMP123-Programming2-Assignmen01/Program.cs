/*
 * studentName:Bin Liang | studentNumber:300788322
 * Date last Modified:Jan 27th,2015
 * Program description:COMP123_Assignment01,Implement the Hero Class.
 * Revision	History:
 * 1.This is 1st Edition.
 * 2.2nd Edition,debugging successfully!
 * 3.3rd Edition,improve the comments.
 * 4.4th Edition,add infomation to display whether hits successfully.
 * 5.5th Edition,remove unnecessary code.
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
