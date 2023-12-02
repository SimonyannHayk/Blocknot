using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    internal class Record
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Record()
            : this("unknown", "unknown")
        {
        }

        public Record(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"{Name} ----- {Phone}";
        }
    }
}
