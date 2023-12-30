using GuerreroWebAPIFINAL.CORE.DTOs;
using GuerreroWebAPIFINAL.CORE.Interfaces;

namespace GuerreroWebAPIFINAL.CORE.Interfaces
{
    public interface IStudentService
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<StudentDTO>> GetAll();
        Task<StudentDTO> GetById(int id);
        Task<bool> Insert(StudentInsertDTO studentInsertDTO);
        Task<bool> Update(StudentUpdateDTO studentUpdateDTO);
    }
}