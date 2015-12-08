using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_4_1._0
{
    public class Bil
    {
        private string brand;
        private int numberOfGears;
        private string color;
        private string configuration;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (value != null)
                {
                    brand = value;
                }
                else { throw new Exception("Brand har inte ett giltigt värde."); }
            }
        }
        public int NumberOfGears
        {
            get { return numberOfGears; }
            set
            {
                if (value > 0 && value <= 20)
                {
                    numberOfGears = value;
                }
                else { throw new Exception("NumberOfGears har inte ett giltigt värde."); }
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
                else { throw new Exception("Color har inte ett igltigt värde."); }
            }
        }
        public string Configuration
        {
            get { return configuration; }
            set
            {
                var validConfiguration = value != null && value.ToLower().Trim() == "combi" || value.ToLower().Trim() == "cupe";
                if (validConfiguration)
                {
                    configuration = value.ToLower().Trim();
                }
                else { throw new Exception("fel värde på Car/configuration"); }
            }
        }

        public Bil()
        {
            brand = "Bentley";
            numberOfGears = 5;
            color = "Glossy Brown";
            configuration = "Hot-Rod";
        }
        public Bil(string brand, int numberOfGears, string color, string configuration)
        {
            Brand = brand;
            NumberOfGears = numberOfGears;
            Color = color;
            Configuration = configuration;
        }
        public override string ToString()
        {
            return $"Brand: {Brand}. \r\nNumberOfGears: {NumberOfGears}. \r\nColor: {Color}.\r\nConfiguration: {Configuration}\r\n\r\n";
        }
    }
}
