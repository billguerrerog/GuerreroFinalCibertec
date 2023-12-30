using GuerreroWebAPIFINAL.CORE.DTOs;
using GuerreroWebAPIFINAL.CORE.Entities;
using GuerreroWebAPIFINAL.CORE.Interfaces;

namespace GuerreroWebAPIFINAL.CORE.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;

        public CourseService(ICourseRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<CourseDTO>> GetAll()
        {
            var products = await _repository.GetAll();

            var productsDTO = products.Select(p => new CourseDTO
            {
                Id = p.Id,
                Name = p.Name,
                Credits = p.Credits
            });

            return productsDTO;
        }

        public async Task<CourseDTO> GetById(int id)
        {
            var product = await _repository.GetById(id);

            var productDTO = new CourseDTO()
            {
                Id = product.Id,
                Name = product.Name,
                Credits = product.Credits
            };
            return productDTO;
        }

        public async Task<bool> Insert(CourseInsertDTO courseInsertDTO)
        {
            var course = new Course()
            {
                Name = courseInsertDTO.Name,
                Credits = courseInsertDTO.Credits
            };
            return await _repository.Insert(course);
        }

        public async Task<bool> Update(CourseUpdateDTO courseUpdateDTO)
        {
            var course = await _repository.GetById(courseUpdateDTO.Id);
            if (course == null)
                return false;
            
            course.Name = courseUpdateDTO.Name;
            course.Credits = courseUpdateDTO.Credits;

            return await _repository.Update(course);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }


    }
}
