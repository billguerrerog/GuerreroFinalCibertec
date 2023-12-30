using GuerreroWebAPIFINAL.CORE.Entities;

namespace GuerreroWebAPIFINAL.CORE.Interfaces
{
    public interface IStudentRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetById(int id);
        Task<bool> Insert(Student student);
        Task<bool> Update(Student student);
    }
}