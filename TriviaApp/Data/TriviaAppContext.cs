using Microsoft.EntityFrameworkCore;
using TriviaApp.Models;

namespace TriviaApp.Data
{
    public class TriviaAppContext : DbContext
    {
        public TriviaAppContext(DbContextOptions<TriviaAppContext> options)
            : base(options)
        {

        }

        public DbSet<Question> Question { get; set; }
    }
}