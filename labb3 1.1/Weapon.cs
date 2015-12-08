using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb3_1._1
{
    public class Weapon
    {
        private string configuration;
        private string model;
        private string energyOutput;

        public void SetConfiguration(string configuration)
        {
            this.configuration = configuration;
        }
        public string GetConfiguration()
        {
            return configuration;
        }
        public void SetModel(string model)
        {
            this.model = model;
        }
        public string GetModel()
        {
            return model;
        }
        public void SetEnergyOutput(string energyOutput)
        {
            this.energyOutput = energyOutput;
        }
    }
}
