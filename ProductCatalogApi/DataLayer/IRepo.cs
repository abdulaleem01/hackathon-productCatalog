using System;
using DataLayer.DbEntities;
namespace DataLayer
{
    public interface IRepo
    {
        Category AddCategory(Category category);
        IEnumerable<Category> GetAllCategories();

    }
}

