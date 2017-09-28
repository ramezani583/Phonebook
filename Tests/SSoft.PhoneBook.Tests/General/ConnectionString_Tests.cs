using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace SSoft.PhoneBook.Tests.General
{
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=PhoneBook; Trusted_Connection=True;");
            csb["Database"].ShouldBe("PhoneBook");
        }
    }
}
