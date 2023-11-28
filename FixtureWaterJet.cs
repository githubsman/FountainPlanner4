
using System;
using FountainDesign;

namespace FountainDesign
{

	// FIXME This subclass is not recognized!

	public class FixtureWaterJet : FixtureWater
	{
		public string Type;             // "Hollow bore", "jet"
		public string Size;             // small, medium, large
		public byte EffectHeight;
		public byte Weight;             // hectograms  ( 5 == 1.1 lbs )
										//public byte Pressure;         // PSI
		public FixtureWaterJet(string inType, string inSize, byte inEffectHeight, byte inWeight)
        {
			//Model_ID = "Jet";
			//Effect = "A solid stream of water";
			//Construction = "Machined cast bronze and brass construction";
			Type = inType;
			Size = inSize;
			EffectHeight = inEffectHeight;
			Weight = inWeight;
		}


	}

	//public static class JET_Small : Fixture_JET { Weight = 5;		basePressure = 7; }
	//public static class JET_Medium : Fixture_JET { Weight = 9;	basePressure = 7; }
	//public static class JET_Large : Fixture_JET { Weight = 16;	basePressure = 7; }
}