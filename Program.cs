using System;

namespace ConsoleApp2
{
    class student
    {
        int rollnumber;
        string name;
        int age;
        int standard;
        public void setstudent(int rollnumber, string name, int age, int standard)
        {
            this.rollnumber = rollnumber;
            this.name = name;
            this.age = age;
            this.standard = standard;
        }
        public void getstudent()
        {
            Console.WriteLine("The Roll Number of student is {0} :",this.rollnumber);
            Console.WriteLine("The name of student is {0} :", this.name);
            Console.WriteLine("The age  of student is {0} :", this.age); 
            Console.WriteLine("The class  of student is {0} :", this.standard);


        }

        static void Main(string[] args)
        {
            student st = new student();
            Console.WriteLine("Enter the Roll Number of Student");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name  of Student");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the age of Student");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Class of Student");
            int standard = int.Parse(Console.ReadLine());
            st.setstudent(roll, name, age, standard);
            st.getstudent();
          
        }
    }
}
