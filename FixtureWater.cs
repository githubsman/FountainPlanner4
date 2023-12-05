
/* FixtureWater is the base class for a water nozzle.  
 * See real-life details about fountain nozzles in the docs/ folder - 
 *  enough to allow thorough modeling, but I don't expect to do that.  
 * 
 * TODO allow a variety of sizes (for most kinds);
 *           size determines basePressure,
 *           basePressure with effectHeight determines Pressure,
 *           Pressure contributes to totalPressure.
 * 
 * SOMEDAY:  flowActive       // For simulating system-total pressure states.
 * SOMEDAY:                           // On/Off reflects a control system that
 * SOMEDAY:                           // controls nozzles, either in sync or (apparent) random.
 * SOMEDAY:  f_Construction   // Eng. spec'n:  "Machined cast bronze and brass construction..."
 * SOMEDAY:  f_Aesthetic      // "A solid stream of water in a flat shape (like a fan)."
 * SOMEDAY:  f_Cost           // cost in dollars
 * SOMEDAY:  f_Weight         // hectograms  ( 5 == 1.1 lbs )*      
 */

using System;
using System.Windows;

namespace FountainDesign
{

    public class FixtureWater : IFixtureWater
    {
        //TODO Interfaces are here, now get Size and Type to affect calculation.
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
        //public FixtureWater()
        {
            
            f_Type = inType;
            f_Size = inSize;
            effectHeight = inEffectHeight;
            quantity = inQuantity;

            //set_effectPressure(f_Type, f_Size, f_minPressure, effectHeight);



        }

        public byte set_WorkingPressure(string size, byte effectHeight)
        {
            f_minPressure = 3;      //TODO let size determine base pressure
            double thisPressure = effectHeight / 2;  
            thisPressure = thisPressure * f_minPressure;

            return Convert.ToByte(thisPressure);
        }

        //internal void set_effectPressure(string f_Type, string f_Size, byte f_minPressure, byte effectHeight)
        //{
        //    double thisPressure = effectHeight / 2;  
        //    thisPressure = thisPressure * f_minPressure;

        //    effectPressure = Convert.ToByte(thisPressure);
        //}

    }
}


