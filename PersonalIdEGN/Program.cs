using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalIdEGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you EGN");
            string egn = Console.ReadLine();

            bool count = false;

            if (10 == egn.Length)
            {
                count = true;
                Console.WriteLine("True,you egn have 10 numbers");




                string dayOfBirth = egn.Substring(4, 2);

                string monthOfBirth = egn.Substring(2, 2);

                string yearOfBirth = egn.Substring(0, 2);

                int TwoThous = Int32.Parse(monthOfBirth);
                int invDay = Int32.Parse(dayOfBirth);

                if (invDay < 31 )
                {
                    if (TwoThous - 40 >= 0 && TwoThous <= 52)

                    {
                        string swap = egn.Substring(2, 1);

                        int TwoThousFour = Int32.Parse(swap);

                        string TwoThousBSec = egn.Substring(3, 1);

                        if (TwoThousFour > 4)
                        {

                            swap = "1";
                            Console.WriteLine("Your data of birth: " + dayOfBirth + "." + swap + TwoThousBSec + ".20" + yearOfBirth);
                        }
                        else
                        {
                            swap = "0";
                            Console.WriteLine("Your data of birth: " + dayOfBirth + "." + swap + TwoThousBSec + ".20" + yearOfBirth);
                        }

                    }
                    else if (TwoThous >52 )
                    {
                        Console.WriteLine("Error: You Impossible Month of B-day in ID");
                    }
                    else
                        Console.WriteLine("Your data of birth: " + dayOfBirth + "." + monthOfBirth + ".19" + yearOfBirth);

                    string sex = egn.Substring(8, 1);
                    int sexP = Int32.Parse(sex);

                    if (sexP % 2 == 0)
                    {
                        Console.WriteLine("Male");
                    }
                    else
                        Console.WriteLine("Female");

                }
                else
                {
                    count = false;
                    Console.WriteLine("False,you egn must have 10 numbers");


                }
                Console.WriteLine(count);
                Console.ReadKey();




            }

        }
    }
}
