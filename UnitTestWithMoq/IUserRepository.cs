﻿using System.Collections.Generic;

namespace UnitTestWithMoq
{
    public interface IUserRepository
    {
        List<User> GetAll();

        User GetById(int userId);

        void Insert(User user);

        void Update(User user);

        void Delete(int Id);
    }
}