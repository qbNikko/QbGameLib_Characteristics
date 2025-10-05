namespace QbGameLib_Characteristics
{
    public interface ICharacteristics<T>
    {
        public void Add(ICharacteristicsBonus<T> characteristics);
        public void Remove(ICharacteristicsBonus<T> characteristics);
        public bool Check(ICharacteristicsBonus<T> characteristics);
        public T Calculate();
    }
}