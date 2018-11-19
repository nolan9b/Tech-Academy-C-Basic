using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeExercises
{
    class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, int number) : this(name)
        {
            Telephone = number;
        }

        public int Telephone { get; set; }
        public string Name { get; set; }
    }
}
