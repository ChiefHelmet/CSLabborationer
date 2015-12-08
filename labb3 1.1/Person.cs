using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb3_1._1
{
    public class Person
    {
        private string name;

        public void SetName(string snoppTomte)
        {
            this.name = snoppTomte;     //notera att här är 'this' överflödigt, eftersom att jag har döpt om 'name'
        }
        //public void SetName2(string name)
        //{
        //    this.name = name;           //Här är däremot 'this' nödvändigt. 'this' pekar på 'name' en nivå uppåt, så att den inte pekar på 'name' inom parateserna på rad 17.
        //}
        public string GetName()
        {
            return name;
        }
    }
}
