using System;
using System.Collections.Generic;

namespace GuerreroWebAPIFINAL.CORE.Entities;

public partial class Course
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Credits { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; } = new List<Enrollment>();
}
