using Design_XCorePro.Model;
using Design_XCorePro.Repository.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Design_XCorePro.Repository.Services
{
    public class ServiceStudent : InterfaceStudent
    {
        private AddDbContext _dbContext;

        public ServiceStudent(AddDbContext dbContext)
        {
            _dbContext=dbContext;
        }
        public async Task<List<Student>> GetStdList()
        {
            var slist = await _dbContext.Students.ToListAsync();
            return slist;
        }


        public async Task<Student> AddStudent(Student student)
        {
            _dbContext.Students.Add(student);
            await _dbContext.SaveChangesAsync();
            return student;
        }

        public async Task<Student> DeleteStudent(int Id)
        {
            var result = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == Id);
            if (result == null)
            {
                return null;
            }

            _dbContext.Students.Remove(result);
            await _dbContext.SaveChangesAsync();
            return result;
        }

        public async Task<Student> UpdateStudent(Student student)
        {
            _dbContext.Entry(student).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return student;
        }
    }
}
