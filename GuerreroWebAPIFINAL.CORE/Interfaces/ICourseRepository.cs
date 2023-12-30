using GuerreroWebAPIFINAL.CORE.Entities;

namespace GuerreroWebAPIFINAL.CORE.Interfaces
{
    public interface ICourseRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Course>> GetAll();
        Task<Course> GetById(int id);
        Task<bool> Insert(Course course);
        Task<bool> Update(Course course);
    }
}