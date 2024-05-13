using Půjčovna.Data;

namespace Půjčovna.Controllers
{
    public class CategoriesController : CategoriesService
    {
        private readonly BorrowDB db;

        public CategoriesController(BorrowDB db)
        {
            this.db = db;
        }

        public void AddCategory(Category category)
        {
            try
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
            catch 
            {
                throw;
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            try
            {
                return db.Categories.Where(x => x.Id == id).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }
    }
}
