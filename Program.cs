using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QLSV1
{
    internal class Program
    {
        public static void MainProgram()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ; Console.WriteLine("Nhập thông tin về trường học");
            Console.Write("Tên trường: ");
            string schoolName = Console.ReadLine();
            Console.Write("ID Trường: ");
            string schoolID = Console.ReadLine();
            School school = new School(schoolName, schoolID);
            while (true)
            {
                Console.WriteLine("\n||^^^^^^^^^^ MENU PHẦN MỀM QUẢN LÝ SINH VIÊN: ^^^^^^^^^^ ||");
                Console.WriteLine("1. ||---Thêm sinh viên---                                  ||");
                Console.WriteLine("2. ||---danh sách sinh viên---                             ||");
                Console.WriteLine("3. ||---Xóa sinh viên---                                   ||");
                Console.WriteLine("4. ||---Tìm sinh Viên---                                   ||");
                Console.WriteLine("5. ||---END---                                             ||");
                Console.WriteLine("Nhập lựa chọn của bạn (1-5)");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(school);
                        break;
                    case "2":
                        PrintAllStudents(school);
                        break;
                    case "3":
                        RemoveStudent(school);
                        break;
                    case "4":
                        SearchStudent(school);
                        break;
                    case "5":
                        Console.WriteLine("Chương trình kết thúc");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }
            }
        }
        public static void AddStudent(School school)
        {
            Console.WriteLine("Số lượng học sinh bạn muốn thêm vào: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"\nNhập thông tin cho sinh viên #{i + 1}:");
                Console.Write("Họ và tên: ");
                string name = Console.ReadLine();
                Console.Write("Tuổi: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("MSSV: ");
                string id = Console.ReadLine();
                Console.Write("Giới tính (nam/nu): ");
                string gender = Console.ReadLine();
                Console.Write("Ngành học: ");
                string major = Console.ReadLine();
                Console.Write("Trường trung học phổ thông: ");
                string highSchoolName = Console.ReadLine();

                Student student;
                if (string.IsNullOrEmpty(major))
                {
                    student = new Student();
                }
                else
                {
                    student = new HighSchoolStudent();
                    ((HighSchoolStudent)student).HighSchoolName = highSchoolName;
                }
                student.Name = name;
                student.Age = age;
                student.ID = id;
                student.Gender = gender.ToLower();

                if (gender == "nam" || gender == "nu")
                {
                    gender = gender;
                }
                else
                {
                    Console.WriteLine("Giới tính không hợp lệ. Vui lòng chọn 'nam' hoặc 'nu'.");
                }

                school.AddStudent(student);
            }
        
    }

        public static void PrintAllStudents(School school)
        {
            Console.WriteLine("\nThông tin sinh viên trong trường " + school.SchoolName + ":");
            school.PrintAllStudent();
        }
        public static void RemoveStudent(School school)
        {
            Console.Write("\nNhập ID của sinh viên cần xóa: ");
            string idToRemove = Console.ReadLine();
            school.RemoveStudent(idToRemove);
        }

        public static void SearchStudent(School school)
        {

            Console.Write("\nNhập ID của sinh viên cần tìm: ");

            string idToSearch = Console.ReadLine();
            Student student = school.SearchStudent(idToSearch);
            if (student != null)
            {
                Console.WriteLine("Sinh viên được tìm thấy:");
                student.PrintInfo();
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên có ID " + idToSearch);
            }
        }
        static void Main(string[] args)
        {
            MainProgram();
        }
    }
}
