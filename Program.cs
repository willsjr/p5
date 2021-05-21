using System;

namespace sess5
{
    class Program
    {
        static string firstName = "William";
        static string lastName = "Rogers";
        static int age = 26;
        static int num1 = 209;
        static int num2 = 899;
        static int max_age = 10;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program p = new Program();

            //p.GetNames("","");

            Console.WriteLine("Names are: " +p.GetNames(firstName,lastName,age));

            Program z = new Program();

            Console.WriteLine("The Result is: " + z.Multiplier(num1,num2));

            Program s = new Program();

            Console.WriteLine("Name is: " + s.GetUserData(age,firstName,lastName));

        }
        public string GetNames(string firstName, string lastName, int age)
        {
            return firstName + " " + lastName + " with age  " + age;
        }

        private int Multiplier(int a, int b)
        {
            return a*b;
        }

        public string GetUserData(int age, string fname, string lname)
        {
            if (age <= max_age)
            {
                return fname + " " + lname + " is below age.";
            }else
            {
                return fname + " " + lname + " has access!";
            }
        }
    }
}
