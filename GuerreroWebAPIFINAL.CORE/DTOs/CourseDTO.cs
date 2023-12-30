using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuerreroWebAPIFINAL.CORE.DTOs
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Credits { get; set; }
    }

    public class CourseInsertDTO
    {
        public string? Name { get; set; }
        public int? Credits { get; set; }
    }

    public class CourseUpdateDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Credits { get; set; }
    }
}
