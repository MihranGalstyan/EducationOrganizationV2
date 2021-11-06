using System;
using System.Collections.Generic;
using UniversityOrg.Models;

namespace UniversityOrg.Services
{
    class PrintService
    {
        /// <summary>
        /// Prints "Student" type list
        /// </summary>
        /// <param name="list">Given list</param>
        public void PrintStudents(List<Student> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{list[i]._name} ");
            }
        }

        /// <summary>
        /// Prints "Teacher" type list
        /// </summary>
        /// <param name="list">Given list</param>
        public void PrintTeachers(List<Teacher> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{list[i]._name} ");
            }
        }
    }
}
