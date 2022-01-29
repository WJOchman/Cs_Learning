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

            Console.ReadLine();
        }
    }
}

// Getting User Input
namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", you are " + age + "years old.");
    
            Console.ReadLine();
        }
    }
}

// Building a Calculator
namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter a Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Another Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}

// Building a Mad Libs Game 
namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            string colour, pluralNoun, celebrity; 
            
            Console.Write("Enter a colour: ");
            colour = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity name: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are" + colour);
            Console.WriteLine(pluralNoun + "are blue");
            Console.WriteLine("I love" + celebrity);

            Console.ReadLine();
        } 
    }
}

// Arrays 
namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            Console.WriteLine(luckyNumbers[1]);    

            string[] friends = new string[5]; 
            friends[0] = "Jim";
            friends[1] = "Kelly";
            friends[2] = "Clarke";
            friends[3] = "Samuel";
            friends[4] = "Johnathan";
            
            Console.ReadLine();
        }
    }
}

// Methods

namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            
            SayHi("Mike", 33);
            SayHi("John", 56);
            SayHi("Tom", 12);

            Console.ReadLine();
        }

        static void SayHi(string name, int age) {
            Console.WriteLine("Hello " + name + ", you are" + age + "years old.");
        }
    }
}

// Return Statement 
namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(cube(5));

            Console.ReadLine();
        }

        static int cube(int num) {
            int result = num * num * num;
            return result; 
        }
    }
}

// If Statements 
namespace Giraffe {
    class Program {
        static void Main(string[] args) {

            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall) {
                Console.WriteLine("You are a tall male.");
            } else if (isMale && !isTall){
                Console.WriteLine("You are a short male.");
            } else if (!isMale && isTall) {
                Console.WriteLine("You are not male but you are tall.");
            } else {
                Console.WriteLine("You are not male and not tall.");
            }

            Console.ReadLine();
        }
    }
}

// More If Satements
namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(getMax(20, 10, 40));

            Console.ReadLine();
        }

        static int getMax(int num1, int num2, int num3) {
            int result; 
            if (num1 >= num2 && num1 >= num2) {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3) {
                result = num2;
            } else {
                result = num3;
            }
            
            return result;
        }
    }
}

// Building a Better Calculator
