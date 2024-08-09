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
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest>
    {
        private readonly IStoreRepository<Category> repository;

        public UpdateCategoryCommandHandler(IStoreRepository<Category> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await this.repository.GetByIDAsync(request.CategoryID);
            if (updatedEntity!=null)
            {
                updatedEntity.Definition = request.Definition;
                await this.repository.UpdateAsync(updatedEntity);
            }
            return Unit.Value;
        }
        
    }
}
