using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TestClass
    {
        int Id { get; set; }
        public string Name { get; set; }    
        public TestClass(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
