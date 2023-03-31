using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heavenly_visions
{
    public class Person
    {
        private string name;
        private int tourID;

        public Person(string name, int tourID)
        {
            this.name = name;
            this.tourID = tourID;
        }

        public string Name { get => name; set => name = value; }
        public int TourID { get => tourID; set => tourID = value; }

        public virtual string UserInput() 
        {

        }
    }
}
