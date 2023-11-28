
/* FixtureWater is the base class for a water nozzle.  
 * See real-life details (not well modelled) in the docs/ folder.
 * 
 * A subclass is found in FixtureWaterJet.cs, but I can't get it working.  <<<< FIXME <<<<<<<<
 * 
 *    TODO allow a variety of sizes (for most kinds);
 *           size determines basePressure,
 *           basePressure with EffectHeight determines Pressure,
 *           Pressure contributes to totalPressure.
 * 
 *    FUTURE (or GONE WILD):  
 *      //public bool flowActive;   // For simulating system-total pressure states.
 *                          // This gets interesting when you have a control system that
 *                          // turns nozzles off and on, either in sync or (apparent) random.
 *      //public string Description;    // Marketing 
 *      //public string Construction;   // Eng. spec'n:  "Machined cast bronze and brass construction..."
 *      //public string Aesthetic;        // "A solid stream of water in a flat shape (like a fan)."
 */

using System;
using FountainDesign;       // LEARN why is 'using LocalNamespace' needed or not needed?


namespace FountainDesign
{
    public class FixtureWater
    {
        public string Type;             // "Hollow bore", "jet"
        public string Size;             // small, medium, large
        public byte EffectHeight;
        public byte Weight;             // hectograms  ( 5 == 1.1 lbs )
                                        //public byte Pressure;         // PSI
        //public FixtureWater(string inType, string inSize, byte inEffectHeight, byte inWeight)
        public FixtureWater()
        {
            // Type = inType; 
            // Size = inSize; 
            // EffectHeight = inEffectHeight;
            // Weight = inWeight;
        }

        //public byte getPressure
        //{
        //    get { return 4; }
        //    set
        //    {
        //        double thisPressure = (EffectHeight / 2);  // multiplierPressure = 2 ? 
        //        thisPressure = thisPressure * Pressure;

        //        // TODO Get the logger to work again, and make meaningful entries.
        //        // string myMsg = Model_ID + ": " + EffectHeight + " = " + thisPressure;
        //        // Logger.logEntry("Info", myMsg);
        //    }
        //}
    }

}
