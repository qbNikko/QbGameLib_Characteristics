namespace QbGameLib_Characteristics
{
    public struct FloatPercentCharacteristicsBonus : ICharacteristicsBonus<float>
    {
        private float _bonus;

        public FloatPercentCharacteristicsBonus(float bonus)
        {
            this._bonus = bonus;
        }

        public float Get()
        {
            return _bonus;
        }

        public float Apply(float currentValue)
        {
            return currentValue*_bonus;
        }
    }
}