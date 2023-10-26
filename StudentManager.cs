using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV1
{
    internal class StudentManager
    {
        private List<Student> students;
        public StudentManager()
        {
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void RemoveStudent(String id)
        {
            Student studentToRemove = students.Find(s => s.ID == id);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Student with ID " + id + "has been removed ");
            }
            else
            {
                Console.WriteLine("Student with ID" + id + "does not exist");
            }
        }
        
        public void SearchStudent(string id)
        {
            Student student = students.Find(s => s.ID == id);
            if (student != null)
            {
                Console.WriteLine("Student found:");
                student.PrintInfo();
               
            }
            else
            {
                Console.WriteLine("Student with ID" + id + "does not exist");
            }
        }
        public void PrintAllStudent()
        {
            foreach (var student in students)
            {
                student.PrintInfo();
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            }
        }
    }
}
