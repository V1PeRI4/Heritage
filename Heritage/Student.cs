using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class Student : Humanz
    {
        public Student(string name, int age, string alive, int yearsofstudy) : base(name, age, alive)
        {
            YearsOfStudying = yearsofstudy;
        }


        public int YearsOfStudying { get; set; }

        public override string ToString()
        {
            return $"Группа - Люди\n" +
                $"Имя - {Name}\n" +
                $"Возраст - {Age}\n" +
                $"Живой? - {Alive}\n" +
                $"Лет обучения - {YearsOfStudying} года\n";
        }
    }
}
