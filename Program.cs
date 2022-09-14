using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student objectStudent = new Student();
            objectStudent.Fname = "Ann";
            objectStudent.Lname = "Jones";
            objectStudent.StudentGroup = "1A";

            Teacher objectTeacher = new Teacher();
            objectTeacher.Fname = "Lisa";
            objectTeacher.Lname = "Smith";
            objectTeacher.TeachingSubject = "English";

            Console.WriteLine("Student: " + objectStudent.Fname);
            Console.WriteLine("Student: " + objectStudent.Lname);
            Console.WriteLine("Student: " + objectStudent.StudentGroup);

            Console.WriteLine("Teacher " + objectTeacher.Fname);
            Console.WriteLine("Teacher " + objectTeacher.Lname);
            Console.WriteLine("Teacher " + objectTeacher.TeachingSubject);
        }
    }
}
