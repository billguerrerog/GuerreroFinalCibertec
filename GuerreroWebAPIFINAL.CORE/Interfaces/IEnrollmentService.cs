using GuerreroWebAPIFINAL.CORE.DTOs;
using GuerreroWebAPIFINAL.CORE.Interfaces;

namespace GuerreroWebAPIFINAL.CORE.Interfaces
{
    public interface IEnrollmentService
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<EnrollmentDTO>> GetAll();
        Task<EnrollmentDTO> GetById(int id);
        Task<bool> Insert(EnrollmentInsertDTO enrollmentInsertDTO);
        Task<bool> Update(EnrollmentUpdateDTO enrollmentUpdateDTO);
    }
}