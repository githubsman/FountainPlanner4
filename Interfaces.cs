using System;

namespace FountainDesign
{
	public interface IFixtureWater
	{
		byte EffectHeight(string size, byte pressure);
		byte set_WorkingPressure(byte f_minPressure, string size, byte effectHeight);
		void WaterFlow(bool Active);
		//bool IsFlowActive();		//SOMEDAY  get_WaterFlow
	}

	// FIXME public interface IFixtureWaterJet
	// {
	// 	byte minPressure;
	// }

}


