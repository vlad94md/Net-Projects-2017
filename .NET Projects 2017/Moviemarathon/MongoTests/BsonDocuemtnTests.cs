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
    class BsonDocuemtnTests
    {
        public BsonDocuemtnTests()
        {
            JsonWriterSettings.Defaults.Indent = true;
        }

        [Test]
        public void EmptyDocument()
        {
            var document = new BsonDocument();

            Console.WriteLine(document.ToJson());
        }

        [Test]
        public void AddElements()
        {
            var document = new BsonDocument();
            document.Add("name", "Vlad");

            Console.WriteLine(document.ToJson());
        }

        [Test]
        public void AddElementsToExisting()
        {
            var document = new BsonDocument()
            {
                {"age", new BsonInt32(23)},
                {"isAlive", true }
            };

            document.Add("name", "Vlad");

            Console.WriteLine(document.ToJson());
        }

        [Test]
        public void AddArray()
        {
            var document = new BsonDocument();

            document.Add("adresses", new BsonArray(new [] {"Str Main 32", "Hyda Park bld"}));

            Console.WriteLine(document.ToJson());
        }

        [Test]
        public void EmbedddedDocuments()
        {
            var document = new BsonDocument();

            document.Add("contact", new BsonDocument()
            {
                {"email", "test@mail.com" },
                { "telephone", "31-24-56"}
            });

            Console.WriteLine(document.ToJson());
        }

        [Test]
        public void BsonValueConverstion()
        {
            var document = new BsonDocument()
            {
                {"age", 54}
            };

            Console.WriteLine(document["age"].AsInt32 + 10);
            Console.WriteLine(document["age"].ToDouble() + 0.1);
        }
    }
}
