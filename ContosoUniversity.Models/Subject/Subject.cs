namespace ContosoUniversity.Models.Subject
{
    public class Subject : FullAuditedEntity
    {
        public Subject(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
