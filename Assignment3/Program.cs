using System;
namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            Passing by Value means sending a copy of the variable to the method.Changes inside the method do not affect the original variable.
              Passing by Reference means sending the actual memory reference of the variable. Changes inside the method do affect the original variable.



             int number = 50;
            ChangeValue(number);
            Console.WriteLine("By Value → number = " + number);   //50

            ChangeValue(ref number);
            Console.WriteLine("By Reference → number = " + number);  //100

            #endregion

            #region Q2

            Passing by value passes a copy of the reference.Changes to the object affect the original, but changing the reference itself does not.
              Passing by reference allows the method to change both the object and the reference itself.

             Person person = new Person();
            person.Name = "Ahmed";
            ChangePerson(person);
            Console.WriteLine(person.Name); //Ali


            Person person = new Person();
            person.Name = "Ahmed";
            ChangePerson(ref person);
            Console.WriteLine(person.Name); //Omar
            #endregion

            #region Q3
            Console.WriteLine("Enter 4 numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            var result = Calculater(num1, num2, num3, num4);
            Console.WriteLine($"Sum of first two numbers = {result.sum}");
            Console.WriteLine($"Subtract of last two numbers = {result.sub}");
            #endregion
        }

        #region Q1 Functions
        static void ChangeValue(int num)
        {
            num = 100;

        }
        static void ChangeValue(ref int num)
        {
            num = 100;
        }
        #endregion
        #region Q2 Functions

        static void ChangePerson(Person p)
        {
            p.Name = "Ali";
            p = new Person();
            p.Name = "Omar";
        }

        static void ChangePerson(ref Person p)
        {
            p = new Person();
            p.Name = "Omar";
        }
        class Person
        {
            public string Name;
        }
        #endregion
        #region Q3
        static (int sum, int sub) Calculater(int num1, int num2, int num3, int num4)
            {
            int sum = num1+ num2;
            int sub = num3 - num4;
        return (sum,sub);
        }
        #endregion


    }
}
