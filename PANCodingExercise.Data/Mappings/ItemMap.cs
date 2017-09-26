using PANCodingExercise.Data.Domain;
using System.Data.Entity.ModelConfiguration;

namespace PANCodingExercise.Data.Mappings
{
    public class ItemMap : EntityTypeConfiguration<Item>
    {
        public ItemMap()
        {
            this.ToTable("Item");
        }
    }
}
