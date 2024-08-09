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
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IStoreRepository<Product> repository;

        public UpdateProductCommandHandler(IStoreRepository<Product> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedProduct = await this.repository.GetByIDAsync(request.ProductID);
            if (updatedProduct!=null)
            {
                updatedProduct.CategoryID = request.CategoryID;
                updatedProduct.Price = request.Price;
                updatedProduct.Name = request.Name;
                await this.repository.UpdateAsync(updatedProduct);
            }
            return Unit.Value;
        }
    }
}
