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
namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number:");
            double num2 = Convert.ToDouble(Console.ReadLine());            

            if (op == "+") {
                Console.WriteLine(num1 + num2);
            } else if (op == "=") {
                Console.WriteLine(num1 - num2);
            } else if (op == "*") {
                Console.WriteLine(num1 * num2);
            } else if (op == "/") {
                Console.WriteLine(num1 / num2);
            } else {
                Console.WriteLine("Invalid operator");
            }

            Console.ReadLine();
        }
    }
}

// Switch Statements 
namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(GetDay(0));

            Console.ReadLine();
        } 

        static string GetDay(int dayNum) {
            string dayName;

            switch (dayNum) {
                case 0: dayName = "Sunday";
                break;
                case 1: dayName = "Monday";
                break;
                case 2: dayName = "Tuesday";
                break;
                case 3: dayName = "Wednesday";
                break;
                case 4: dayName = "Thursday";
                break;
                case 5: dayName = "Friday";
                break;
                case 6: dayName = "Saturday";
                break; 
                default: dayName = "Invalid Day Number";
                break;
            }

            return dayName; 
        }
    }
}

// While Loops
namespace Giraffe {
    class Program {
        static void Main(string[] args) {

            while (index <= 5) {
                Console.WriteLine(index);
                index++;
            }

            Console.ReadLine();
        }
    }
}

// Do While Loop
namespace Giraffe {
    class Program {
        static void Main(string[] args) {

            do {
                Console.WriteLine(index);
                index++;
            } while (index <= 5); 

            Console.ReadLine();
        }
    }
}

// Building a Guessing Game
namespace Giraffe {
    class Program {
        static void Main(string[] args) {

            string secretWord = "Giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = "3";
            bool outOfGuesses = false;


            while (guess != secretWord && !outOfGuesses) {

                Console.WriteLine("I'm an animal in Africa with a long neck, and I love to eat leaves. What am I?");

                if (guessCount < guessLimit) {
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } else {
                    outOfGuesses = true;
                }
                
            }

            if (outOfGuesses) {
                Console.Write("You Lose!");
            } else {
                Console.Write("You Win!");
            }

            Console.ReadLine();
        }
    }
}

// For Loops
namespace Giraffe {
    class Program {
        static void Main(string[] args) {

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int i = 1; i < luckyNumbers.Length;  i++) {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

// Building an Exponent Method
namespace Giraffe {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(GetPow(3, 2));
            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum) {
            int result = 1;

            for (int i = 0; i < powNum; i++) {
                result = result * baseNum;
            }

            return result;
        }
    }
}

// 2D Arrays
namespace Giraffe {
    class Program {
        static void Main(string[] args) {

        int[,] numberGrid = {
            {1, 2},
            {3, 4},
            {5, 6}
        }; 
        int[,] myArray = new int[2, 3];

        Console.WriteLine(numberGrid[1, 1]);
        }
    }
}

// Exception Handling 
namespace Giraffe {
    class Program {
        static void Main(string[] args) {

            try {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            } catch (DivideByZeroException) {
                Console.WriteLine(e.Message);
            } catch (FormatException) {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}

// Classes & Objects
namespace Giraffe {

    class Program {
        static void Main(string[] args) {

            // Book 1
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "J.K.Rowling";
            book1.bookType = "Hard Cover";
            book1.pages = 400;

            // Book 2
            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "J.R.R.Tolkien";
            book2.bookType = "Hard Cover";
            book2.pages = 700;

            // Here you can call the different attributes of the book classes.
            Console.WriteLine(book1.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book1.bookType);
            Console.WriteLine(book2.pages);

            Console.ReadLine();
        }
    }

    class Book {
        public string title;
        public string author;
        public string bookType;
        public int pages;
    }
}

// Constructors 
namespace Giraffe {

    class Program {
        static void Main(string[] args) {

            // Book 1
            Book book1 = new Book("Harry Potter", "J.K.Rowling", "Hardcover", 400);

            // Book 2
            Book book2 = new Book("Lord of the Rings", "J.R.R.Tolkien", "Hard Cover", 700);

            // Here you can call the different attributes of the book classes.
            Console.WriteLine(book1.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book1.bookType);
            Console.WriteLine(book2.pages);

            Console.ReadLine();
        }
    }

    class Book {
        public string title;
        public string author;
        public string bookType;
        public int pages;

        public Book(string aTitle, string aAuthor, string aBookType, int aPages) {
            title = aTitle;
            author = aAuthor;
            bookType = aBookType;
            pages = aPages; 
        }
    }
}

// Object Methods
namespace Giraffe {
    class Program {
        static void Main(string[] args) {

            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadLine();
        }
    }

    class Student {
        public string name;
        public string major;
        public double gpa;

        public Student(string aname, string aMajor, double aGPA);
    }

    public bool HasHonors() {
        if (gpa >= 3.5) {
            return true;
        } else {
            return false;
        }
    }
}

// Getters & Setters
namespace Giraffe {
    class Program {
        static void Main(string[] args) {

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Console.ReadLine();
        }
    }

    class Movie {
        public string title;
        public string director; 
        private string rating; 

        public Movie(string aTitle, string aDirector, string aRating) {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating {
            get { return rating; }
            set { 
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR") {
                    rating = value;
                } else {
                    rating = "NR";
                }
            }
        }
    }
}

// Static Class Attributes
namespace Giraffe {
    class Program {
        static void Main(string[] args) {


            Console.ReadLine();
        }
    }
}

// Static Methods & Classes 
namespace Giraffe {
    class Program {
        static void Main(string[] args) {


            Console.ReadLine();
        }
    }
}

// Inheritance
namespace Giraffe {
    class Program {
        static void Main(string[] args) {

            Console.ReadLine();
        }
    }
}
