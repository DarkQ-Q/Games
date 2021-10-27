using Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public abstract class Human
    {
        public string Name { get; set; }
        public string Surname{ get; set; }
        public string Patronymic { get; set; }

        private string _fullName;
        public string FullName
        {
            get { return $"{Surname} {Name} {Patronymic ?? ""}"; }
        }

        public int Age { get; set; }
        public Sex Sex { get; set; }

        public decimal Money { get; set; }
       
        public Human()
        {

        }

        public Human(string fullName, int age, Sex sex)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Age = age;
            Sex = sex;
        }

        public Human(string name, string surname, string patronymic, int age, Sex sex)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Age = age;
            Sex = sex;
        }

        public Human(string name, string surname, string patronymic, int age, Sex sex, decimal money)
            :this(name, surname, patronymic, age, sex)
        {
            Money = money;
        }
    }
}
