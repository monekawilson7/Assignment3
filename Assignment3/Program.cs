using System;
namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Q1

            /*Passing by Value means sending a copy of the variable to the method.Changes inside the method do not affect the original variable.
               Passing by Reference means sending the actual memory reference of the variable. Changes inside the method do affect the original variable.
            */

              int number = 50;
            ChangeValue(number);
            Console.WriteLine("By Value → number = " + number);   //50

            ChangeValue(ref number);
            Console.WriteLine("By Reference → number = " + number);  //100
            #endregion

            #region Q2
            /*
            Passing by value passes a copy of the reference.Changes to the object affect the original, but changing the reference itself does not.
               Passing by reference allows the method to change both the object and the reference itself.
            */

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

            #region Q4
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int result = SumDigits(num);
            Console.WriteLine(result);
            #endregion

            #region Q5
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            if (IsPrime(num))
                Console.WriteLine($"{num} is prime number");
            else
                Console.WriteLine($"{num} is not prime number");
            #endregion
            
            #region Q6
            int[] numbers = {50,10,100,30,7 };
            MinMaxArray(numbers, out int minVal, out int maxVal);
            Console.WriteLine($"min value= {minVal}");
            Console.WriteLine($"max value= {maxVal}");
            #endregion
            
            #region Q7
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            int fact = Factorial(number);
            Console.WriteLine(fact);
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
            int sum = num1 + num2;
            int sub = num3 - num4;
            return (sum, sub);
        }
        #endregion
        #region Q4
        static int SumDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum;
        }
        #endregion
        #region Q5
        static bool IsPrime(int num) { 
        if (num<=1)
                return false;
            for (int i = 2; i < num; i++) {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        #endregion
        #region Q6
        static void MinMaxArray(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }
        }
        #endregion

        #region Q7
        static int Factorial(int num) {
            int result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
        #endregion
    }
}
