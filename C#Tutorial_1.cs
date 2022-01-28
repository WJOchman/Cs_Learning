using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Drawing a Shape
namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");
            Console.ReadLine();
        }
    }
}

// Variables
namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            string characterName = "John";
            int characterAge = "25";

            Console.WriteLine("There once was a man named" + characterName);
            Console.WriteLine("He was" + characterAge + "years old.");
            Console.WriteLine("He really liked the name" + characterName);
            Console.WriteLine("But didn't like being" + characterAge);

            Console.ReadLine();
        }
    }
}

// Data Types
namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            string phrase = "Giraffe Academy";
            char graded = 'B';
            int age = 30;
            float GPA = 3.1;
            double morepreciseGPA = 3.11;
            decimal evenmorepreciseGPA = 3.11;
            bool isMale = false;

            Console.ReadLine();
        }
    }
}

// Working With Strings 
namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            string phrase = "Giraffe Academy" + "is cool!";
            Console.WriteLine(phrase.ToUpper()); // .ToUpper() is a method which capitalises a string. 
            Console.WriteLine(phrase.ToLower()); // .ToLower() is a method which minimises a string. 
            Console.WriteLine(phrase.Contains("Academy")); // .Contains() is a method which produces a true or false statement if the string contains the phrase "Academy"
            Console.WriteLine(phrase[0]); // This method presents the character at index position 0. Which here is G.
            
            
            Console.ReadLine();
        }
    }
}

// Working With Numbers
namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            
            int num = 6;
            num++;
            // Or num--
            Console.WriteLine(num);
                
            Console.WriteLine( Math.Abs(-40) );
            Console.WriteLine( Math.Pow(3, 2));
            Console.WriteLine( Math.Sqrt(36) );
            Console.WriteLine( Math.Max(4, 20) );
            Console.WriteLine( Math.Min(4, 90) );
            Console.WriteLine( Math.Round(4.6) );
            Console.WriteLine( Math. );

            Console.ReadLine();
        }
    }
}





