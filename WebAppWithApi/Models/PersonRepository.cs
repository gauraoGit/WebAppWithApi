using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppWithApi.Models
{
    public class PersonRepository : IPersonRepository
    {
        InitialData initialData = new InitialData();
        public IEnumerable<Person> Get()
        {
            return initialData.PersonList;
        }
        public Person Get(int id)
        {
            return initialData.PersonList.Where(x=>x.Id==id).First();
        }
        void IPersonRepository.Add(Person person)
        {
            initialData.PersonList.ToList().Add(person);
        }
        
        public bool Delete(int id)
        {
            var person = initialData.PersonList.Where(x => x.Id == id).First();
            return initialData.PersonList.ToList().Remove(person);
        }
        public bool Update(Person person)
        {
            var updatedPerson = initialData.PersonList.Where(x => x.Id == person.Id).First();
            if (updatedPerson != null)
            {
                updatedPerson.FirstName = person.FirstName;
                updatedPerson.LastName = person.LastName;
                return true;
            }
            return false;
        }

      
    }
}