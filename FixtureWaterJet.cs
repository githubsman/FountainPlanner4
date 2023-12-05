namespace FountainDesign
{
    public class FixtureWaterJet : FixtureWater
    { 
        public FixtureWaterJet(string inType, string inSize, byte inEffectHeight, byte inQuantity)
                                    : base(inType, inSize, inEffectHeight, inQuantity)
        {
            f_Type = inType;
            f_Size = inSize;
            effectHeight = inEffectHeight;
            quantity = inQuantity;
            f_minPressure = 4;

            effectPressure = set_WorkingPressure(f_minPressure, f_Size, effectHeight);
        }
    }
}