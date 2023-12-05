using System;

namespace FountainDesign
{
	public interface IFixtureWater
	{
		byte EffectHeight(string size, byte pressure);
		byte set_WorkingPressure(string size, byte effectHeight);
		void WaterFlow(bool Active);
		bool IsFlowActive();
	}

}


