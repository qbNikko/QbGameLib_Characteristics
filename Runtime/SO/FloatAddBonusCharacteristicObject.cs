using UnityEngine;

namespace QbGameLib_Characteristics.SO
{
    [CreateAssetMenu(fileName = "AddFloatBonus", menuName = "UnityGameLib/Characteristic/AddFloatBonus", order = 1)]
    public class FloatAddBonusCharacteristicObject : BonusCharacteristicObject
    {
        public float bonus;
        private ICharacteristicsBonus<float> _bonusCharacteristics;

        public override ICharacteristicsBonus<N> ToBonus<N>()
        {
            if (_bonusCharacteristics == null)
            {
                _bonusCharacteristics = new FloatAddCharacteristicsBonus(bonus);
            }
            return (ICharacteristicsBonus<N>) _bonusCharacteristics;
        }
    }
}