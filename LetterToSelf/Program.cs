using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Letter To Self
 * Displays the front of an envelope using text.
 * September 3rd, 2019 */
namespace StudentInfoTest
{
    
    class Program
    {
        static private int linecounter = 1;
        static private bool isFinished = false;
        static void Main(string[] args)
        {
            while (!isFinished)
            {

                if (linecounter == 1) 
                    {
                    Console.WriteLine("+------------------------------------------------+"); //top line
                    linecounter++;
                }
                //top and bottom
                while ((linecounter > 1) && (linecounter < 5))
                {
                    Console.WriteLine("|                                            ### |"); //stamp section
                    linecounter++;
                }
                while ((linecounter == 5) || (linecounter == 9) || (linecounter == 10))
                {
                    Console.WriteLine("|                                                |");    //blank section
                    linecounter++;
                }
                if (linecounter == 6){
                    Console.WriteLine("|                         Alexander Summers      |"); //Front writing, part one
                    linecounter++;}

                if (linecounter == 7)
                {
                Console.WriteLine("|                         4987 Coolworld Lane    |");  //Front writing, part two
                    linecounter++;
                }
                if (linecounter == 8)
                {
                        Console.WriteLine("|                         Fort Wayne, IN 46816   |");      //Front writing, part 3
                    linecounter++;
                }

                            
                if (linecounter == 11)
                {
                    Console.WriteLine("+------------------------------------------------+"); //bottom line
                    isFinished = true;      
                } 
            }
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
