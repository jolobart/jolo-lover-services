using JoloLoverServices.Interfaces;
using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;
using JoloLoverServices.Services.Extension.CategoryServiceExtensions;
using JoloLoverServices.Data.Interfaces;
using System.Net;

namespace JoloLoverServices.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategorySqlDataGateway _dataGateway;

    public CategoryService(ICategorySqlDataGateway dataGateway)
    {
        _dataGateway = dataGateway;
    }

    public ResponseBase<List<Category>> GetAll(int id)
    {
        var response = new ResponseBase<List<Category>>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (id.IsValid(ref errors))
            {
                var result = _dataGateway.GetAll(id);
                return response.AsData(result);
            }

            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }

    public ResponseBase<Category> GetCategoryById(GetCategoryRequest request)
    {
        var response = new ResponseBase<Category>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (request.IsValid(ref errors))
            {
                var result = _dataGateway.GetCategoryById(request.Id.Value, request.UserId.Value);
                return response.AsData(result);
            }

            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }

    public ResponseBase<Category> RemoveCategory(int id)
    {
        var response = new ResponseBase<Category>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (id.IsValid(ref errors))
            {
                var result = _dataGateway.Delete(id);
                return response.AsData(result);
            }

            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }

    public ResponseBase<Category> UpsertCategory(Category request)
    {
        var response = new ResponseBase<Category>();
        ICollection<string> errors = new List<string>();

        try
        {
            if (request.IsValid(ref errors))
            {
                var result = _dataGateway.Upsert(request);
                return response.AsData(result, HttpStatusCode.Created);
            }

            return response.AsInvalidRequestError(errors);
        }
        catch (Exception e)
        {
            return response.AsInternalApiError(e);
        }
    }
}