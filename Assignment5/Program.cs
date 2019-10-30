
using System;
using System.IO;
using System.Collections.Generic;
using DataAccessLayer;
using BusinessLayer;

namespace Assignment5
{
    class Program
    {
        static BusinessLayer.BusinessLayer bl = new BusinessLayer.BusinessLayer();
        
        public static void Main(string[] args)
        {
            //AddStandard();
            //AddStudent();
            //SearchStandardStudents();
            //break;
            IBusinessLayer businessLayer = new BusinessLayer.BusinessLayer();
            //Standard s0 = new Standard() { StandardId = 123, StandardName = "Standard1", Description = "First Standard" };
            //Standard s1 = new Standard() { StandardId = 321, StandardName = "Standard2", Description = "Second Standard" };
            //Student student0 = new Student() { StudentID = 0, StudentName = "Tri Nguyen", StandardId = 123 };
            //Student student1 = new Student() { StudentID = 1, StudentName = "Christian Baiza", StandardId = 321 };
            //businessLayer.AddStandard(s0);
            //businessLayer.AddStandard(s1);
            //businessLayer.AddStudent(student0);
            //businessLayer.AddStudent(student1);

            Console.WriteLine("Enter StudentID to Remove: ");
            int removeMe = Console.Read();

            Student s = businessLayer.GetStudentByID(removeMe);
            businessLayer.RemoveStudent(s);
            Console.Write(s.StudentID);
            Console.Write(s.StudentName);


            IList<Student> students = businessLayer.GetAllStudents();
            foreach (Student stud in students)
                Console.WriteLine(string.Format("{0} - {1} - {2}", stud.StudentID, stud.StudentName, stud.StandardId));

            IEnumerable<Standard> standards = businessLayer.GetAllStandards();
            foreach (Standard stand in standards)
                Console.WriteLine(string.Format("{0} - {1}", stand.StandardId, stand.StandardName));

            //SearchStandardStudents();
            Console.ReadLine();
        }
        //------------------- ReadCoice -------------------


        //------------------- SearchStandardStudents ------ 
        private static void SearchStandardStudents()
        {
            Console.Write("Enter Standard ID: ");

            int choice = Console.Read();

            Standard s = bl.GetStandardByID(choice);

            if (s == null)
            {
                Console.WriteLine("Standard not found!");
                return;
            }
            else if (s.Students == null || s.Students.Count == 0)
            {
                Console.WriteLine("This Standard has no Students!");
                return;
            }
            Console.WriteLine("\nContaining Students: {0}", s.Students.Count);
            foreach (Student student in s.Students)
                Console.WriteLine("- " + student.StudentName);
        }

        private static void AddStandard()
        {
            int id;
            string name, description;
            IBusinessLayer businessLayer = new BusinessLayer.BusinessLayer();

            Console.WriteLine("Enter Standard ID: ");
            id = Console.Read();

            Console.WriteLine("Enter Standard Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Standard Description: ");
            description = Console.ReadLine();

            Standard s = new Standard() { StandardId = id, StandardName = name, Description = description };

            businessLayer.AddStandard(s);
        }

        private static void AddStudent()
        {
            IBusinessLayer businessLayer = new BusinessLayer.BusinessLayer();

            Console.WriteLine("Enter Student ID: ");
            int id = Console.Read();

            Console.WriteLine("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Standard ID: ");
            int standardID = Console.Read();

            Student s = new Student() { StudentID = id, StudentName = name, StandardId = standardID };

            businessLayer.AddStudent(s);
        }
    }
}