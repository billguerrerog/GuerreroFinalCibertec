using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuerreroWebAPIFINAL.CORE.DTOs
{
    public class EnrollmentDTO
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public int? Grade { get; set; }
    }

    public class EnrollmentInsertDTO
    {
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public int? Grade { get; set; }
    }

    public class EnrollmentUpdateDTO
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public int? Grade { get; set; }
    }
}
