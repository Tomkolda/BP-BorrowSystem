using Půjčovna.Data;

namespace Půjčovna.Controllers
{
    interface Borrow_thingsService
    {
        void InsertThings(List<Borrow_things> things);
        IEnumerable<Borrow_things> GetAllThingsByIDBorrow(int id);
        List<int> GetAllBorrowByThingId(int id);
    }
}
