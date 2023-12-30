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
    public class StudentRepository : IStudentRepository
    {
        private readonly GuerreroFinalCibertecContext _context;

        public StudentRepository(GuerreroFinalCibertecContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _context.Students
                .ToListAsync();
        }

        public async Task<Student> GetById(int id)
        {
            return await _context.Students
                    .Where(x => x.Id == id)
                    .FirstOrDefaultAsync();
        }

        public async Task<bool> Insert(Student student)
        {
            await _context.Students.AddAsync(student);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Update(Student student)
        {
            _context.Students.Update(student);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var findStudent = await _context
                            .Students
                            .Where(x => x.Id == id)
                            .FirstOrDefaultAsync();
            if (findStudent == null)
                return false;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

    }
}
