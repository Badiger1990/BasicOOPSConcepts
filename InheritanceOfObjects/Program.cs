﻿using System;

public class InheritanceOfObjects
{
    public static void Main(string[] args)
    {
        int total = 3;
        ////Camel case variable
        //string firtName = "Ramesh";
        ////Pascal case variable
        //string LastName = "Suresh";
        Person[] persons = new Person[total];

        for (int i = 0; i < total; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("Enter Teacher Name");
                persons[i] = new Teacher(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter Student Name");
                persons[i] = new Student(Console.ReadLine());
            }
        }

        for (int i = 0; i < total; i++)
        {
            if (i == 0)
            {
                ((Teacher)persons[i]).Explain();

            }
            else
            {
                ((Student)persons[i]).Study();
            }
        }
    }

    public class Person
    {
        protected string Name { get; set; }

        public Person(string name)
        {
            Name = name.ToString();
        }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }

        ~Person()
        {
            Name = string.Empty;
        }
    }

    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }

        public void Explain()
        {
            Console.WriteLine("Explain");
        }
    }

    public class Student : Person
    {
        public Student(string name) : base(name)
        {
            Name = name;
        }

        public void Study()
        {
            Console.WriteLine("Study");
        }
    }
}