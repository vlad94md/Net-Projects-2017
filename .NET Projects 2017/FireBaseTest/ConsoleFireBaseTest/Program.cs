using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ConsoleFireBaseTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var gg = new MyClass();
            gg.Function().Wait();
            Console.WriteLine();

        }

        public class MyClass
        {

            public async Task Function()
            {
                IFirebaseConfig config = new FirebaseConfig
                {
                    BasePath = "https://birthdaytest-16f92.firebaseio.com/"
                };
                IFirebaseClient client = new FirebaseClient(config);

                var todo = new User
                {
                    username = "Execute SET",
                    money = 2
                };
                SetResponse response = await client.SetAsync("users/set", todo);
                User result = response.ResultAs<User>(); //The response will contain the data written
            }
        }

    }
}
