using DataAccessLayer.Abstract;
using DataAccessLayer.CQRS.Commands;
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
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest>
    {
        private readonly IStoreRepository<Product> repository;

        public CreateProductCommandHandler(IStoreRepository<Product> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(new Product
            {
                CategoryID = request.CategoryID,
                Name = request.Name,
                Price = request.Price
            });
            return Unit.Value;
        }
    }
}
