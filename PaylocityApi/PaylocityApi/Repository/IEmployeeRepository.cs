﻿using PaylocityApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaylocityApi.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeCostToCompany>> GetEmployees();

        Task SaveEmployee(EmployeeCostToCompany employeeCostToCompany);
    }
}
