namespace FountainDesign
{
    public class FixtureWaterMist : FixtureWater
    {

        public FixtureWaterMist(string inType, string inSize, byte inEffectHeight, byte inQuantity)
                                    : base(inType, inSize, inEffectHeight, inQuantity)
        {
            f_Type = inType;
            f_Size = inSize;
            effectHeight = inEffectHeight;
            quantity = inQuantity;
            f_minPressure = 7;

            effectPressure = set_WorkingPressure(f_minPressure, f_Size, effectHeight);
        }
    }
}