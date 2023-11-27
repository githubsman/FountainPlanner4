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

        public string Model_ID;
        public string Type;
        public string Size;             // "HBN", "Hollow bore", "jet", "small" 
        public string Effect;           // "A solid stream of water in a flat shape (like a fan)."
        public byte Weight;             // hectograms  ( 5 == 1.1 lbs )
        //public byte Pressure;           // PSI
        //public string Description;    //
        //public string Construction;   // "Machined cast bronze and brass construction..."
        //public bool flowActive;       // for simulating system-total pressure states

        public byte EffectHeight
        {
            get { return this.EffectHeight; }
            set { byte itemNo = value; }
        }


        public byte Pressure
        {
            get { return this.Pressure; } 
            set 
            {
                double thisPressure = (EffectHeight / 2);  // multiplierPressure = 2 ? 
                thisPressure = thisPressure * Pressure;
                string myMsg = Model_ID + ": " + this.EffectHeight + " = " + thisPressure;
                Logger.logEntry("Info", myMsg);
            }

        }

        //internal byte SupplyPressure(string fixtureSize, string nozzleType, byte effectHeight)
        //{

        //    byte basePressure;
        //    double thisPressure, multiplierPressure;

        //    switch (nozzleType)
        //    {
        //        case "spray":
        //            basePressure = 5;
        //            break;
        //        case "mist":
        //            basePressure = 7;
        //            break;
        //        case "jet":
        //            basePressure = 6;
        //            break;
        //        default:
        //            basePressure = 0;
        //            break;
        //    }

        //    switch (fixtureSize)
        //    {
        //        case "small":
        //            multiplierPressure = 0.5;
        //            break;
        //        case "medium":
        //            multiplierPressure = 1.0;
        //            break;
        //        case "large":
        //            multiplierPressure = 1.5;
        //            break;
        //        default:
        //            multiplierPressure = 0;
        //            break;
        //    }

        //    //  double   =  integer     *    double          * (  integer    / integer )
        //    thisPressure = basePressure * multiplierPressure * (effectHeight / 2);

        //    Logger.logEntry("info", "pressure = " + thisPressure as string);

        //    return (byte)thisPressure;
        //}
    }
}