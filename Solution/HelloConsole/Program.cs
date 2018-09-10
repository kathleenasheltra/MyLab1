using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            int myAge;
            int length = args.Length;
            if (length > 0)
            {
                if(length < 3)
                {
                    age = (args[1]);
                    if (int.TryParse(age, out myAge))
                    {
                        if (myAge > 1)
                        {
                            name = Convert.ToString(args[0]);

                            Console.WriteLine("Hello, " + name + ". You are " + age + " years old");
                        }
                        else
                        {
                            Console.WriteLine("Age is invalid. Age must be an integer value over 0");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Your age value is invalid");
                    }
                    
                    

                }
                else
                {
                    Console.WriteLine("Usage Error");
                    
                }
                
            }
            else
            {
                Console.WriteLine("Type your first name and press enter");
                name = Console.ReadLine();
                Console.WriteLine("Type in your age and press enter");
                age = Console.ReadLine();
                Console.WriteLine("Hello, " + name + ". You are " + age + " years old");

            }
           


            Console.ReadLine();
            

        }
    }
}
