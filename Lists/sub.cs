using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
    }
    public class sub
    {
        public static void Main(string[] args)
        {
            sub objSub = new sub();
            List<string> Subject = new List<string>()
            {
                "English",
                "Math",
                "Chemistry",
                "Python",
                "Data Science",
                "AI Engineering"

            };
            Console.WriteLine("The First Element of the list is : " + Subject[0]);
            Console.WriteLine("The SECOND Element of the list is : " + Subject[1]);
            Console.WriteLine("The Third Element of the list is : " + Subject[2]);
            Console.WriteLine("The Fourth  Element of the list is : " + Subject[3]);

            List<string> Album = new List<string>()
            {
                "AvoidRafa",
                "Games",
                "Arthohin",
                "Jal",
                "ColdPlay"
            };
            foreach (var item in Album)
            {
                Console.WriteLine("The list of the album is given below : " + item);

            }
            Album.Add("Nemesis");
            Album.Add("Chirkutt");
            Album.Add("Warfaze");
            Album.Add("Artcell");
            foreach (var item in Album)
            {
                Console.WriteLine("The list of the album is given below : " + item);

            }


            List<Person> people = new List<Person>
            {
                new Person { Id = 1, Name = "Monika", Surname = "Hossain", Country = "Bangladesh" },
                new Person { Id = 2, Name = "Rahim", Surname = "Ahmed", Country = "Bangladesh" },
                new Person { Id = 3, Name = "Karim", Surname = "Hossain", Country = "Bangladesh" },
                new Person { Id = 4, Name = "Sharmin", Surname = "Akter", Country = "Bangladesh" },
                new Person { Id = 5, Name = "John", Surname = "Smith", Country = "USA" },
                new Person { Id = 6, Name = "Emma", Surname = "Johnson", Country = "USA" },
                new Person { Id = 7, Name = "Michael", Surname = "Smith", Country = "USA" },
                new Person { Id = 8, Name = "David", Surname = "Brown", Country = "UK" },
                new Person { Id = 9, Name = "Sophia", Surname = "Wilson", Country = "UK" },
                new Person { Id = 10, Name = "James", Surname = "Taylor", Country = "UK" },
                new Person { Id = 11, Name = "Ali", Surname = "Khan", Country = "Pakistan" },
                new Person { Id = 12, Name = "Sara", Surname = "Khan", Country = "Pakistan" },
                new Person { Id = 13, Name = "Arjun", Surname = "Patel", Country = "India" },
                new Person { Id = 14, Name = "Priya", Surname = "Sharma", Country = "India" },
                new Person { Id = 15, Name = "Ayesha", Surname = "Rahman", Country = "Bangladesh" }
            };
            //display allpeople
            foreach (Person person in people)
            {
                Console.WriteLine(
                    $"ID: {person.Id}, Name: {person.Name} {person.Surname}, Country: {person.Country}"
                );
            }

            IEnumerable<Person> result = people
     .Where(p => p.Country == "Bangladesh");

            foreach (Person person in result)
            {
                Console.WriteLine($"{person.Name} {person.Surname}");
            }

            IQueryable<Person> query = people.AsQueryable();
            var queryResult = query.Where(p => p.Country == "Bangladesh");
            foreach (var item in queryResult)
            {
                Console.WriteLine(item);
            }
            ///: Find all people from Bangladesh using Where().
            ///
            var findPeople = people.Where(p => p.Country == "Bangladesh");
            foreach (Person peoples in findPeople)
            {
                Console.WriteLine(" The people from bangladesh is : " +
                                    $"ID: {peoples.Id}, Name: {peoples.Name} {peoples.Surname}, Country: {peoples.Country}"
                                );
            }
            /////Task 3: Display only names using Select().
            ///
            var name = people.Select(p => p.Name).ToList();
            foreach (var item in name) 
            {
                Console.WriteLine(" The name is : " +item);
            }

        }
        
        }
}
