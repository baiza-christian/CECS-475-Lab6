
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

        public static int inputValidation(int min, int max)
        {
            int lower = min;
            int upper = max;
            int userInput = 0;
            bool istrue = true;
            return userInput;
        }

        public static string menuTableTeacher()
        {
            Console.WriteLine("\nTable Teacher\n1. Create Teacher\n2. Read Teacher\n3. Update Teacher\n4. Delete Teacher\n5. Display Teachers\n");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string menuTableCourse()
        {
            Console.WriteLine("\nTable Course\n1. Create Course\n2. Read Course\n3. Update Course\n4. Delete Course\n5. Display Courses\n");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static void Main(string[] args)
        {

            IBusinessLayer businessLayer = new BusinessLayer.BusinessLayer();

            bool cont = true;
            string userInput;

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
                        userInput = menuTableTeacher();
                        if (userInput == "1")
                        {
                            Teacher newTeach = new Teacher();
                            Console.WriteLine("Enter Teacher Name: ");
                            //string name = Console.ReadLine();
                            newTeach.TeacherName = Console.ReadLine();
                            businessLayer.AddTeacher(newTeach);
                        }
                        else if (userInput == "2")
                        {

                            Console.WriteLine("Enter ID: ");
                            string temp = Console.ReadLine();
                            int id = int.Parse(temp);
                            Teacher newTeach = businessLayer.GetTeacherByID(id);
                            if (newTeach != null)
                            {
                                Console.WriteLine(newTeach.TeacherId + " " + newTeach.TeacherName);
                                ICollection<Course> courses = newTeach.Courses;
                                foreach(Course course in courses)
                                {
                                    Console.WriteLine(course.CourseId + " " + course.CourseName);
                                }
                            }
                                

                            else
                                Console.WriteLine("Teacher not found!!!");
                            
                        }
                        else if (userInput == "3")
                        {
                            Console.WriteLine("Enter Teacher ID to Update: ");
                            string temp = Console.ReadLine();
                            int id = int.Parse(temp);
                            Teacher newTeach = businessLayer.GetTeacherByID(id);
                            Console.WriteLine("Enter Teacher new Name: ");
                            //string name = Console.ReadLine();
                            newTeach.TeacherName = Console.ReadLine();
                            businessLayer.UpdateTeacher(newTeach);
                        }
                        else if (userInput == "4")
                        {
                            Console.WriteLine("Enter Teacher ID to Delete: ");
                            string temp = Console.ReadLine();
                            int id = int.Parse(temp);
                            Teacher newTeach = businessLayer.GetTeacherByID(id);
                            businessLayer.RemoveTeacher(newTeach);
                        }
                        else
                        {
                            IList<Teacher> teachers = businessLayer.GetAllTeacher();
                            foreach (Teacher teacher in teachers)
                            {
                                Console.WriteLine(string.Format("{0} - {1}", teacher.TeacherId, teacher.TeacherName));
                            }
                        }
                        break;

                    case "2":
                        userInput = menuTableCourse();
                        if (userInput == "1")
                        {
                            Course newCourse = new Course();
                            Console.WriteLine("Enter New Course Name: ");
                            string name = Console.ReadLine();
                            newCourse.CourseName = name;
                            businessLayer.AddCourse(newCourse);
                        }
                        else if (userInput == "2")
                        {
                            
                            Console.WriteLine("Enter ID: ");
                            string temp = Console.ReadLine();
                            int id = int.Parse(temp);
                            Course newCourse = businessLayer.GetCourseByID(id);
                            if (newCourse != null)
                                Console.WriteLine(newCourse.CourseId + " " + newCourse.CourseName);
                            else
                                Console.WriteLine("Course not found!!!");
                            
                        }
                        else if (userInput == "3")
                        {
                            Console.WriteLine("Enter Course ID to Update: ");
                            string temp = Console.ReadLine();
                            int id = int.Parse(temp);
                            Course newCourse = businessLayer.GetCourseByID(id);
                            Console.WriteLine("Enter Course new Name: ");
                            newCourse.CourseName = Console.ReadLine();
                            businessLayer.UpdateCourse(newCourse);
                        }
                        else if (userInput == "4")
                        {
                            Console.WriteLine("Enter Course ID to Delete: ");
                            string temp = Console.ReadLine();
                            int id = int.Parse(temp);
                            Course newCourse = businessLayer.GetCourseByID(id);
                            businessLayer.RemoveCourse(newCourse);
                        }
                        else
                        {
                            IList<Course> courses = businessLayer.GetAllCourse();
                            foreach (Course course in courses)
                            {
                                Console.WriteLine(string.Format("{0} - {1}", course.CourseId, course.CourseName));
                            }
                           
                        }
                        break;

                    case "3":
                        cont = false;
                        break;
                    default:
                        continue;
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
