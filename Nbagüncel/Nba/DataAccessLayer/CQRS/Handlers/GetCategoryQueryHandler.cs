using AutoMapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.CQRS.Queries;
using DataAccessLayer.Dto;
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
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQueryRequest, CategoryListDto>
    {
        private readonly IStoreRepository<Category> repository;
        private readonly IMapper mapper;

        public GetCategoryQueryHandler(IStoreRepository<Category> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<CategoryListDto> Handle(GetCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(x => x.CategoryID == request.CategoryID);
            return this.mapper.Map<CategoryListDto>(data);
        }
    }
}
