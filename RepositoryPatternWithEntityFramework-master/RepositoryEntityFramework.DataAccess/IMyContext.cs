using System.Data.Entity;
using RepositoryEntityFramework.DataAccess.Model;

namespace RepositoryEntityFramework.DataAccess
{
    public interface IMyContext
    {
        DbSet<User> User { get; set; }
    }
}