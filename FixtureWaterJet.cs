
using System;
using FountainDesign;

namespace FountainDesign
{
	public class FixtureWaterJet : FixtureWater
	{
		public string Type;             // "Hollow bore", "jet"
		public string Size;             // small, medium, large
		public byte EffectHeight;
		public byte Weight;             // hectograms  ( 5 == 1.1 lbs )
		public byte Pressure;           // PSI
		public FixtureWaterJet(string inType, string inSize, byte inEffectHeight, byte inWeight)
        {
			//Model_ID = "Jet";
			//Effect = "A solid stream of water";
			//Construction = "Machined cast bronze and brass construction";
			this.Type = inType;
			this.Size = inSize;
			this.EffectHeight = inEffectHeight;
			this.Weight = inWeight;
			this.Pressure = Convert.ToByte(EffectHeight * 3);
		}


	}

}