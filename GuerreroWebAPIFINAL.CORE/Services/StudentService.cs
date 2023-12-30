using GuerreroWebAPIFINAL.CORE.DTOs;
using GuerreroWebAPIFINAL.CORE.Entities;
using GuerreroWebAPIFINAL.CORE.Interfaces;

namespace GuerreroWebAPIFINAL.CORE.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<StudentDTO>> GetAll()
        {
            var products = await _repository.GetAll();

            var productsDTO = products.Select(p => new StudentDTO
            {
                Id = p.Id,
                LastName = p.LastName,
                FirstName = p.FirstName,
                Email = p.Email,
                Password = p.Password,
                IsActive = p.IsActive

            });

            return productsDTO;
        }

        public async Task<StudentDTO> GetById(int id)
        {
            var product = await _repository.GetById(id);

            var productDTO = new StudentDTO()
            {
                Id = product.Id,
                LastName = product.LastName,
                FirstName = product.FirstName,
                Email = product.Email,
                Password = product.Password,
                IsActive = product.IsActive

            };
            return productDTO;
        }

        public async Task<bool> Insert(StudentInsertDTO studentInsertDTO)
        {
            var student = new Student()
            {
                LastName = studentInsertDTO.LastName,
                FirstName = studentInsertDTO.FirstName,
                Email = studentInsertDTO.Email,
                Password = studentInsertDTO.Password,
                IsActive = studentInsertDTO.IsActive
            };
            return await _repository.Insert(student);
        }

        public async Task<bool> Update(StudentUpdateDTO studentUpdateDTO)
        {
            var student = await _repository.GetById(studentUpdateDTO.Id);
            if (student == null)
                return false;

            student.LastName = studentUpdateDTO.LastName;
            student.FirstName = studentUpdateDTO.FirstName;
            student.Email = studentUpdateDTO.Email;
            student.Password = studentUpdateDTO.Password;
            student.IsActive = studentUpdateDTO.IsActive;

            return await _repository.Update(student);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }


    }
}
