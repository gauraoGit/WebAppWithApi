using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using WebAppWithApi.Models;

namespace WebAppWithApi.Controllers
{

    public class PersonsController : ApiController
    {
        private readonly IPersonRepository personsRepository;
        public PersonsController(IPersonRepository repository)
        {
            personsRepository = repository;
        }
        // GET api/Person
        public IEnumerable<Person> Get()
        {
            return personsRepository.Get();
        }

        // GET api/values/5
        public Person Get(int id)
        {
            var person = personsRepository.Get(id);
            if (person != null)
                return person;
            else
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        // POST api/values
        public void Post([FromBody]Person person)
        {
            personsRepository.Add(person);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Person person)
        {
            personsRepository.Update(person);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            personsRepository.Delete(id);
        }
    }
}
