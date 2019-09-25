using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Person
    {
        public string fav_food;

        public Person(string food)
        {
            fav_food = food;
        }
        public string getname()
        {
            return (fav_food);
        }
    }
}
