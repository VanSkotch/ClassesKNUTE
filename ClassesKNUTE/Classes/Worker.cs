using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesKNUTE.Classes
{
    public abstract class Worker : Person
    {
        private String position;
        private double salary;

        public virtual String Position
        {
            get { return position; }
            set { position = value; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value <= 0 || value > 200000) throw new Exception("Введена зарплатня некоретна!");
                else salary = value;
            }
        }

        public Worker(String firstName, String lastName, String patronym, DateTime birthdate, String idCode, String position, double salary) : base(firstName, lastName, patronym, birthdate, idCode)
        {
            Position = position;
            Salary = salary;
        }
    }
}