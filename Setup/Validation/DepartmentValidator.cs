﻿using FluentValidation;
using FOS.DataLayer;
using FOS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.Setup.Validation
{
    public class DepartmentValidator : AbstractValidator<AdminData>
    {
        public DepartmentValidator()
        {
            //RuleFor(RH => RH.Name).NotEmpty().WithMessage("* Required");
            RuleFor(RH => RH.Name).Must(BeUniqueDepartment).WithMessage("Department Already Exist");
        }

        private bool BeUniqueDepartment(string strPhone1)
        {
            using (FOSDataModel dbContext = new FOSDataModel())
            {
                Boolean boolFlag = true;
                if (!String.IsNullOrEmpty(strPhone1))
                {
                    if (dbContext.Departments.FirstOrDefault(x => x.Name == strPhone1) == null) return true;
                    boolFlag = false;
                }
                return boolFlag;
            }
        }

    }
}
