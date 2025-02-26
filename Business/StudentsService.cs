using Business.Interfaces;
using DataAccess.Repository.Interfaces;
using Models.Models;

namespace Business;

internal class StudentsServices(IRepositoryStudents repositoryStudents) : IServiceStudents
{
    public async Task<IEnumerable<Student>> GetListAsync()
    {
        return await repositoryStudents.GetListAsync().ConfigureAwait(false);
    }

    public async Task<Student?> GetByIdAsync(int id)
    {
        return await repositoryStudents.GetByIdAsync(id).ConfigureAwait(false);
    }

    public async Task<Student?> PostAsync(Student entity)
    {
        return await repositoryStudents.PostAsync(entity).ConfigureAwait(false);
    }

    public async Task<Student?> UpdateByIdAsync(int id, Student entity)
    {
        return await repositoryStudents.UpdateByIdAsync(id, entity).ConfigureAwait(false);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await repositoryStudents.DeleteAsync(id).ConfigureAwait(false);
    }
}