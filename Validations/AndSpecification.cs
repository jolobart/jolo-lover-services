namespace JoloLoverServices.Validations;

public class AndSpecification<T> : Specification<T>
{
    private readonly Specification<T> _left;
    private readonly Specification<T> _right;

    public AndSpecification(Specification<T> left, Specification<T> right)
    {
        _right = right;
        _left = left;
    }
    public override bool IsSatisfiedBy(T entity, ref ICollection<string> errors)
    {
        return _left.IsSatisfiedBy(entity, ref errors) && _right.IsSatisfiedBy(entity, ref errors);
    }
}
