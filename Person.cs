using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac45
{
    class Person<T>
    {
        public T Id { get;}
        public string Name { get; }
        public Person() { }
        public Person(T id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
