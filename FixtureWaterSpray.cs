namespace FountainDesign
{
    public class FixtureWaterSpray : FixtureWater
    {
       
        public FixtureWaterSpray(string inType, string inSize, byte inEffectHeight, byte inQuantity) 
                                    : base(inType, inSize, inEffectHeight, inQuantity)
        {
            f_Type = inType;
            f_Size = inSize;
            effectHeight = inEffectHeight;
            quantity = inQuantity;
            f_minPressure = 5;

            set_effectPressure(f_Type, f_Size, f_minPressure, effectHeight);
        }
    }
}