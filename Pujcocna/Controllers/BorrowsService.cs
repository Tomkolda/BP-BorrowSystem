using Půjčovna.Data;

namespace Půjčovna.Controllers
{
    interface BorrowsService
    {
        IEnumerable<Borrows> GetAllBorrows();
        void InsertBorrow(Borrows borrows);
        int GetBorrowId(Borrows borrows);
        void DeleteBorrow(Borrows borrows);

        DateTime GetBorrowDateFrom(int id);

        DateTime GetBorrowDateto(int id);

    }
}
