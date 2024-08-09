using AutoMapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.CQRS.Queries;
using EntitiyLayer.Dto;
using MediatR;
using NbaWebApi.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Handlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQueryRequest, ProductListDto>
    {
        private readonly IStoreRepository<Product> repository;
        private readonly IMapper mapper;

        public GetProductQueryHandler(IStoreRepository<Product> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ProductListDto> Handle(GetProductQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(x => x.ProductID == request.Id);
            return this.mapper.Map<ProductListDto>(data);
        }
    }
}
