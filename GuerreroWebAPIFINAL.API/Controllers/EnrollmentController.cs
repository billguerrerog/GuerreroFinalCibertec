using GuerreroWebAPIFINAL.CORE.DTOs;
using GuerreroWebAPIFINAL.CORE.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuerreroWebAPIFINAL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;
        public EnrollmentController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _enrollmentService.GetAll();
            if(products == null)
                return NotFound();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _enrollmentService.GetById(id);
            if(product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] EnrollmentInsertDTO enrollmentInsertDTO)
        {
            var result = await _enrollmentService.Insert(enrollmentInsertDTO);
            if(!result)
                return BadRequest();
            
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] EnrollmentUpdateDTO enrollmentUpdateDTO)
        {
            if(id != enrollmentUpdateDTO.Id)
                return BadRequest();

            var result = await _enrollmentService.Update(enrollmentUpdateDTO);
            if(!result)
                return BadRequest();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        { 
            var result = await _enrollmentService.Delete(id);
            if(!result)
                return BadRequest();

            return Ok(result);
        }


    }
}
