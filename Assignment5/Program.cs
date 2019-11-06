
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

        public static int input inputValidation(int min, int max)
        {
            int lower = min;
            int upper = max;
            int userInput = 0;
            bool 
        }

        public static void menuTableTeacher()
        {
            Console.WriteLine("\nTable Teacher\n1. Create Teacher\n2. Read Teacher\n3. Update Teacher\n4. Delete Teacher ");
            int userInput;
        }

        public static void menuTableCourse()
        {

        }

        public static void Main(string[] args)
        {

            IBusinessLayer businessLayer = new BusinessLayer.BusinessLayer();

            bool cont = true;

            while (cont)
            {
                Console.WriteLine("CRUD Operations School Database");
                Console.WriteLine("1) Table Teacher ");
                Console.WriteLine("2) Table Course ");
                Console.WriteLine("3) Exit");

                string menu1 = Console.ReadLine();


                switch (menu1)
                {
                    case "1":
                        menuTableTeacher();
                        break;

                    case "2":
                        menuTableCourse();
                        break;

                    case "3":
                        cont = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

/*

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
      */
