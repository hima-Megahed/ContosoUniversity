using ContosoUniversity.Application.Interfaces;
using ContosoUniversity.Models.Subject;
using ContosoUniversity.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Repositories
{
    public class SubjectsRepository : ISubjectsRepository
    {
        private readonly ContosoUniversityDbContext _context;

        public SubjectsRepository(ContosoUniversityDbContext context)
        {
            _context = context;
        }

        public async Task<List<Subject>> GetAllSubjects()
        {
            return await _context.Subjects.ToListAsync();
        }
    }
}
