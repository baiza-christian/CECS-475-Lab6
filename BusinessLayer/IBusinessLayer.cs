﻿using DataAccessLayer;
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
    }
}