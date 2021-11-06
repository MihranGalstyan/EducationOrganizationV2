using System;
using System.Collections.Generic;
using UniversityOrg.Models;

namespace UniversityOrg.Services
{
    public class StudentService
    {
        /// <summary>
        /// All students list
        /// </summary>
        private static List<Student> _studentsAll = new List<Student>();

        /// <summary>
        /// Adds given student to the list
        /// </summary>
        /// <param name="student">Given student</param>
        public void Add(Student student)
        {
            _studentsAll.Add(student);
        }

        /// <summary>
        /// Finds student by given id
        /// </summary>
        /// <param name="id">Given id</param>
        /// <returns>Object</returns>
        public Student Get(Guid id)
        {
            for (int i = 0; i < _studentsAll.Count; i++)
            {
                if (GetId(_studentsAll[i]) == id)
                    return _studentsAll[i];
            }
            return default(Student);
        }

        /// <summary>
        /// Finds all studens of teacher by given id
        /// </summary>
        /// <param name="id">Given id</param>
        /// <returns>List</returns>
        public List<Student> GetAllByTeacher(Guid id)
        {
            List<Student> stList = new List<Student>();
            for (int i = 0; i < _studentsAll.Count; i++)
            {

                if (_studentsAll[i]._teacher.GetId() == id)
                {
                    stList.Add(_studentsAll[i]);
                }
            }
            return stList;
        }

        /// <summary>
        /// Returns all students list
        /// </summary>
        /// <returns>List</returns>
        public List<Student> GetAll()
        {
            return _studentsAll;
        }

        /// <summary>
        /// Removes given student from all students list
        /// </summary>
        /// <param name="student">Given student</param>
        public void Remove(Student student)
        {
            _studentsAll.Remove(student);
        }

        /// <summary>
        /// Finds student by id in all students list and replaces with given student
        /// </summary>
        /// <param name="student">Given student</param>
        public void Update(Student student)
        {
            for (int i = 0; i < _studentsAll.Count; i++)
            {
                if (GetId(_studentsAll[i]) == GetId(student))
                {
                    _studentsAll[i] = student;
                }
            }
        }

        /// <summary>
        /// Gets value of private Id
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Guid value</returns>
        public Guid GetId(Student student)
        {
            return student.GetId();
        }

        /// <summary>
        /// Prints profile of given student
        /// </summary>
        /// <param name="student">Given student</param>
        public void GetProfile(Student student)
        {
            student.GetProfile();
        }

        /// <summary>
        /// (Setter) Updates all students list
        /// </summary>
        /// <param name="students">Given list</param>
        public void UpdateStudentsList(List<Student> students)
        {
            _studentsAll = students;
        }
    }
}
