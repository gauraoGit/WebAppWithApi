using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppWithApi.Models
{
    public interface IPersonRepository
    {
        IEnumerable<Person> Get();
        Person Get(int id);
        void Add(Person person);
        bool Delete(int id);
        bool Update(Person person);

    }
}