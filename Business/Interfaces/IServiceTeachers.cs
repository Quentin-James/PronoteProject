using Models.Models;

namespace Business.Interfaces;

public interface IServiceTeachers
{
    Task<Teacher?> GetByIdAsync(int id);

    Task<Teacher?> PostAsync(Teacher entity);

    Task<Teacher?> UpdateByIdAsync(int id, Teacher entity);

    Task<bool> DeleteAsync(int id);
}