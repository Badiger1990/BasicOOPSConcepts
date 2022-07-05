using System;
using System.Collections.Generic;

namespace BasicOOPSConcepts
{
    public class ObjectOrinatedPrograms
    {
        
        /// <summary>
        /// This test method for training..
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            //string firstName = "Hello Kira Technology";
            //string lastName = "Thank you";

            //Console.WriteLine("{0}This is my first program:-{1}", firstName, lastName);
            ConstructorExample example = new ConstructorExample(20, 50);
            example.PrintMethod();

            Console.WriteLine("Constructor example is pass:");
            Console.ReadKey();
        }
    }

    public class ConstructorExample
    {
        #region variable
        string Employee;
        int sum;
        #endregion

        #region public methods
        public ConstructorExample()
        {
            Employee = "Ramesh";
        }

        public ConstructorExample(int a, int b)
        {
            Employee = "Suresh";
            a = 20; b = 30;
            sum = a + b;
        }

        public void PrintMethod()
        {
            Console.WriteLine("Employee Name is:{0}",Employee);
            Console.WriteLine("Total is:{0}",sum);
        }

        #endregion
    }
}
