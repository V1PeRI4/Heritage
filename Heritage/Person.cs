using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heritage;
namespace Heritage
{
    internal class Person : Humanz
    {
        public Person(string name, int age, string alive, int socialcredit) : base(name, age, alive)
        {
            SocialCredit = socialcredit;
        }


        public int SocialCredit { get; set; }

        public override string ToString()
        {
            return $"Группа - Люди\n" +
                $"Имя - {Name}\n" +
                $"Возраст - {Age}\n" +
                $"Живой? - {Alive}\n" +
                $"Очков социального рейтинга - {SocialCredit}\n";
        }
    }
}
    