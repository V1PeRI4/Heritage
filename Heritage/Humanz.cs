using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class Humanz
    {
        public Humanz(string name, int age, string alive)
        {
            Name = name;
            Age = age;
            Alive = alive;
        }


        public string Name { get; set; }
        public int Age { get; set; }
        public string Alive { get; set; }

        public override string ToString()
        {
            return $"Группа - Люди\n" +
                $"Имя - {Name}\n" +
                $"Возраст - {Age}\n" +
                $"Живой? - {Alive}\n";
        }
    }
}