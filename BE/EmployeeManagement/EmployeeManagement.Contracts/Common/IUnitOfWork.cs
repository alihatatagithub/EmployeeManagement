﻿using EmployeeManagement.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Contracts.Common
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }
        IIntegrationTradeRepository IntegrationTradeRepository { get; }
        Task SaveChangesAsync();

    }
}
