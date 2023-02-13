using JoloLoverServices.Models;
using JoloLoverServices.Models.Request;

namespace JoloLoverServices.Interfaces;

public interface ICategoryService
{
    ResponseBase<List<Category>> GetAll(int id);
    ResponseBase<Category> GetCategoryById(GetCategoryRequest request);
    ResponseBase<Category> UpsertCategory(Category request);
    ResponseBase<Category> RemoveCategory(int id);
}
