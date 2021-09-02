using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.DataAccess.Abstract;
using Uygulama.Entities;

namespace Uygulama.DataAccess.Concrete
{
    public class PersonRepository : IPersonRepository
    {
        public Person CreatePerson(Person person)
        {
            using (var personDbContext = new PersonDbContext())
            {
                personDbContext.Persons.Add(person);
                personDbContext.SaveChanges();
                return person;
            }
        }

        public void DeletePerson(int id)
        {
            using (var personDbContext = new PersonDbContext())
            {
                var personId = GetPersonById(id);
                personDbContext.Persons.Remove(personId);
                personDbContext.SaveChanges();
            }
        }

        public List<Person> GetAllPersons()
        {
            using (var personDbContext = new PersonDbContext())
            {
                return personDbContext.Persons.ToList();
            }
        }

        public Person GetPersonById(int id)
        {
            using (var personDbContext = new PersonDbContext())
            {
                return personDbContext.Persons.Find(id);
            }
        }

        public Person UpdatePerson(Person person)
        {
            using (var personDbContext = new PersonDbContext())
            {
                personDbContext.Persons.Update(person);
                personDbContext.SaveChanges();
                return person;
            }
        }
    }
}
