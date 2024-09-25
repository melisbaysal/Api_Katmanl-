﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AbstractRepositories
{
    public interface IAuthorRepository
    {
        Task<Author>GetAuthorWithBooks(int id);   
    }
}
