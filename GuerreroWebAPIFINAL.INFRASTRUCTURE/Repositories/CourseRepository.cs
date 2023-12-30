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
    public class CourseRepository : ICourseRepository
    {
        private readonly GuerreroFinalCibertecContext _context;

        public CourseRepository(GuerreroFinalCibertecContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Course>> GetAll()
        {
            return await _context.Courses
                .ToListAsync();
        }

        public async Task<Course> GetById(int id)
        {
            return await _context.Courses
                    .Where(x => x.Id == id)
                    .FirstOrDefaultAsync();
        }

        public async Task<bool> Insert(Course course)
        {
            await _context.Courses.AddAsync(course);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Update(Course course)
        {
            _context.Courses.Update(course);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var findCourse = await _context
                            .Courses
                            .Where(x => x.Id == id)
                            .FirstOrDefaultAsync();
            if (findCourse == null)
                return false;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

    }
}
