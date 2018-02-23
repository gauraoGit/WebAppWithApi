using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppWithApi.Models
{
    public class InitialData
    {
        public IEnumerable<Person> PersonList { get; set; }
        public InitialData()
        {
            PersonList= new List<Person>(){
                new Person(){Id=1, FirstName="Jane",LastName ="Doe"},
                new Person(){Id=2, FirstName="Gaurao",LastName ="Tarpe"},
                new Person(){Id=3, FirstName="Jon",LastName ="Doe"}
            };
        }
    }
}