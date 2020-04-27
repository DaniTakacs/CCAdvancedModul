using System;
using CreateClass.Properties;

namespace CreateClass
{
    public class Person
    {
        protected string Name;
        protected DateTime BirthDate;
        protected readonly GenderEnum Gender;

        protected Person()
        {
        }

        private Person(string name, DateTime birthDate, GenderEnum gender)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Gender = gender;
        }

        protected enum GenderEnum
        {
            Male,
            Female
        }

        public override string ToString()
        {
            string personString = "My name is " + this.Name + ", I was born in " + this.BirthDate + " and I am a " +
                                  this.Gender;
            return personString;
        }

        private static void Main(string[] args)
        {
            var dani = new Person("Dani", new DateTime(1997, 03, 05), GenderEnum.Male);
            Console.WriteLine(dani.ToString());

            var kovacs = new Employee("Géza", new DateTime(2020, 04, 22), 1000, "léhűtő") {Room = new Room(111)};
            var kovacs2 = (Employee)kovacs.Clone();
            kovacs2.Room.Number = 112;
            Console.WriteLine(kovacs.ToString());
            Console.WriteLine(kovacs2.ToString());
            Console.ReadKey();
        }
    }
}