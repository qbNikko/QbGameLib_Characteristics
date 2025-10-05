namespace QbGameLib_Characteristics
{
    public interface ICharacteristicsBonus<T>
    {
        public T Apply(T currentValue);
    }
}