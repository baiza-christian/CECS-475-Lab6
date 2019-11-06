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
                            Console.WriteLine("Enter Teacher ID: ");
                            int id = Console.Read();
                            Console.WriteLine("Enter Teacher Name: ");
                            string name = Console.ReadLine();
                            newTeach.TeacherId = id;
                            newTeach.TeacherName = name;
                            businessLayer.AddTeacher(newTeach);
                        }
                        else if (userInput == "2")
                        {
                            Console.WriteLine("\n1. Find Teacher By Name\n2. Find Teacher by ID\n");
                            if (Console.ReadLine() == "1")
                            {
                                Console.WriteLine("Enter Name: ");
                                string name = Console.ReadLine();
                                Teacher newTeach = businessLayer.GetTeacherByName(name);
                                if (newTeach != null)
                                    Console.WriteLine(newTeach.TeacherId + " " + newTeach.TeacherName);
                                else
                                    break;
                            }
                            else
                            {
                                Console.WriteLine("Enter ID: ");
                                int id = Console.Read();
                                Teacher newTeach = businessLayer.GetTeacherByID(id);
                                if (newTeach != null)
                                    Console.WriteLine(newTeach.TeacherId + " " + newTeach.TeacherName);
                                else
                                    break;
                            }
                        }
                        else if (userInput == "3")
                        {
                            Console.WriteLine("Enter Teacher ID to Update: ");
                            int id = Console.Read();
                            Teacher newTeach = businessLayer.GetTeacherByID(id);
                            Console.WriteLine("Enter Teacher new Name: ");
                            string name = Console.ReadLine();
                            newTeach.TeacherName = name;
                            businessLayer.UpdateTeacher(newTeach);
                        }
                        else if (userInput == "4")
                        {
                            Console.WriteLine("Enter Teacher ID to Delete: ");
                            int id = Console.Read();
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
                            Console.WriteLine("Enter New Course ID: ");
                            int id = Console.Read();
                            Console.WriteLine("Enter New Course Name: ");
                            string name = Console.ReadLine();
                            newCourse.CourseId = id;
                            newCourse.CourseName = name;
                            businessLayer.AddCourse(newCourse);
                        }
                        else if (userInput == "2")
                        {
                            Console.WriteLine("\n1. Find Course By Name\n2. Find Course by ID\n");
                            if (Console.ReadLine() == "1")
                            {
                                Console.WriteLine("Enter Name: ");
                                string name = Console.ReadLine();
                                Course newCourse = businessLayer.GetCourseByName(name);
                                if (newCourse != null)
                                    Console.WriteLine(newCourse.CourseId + " " + newCourse.CourseName);
                                else break;
                            }
                            else
                            {
                                Console.WriteLine("Enter ID: ");
                                int id = Console.Read();
                                Course newCourse = businessLayer.GetCourseByID(id);
                                if (newCourse != null)
                                    Console.WriteLine(newCourse.CourseId + " " + newCourse.CourseName);
                                else break;
                            }
                        }
                        else if (userInput == "3")
                        {
                            Console.WriteLine("Enter Course ID to Update: ");
                            int id = Console.Read();
                            Course newCourse = businessLayer.GetCourseByID(id);
                            Console.WriteLine("Enter Course new Name: ");
                            string name = Console.ReadLine();
                            newCourse.CourseName = name;
                            businessLayer.UpdateCourse(newCourse);
                        }
                        else if (userInput == "4")
                        {
                            Console.WriteLine("Enter Course ID to Delete: ");
                            int id = Console.Read();
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
                        break;
                }
            }
        }
    }
}
