namespace QbGameLib_Characteristics
{
    public struct IntPercentCharacteristicsBonus : ICharacteristicsBonus<int>
    {
        private float _bonus;

        public IntPercentCharacteristicsBonus(float bonus)
        {
            this._bonus = bonus;
        }

        public float Get()
        {
            return _bonus;
        }

        public int Apply(int currentValue)
        {
            return (int)(currentValue * _bonus);
        }
    }
}