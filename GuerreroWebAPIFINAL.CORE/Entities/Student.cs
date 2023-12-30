using System;
using System.Collections.Generic;

namespace GuerreroWebAPIFINAL.CORE.Entities;

public partial class Student
{
    public int Id { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; } = new List<Enrollment>();
}
