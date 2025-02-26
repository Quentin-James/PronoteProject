using Business.Interfaces;
using DataAccess.Repository.Interfaces;
using Models.Models;

namespace Business;

internal class StudentsServices(IRepositoryStudents repositoryStudents) : IServiceStudents
{
    private readonly IRepositoryStudents _repositoryStudents = repositoryStudents;

    public async Task<IEnumerable<Student>> GetListAsync()
    {
        _repositoryStudents.Find(predicate: null, navigationPropertyPath: null, asNoTracking: true);
        return await _repositoryStudents.GetListAsync().ConfigureAwait(false);
    }

    public async Task<Student?> GetByIdAsync(int id)
    {
        return await _repositoryStudents.GetByIdAsync(id).ConfigureAwait(false);
    }

    public async Task<Student?> PostAsync(Student entity)
    {
        return await _repositoryStudents.PostAsync(entity).ConfigureAwait(false);
    }

    public async Task<Student?> UpdateByIdAsync(int id, Student entity)
    {
        return await _repositoryStudents.UpdateByIdAsync(id, entity).ConfigureAwait(false);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _repositoryStudents.DeleteAsync(id).ConfigureAwait(false);
    }
}