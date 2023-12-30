using GuerreroWebAPIFINAL.CORE.Entities;

namespace GuerreroWebAPIFINAL.CORE.Interfaces
{
    public interface IEnrollmentRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Enrollment>> GetAll();
        Task<Enrollment> GetById(int id);
        Task<bool> Insert(Enrollment enrollment);
        Task<bool> Update(Enrollment enrollment);
    }
}