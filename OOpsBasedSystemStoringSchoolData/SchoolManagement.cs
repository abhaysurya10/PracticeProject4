using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOpsBasedSystemStoringSchoolData
{
    public class SchoolManagement
    {
        public static List<Student> studList = new List<Student>()
        {
            new Student("Abhay","9","A"),new Student("Nikhil","10","B"),
            new Student("Faizan","9","A"),new Student("Vishnu","10","B")
        };

        public static List<Teacher> TeacherList = new List<Teacher>()
        {
            new Teacher("Arjun", "10th", "A") , new Teacher("Advika", "9th", "B"),
            new Teacher("James", "9th", "B") , new Teacher("Nidhi", "9th", "A"),
            new Teacher("Prajwal", "10th", "A") , new Teacher("Krupa", "9th", "A")
        };

        public static List<Subject> SubjectList = new List<Subject>()
        {
            new Subject("English","10","Arjun"), new Subject("Kannada", "9", "Advika"),
            new Subject("Maths","5","Krupa"), new Subject("Social", "8", "Nidhi"),
            new Subject("Science","7","Prajwal"), new Subject("History", "4", "James"),
        };


        public static void GetStudentsInClass()
        {
            Console.WriteLine("Enter Student Class:");
            var className = Console.ReadLine();
            var studentsInClass = studList.FindAll(s => s.Class == className).ToList();
            if (studentsInClass.Count != 0)
            {
                Console.WriteLine($"Students in class '{className}':");
                foreach (var student in studentsInClass)
                {
                    Console.WriteLine($"Student: {student.Name}, Class: {student.Class}, Section: {student.Section}");
                }
            }
            else
            {
                Console.WriteLine($"No students found in class '{className}'.");
                return;
            }
        }
        public static void GetSubjectsTaughtByTeacher()
        {
            Console.WriteLine("Enter Teacher Name:");
            var teacherName = Console.ReadLine();

            var subjectsTaughtByTeacher = SubjectList.Where(s => s.TeacherName == teacherName).ToList();
            if (subjectsTaughtByTeacher.Count != 0)
            {
                Console.WriteLine($"Subjects taught by '{teacherName}':");
                foreach (var subject in subjectsTaughtByTeacher)
                {
                    Console.WriteLine($"Subject: {subject.Name}, Subject Code: {subject.SubjectCode}, Teacher: {subject.TeacherName}");
                }
            }
            else
            {
                Console.WriteLine($"No subjects found taught by '{teacherName}'.");
                return;
            }
        }
    }
}
