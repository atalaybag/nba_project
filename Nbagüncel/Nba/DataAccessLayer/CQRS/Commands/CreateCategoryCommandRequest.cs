﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Commands
{
    public class CreateCategoryCommandRequest :IRequest
    {
        public string Definition { get; set; }
    }
}
