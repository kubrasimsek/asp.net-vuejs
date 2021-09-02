using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Entities;

namespace Uygulama.Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAllPersons();
        Person GetPersonById(int id);
        Person CreatePerson(Person person);
        Person UpdatePerson(Person person);
        void DeletePerson(int id);
    }
}
