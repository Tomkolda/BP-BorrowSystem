using Microsoft.EntityFrameworkCore;
using Půjčovna.Data;

namespace Půjčovna.Controllers
{
    public class ContactPersonController : ContactPersonService
    {
        private readonly BorrowDB db;

        public ContactPersonController(BorrowDB db)
        {
            this.db = db;
        }

        public IEnumerable<Contact_Person> GetContactPersons()
        {
            try
            {
                return db.Contact_Persons.ToList().Where(x => x.Is_Deleted == false);
            }
            catch
            {
                throw;
            }
        }

        public void InsertContactPerson(Contact_Person contact_Person)
        {
            try
            {
                db.Contact_Persons.Add(contact_Person);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public void DeleteContactPerson(Contact_Person contact_Person)
        {
            contact_Person.Is_Deleted = true;
            try
            {
                var local = db.Set<Contact_Person>().Local.FirstOrDefault(entry => entry.Id.Equals(contact_Person.Id));
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(contact_Person).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateContactPerson(Contact_Person contact_person)
        {
            try
            {
                var local = db.Set<Contact_Person>().Local.FirstOrDefault(entry => entry.Id.Equals(contact_person.Id));
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(contact_person).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public Contact_Person GetContactPerson(int id)
        {
            try
            {
                return db.Contact_Persons.Where(x => x.Id == id).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }
    }
}
