using GuerreroWebAPIFINAL.CORE.DTOs;
using GuerreroWebAPIFINAL.CORE.Entities;
using GuerreroWebAPIFINAL.CORE.Interfaces;

namespace GuerreroWebAPIFINAL.CORE.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository _repository;

        public EnrollmentService(IEnrollmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EnrollmentDTO>> GetAll()
        {
            var products = await _repository.GetAll();

            var productsDTO = products.Select(p => new EnrollmentDTO
            {
                Id = p.Id,
                CourseId = p.CourseId,
                StudentId = p.StudentId,
                Grade = p.Grade
            });

            return productsDTO;
        }

        public async Task<EnrollmentDTO> GetById(int id)
        {
            var product = await _repository.GetById(id);

            var productDTO = new EnrollmentDTO()
            {
                Id = product.Id,
                CourseId = product.CourseId,
                StudentId = product.StudentId,
                Grade = product.Grade
            };
            return productDTO;
        }

        public async Task<bool> Insert(EnrollmentInsertDTO enrollmentInsertDTO)
        {
            var enrollment = new Enrollment()
            {
                CourseId = enrollmentInsertDTO.CourseId,
                StudentId = enrollmentInsertDTO.StudentId,
                Grade = enrollmentInsertDTO.Grade
            };
            return await _repository.Insert(enrollment);
        }

        public async Task<bool> Update(EnrollmentUpdateDTO enrollmentUpdateDTO)
        {
            var enrollment = await _repository.GetById(enrollmentUpdateDTO.Id);
            if (enrollment == null)
                return false;

            enrollment.CourseId = enrollmentUpdateDTO.CourseId;
            enrollment.StudentId = enrollmentUpdateDTO.StudentId;
            enrollment.Grade = enrollmentUpdateDTO.Grade;

            return await _repository.Update(enrollment);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }


    }
}
