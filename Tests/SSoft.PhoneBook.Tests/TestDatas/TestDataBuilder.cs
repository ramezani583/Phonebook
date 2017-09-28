using EntityFramework.DynamicFilters;
using SSoft.PhoneBook.EntityFramework;

namespace SSoft.PhoneBook.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly PhoneBookDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(PhoneBookDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
