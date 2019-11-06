using DataAccessLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IBusinessLayer
    {
        #region Standard
        IEnumerable<Standard> GetAllStandards();

        Standard GetStandardByID(int id);

        Standard GetStandardByName(string name);

        void AddStandard(Standard standard);

        void UpdateStandard(Standard standard);

        void RemoveStandard(Standard standard);
        #endregion

        #region Student
        IList<Student> GetAllStudents();

        Student GetStudentByID(int id);

        Student GetStudentByName(string name);

        void AddStudent(Student student);

        void UpdateStudent(Student student);

        void RemoveStudent(Student student);

        #endregion

        #region Course
        IList<Course> GetAllCourse();

        Course GetCourseByID(int id);

        Course GetCourseByName(string name);

        void AddCourse(Course course);

        void UpdateCourse(Course course);

        void RemoveCourse(Course course);

        #endregion

        #region Teacher
        IList<Teacher> GetAllTeacher();

        Teacher GetTeacherByID(int id);

        Teacher GetTeacherByName(string name);

        void AddTeacher(Teacher teacher);

        void UpdateTeacher(Teacher teacher);

        void RemoveTeacher(Teacher teacher);

        #endregion
    }
}