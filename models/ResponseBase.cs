using System.Net;

namespace JoloLoverServices.Models;

public class ResponseBase<T>
{
    public T? Data { get; set; }
    public bool Succeeded { get; set; }
    public int Code { get; set; }
    public string? Message { get; set; }
    public string? Type { get; set; }
    
    public ResponseBase()
    {
        this.Succeeded = true;
        this.Code = (int)HttpStatusCode.OK;
    }

    public ResponseBase(T result, HttpStatusCode code)
    {
        this.Data = result;
        this.Succeeded = true;
        this.Code = (int)code;
    }

    public ResponseBase(IEnumerable<string> errorMessage)
    {
        this.Succeeded = false;
        this.Message = string.Join(" ", errorMessage);
        this.Type = "Invalid request error";
        this.Code = (int)HttpStatusCode.BadRequest;
    }

    public ResponseBase(string errorMessage)
    {
        this.Succeeded = false;
        this.Message = string.Join(" ", errorMessage);
        this.Type = "Invalid request error";
        this.Code = (int)HttpStatusCode.BadRequest;
    }

    public ResponseBase(Exception exception)
    {
        this.Succeeded = false;
        this.Message = exception.InnerException?.Message ?? exception.Message;
        this.Type = "Invalid request error";
        this.Code = (int)HttpStatusCode.InternalServerError;
    }

    public ResponseBase<T> AsData(T result, HttpStatusCode code = HttpStatusCode.OK)
    {
        this.Data = result;
        this.Succeeded = true;
        this.Code = (int)code;
        return this;
    }

    public ResponseBase<T> AsInvalidRequestError(IEnumerable<string> errorMessages)
    {
        this.Succeeded = false;
        this.Message = string.Join(" ", errorMessages);
        this.Type = "Invalid request error";
        this.Code = (int)HttpStatusCode.BadRequest;
        return this;
    }

    public ResponseBase<T> AsError(string errorType, string errorMessage)
    {
        this.Succeeded = false;
        this.Message = errorMessage;
        this.Type = errorType;
        this.Code = (int)HttpStatusCode.BadRequest;
        return this;
    }

    public ResponseBase<T> AsInternalApiError(Exception exception)
    {
        this.Succeeded = false;
        this.Message = exception.InnerException?.Message ?? exception.Message;
        this.Type = "Internal api error";
        this.Code = (int)HttpStatusCode.InternalServerError;
        return this;
    }
}
