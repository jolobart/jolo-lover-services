namespace JoloLoverServices.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T obj);
        string ErrorMessage { get; }
    }
}