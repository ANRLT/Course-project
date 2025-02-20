using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Repositories.IRepositories
{
    public interface IUserRepository
    {
        public Task<int> AddAsync();
        public Task<int> UpdateAsync();
        public Task<int> DeleteByIdAsync(int id);
        public Task<int> DeleteManyByIdAsync(int id);
        public Task<int> GetByIdAsync(int id);
        public Task<int> GetAllAsync();
    }
}
