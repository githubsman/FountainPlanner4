﻿
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
 *      
 */ 
using System;
using FountainDesign;       // LEARN why is 'using LocalNamespace' needed or not needed?

namespace FountainDesign
{
    public class FixtureWater
    {



        //interface ISpecs   //TODO? Set up an interface
        //{
        //    string Type { get; set; }
        //    string Size { get; set; }     //   etc.
        //}

        public string Model_ID = "HBN"; // "HBN", "JET"
        public string Type;             // "Hollow bore", "jet"
        public string Effect;           // "A solid stream of water in a flat shape (like a fan)."
        public string Size;             // small, medium, large
        public byte Weight;             // hectograms  ( 5 == 1.1 lbs )
        //public byte Pressure;         // PSI


        public byte EffectHeight
        {
            get { return EffectHeight; }
            set { byte EffectHeight; }
        }


        public byte Pressure
        {
            get { return 4; } 
            set 
            {
                double thisPressure = (EffectHeight / 2);  // multiplierPressure = 2 ? 
                thisPressure = thisPressure * Pressure;
                string myMsg = Model_ID + ": " + EffectHeight + " = " + thisPressure;
                Logger.logEntry("Info", myMsg);
            }
        }
    }

}