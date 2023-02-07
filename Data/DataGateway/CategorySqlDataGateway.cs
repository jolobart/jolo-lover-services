using JoloLoverServices.Data.Interfaces;
using JoloLoverServices.Models;

namespace JoloLoverServices.Data.DataGateway;

public class CategorySqlDataGateway : ICategorySqlDataGateway
{
    private readonly DataContext _dataContext;

    public CategorySqlDataGateway(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public Category Delete(Category category)
    {
        _dataContext.Categories.Remove(category);
        _dataContext.SaveChanges();
        return category;
    }

    public List<Category> GetAll(int id)
    {
        return _dataContext.Categories
       .Where(c => c.UserId == id)
       .ToList();
    }

    public Category GetCategoryById(int id, int userId)
    {
        return _dataContext.Categories.SingleOrDefault(c => c.Id == id && c.UserId == userId);
    }

    public Category Upsert(Category category)
    {
        if (category.Id == null)
        {
            _dataContext.Categories.Add(category);
        }
        else
        {
            _dataContext.Categories.Update(category);
        }

        _dataContext.SaveChanges();
        return _dataContext.Categories.Find(category.Id);
    }

    private Transaction GetLastInsertedCategory()
    {
        var transaction = _dataContext.Transactions.OrderByDescending(c => c.Id).FirstOrDefault();
        return transaction;
    }
}