using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uygulama.Business.Abstract;
using Uygulama.Business.Concrete;
using Uygulama.Entities;

namespace Uygulama.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private IPersonService _personService;
        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public List<Person> Get()
        {
          return _personService.GetAllPersons();
        }
        [HttpGet("{id}")]
        public Person Get(int id)
        {
          return _personService.GetPersonById(id);
        }

        [HttpPost]
        public Person Post(
            [FromBody] Person person
            )
        {
            return _personService.CreatePerson(person);
        }
        [HttpPut]
        public Person Put(
            [FromBody] Person person
            )
        {
            return _personService.UpdatePerson(person);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _personService.DeletePerson(id);
        }
    }
}
