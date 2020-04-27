using System;
using CreateClass.Properties;

namespace CreateClass

{
    public class Employee : Person, ICloneable
    {
        private double _salary;
        private string _profession;
        public Room Room;
        
        public Employee(string name, DateTime birthDate, double salary, string profession)
        {
            Name = name;
            BirthDate = birthDate;
            _profession = profession;
            _salary = salary;
        }
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }


}