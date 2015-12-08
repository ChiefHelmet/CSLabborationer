using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_4_1._0
{
    class Book
    {
        private int numberOfPages;
        private bool isHardCover;
        private string measurements;
        //private string[] author;
        //skicka in hel array när man setter. new string[]{"sdfsdf","sdfsdf"}
        public int NumberOfPages
        {
            get { return numberOfPages; }
            set
            {
                if (value > 0)
                {
                    numberOfPages = value;
                }
                else
                {
                    throw new Exception("Fel värde på NumberOfPages");
                }
            }
        }
        public bool IsHardCover
        {
            get { return isHardCover; }
            set { isHardCover = value; }
        }
        public string Measurements
        {
            get { return measurements; }
            set { if (value != null)
                {
                    measurements = value;
                }
            }
        }
        //public string[] Author
        //{
        //    get { return author; }
        //    set { author = value; }
        //}

        public Book()
        {
            NumberOfPages = 50;
            IsHardCover = true;
            Measurements = "20X35cm";
        }

        //public Book()
        //{
        //    NumberOfPages = 50;
        //    IsHardCover = true;
        //    Measurements = "20X35cm";
        //    Author = { "Anonymous", "Unknown"}; //Måste ha loopar för att komma åt allt
        //}
        public override string ToString()
        {
            return $"NumberOfPages: {NumberOfPages}. \r\nIsHardCover: {IsHardCover}. \r\nMeasurement: {Measurements}. \r\n";
        }
    }
}
