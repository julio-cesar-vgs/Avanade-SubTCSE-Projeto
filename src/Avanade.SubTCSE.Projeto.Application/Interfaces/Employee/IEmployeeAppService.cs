﻿using Avanade.SubTCSE.Projeto.Application.Dtos.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Services.Employee
{
  public interface IEmployeeAppService
    {
        Task<EmployeeDto> AddEmployee(EmployeeDto employeeDto);
    }
}
