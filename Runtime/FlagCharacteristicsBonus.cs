

using System.Collections.Generic;

namespace QbGameLib_Characteristics
{
    public class FlagCharacteristicsBonus : ICharacteristicsBonus<List<string>>
    {
        private string _flag;
        public string Get()
        {
            return _flag;
        }

        public List<string> Apply(List<string> currentValue)
        {
            currentValue.Add(_flag);
            return currentValue;
        }
    }
}