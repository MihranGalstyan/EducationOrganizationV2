using System;
using System.Collections.Generic;
using UniversityOrg.Models;
using UniversityOrg.Services;

namespace UnivercityOrg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating services objects
            StudentService stServ = new StudentService();
            TeacherService teachServ = new TeacherService();
            PrintService printerOne = new PrintService();
            UniversityService uniVer = new UniversityService(stServ, teachServ);

            // Creating teachers
            Teacher teachOne = new Teacher("Zaven", 45);
            Teacher teachTwo = new Teacher("Vahan", 38);
            Teacher teachThree = new Teacher("Anahit", 36);

            // Adding teachers to list
            uniVer.AddTeacher(teachOne);
            uniVer.AddTeacher(teachTwo);
            uniVer.AddTeacher(teachThree);

            // Creating students
            Student stuOne = new Student("Hayk", 17, 1);
            Student stuTwo = new Student("Armen", 18, 2);
            Student stuThree = new Student("Anna", 17, 1);
            Student stuFour = new Student("Gayane", 19, 3);
            Student stuFive = new Student("Ani", 20, 4);
            Student stuSix = new Student("Karen", 20, 4);
            Student stuSeven = new Student("Vardan", 18, 2);
            Student stuEleven = new Student("Harut", 20, 4, teachThree);

            /// Adding student to all students lists
            uniVer.AddStudent(stuOne, teachTwo);
            uniVer.AddStudent(stuTwo, teachTwo);
            uniVer.AddStudent(stuThree, teachOne);
            uniVer.AddStudent(stuFour, teachOne);
            uniVer.AddStudent(stuFive, teachThree);
            uniVer.AddStudent(stuSix, teachThree);
            uniVer.AddStudent(stuSeven, teachThree);

            //// Printig teachers id
            Console.WriteLine($"{teachTwo._name}'s id is: \n{teachServ.GetId(teachTwo)}");
            Console.WriteLine();

            //// Printig students list of given teacher
            printerOne.PrintStudents(teachThree._students);
            Console.WriteLine();

            // Prining teachers and students profiles
            teachTwo.GetProfile();
            Console.WriteLine();
            stuOne.GetProfile();
            Console.WriteLine();

            // Swapping teacher
            uniVer.SwappTeacherForOne(stuOne, teachTwo, teachThree);
            stuOne.GetProfile();
            Console.WriteLine();

            // Printing lists
            Console.WriteLine($"Students list for {teachThree._name}: ");
            printerOne.PrintStudents(teachThree._students);
            Console.WriteLine();

            Console.WriteLine("All teachers list: ");
            printerOne.PrintTeachers(teachServ.GetAll());
            Console.WriteLine();

            // Printing given text
            stuOne.Speak("\nHello world!!!");
        }
    }
}
