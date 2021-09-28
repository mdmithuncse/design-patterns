using System;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to singleton design pattern");

            Parallel.Invoke(
                    () => PrintStudentDetails(),
                    () => PrintTeacherDetails()
                );

            Console.ReadLine();
        }

        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.GetInstance();
            fromTeacher.PrintDetails("From Teacher");
        }

        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.GetInstance();
            fromStudent.PrintDetails("From Student");
        }
    }
}
