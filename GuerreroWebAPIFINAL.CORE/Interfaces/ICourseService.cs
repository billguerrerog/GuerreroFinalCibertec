using GuerreroWebAPIFINAL.CORE.DTOs;
using GuerreroWebAPIFINAL.CORE.Interfaces;

namespace GuerreroWebAPIFINAL.CORE.Interfaces
{
    public interface ICourseService
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<CourseDTO>> GetAll();
        Task<CourseDTO> GetById(int id);
        Task<bool> Insert(CourseInsertDTO courseInsertDTO);
        Task<bool> Update(CourseUpdateDTO courseUpdateDTO);
    }
}