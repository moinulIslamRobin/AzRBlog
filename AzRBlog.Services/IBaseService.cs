﻿using AzRBlog.Entities;
using System.Collections.Generic;

namespace AzRBlog.Services
{
    public interface IBaseService<T> where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
