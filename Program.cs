using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var college = new College
            {
                Name = "Московский Государственный Университет",
                Address = new Address { Street = "Ленинские горы", City = "Москва" }
            };

            college.Teachers.Add(new Teacher { FIO = "Иванов Иван Иванович", Course = "Математика" });
            college.Teachers.Add(new Teacher { FIO = "Петрова Анна Сергеевна", Course = "Физика" });
            college.Teachers.Add(new Teacher { FIO = "Сидоров Петр Петрович", Course = "Химия" });

            college.ShowAll();
            Console.ReadLine();
        }
    }
}
