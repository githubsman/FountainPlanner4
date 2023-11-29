
/* FixtureWater is the base class for a water nozzle.  
 * See real-life details about fountain nozzles in the docs/ folder - 
 *  enough to allow thorough modeling, but I don't expect to do that.  
 * 
 *    TODO allow a variety of sizes (for most kinds);
 *           size determines basePressure,
 *           basePressure with EffectHeight determines Pressure,
 *           Pressure contributes to totalPressure.
 * 
 *    FUTURE (or GONE WILD):  
 *      //public bool flowActive;   // For simulating system-total pressure states.
 *                                  // This gets interesting when you have a control system that
 *                                  // turns nozzles off and on, either in sync or (apparent) random.
 *      //public string Description;    // Marketing 
 *      //public string Construction;   // Eng. spec'n:  "Machined cast bronze and brass construction..."
 *      //public string Aesthetic;      // "A solid stream of water in a flat shape (like a fan)."
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
        public byte Pressure;           // PSI

        public FixtureWater()
        {
            // Type = inType; 
            // Size = inSize; 
            // EffectHeight = inEffectHeight;
            // Weight = inWeight;
        }

        public int getPressure()
        {

            double thisPressure = (EffectHeight / 2);  // multiplierPressure = 2 ? 
            thisPressure = thisPressure * Pressure;

            // TODO Get the logger to work again, and make meaningful entries.
            // string myMsg = Model_ID + ": " + EffectHeight + " = " + thisPressure;
            // Logger.logEntry("Info", myMsg);

            return Convert.ToByte(thisPressure);
        }
    }

}
