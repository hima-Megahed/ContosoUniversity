namespace ContosoUniversity.Models
{
    public class FullAuditedEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
