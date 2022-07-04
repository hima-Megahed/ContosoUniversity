using ContosoUniversity.Models.Subject;

namespace ContosoUniversity.Application.Interfaces;

public interface ISubjectsRepository
{
    public Task<List<Subject>> GetAllSubjects();
}
