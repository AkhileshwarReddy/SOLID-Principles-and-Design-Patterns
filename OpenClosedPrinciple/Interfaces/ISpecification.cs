namespace OpenClosedPrinciple
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
