using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample
{
    class PeopleRepository
    {
        //a `field`: exclusion to the class only - hidden state
        //static in this context, this fields works differently than a normal field
        //you only get one of these for all of the instances (versus every instance having one)
        //all instances share this one field
        //think of it as a global variable to all People repositories
        static List<Person> _people = new List<Person> {
            //start out with five people automatically. will be there across all the instances
            //sets initial chunk of data every time the application starts
            new Person{Name="Bob" },
            new Person{Name="Steve" },
            new Person{Name="Jim" },
            new Person{Name="Larry" },
            new Person{Name="Curly" },
        }
        ;

        public List<Person> GetAll()
        {
            return _people;
        }
        public void Add(Person person)
        {
            _people.Add(person);
        }

        public void Delete(string name)
        {
            var personToRemove = _people.First(person => person.Name == name);

            _people.Remove(personToRemove);
        }

    }

    class Person
    {
        public string Name { get; set; }
    }

}
