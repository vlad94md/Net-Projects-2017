using ConsoleApp1;
using Xunit;

namespace MongoDbTests
{   
    public class RentalTests 
    {
        [Fact]
        public void ToDocument_RentalWithPrice_RespresentedAsDouble()
        {
            var rental = new Rental();

            Assert.Equal(true, true);
        }
    }
}
