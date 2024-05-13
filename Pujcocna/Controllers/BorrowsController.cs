using Půjčovna.Data;

namespace Půjčovna.Controllers
{
    public class BorrowsController : BorrowsService
    {
        private readonly BorrowDB db;

        public BorrowsController(BorrowDB db)
        {
            this.db = db;
        }
        public void DeleteBorrow(Borrows borrows)
        {
            try
            {
                db.Borrows.Remove(borrows);
                db.SaveChanges();
            }
            catch 
            {
                throw;
            }
        }

        public IEnumerable<Borrows> GetAllBorrows()
        {
            try
            {
                return db.Borrows.ToList();
            }
            catch
            {
                throw;
            }
        }

        public DateTime GetBorrowDateFrom(int id)
        {
            try
            {
                return db.Borrows.Where(x => x.Id == id).Select(x => x.Borrow_Date_From).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

        public DateTime GetBorrowDateto(int id)
        {
            return db.Borrows.Where(x => x.Id == id).Select(x => x.Borrow_Date_To).FirstOrDefault();
        }

        public int GetBorrowId(Borrows borrows)
        {
            try
            {
                return db.Borrows.Where(x => x.Borrow_Number == borrows.Borrow_Number).Select(x => x.Id).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

        public void InsertBorrow(Borrows borrows)
        {
            try
            {
                db.Borrows.Add(borrows);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
