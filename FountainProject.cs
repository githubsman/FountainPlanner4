
/* FountainProject is the top level within Fountain Design.  It expects a set of nozzles that 
 * create various effects.  (Inspiration https://www.fountainpeople.com/products.)
 * 
 * BIG CHALLENGE, I don't know how to set up get, set. 
 * 
 * FUTURE (or GONE WILD):  
 *      // static int ProjectCost = 10000;      // cost constraint in dollars
 *      
 */


// TODO Get the logger to work again, and make meaningful entries.
// string myMsg = Model_ID + ": " + effectHeight + " = " + thisPressure;
// Logger.logEntry("Info", myMsg);


using System;


//MARK Global rename for namespace: Ctrl-R, Ctrl-R
namespace FountainDesign
{
    public class FountainProject
    {
        public int MaxPressureTotal = 1500;     // engineering constraint in PSI
                                                // for simulating system-total pressure states

        //TODO make array count reflect user-form entries which vary in number of line-items 
        public FixtureWater[] myWaterFixtures = new FixtureWater[3];

        public void FountainProjectBegin()
        {
            myWaterFixtures = new FixtureWater[3];
        }

        public int getTotalPressure()
        {
            // FIXME Improve calculation (no real physics needed... 

            // TODO Implement nozzle count (the user form offers "f_Quantity" but does nothing). 
            int totalPressure = 0;
            int myPressure;
            int myQuantity;
            for (int i = 0; i < myWaterFixtures.Length; i++)
            {
                myPressure = myWaterFixtures[i].effectPressure;
                myQuantity = myWaterFixtures[i].quantity;
                myPressure = myPressure * myQuantity;

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