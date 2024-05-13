using Půjčovna.Data;

namespace Půjčovna.Controllers
{
    public interface CategoriesService
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(int id);
        void AddCategory(Category category);
    }
}
