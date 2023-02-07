using JoloLoverServices.Models;

namespace JoloLoverServices.Validations.WalletSpecifications.UpsertWalletSpecifications;

internal class CurrencyIsNotNullOrEmptySpecification : Specification<Wallet>
{
    public override bool IsSatisfiedBy(Wallet entity, ref ICollection<string> errors)
    {
        var result = IsNullOrEmptyOrWhiteSpace(entity.Name);

        if (!result)
        {
            errors.Add("Invalid wallet currency");
        }

        return result;
    }

    private bool IsNullOrEmptyOrWhiteSpace(string name)
    {
        return !string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name);
    }
}