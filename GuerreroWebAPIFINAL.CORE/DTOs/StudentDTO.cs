using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuerreroWebAPIFINAL.CORE.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? IsActive { get; set; }
    }

    public class StudentInsertDTO
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? IsActive { get; set; }
    }

    public class StudentUpdateDTO
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? IsActive { get; set; }
    }
}
