using System;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             Passing by Value means sending a copy of the variable to the method. Changes inside the method do not affect the original variable.
             Passing by Reference means sending the actual memory reference of the variable. Changes inside the method do affect the original variable.
             */
            int number = 50;
            ChangeValue(number);
            Console.WriteLine("By Value → number = " + number);   //50

            ChangeValue(ref number);
            Console.WriteLine("By Reference → number = " + number);  //100
            #endregion
        }

        static void ChangeValue (int num)
        {
            num = 100;

        }
        static void ChangeValue(ref int num)
    {
        num = 100;
    }


    }
}
