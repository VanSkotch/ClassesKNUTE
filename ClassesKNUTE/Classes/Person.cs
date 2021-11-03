using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesKNUTE.Classes
{
    public abstract class Person
    {
        private String firstName;
        private String lastName;
        private String patronym;
        private DateTime birthdate;
        private String idCode;

        public String FirstName
        {
            get { return firstName; }
            set
            {
                foreach (Char c in value)
                {
                    if (!Char.IsLetter(c) && c != '\'' && c != '-') throw new Exception("Введене ім'я некоректне!");
                }
                firstName = value;
            }
        }

        public String LastName
        {
            get { return lastName; }
            set
            {
                foreach (Char c in value)
                {
                    if (!Char.IsLetter(c) && c != '\'' && c != '-') throw new Exception("Введене прізвище некоректне!");
                }
                lastName = value;
            }
        }

        public String Patronym
        {
            get { return patronym; }
            set
            {
                foreach (Char c in value)
                {
                    if (!Char.IsLetter(c) && c != '\'' && c != '-') throw new Exception("Введене ім'я по-батькові некоректне!");
                }
                patronym = value;
            }
        }

        public virtual DateTime Birthdate
        {
            get { return birthdate; }
            set
            {
                int age = DateTime.Now.Year - value.Year;
                if (DateTime.Now.Month < value.Month || (DateTime.Now.Month == value.Month && DateTime.Now.Day < value.Day)) age--;
                if (age >= 0 && age < 130) birthdate = value.Date;
                else throw new Exception("Введена дата народження некоректна! Вік людини має бути від 0 до 130.");
            }
        }

        public String IDcode
        {
            get { return idCode; }
            set
            {
                int numbers = 0;
                foreach (Char letter in value)
                {
                    if (Char.IsNumber(letter)) numbers++;
                }
                if (numbers == value.Length && value.Length == 10) idCode = value;
                else throw new Exception("Введений ідентифікаційний код некоректний!");
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - Birthdate.Year;
                if (DateTime.Now.Month < Birthdate.Month || (DateTime.Now.Month == Birthdate.Month && DateTime.Now.Day < Birthdate.Day)) age--;
                return age;
            }
        }

        public Person(String firstName, String lastName, String patronym, DateTime birthdate, String idCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronym = patronym;
            Birthdate = birthdate;
            IDcode = idCode;
        }
    }
}
