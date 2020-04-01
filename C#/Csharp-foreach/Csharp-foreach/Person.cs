using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_foreach
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<Person> GetUserList()
        {
            Person person = new Person();
            person.Age = 1;
            person.Name = "A";
            List<Person> personList = new List<Person>();
            personList.Add(new Person
            {
                Age = 1,
                Name="A"
                
            });
            personList.Add(new Person
            {
                Age = 2,
                Name = "B"

            }); personList.Add(new Person
            {
                Age = 3,
                Name = "C"

            });
            return personList;
        }
    }
}
