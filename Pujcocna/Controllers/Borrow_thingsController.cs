using Půjčovna.Data;

namespace Půjčovna.Controllers
{
    public class Borrow_thingsController : Borrow_thingsService
    {
        private readonly BorrowDB db;

        public Borrow_thingsController(BorrowDB db)
        {
            this.db = db;
        }

        public void InsertThings(List<Borrow_things> things)
        {
            foreach (Borrow_things th in things)
            {
                try
                {
                    db.Borrow_Things.Add(th);
                    db.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public IEnumerable<Borrow_things> GetAllThingsByIDBorrow(int id)
        {
            try
            {
                return db.Borrow_Things.Where(x => x.BorrowsId == id).ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<int> GetAllBorrowByThingId(int id)
        {
            try
            {
                return db.Borrow_Things.Where(x => x.Things_To_BorrowID == id).Select(x => x.BorrowsId).ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
