using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV1
{
    internal class School
    {
        public string SchoolName { get; set; }
        public string SchoolID { get; set; }
        private List<Student> students;
        public School(string name, string id)
        {
            SchoolName = name;
            SchoolID = id;
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void RemoveStudent(String id)
        {
            Student studentToRemove = students.Find(x => x.ID == id);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Student with ID " + id + " has been removed from" + SchoolName + ".");
            }
            else
            {
                Console.WriteLine("Student with ID " + id + " does not exist in " + SchoolName + ".");
            }
        }
        public Student SearchStudent(string id)
        {
            return students.Find(x => x.ID == id);
        }
        public void PrintAllStudent()
        {
            Console.WriteLine("School: " + SchoolName);
            Console.WriteLine("School: " + SchoolID);
            Console.WriteLine("School List:");
            foreach (Student student in students)
            {
                student.PrintInfo();
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            }
        }
    }
}
