using System.Net.Mail;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Validations.UserSpecifications.RegisterSpecifications;

internal class EmailIsValidNotNullOrEmptySpecification : Specification<RegisterRequest>
{
    public override bool IsSatisfiedBy(RegisterRequest entity, ref ICollection<string> errors)
    {
        var result = IsValidIsNullOrEmptyOrWhiteSpace(entity.Email);

        if (!result)
        {
            errors.Add("Invalid email address");
        }

        return result;
    }

    private bool IsValidIsNullOrEmptyOrWhiteSpace(string emailaddress)
    {
        return !string.IsNullOrEmpty(emailaddress) && !string.IsNullOrWhiteSpace(emailaddress) && IsValid(emailaddress);
    }

    private bool IsValid(string emailaddress)
    {
        try
        {
            MailAddress m = new MailAddress(emailaddress);

            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}