using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb3_1._0
{
    public class Person
    {
        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            this.name = name;
        }
    }
}
