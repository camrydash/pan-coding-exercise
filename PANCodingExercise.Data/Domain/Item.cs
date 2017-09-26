using System;

namespace PANCodingExercise.Data.Domain
{
    /// <summary>
    /// Represents our Item class
    /// </summary>
    public class Item : BaseEntity
    {
        public virtual string DisplayName { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime CreatedOn { get; set; }
    }
}
