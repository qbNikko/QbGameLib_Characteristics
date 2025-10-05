using UnityEngine;

namespace QbGameLib_Characteristics.SO
{
    [CreateAssetMenu(fileName = "PercentFloatBonus", menuName = "UnityGameLib/Characteristic/PercentFloatBonus", order = 1)]
    public class FloatPercentBonusCharacteristicObject : BonusCharacteristicObject
    {
        [Range(0,5)] public float bonus = 1f;

        private ICharacteristicsBonus<float> _bonusCharacteristics;

        public override ICharacteristicsBonus<N> ToBonus<N>()
        {
            if (_bonusCharacteristics == null)
            {
                _bonusCharacteristics = new FloatPercentCharacteristicsBonus(bonus);
            }
            return (ICharacteristicsBonus<N>) _bonusCharacteristics;
        }
    }
}