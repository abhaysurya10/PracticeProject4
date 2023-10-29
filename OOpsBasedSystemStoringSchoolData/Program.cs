using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpsBasedSystemStoringSchoolData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolManagement.GetStudentsInClass();
            SchoolManagement.GetSubjectsTaughtByTeacher();

            Console.ReadLine();
        }
    }
}
