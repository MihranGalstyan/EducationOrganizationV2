using System;
using System.Collections.Generic;

namespace UniversityOrg.Models
{
    public class Teacher
    {
        private Guid _id;
        public string _name;
        public int _age;
        public List<Student> _students;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Teacher()
        {
            _id = Guid.NewGuid();
        }

        /// <summary>
        /// Constructor with given name and age
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Teacher(string name, int age)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
            _students = new List<Student>();
        }

        /// <summary>
        /// Gets value of private Id
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns>Guid value</returns>
        public Guid GetId()
        {
            return _id;
        }

        /// <summary>
        /// Prints teachers profile
        /// </summary>
        public void GetProfile()
        {
            Console.WriteLine($"{_name}'s profile \n\nuId: {_id} \nName: {_name} \nAge: {_age} \nNumber of students: {_students.Count}");
        }

        /// <summary>
        /// Prints given text
        /// </summary>
        /// <param name="text">given text</param>
        public void Speak(String text)
        {
            Console.WriteLine($"{_name} says: {text}");
        }
    }
}
