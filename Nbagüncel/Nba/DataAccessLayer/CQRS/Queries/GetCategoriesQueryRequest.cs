﻿using DataAccessLayer.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Queries
{
    public class GetCategoriesQueryRequest :IRequest<List<CategoryListDto>>
    {
    }
}
