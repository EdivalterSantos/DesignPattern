using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = Singleton.Instance;
            fromEmployee.PrintDetails("This is the first message");

            Singleton fromStudent = Singleton.Instance;
            fromStudent.PrintDetails("This is the second message");

            Console.ReadLine();

        }
    }
}
