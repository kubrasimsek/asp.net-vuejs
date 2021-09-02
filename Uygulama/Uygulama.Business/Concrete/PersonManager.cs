using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Business.Abstract;
using Uygulama.DataAccess.Abstract;
using Uygulama.DataAccess.Concrete;
using Uygulama.Entities;

namespace Uygulama.Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonRepository _personRepository;
        public PersonManager(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public Person CreatePerson(Person person)
        {
            return _personRepository.CreatePerson(person);
        }

        public void DeletePerson(int id)
        {
            _personRepository.DeletePerson(id);
        }

        public List<Person> GetAllPersons()
        {
            return _personRepository.GetAllPersons();
        }

        public Person GetPersonById(int id)
        {
            if (id > 0)
            {
                return _personRepository.GetPersonById(id);
            }
            throw new Exception("Kişi Id'si 0 dan küçük olamaz");
        }

        public Person UpdatePerson(Person person)
        {
            return _personRepository.UpdatePerson(person);
        }
    }
}
