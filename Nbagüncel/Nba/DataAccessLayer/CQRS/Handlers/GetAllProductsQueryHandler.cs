using AutoMapper;
using DataAccessLayer.Abstract;
using EntitiyLayer.CQRS.Queries;
using EntitiyLayer.Dto;
using MediatR;
using NbaWebApi.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EntitiyLayer.CQRS.Handlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, List<ProductListDto>>
    {
        private readonly IStoreRepository<Product> rep;
        private readonly IMapper mapper;
        public GetAllProductsQueryHandler(IStoreRepository<Product> rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public async Task<List<ProductListDto>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var data =  await this.rep.GetAllAsync();
            return this.mapper.Map<List<ProductListDto>>(data);
        }
    }
}
