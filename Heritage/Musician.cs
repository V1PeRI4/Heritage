using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heritage;

namespace Heritage
{
    internal class Musician : Humanz
    {
        public Musician(string name, int age, string alive) : base(name, age, alive)
        {
        }

        public Musician(string name, int age, string alive, int yearsofplaying) : base(name, age, alive)
        {
            YearsOfPlaying = yearsofplaying;
        }


        public int YearsOfPlaying { get; set; }

        public override string ToString()
        {
            return $"Группа - Музыкант\n" +
                $"Имя - {Name}\n" +
                $"Возраст - {Age}\n" +
                $"Живой? - {Alive}\n" +
                $"Лет игры - {YearsOfPlaying} лет\n";
        }
    }
}