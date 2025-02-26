using Models.Models;

namespace Business.Interfaces
{
    public interface IServiceStudents
    {
        Task<IEnumerable<Student>> GetListAsync();

        Task<Student?> GetByIdAsync(int id);

        Task<Student?> PostAsync(Student entity);

        Task<Student?> UpdateByIdAsync(int id, Student entity);

        Task<bool> DeleteAsync(int id);
    }
}