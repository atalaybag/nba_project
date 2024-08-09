using EntitiyLayer.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.CQRS.Queries
{
    public class GetAllProductsQueryRequest: IRequest<List<ProductListDto>>
    {
    }
}
