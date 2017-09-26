using PANCodingExercise.Data.Contracts;
using PANCodingExercise.Data.Mappings;
using System.Data.Entity;

namespace PANCodingExercise.Data
{
    public class ItemDbContext : DbContext, IDbContext
    {
        public ItemDbContext()
            : base(System.Configuration.ConfigurationManager.ConnectionStrings["ItemDbContext"].ConnectionString)
        {
            Database.SetInitializer<ItemDbContext>(new CreateDatabaseIfNotExists<ItemDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ItemMap());

            base.OnModelCreating(modelBuilder);
        }

        public new IDbSet<T> Set<T>() where T : BaseEntity
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
