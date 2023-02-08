using JoloLoverServices.Models;
using JoloLoverServices.WebModels;

namespace JoloLoverServices.Controllers.Extensions;

public static class ResponseBaseExtensions
{
    public static object ToWebModel<T>(this ResponseBase<T> response, object? mappedData = null)
    {
        if (response.Succeeded)
        {
            var data = mappedData ?? response.Data;

            if (response.AccessToken != null)
            {
                return new
                {
                    BearerToken = response.AccessToken
                };
            }

            if (data == null)
            {
                return string.Empty;
            }
            else
            {
                return data;
            }
        }
        else
        {
            return new WebModelError
            {
                Code = response.Code,
                Message = response.Message,
                Type = response.Type
            };
        }
    }
}