﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_DependencyInversionPrinciple.BusinessLogic
{
    interface IUserBusinessLogic
    {
        List<string> GetUsers();
    }
}
