using System;
using System.Collections.Generic;

namespace BasicOOPSConcepts
{
    public class ObjectOrinatedPrograms
    {
        string firstName = "Ramesh";
        string lastName = "Suresh";
        
        public static void Main(string[] args)
        {
            //string firstName = "Hello Kira Technology";
            Console.WriteLine("Hello Kira Technology");
            //ObjectOrinatedPrograms obj = new ObjectOrinatedPrograms();

            ////Console.WriteLine("{0}This is my first program:-{1}", obj.firstName, obj.lastName);
            ConstructorExample obj = new ConstructorExample(20, 50);
            obj.strProperty = "New Property";
            obj.PrintMethod();
            

            //Console.WriteLine("Constructor example is pass:");
            AccessModifier accessModifier = new AccessModifier();
            
            Console.ReadKey();
        }
    }

    public class ConstructorExample : AccessModifier
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
            sum = a + b;
        }

        #region objects
        AccessModifier AccessModifierObject = new AccessModifier();
        #endregion

        internal void PrintMethod()
        {
            Console.WriteLine("Employee Name is:{0}",Employee);
            Console.WriteLine("Total is:{0}",sum);

            AccessModifierObject.publicVariable = "Calling from print method";



            Console.WriteLine(AccessModifierObject.publicVariable);

            Console.WriteLine("this is my new property expample-{0}",strProperty);
        }

        private string propVar;

        public string strProperty
        {
            get { return propVar; }
            set { propVar = value; }
        }

        public double GetNumberFromCalPrject { get; set; }

        #endregion
    }
}
