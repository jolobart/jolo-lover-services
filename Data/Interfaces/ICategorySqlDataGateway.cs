using JoloLoverServices.Models;

namespace JoloLoverServices.Data.Interfaces;

public interface ICategorySqlDataGateway
{
    List<Category> GetAll(int id);
    Category GetCategoryById(int id, int userId);
    Category Upsert(Category category);
    Category Delete(int id);
}
