using JoloLoverServices.Validations.WalletSpecifications.GetAllWalletsSpecifications;

namespace JoloLoverServices.Validations.WalletSpecifications;

internal class GetAllWalletsSpecification : Specification<int>
{
    private static Specification<int> spec = new UserIdIsNotNullOrEmptySpecification();

    public override bool IsSatisfiedBy(int entity, ref ICollection<string> errors)
    {
        return spec.IsSatisfiedBy(entity, ref errors);
    }
}
