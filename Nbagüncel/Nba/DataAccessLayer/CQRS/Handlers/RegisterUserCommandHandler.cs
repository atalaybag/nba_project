using DataAccessLayer.Abstract;
using DataAccessLayer.CQRS.Commands;
using DataAccessLayer.CQRS.Enums;
using EntitiyLayer.Login;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Handlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest>
    {
        private readonly IStoreRepository<AppUser> repository;

        public RegisterUserCommandHandler(IStoreRepository<AppUser> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(new AppUser
            {
                AppRoleID = (int)RoleType.Member,
                Password = request.Password,
                Username = request.Username,
            });
            return Unit.Value;
        }
    }
}
