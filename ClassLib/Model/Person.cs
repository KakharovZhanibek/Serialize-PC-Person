using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Model
{
    public class Person
    {
        public Person()
        {

        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }

        public List<W> WList { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
    }

    public class W
    {
        public DateTime date { get; set; }
        public string desc { get; set; }    
    }
}
