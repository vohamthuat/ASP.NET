using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public DateTime DoB { get; set; }

        public int GetAges()
        {
            return (DoB.Year - DateTime.Now.Year);
        }
    }
}
