using Microsoft.EntityFrameworkCore;
using Půjčovna.Data;

namespace Půjčovna.Controllers
{
    public class ThingsToBorrowController : ThingsToBorrowService
    {
        private readonly BorrowDB db;

        public ThingsToBorrowController(BorrowDB db)
        {
            this.db = db;
        }

        public void AddThing(Things_To_Borrow thing, List<string> categories)
        {
            try
            {
                db.Things_To_Borrows.Add(thing);
                int id = db.Things_To_Borrows.Where(x => x.Inventory_number ==
                thing.Inventory_number).Select(x => x.Id).FirstOrDefault();
                foreach (var category in categories)
                {
                    Things_Category things_Category = new()
                    {
                        Things_To_BorrowID = id,
                        CategoryId = int.Parse(category),
                        things_to_borrow = thing
                    };
                    db.Things_Categories.Add(things_Category);
                }
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteThing(Things_To_Borrow things_to_borrow)
        {
            things_to_borrow.Is_Deleted = true;
            try
            {
                var local = db.Set<Things_To_Borrow>().Local.FirstOrDefault(entry => entry.Id.Equals(things_to_borrow.Id));
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(things_to_borrow).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Things_To_Borrow> GetAllThings()
        {
            return db.Things_To_Borrows.ToList().Where(x=> x.Is_Deleted == false);
        }



        public List<Things_To_Borrow> GetThingsFromCategory(Category category)
        {
            List<Things_To_Borrow> things = new List<Things_To_Borrow>();
            List<int> ids = db.Things_Categories.Where(x => x.CategoryId == category.Id).Select(x => x.Things_To_BorrowID).ToList();
            List<Things_To_Borrow> things_To_Borrows = db.Things_To_Borrows.Where(thing => ids.Contains(thing.Id)).ToList();
            foreach(var thing in things_To_Borrows)
            {
                if (thing.Is_Deleted == false)
                {
                    things.Add(thing);
                }
            }
            return things;

        }

        public Things_To_Borrow GetThingByID(int id)
        {
            try
            {
                return db.Things_To_Borrows.Where(x => x.Id == id).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }
    }
}
