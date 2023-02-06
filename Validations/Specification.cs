using JoloLoverServices.Interfaces;

namespace JoloLoverServices.Validations;

public abstract class Specification<T> : ISpecification<T>
{
    public abstract bool IsSatisfiedBy(T obj, ref ICollection<string> errors);

    public Specification<T> And(Specification<T> specification)
    {
        return new AndSpecification<T>(this, specification);
    }

    public Specification<T> Or(Specification<T> specification)
    {
        return new OrSpecification<T>(this, specification);
    }
}
