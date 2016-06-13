using System.Data.Entity;

namespace ServiceApp.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long HomePhone { get; set; }
        public long CellPhone { get; set; }
        public long AlternatePhone { get; set; }
    }

    public class ServiceDBContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
    }
}