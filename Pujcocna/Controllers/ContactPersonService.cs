using Microsoft.AspNetCore.Components;
using Půjčovna.Data;

namespace Půjčovna.Controllers
{
    interface ContactPersonService
    {
        IEnumerable<Contact_Person> GetContactPersons();
        void InsertContactPerson(Contact_Person contact_Person);
        void DeleteContactPerson(Contact_Person contact_Person);

        void UpdateContactPerson(Contact_Person contact_person);

        Contact_Person GetContactPerson(int id);
    }
}
