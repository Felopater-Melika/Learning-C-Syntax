using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    enum Colleges
    {
        TTU,
        MTSU,
        UT
    }

    class StudentClass
    {
        public string name = "Felopater Melika";
        public int age =  18;
        public string major = "Computer Science";

        public void introduction()
        {
            Console.WriteLine(name + " is " + age + " and is a " + major + " major");
        }
    }

    class StudentWithConstructor
    {
        public string name;
        public int age;
        public string major;

        public StudentWithConstructor(string Sname, int Sage, string Smajor)
        {
            name = Sname;
            age = Sage;
            major = Smajor;
        }

        public void introduction()
        {
            Console.WriteLine(name + " is " + age + " and is a " + major + " major");
        }
    }
    
    class StudentWithEncapsulation
    {
        private string name;
        private int age;
        private string major;

        public StudentWithEncapsulation(string name, int age, string major)
        {
            Name = name;
            Age = age;
            Major = major;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        
       

        public void introduction()
        {
            Console.WriteLine(name + " is " + age + " and is a " + major + " major");
        }
    }
    
    class StudentWithInheritance : StudentClass
    {
        public Colleges college = Colleges.MTSU;
        public void introduction()
        {
            Console.WriteLine(name + " is " + age + " and is a " + major + " major" + " and goes to " + college);
        }
    }

    class StudentWithPolymorphism
    {
        public virtual void introduction()
        {
            Console.WriteLine("I am a student");
        }
    }
    
    class Felopater : StudentWithPolymorphism
    {
        public override void introduction()
        {
            Console.WriteLine("I am Felopater");
        }
     }
    
    abstract class StudentWithAbstraction
    {
        public abstract void introduction();
        public string name;
    }
    
    class Felo : StudentWithAbstraction
    {
        string name = "Felo";
        public override void introduction()
        {
            Console.WriteLine("I am " + name);
        }
    }

    interface StudentInterface
    {
        void introduction();
    }
    
    class felo : StudentWithInheritance
    {
        void introduction()
        {
            Console.WriteLine("Hello!");
        }
    }
    
    
}
