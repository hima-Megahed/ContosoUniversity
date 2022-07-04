using ContosoUniversity.Models.Subject;

namespace ContosoUniversity.Persistence
{
    public static class ContosoUniversityDbContextIntializer
    {
        public static void Seed(ContosoUniversityDbContext dbContext)
        {
            SeedSubjects(dbContext);
        }

        private static void SeedSubjects(ContosoUniversityDbContext dbContext)
        {
            if (dbContext.Subjects.Any())
                return;

            dbContext.AddRange(new List<Subject>
            {
                new("Arabic"),
                new("English"),
                new("Math 1"),
                new("Math 2"),
                new("Algebra"),
                new("Discrete Math"),
                new("Frensh"),
                new("Intro To Programming"),
                new("Logical Thinking"),
                new("Database Design"),
                new("Artificial Intelligence")
            });

            dbContext.SaveChanges();
        }
    }
}
