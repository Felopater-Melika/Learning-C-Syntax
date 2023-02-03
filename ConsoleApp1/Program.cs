using Student;
using System;
using System.Linq;
using System.Xml.Linq;
using System.IO;


namespace HelloWorld
{
    class Program
    { 
        // Methods


        //static string MyMethod(string firstName = "NAME", int age = 0)
        //{
        //    return firstName + " is " + age + " years old";
        //}

        static void Main(string[] args)
        {
            // Basics


            //const String myName = "Felopater";
            //int myAge = 18;
            //char myChar = 'P';
            //float Pi = 3.14F;
            //Console.WriteLine(myName + myAge + myChar + Pi);
            //int x, y, z;
            //x = y = z = 50;
            //Console.WriteLine(x + y + z);
            //float f1 = 35e3F;
            //double d1 = 12E4D;
            //Console.WriteLine(f1);
            //Console.WriteLine(d1);
            //Console.WriteLine(Convert.ToString(myAge));
            //Console.WriteLine(Convert.ToDouble(Pi));


            // Taking input


            //Console.WriteLine("Enter your first name:");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Enter your last name:");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Your name is: "+firstName+" "+lastName);
            //Console.WriteLine("Enter your age:");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is: " + age);


            // Math

            //int x = 10;
            //int y = 20;

            //Console.WriteLine(Math.Max(x, y));
            //Console.WriteLine(Math.Min(x, y));
            //Console.WriteLine(Math.Sqrt(4));
            //Console.WriteLine(Math.Abs(-4.7));
            //Console.WriteLine(Math.Round(9.6));


            // Strings


            //string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Console.WriteLine(txt.Length);
            //Console.WriteLine(txt.ToLower());
            //Console.WriteLine(txt.ToLower().ToUpper());
            //string firstName = "Felopater ";
            //string lastName = "Melika";
            //string name = string.Concat(firstName, lastName);
            //Console.WriteLine(name);
            //string intro = $"My full name is: {firstName} {lastName}";
            //Console.WriteLine(intro);
            //string myString = "Hello";
            //Console.WriteLine("Enter a number from 0 to 4");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(myString[x]);
            //Console.WriteLine("Enter a letter from H e l o");
            //string y = Console.ReadLine();
            //Console.WriteLine(myString.IndexOf(y));
            //string ello = myString.Substring(1);
            //Console.WriteLine(ello);
            //Console.WriteLine("my favorite book is \'the laws of human nature\' my second favorite is \"think and grow rich\" \n \t this is a back space \\\b");


            // Conditionals / Bools

            //int age = 17;
            //int adultAge = 18;

            //if (age >= adultAge)
            //{
            //    Console.WriteLine("Is an adult.");
            //}
            //else if (age < adultAge) 
            //{
            //    Console.WriteLine("Is a minor.");
            //}
            //else
            //{
            //    Console.WriteLine("In not an adult.");
            //}

            //bool isAdult = (age >= adultAge) ? true : false;

            //Console.WriteLine(isAdult);

            //Console.WriteLine("Enter a number from 1 to 7");
            //int day = Convert.ToInt32(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid week day");
            //        break;

            //}


            // Loops


            //int x = 0;
            //while (x < 100)
            //{
            //    Console.WriteLine(x++);
            //}

            //do
            //{
            //    Console.WriteLine(x++);
            //}
            //while (x < 100);

            //for (int y = 0; y < 100; y++)
            //{
            //    Console.WriteLine(y);
            //}

            //string[] languages = { "C", "C++", "C#", "Java", "Javascript", "Typescript", "Python" };
            //foreach (string i in languages)
            //{
            //    Console.WriteLine(i);
            //}

            //int j = 0;
            //while (j < 10)
            //{
            //    if (j == 4)
            //    {
            //        j++;
            //        continue;
            //    }
            //    Console.WriteLine(j);
            //    j++;
            //}


            // Arrays


            //string[] weekDays = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //foreach (string day in weekDays)
            //{
            //    Console.WriteLine(day);
            //}

            //Array.Sort(weekDays);

            //for (int i= 0; i < weekDays.Length; i++)
            //{
            //    Console.WriteLine(weekDays[i]);
            //}

            //int[] numbers = { 5, 1, 8, 9 };
            //Console.WriteLine(numbers.Max());  
            //Console.WriteLine(numbers.Min());
            //Console.WriteLine(numbers.Sum());

            //int[,] numbers2 = { { 1, 4, 2 }, { 3, 6, 8 } };

            //for (int i = 0; i < numbers2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers2.GetLength(1); j++)
            //    {
            //        Console.WriteLine(numbers2[i, j]);
            //    }
            //}


            // Methods


            //Console.WriteLine(MyMethod(firstName: "Felopater", age :18));


            // Classes / OOP



            //StudentClass s = new StudentClass();
            //s.introduction();
            //Console.WriteLine(s.name + " " + s.age + " " + s.major);
            //StudentWithEncapsulation s2 = new StudentWithEncapsulation("Felopater", 18, "Computer Science");
            //s2.Name = "Felopater";
            //s2.Age = 18;
            //s2.Major = "Computer Science";
            //s2.introduction();
            //StudentWithInheritance s3 = new StudentWithInheritance();
            //s3.introduction();
            //StudentWithPolymorphism felopater = new Felopater();
            //felopater.introduction();
            //StudentWithInheritance felopater2 = new StudentWithInheritance();
            //felopater2.college = Colleges.MTSU;
            //Console.WriteLine(felopater2.college);


            // Try Catch


            //try
            //{
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    int[] myNumbers = { 1, 2, 3 };
            //    Console.WriteLine(myNumbers[x]);
            //}
            ////catch (Exception e)
            ////{
            ////    Console.WriteLine(e.Message);
            ////}
            //catch
            //{
            //    throw new ArithmeticException("You entered a number that is out of the Array Index");
            //}
            //finally
            //{
            //    Console.WriteLine("Enter a number between 0 to 2");
            //}
        }
    }

}