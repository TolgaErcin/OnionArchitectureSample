

namespace ANK_9.Core
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }

        public DateTime CreateOn { get; set; }

        public DateTime? UpdateOn { get; set; }

        public bool IsActive { get; set; }
    }
}
