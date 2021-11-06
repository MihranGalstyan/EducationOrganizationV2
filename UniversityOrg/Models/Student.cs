using System;
using System.Collections.Generic;

namespace UniversityOrg.Models
{
    public class Student
    {
        private Guid _id;
        public string _name;
        public int _age;
        public Teacher _teacher;
        public int _course;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Student()
        {
            _id = Guid.NewGuid();
        }

        /// <summary>
        /// Constructor with given parameters
        /// </summary>
        /// <param name="name">Given name</param>
        /// <param name="age">Given age</param>
        public Student(string name, int age)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
        }

        /// <summary>
        /// Constructor with given parameters
        /// </summary>
        /// <param name="name">Given name</param>
        /// <param name="age">Given age</param>
        /// <param name="course">Course</param>
        public Student(string name, int age, int course)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
            _course = course;
        }

        /// <summary>
        /// Constructor with given parameters
        /// </summary>
        /// <param name="name">Given name</param>
        /// <param name="age">Given age</param>
        /// <param name="course">Course</param>
        /// <param name="teacher"></param>
        public Student(string name, int age, int course, Teacher teacher)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
            _course = course;
            _teacher = teacher;
        }

        /// <summary>
        /// Gets value of private Id
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Guid value</returns>
        public Guid GetId()
        {
            return _id;
        }

        /// <summary>
        /// Prints students profile
        /// </summary>
        public void GetProfile()
        {
            Console.WriteLine($"{_name}'s profile \n\nuId: {_id} \nName: {_name} \nAge: {_age} \nTeacher: {_teacher._name} \nCourse: {_course}");
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
