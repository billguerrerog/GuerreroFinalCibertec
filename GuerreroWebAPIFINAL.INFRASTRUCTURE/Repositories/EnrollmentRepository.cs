using GuerreroWebAPIFINAL.CORE.Entities;
using GuerreroWebAPIFINAL.CORE.Interfaces;
using GuerreroWebAPIFINAL.INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuerreroWebAPIFINAL.INFRASTRUCTURE.Repositories
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly GuerreroFinalCibertecContext _context;

        public EnrollmentRepository(GuerreroFinalCibertecContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Enrollment>> GetAll()
        {
            return await _context.Enrollments
                .ToListAsync();
        }

        public async Task<Enrollment> GetById(int id)
        {
            return await _context.Enrollments
                    .Where(x => x.Id == id)
                    .FirstOrDefaultAsync();
        }

        public async Task<bool> Insert(Enrollment enrollment)
        {
            await _context.Enrollments.AddAsync(enrollment);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Update(Enrollment enrollment)
        {
            _context.Enrollments.Update(enrollment);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var findEnrollment = await _context
                            .Enrollments
                            .Where(x => x.Id == id)
                            .FirstOrDefaultAsync();
            if (findEnrollment == null)
                return false;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

    }
}
