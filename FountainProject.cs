
/* FountainProject is the top level within Fountain Design.  It expects a set of nozzles that 
 * create various effects.  (Inspiration https://www.fountainpeople.com/products.)
 * 
 * BIG CHALLENGE, I don't know how to set up get, set. 
 * 
 * FUTURE (or GONE WILD):  
 *      // static int ProjectCost = 10000;      // cost constraint in dollars
 *      
 */

using System;
using FountainDesign;


//MARK Global rename for namespace: Ctrl-R, Ctrl-R
namespace FountainDesign
{
    public class FountainProject
    {
        public int MaxPressureTotal = 1500;     // engineering constraint in PSI
                                                // for simulating system-total pressure states

        public FixtureWater[] myWaterFixtures = new FixtureWater[3];

        public void FountainProjectBegin()
        {
            myWaterFixtures = new FixtureWater[3];
        }

        public int getTotalPressure()
        {
            // FIXME Improve calculation (no real physics needed... 
            //                      ... this isn't even collecting entries from the UI.

            // TODO Implement nozzle count (the user form offers "quantity" but does nothing). 
            int totalPressure = 0;
            int myPressure;
            for (int i = 0; i < 3; i++)
            {
                myPressure = myWaterFixtures[i].Pressure;
                totalPressure += myPressure;
            }

            // Ensure MaxPressureTotal is not exceeded.
            //      TODO Raise flag in UI if it is exceeded.
            if ((int)totalPressure > MaxPressureTotal)
            {
                totalPressure = MaxPressureTotal;
            }

            return totalPressure;
        }
    }

}