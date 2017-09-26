using System.ComponentModel.DataAnnotations.Schema;
 
namespace PANCodingExercise.Data
{
    public partial class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
