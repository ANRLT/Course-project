using CourseProject.DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<int> AddAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteManyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
