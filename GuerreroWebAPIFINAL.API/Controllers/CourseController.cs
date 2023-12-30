using GuerreroWebAPIFINAL.CORE.DTOs;
using GuerreroWebAPIFINAL.CORE.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuerreroWebAPIFINAL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _courseService.GetAll();
            if(products == null)
                return NotFound();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _courseService.GetById(id);
            if(product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] CourseInsertDTO courseInsertDTO)
        {
            var result = await _courseService.Insert(courseInsertDTO);
            if(!result)
                return BadRequest();
            
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CourseUpdateDTO courseUpdateDTO)
        {
            if(id != courseUpdateDTO.Id)
                return BadRequest();

            var result = await _courseService.Update(courseUpdateDTO);
            if(!result)
                return BadRequest();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        { 
            var result = await _courseService.Delete(id);
            if(!result)
                return BadRequest();

            return Ok(result);
        }


    }
}
