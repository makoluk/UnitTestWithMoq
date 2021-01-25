using System.Collections.Generic;

namespace UnitTestWithMoq
{
    public class UserRepository : IUserRepository
    {
        public void Delete(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public User GetById(int userId)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(User user)
        {
            throw new System.NotImplementedException();
        }

        public void Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}