
/* FixtureWater is the base class for a water nozzle.  
 * See real-life details about fountain nozzles in the docs/ folder - 
 *  enough to allow thorough modeling, but I don't expect to do that.  
 * 
 * Varables with f_prefix are intrinsic to the nozzle;
 *  variables otherwise depend on implementation. 
 *  
 * TODO Make size a sub-class of nozzle:type
 *          Not every nozzle:type is subject to Size variation.  
 *           Size affects basePressure,
 *           basePressure with effectHeight determines Pressure,
 *           Pressure contributes to totalPressure.
 *
 * SOMEDAY:  flowActive       // For simulating system-total pressure states.
 * SOMEDAY:                           // The goal is scripting that simulates use of a control system
 * SOMEDAY:                           // to (de)activate nozzles in sync or (apparent) random patterns.
 * SOMEDAY:  f_Construction   // Eng. spec'n:  "Machined cast bronze and brass construction..."
 * SOMEDAY:  f_Aesthetic      // "A solid stream of water in a flat shape (like a fan)."
 * SOMEDAY:  f_Cost           // cost in dollars
 * SOMEDAY:  f_Weight         // hectograms  ( 5 == 1.1 lbs )    
 * SOMEDAY:    Weight  total for project, calculate
 */

using System;
using System.Windows;

namespace FountainDesign
{

    public class FixtureWater : IFixtureWater
    {
        //TODO Enter nozzle Type into calculation.
        public string f_Type;             // "Hollow bore", "jet"
        public string f_Size;             // small, medium, large
        public byte effectHeight;
        public byte quantity;
        public byte f_Weight;             // hectograms  ( 5 == 1.1 lbs )
        public byte f_minPressure;        // PSI
        public byte effectPressure;
        //public byte effectPressure { get; set; }

        public byte EffectHeight(string size, byte pressure)
        { return 4;  }

        public void WaterFlow(bool Active)
        { }
        public bool IsFlowActive()
        { return false;  }

        public FixtureWater(string inType, string inSize, byte inEffectHeight, byte inQuantity)
        {
            f_Type = inType;
            f_Size = inSize;
            effectHeight = inEffectHeight;
            quantity = inQuantity;
        }

        public byte set_WorkingPressure(byte f_minPressure, string size, byte effectHeight)
        {
            // This should be handled as a property of the nozzle
            // switch (size)
            // {
            //     case "small":   f_minPressure = 3; break;
            //     case "medium":  f_minPressure = 4; break;
            //     case "large":   f_minPressure = 5; break;
            // }

            // FIXME f_minPressure presents well in Debug, but final calculation is not affected. 
            double thisPressure = effectHeight / 2;  
            thisPressure = thisPressure * f_minPressure;

            return Convert.ToByte(thisPressure);
        }

    }
}


