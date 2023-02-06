namespace JoloLoverServices.Interfaces;
using JoloLoverServices.Validations;
public interface ISpecification<T>
{
    bool IsSatisfiedBy(T obj, ref ICollection<string> errors);
    Specification<T> And(Specification<T> specification);
    Specification<T> Or(Specification<T> specification);
}
