using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heritage;

namespace Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musician musician = new Musician("Никита", 17,"Живой", 5);
            Person person = new Person("Тиань ань", 27, "Ненадолго", -1337);
            Student student = new Student("Тимофей", 18, "Вроде", 2);
            Guitarist guitarist = new Guitarist("Виктор", 38, "Жив", 7);
            Console.WriteLine(musician);
            Console.WriteLine(person);
            Console.WriteLine(student);
            Console.WriteLine(guitarist);
            Console.ReadKey();
        }
    }
}