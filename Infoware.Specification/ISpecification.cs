namespace Infoware.Specification;

public interface ISpecification<in T>
{
    bool IsSatisfied(T obj);
}
