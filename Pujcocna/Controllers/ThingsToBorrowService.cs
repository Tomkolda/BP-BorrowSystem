using Půjčovna.Data;

namespace Půjčovna.Controllers
{
    public interface ThingsToBorrowService
    {
        IEnumerable<Things_To_Borrow> GetAllThings();

        void AddThing(Things_To_Borrow things_to_borrow, List<string> categories);

        void DeleteThing(Things_To_Borrow things_to_borrow);

        List<Things_To_Borrow> GetThingsFromCategory(Category category);
        Things_To_Borrow GetThingByID(int id);
    }
}
