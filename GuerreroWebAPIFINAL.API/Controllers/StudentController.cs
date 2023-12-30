using GuerreroWebAPIFINAL.CORE.DTOs;
using GuerreroWebAPIFINAL.CORE.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuerreroWebAPIFINAL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _studentService.GetAll();
            if(products == null)
                return NotFound();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _studentService.GetById(id);
            if(product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] StudentInsertDTO studentInsertDTO)
        {
            var result = await _studentService.Insert(studentInsertDTO);
            if(!result)
                return BadRequest();
            
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] StudentUpdateDTO studentUpdateDTO)
        {
            if(id != studentUpdateDTO.Id)
                return BadRequest();

            var result = await _studentService.Update(studentUpdateDTO);
            if(!result)
                return BadRequest();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        { 
            var result = await _studentService.Delete(id);
            if(!result)
                return BadRequest();

            return Ok(result);
        }


    }
}
