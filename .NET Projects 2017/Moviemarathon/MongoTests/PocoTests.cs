using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using NUnit.Framework;

namespace MongoTests
{
    class PocoTests
    {
        public PocoTests()
        {
            //JsonWriterSettings.Defaults.Indent = true;
        }

        [Test]
        public void Automatic()
        {
            var document = new Person()
            {
                Name = "Vlad",
                Age = 23
            };

            document.Addreses.Add("Fake street 34");
            document.Contact.Email = "test@mail.com";

            Console.WriteLine(document.ToJson());
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public List<string> Addreses  = new List<string>();
            public Contact Contact  = new Contact();
        }

        public class Contact
        {
            public string Email { get; set; }
            public string Phone { get; set; }
        }
    }
}
