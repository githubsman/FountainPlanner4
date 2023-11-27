using System;
using FountainDesign;

namespace FountainDesign
{
    public class FountainProject
    {
        public int MaxPressureTotal = 1500;     // engineering constraint in PSI
                                                // for simulating system-total pressure states
                                                //static int ProjectCost = 10000;         // cost constraint in dollars

        //static string[] arrWtrFixtures;
        public FixtureWater[] myWaterFixtures = new FixtureWater[3];

        public void FountainProjectBegin()
        {
            //TODO start an array for water fixtures
            //arrWtrFixtures = new arrWtrFixtures[3];       // array  REF RMiles p62

            myWaterFixtures = new FixtureWater[3];

            //FixtureWater fixture_01 = new FixtureWater();

        }

        public int getTotalPressure()
        {

            int totalPressure = 0;
            int myPressure;
            for (int i = 0; i < 3; i++)
            {

                myPressure = this.myWaterFixtures[i].Pressure;
                totalPressure += myPressure;
            }

            //TODO try-catch : ensure MaxPressureTotal is not exceeded. This is a stub workaround:
            if ((int)totalPressure > MaxPressureTotal)
            {
                return MaxPressureTotal;
            }

            return totalPressure; //TODO make the calculation real
        }
    }

}