using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Athlete : Person
    {
        public string fname;
        public Athlete(string name , string food):base(food)
        {
            fname = name;

          
        }
        public string Getname()
        {
            return fname + "" + base.getname();

        }
    }
}
