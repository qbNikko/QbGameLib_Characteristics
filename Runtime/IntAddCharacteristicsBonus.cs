namespace QbGameLib_Characteristics
{
    public struct IntAddCharacteristicsBonus : ICharacteristicsBonus<int>
    {
        private int _bonus;

        public IntAddCharacteristicsBonus(int bonus)
        {
            this._bonus = bonus;
        }

        public int Get()
        {
            return _bonus;
        }

        public int Apply(int currentValue)
        {
            return currentValue + _bonus;
        }
    }
}