using UnityEngine;

namespace QbGameLib_Characteristics.SO
{
    [CreateAssetMenu(fileName = "PercentIntBonus", menuName = "UnityGameLib/Characteristic/PercentIntBonus", order = 1)]
    public class IntPercentBonusCharacteristicObject : BonusCharacteristicObject
    {
        [Range(0,5)] public float bonus = 1f;

        private ICharacteristicsBonus<int> _bonusCharacteristics;

        public override ICharacteristicsBonus<N> ToBonus<N>()
        {
            if (_bonusCharacteristics == null)
            {
                _bonusCharacteristics = new IntPercentCharacteristicsBonus(bonus);
            }
            return (ICharacteristicsBonus<N>) _bonusCharacteristics;
        }
    }
}