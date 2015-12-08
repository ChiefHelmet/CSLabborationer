using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_4_1._0
{
    class Radio
    {
        private bool powerOn;
        private byte volume;
        private double frequency;
        private static int instanceCount; // gör en property utan en set '. Initiera fältet till 0 i en statisk konstruktor'- istället för public radio så skriver man static radio med en tom parameter-lista

        public bool PowerOn
        {
            get { return powerOn; }
            set
            {
                if (value != null)
                {
                    powerOn = value;
                }
                else
                {
                    throw new Exception("fel värde på on/off");
                }
            }
        }
        public byte Volume
        {
            get { return volume; }
            set
            {
                var validVolume = value >= 0 && value <= 100;
                if (validVolume)
                {
                    volume = value;
                }
                else { throw new Exception("fel värde på volume"); }
            }
        }
        public double Frequency
        {
            get { return frequency; }
            set
            {
                var validFrequency = value >= 20 && value <= 16000;
                if (validFrequency)
                {
                    frequency = value;
                }
                else
                {
                    throw new Exception("Fel värde på freuency");
                }
            }
        }
        public static int InstanceCount
        {
            get { return instanceCount; }
        }
        static Radio()
        {
            instanceCount = 0;
        }
        public Radio()
        {
            //PowerOn = false;
            Volume = 5;
            Frequency = 140.85;
            instanceCount++;
        }
        public Radio(byte volume, double frequency) :this()
        {
            //PowerOn = false;
            Volume = volume;
            Frequency = frequency;
        }

        public Radio(bool powerOn, byte volume, double frequency) :this(volume, frequency)
        {
            PowerOn = powerOn;
            //Volume = volume;
            //Frequency = frequency;
        }
        public override string ToString()
        {
            return $"PowerOn: {PowerOn}. \r\nVolume: {Volume}. \r\nFrequency: {Frequency}. \r\nInstanceCount: {InstanceCount}";
        }

    }
}