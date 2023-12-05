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

            effectPressure = set_WorkingPressure(f_Size, effectHeight);
        }
    }
}