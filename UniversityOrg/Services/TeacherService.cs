using System;
using System.Collections.Generic;
using UniversityOrg.Models;

namespace UniversityOrg.Services
{
    public class TeacherService
    {
        /// <summary>
        /// All teachers list
        /// </summary>
        private static List<Teacher> _teachersAll = new List<Teacher>();

        /// <summary>
        /// Adds given teacher to the all teachers list
        /// </summary>
        /// <param name="teacher">Given teacher</param>
        public void Add(Teacher teacher)
        {
            _teachersAll.Add(teacher);
        }

        /// <summary>
        /// Finds teacher by given id
        /// </summary>
        /// <param name="id">Given id</param>
        /// <returns>List</returns>
        public Teacher Get(Guid id)
        {
            for (int i = 0; i < _teachersAll.Count; i++)
            {
                if (_teachersAll[i].GetId() == id)
                    return _teachersAll[i];
            }
            return default(Teacher);
        }

        /// <summary>
        /// Returns all teachers list
        /// </summary>
        /// <returns>List</returns>
        public List<Teacher> GetAll()
        {
            return _teachersAll;
        }

        /// <summary>
        /// Removes given teacher from all teachers list
        /// </summary>
        /// <param name="teacher"></param>
        public void Remove(Teacher teacher)
        {
            _teachersAll.Remove(teacher);
        }

        /// <summary>
        /// Finds teacher on all teachers list by id and replaces with given teacher
        /// </summary>
        /// <param name="teacher"></param>
        public void Update(Teacher teacher)
        {
            for (int i = 0; i < _teachersAll.Count; i++)
            {
                if (GetId(_teachersAll[i]) == GetId(teacher))
                {
                    _teachersAll[i] = teacher;
                }
            }
        }

        /// <summary>
        /// Gets value of private Id
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Guid value</returns>
        public Guid GetId(Teacher teacher)
        {
            return teacher.GetId();
        }

        /// <summary>
        /// Swappes students in list by id
        /// </summary>
        /// <param name="_students"></param>
        /// <param name="student"></param>
        public void SwappStudents(List<Student> _students, Student student)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].GetId() == student.GetId())
                    _students[i] = student;
            }
        }

        /// <summary>
        /// Prints profile of given teacher
        /// </summary>
        /// <param name="teacher">Given teacher</param>
        public void GetProfile(Teacher teacher)
        {
            teacher.GetProfile();
        }

        /// <summary>
        /// (Setter) Updates all teachers list
        /// </summary>
        /// <param name="teachers">Given list</param>
        public void UpdateTeachersList(List<Teacher> teachers)
        {
            _teachersAll = teachers;
        }
    }
}
