using System;
using System.Collections.Generic;

namespace QbGameLib_Characteristics
{
    public class CharacteristicsComponent
    {
        private Dictionary<string,object> _characteristicsBonusList;

        public CharacteristicsComponent()
        {
            Type type = typeof(string);
            _characteristicsBonusList = new Dictionary<string, object>(type.GetFields().Length);
        }

        public CharacteristicsComponent Register<N>(string type, ICharacteristics<N> characteristics)
        {
            _characteristicsBonusList.Add(type, characteristics);
            return this;
        }

        public void AddBonus<N>(string type, ICharacteristicsBonus<N> characteristics)
        {
            (_characteristicsBonusList[type]as ICharacteristics<N>)?.Add(characteristics);
        }
        
        public void RemoveBonus<N>(string type, ICharacteristicsBonus<N> characteristics)
        {
            (_characteristicsBonusList[type]as ICharacteristics<N>)?.Remove(characteristics);
        }
        
        public bool CheckBonus<N>(string type, ICharacteristicsBonus<N> characteristics)
        {
            return (_characteristicsBonusList[type]as ICharacteristics<N>).Check(characteristics);
        }
        
    }
}