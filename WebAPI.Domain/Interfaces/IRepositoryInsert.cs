﻿using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Domain.Base;

namespace WebAPI.Domain.Interfaces
{
    public interface IRepositoryInsert<T>
        where T : BaseDomain
    {
        int Insert(T model);
    }
}
