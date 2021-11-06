using System;
using System.Collections.Generic;
using UniversityOrg.Models;
using UniversityOrg.Services;

namespace UniversityOrg.Services
{
    public class UniversityService
    {
        private StudentService _studentService;
        private TeacherService _teacherService;

        public UniversityService(StudentService studentService, TeacherService teacherService)
        {
            _teacherService = teacherService;
            _studentService = studentService;
        }

        /// <summary>
        /// Adds given student to all students list
        /// </summary>
        /// <param name="student"></param>
        public void AddStudent(Student student)
        {
            _studentService.Add(student);
        }

        /// <summary>
        /// Assignes Given teacher to given student, adds student to all students list, adds student to teachers students list
        /// </summary>
        /// <param name="student">Given student</param>
        /// <param name="teacher">Given teacher</param>
        public void AddStudent(Student student, Teacher teacher)
        {
            student._teacher = teacher;
            _studentService.Add(student);
            teacher._students.Add(student);
        }

        /// <summary>
        /// Removes student by id from all students list and teachers students list
        /// </summary>
        /// <param name="guId">Given id</param>
        public void RemoveStudent(Guid guId)
        {
            Student removable = _studentService.Get(guId);
            removable._teacher._students.Remove(removable);
            _studentService.Remove(removable);
        }

        /// <summary>
        /// Removes student from all students list and teachers students list
        /// </summary>
        /// <param name="student">Given student</param>
        public void RemoveStudent(Student student)
        {
            student._teacher._students.Remove(student);
            _studentService.Remove(student);
        }

        /// <summary>
        /// Adds teacher to teachers list
        /// </summary>
        /// <param name="teacher">Given teacher</param>
        public void AddTeacher(Teacher teacher)
        {
            _teacherService.Add(teacher);
        }

        /// <summary>
        /// Removes given teacher by id from teachers list and all students parameters
        /// </summary>
        /// <param name="guId">Given id</param>
        public void RemoveTeacher(Guid guId)
        {
            Teacher teacher = _teacherService.Get(guId);
            List<Teacher> update = _teacherService.GetAll();
            for (int i = 0; i < update.Count; i++)
            {
                if (update[i] == teacher)
                    update.Remove(teacher);
            }
            _teacherService.UpdateTeachersList(update);

            _teacherService.Remove(teacher);
            List<Student> StUpdate = _studentService.GetAll();
            for (int i = 0; i < StUpdate.Count; i++)
            {
                if (StUpdate[i]._teacher == teacher)
                    StUpdate[i]._teacher = default(Teacher);
            }
            _studentService.UpdateStudentsList(StUpdate);
        }

        /// <summary>
        /// Removes given teacher from teachers list and all students parameters
        /// </summary>
        /// <param name="teacher">Given teacher</param>
        public void RemoveTeacher(Teacher teacher)
        {
            _teacherService.Remove(teacher);
            List<Student> update = _studentService.GetAll();
            for (int i = 0; i < update.Count; i++)
            {
                if (update[i]._teacher == teacher)
                    update[i]._teacher = default(Teacher);
            }
            _studentService.UpdateStudentsList(update);
        }

        /// <summary>
        /// Swappes given students teachers, updates all students list and both teachers students lists
        /// </summary>
        /// <param name="student">Given student</param>
        /// <param name="teacherOld">Old teacher</param>
        /// <param name="teacherNew">New teacher</param>
        public void SwappTeacherForOne(Student student, Teacher teacherOld, Teacher teacherNew)
        {
            student._teacher = teacherNew;
            List<Student> update = _studentService.GetAll();
            for (int i = 0; i < update.Count; i++)
            {
                if (update[i] == student)
                    update[i]._teacher = teacherNew;
            }
            _studentService.UpdateStudentsList(update);
            teacherOld._students.Remove(student);
            teacherNew._students.Add(student);
        }

        /// <summary>
        /// Swappes one teacher to another for all students (uses teacher id)
        /// </summary>
        /// <param name="student"></param>
        /// <param name="teacherOld"></param>
        /// <param name="teacherNew"></param>
        public void SwappTeacherForAll(Student student, Teacher teacherOld, Teacher teacherNew)
        {
            List<Student> update = _studentService.GetAll();
            for (int i = 0; i < update.Count; i++)
            {
                if (update[i]._teacher.GetId() == teacherOld.GetId())
                    update[i]._teacher = teacherNew;
            }
            _studentService.UpdateStudentsList(update);
            teacherOld._students.Remove(student);
            teacherNew._students.Add(student);
        }
    }
}
