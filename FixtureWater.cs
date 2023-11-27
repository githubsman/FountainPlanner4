
using System;
using FountainDesign;

namespace FountainDesign
{
    public class FixtureWater
    {
        //interface ISpecs
        //{
        //    string Model_ID { get; set; }
        //    //string Description { get; set; }
        //    string Type { get; set; }
        //    string Size { get; set; }
        //    //    ... etc.
        //}

        public string Model_ID = "HBN";
        public string Type;             // "HBN", "Hollow bore", "jet", "small" 
        public string Effect;           // "A solid stream of water in a flat shape (like a fan)."
        public string Size;             // small, medium, large
        public byte Weight;             // hectograms  ( 5 == 1.1 lbs )
        //public byte Pressure;         // PSI
        //public string Description;    //
        //public string Construction;   // "Machined cast bronze and brass construction..."
        //public bool flowActive;       // false        for simulating system-total pressure states

        public byte EffectHeight
        {
            get { return this.EffectHeight; }
            set { byte itemNo = value; }
        }


        public byte Pressure
        {
            get { return 4; } 
            set 
            {
                double thisPressure = (EffectHeight / 2);  // multiplierPressure = 2 ? 
                thisPressure = thisPressure * Pressure;
                string myMsg = Model_ID + ": " + this.EffectHeight + " = " + thisPressure;
                Logger.logEntry("Info", myMsg);
            }
        }

    }

    public class FixtureWaterJet : FixtureWater
    {
        public string Model_ID = "JET";

    }

}