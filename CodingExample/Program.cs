using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExample
{
    class Program
    {
         
            static void Main(string[] args)
            {
                childclass ch = new childclass();
                childclass ch1 = new childclass("Hello ");
                Console.ReadKey();
            }
        }

        class baseclass
        {
            public baseclass()
            {
                Console.WriteLine("I am Default Constructors");
            }
            public baseclass(string message)
            {
                Console.WriteLine("Constructor Message : " + message);
            }
        }

        class childclass : baseclass
        {
            public childclass()
            {
            }
            public childclass(string message) : base(message)
                
            {
            }
        }
    }
