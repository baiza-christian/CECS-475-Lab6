using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System;

namespace BusinessLayer
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IStandardRepository _standardRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly ITeacherRepository _teacherRepository;

        public BusinessLayer()
        {
            _standardRepository = new StandardRepository();
            _studentRepository = new StudentRepository();
            _courseRepository = new CourseRepository();
            _teacherRepository = new TeacherRepository();
        }

        #region Standard
        public IEnumerable<Standard> GetAllStandards()
        {
            return _standardRepository.GetAll();
        }

        public Standard GetStandardByID(int id)
        {
            return _standardRepository.GetById(id);
        }

        public Standard GetStandardByName(string name)
        {
            return _standardRepository.GetSingle(
                s => s.StandardName.Equals(name),
                s => s.Students);
        }

        public void AddStandard(Standard standard)
        {
            _standardRepository.Insert(standard);
        }

        public void UpdateStandard(Standard standard)
        {
            _standardRepository.Update(standard);
        }

        public void RemoveStandard(Standard standard)
        {
            _standardRepository.Delete(standard);
        }
        #endregion

        #region Student
        // IMPLEMENT THESE 

        public IList<Student> GetAllStudents() 
        {
            return _studentRepository.GetList();
        }
        public Student GetStudentByID(int id)
        {
            return _studentRepository.GetById(id);
        }
        public Student GetStudentByName(string name) 
        {
            //Implement this
            return _studentRepository.GetByName(name);
        }
        public void AddStudent(Student student)
        {
            _studentRepository.Insert(student);
        }
        public void UpdateStudent(Student student)
        {
            _studentRepository.Update(student);
        }
        public void RemoveStudent(Student student)
        {
            _studentRepository.Delete(student);
        }

        #endregion

        #region Course
        public IList<Course> GetAllCourse()
        {
            return _courseRepository.GetList();
        }

        public Course GetCourseByID(int id)
        {
            return _courseRepository.GetById(id);
        }

        public Course GetCourseByName(string name)
        {
            return _courseRepository.GetByName(name);
        }

        public void AddCourse(Course course)
        {
            _courseRepository.Insert(course);
        }

        public void UpdateCourse(Course course)
        {
            _courseRepository.Update(course);
        }

        public void RemoveCourse(Course course)
        {
            _courseRepository.Delete(course);
        }

        #endregion

        #region Teacher
        public IList<Teacher> GetAllTeacher()
        {
            return _teacherRepository.GetList();
        }

        public Teacher GetTeacherByID(int id)
        {
            return _teacherRepository.GetById(id);
        }

        public Teacher GetTeacherByName(string name)
        {
            return _teacherRepository.GetByName(name);
        }

        public void AddTeacher(Teacher teacher)
        {
            _teacherRepository.Insert(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _teacherRepository.Update(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            _teacherRepository.Delete(teacher);
        }

        #endregion
    }
}
