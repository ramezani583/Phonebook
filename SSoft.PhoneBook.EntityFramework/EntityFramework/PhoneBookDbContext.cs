using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using SSoft.PhoneBook.Authorization.Roles;
using SSoft.PhoneBook.Authorization.Users;
using SSoft.PhoneBook.Chat;
using SSoft.PhoneBook.Friendships;
using SSoft.PhoneBook.MultiTenancy;
using SSoft.PhoneBook.Storage;

namespace SSoft.PhoneBook.EntityFramework
{
    /* Constructors of this DbContext is important and each one has it's own use case.
     * - Default constructor is used by EF tooling on design time.
     * - constructor(nameOrConnectionString) is used by ABP on runtime.
     * - constructor(existingConnection) is used by unit tests.
     * - constructor(existingConnection,contextOwnsConnection) can be used by ABP if DbContextEfTransactionStrategy is used.
     * See http://www.aspnetboilerplate.com/Pages/Documents/EntityFramework-Integration for more.
     */

    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual IDbSet<Friendship> Friendships { get; set; }

        public virtual IDbSet<ChatMessage> ChatMessages { get; set; }

        public PhoneBookDbContext()
            : base("Default")
        {
            
        }

        public PhoneBookDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public PhoneBookDbContext(DbConnection existingConnection)
           : base(existingConnection, false)
        {

        }

        public PhoneBookDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
