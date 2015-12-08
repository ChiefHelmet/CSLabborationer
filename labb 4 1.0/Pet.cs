using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_4_1._0
{
    class Pet
    {
        private string name;
        private string species;
        private int age;
        private string color;
        private bool isACoward;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else { throw new Exception("Fel värde på Name"); }
            }
        }
        public string Species
        {
            get { return species; }
            set
            {
                if (value != null)
                {
                    species = value;
                }
                else { throw new Exception("Fel värde på Species"); }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else { throw new Exception("Fel värde på Age"); }
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                if (value != null)
                {
                    color = value;
                }
                else throw new Exception("Fel värde på color");
            }
        }
        public bool IsACoward
        {
            get { return isACoward; }
            set { isACoward = value; }
        }
        public Pet()
        {
            Name = "Lemmy";
            Species = "Budgerigar";
            Age = 4;
            Color = "Yellow";
            IsACoward = false;
        }
        public override string ToString()
        {
            return $"Name: {Name}. \r\nSpecies: {Species}. \r\nAge: {Age}. \r\nColor: {Color}. \r\nIsACoward: {IsACoward}";
        }
    }
}
