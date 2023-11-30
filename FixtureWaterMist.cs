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

            set_effectPressure(f_Type, f_Size, f_minPressure, effectHeight);
        }
    }
}