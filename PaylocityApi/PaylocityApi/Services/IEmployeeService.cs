﻿using PaylocityApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaylocityApi.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeCostToCompany>> GetEmployees();

        Task SaveEmployee(EmployeeCostToCompany employee);
    }
}
