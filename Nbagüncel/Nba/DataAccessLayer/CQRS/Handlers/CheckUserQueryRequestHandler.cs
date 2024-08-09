using DataAccessLayer.Abstract;
using DataAccessLayer.CQRS.Queries;
using DataAccessLayer.Dto;
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
    public class CheckUserQueryRequestHandler : IRequestHandler<CheckUserQueryRequest, CheckUserResponseDto>
    {
        private readonly IStoreRepository<AppUser> userRepository;
        private readonly IStoreRepository<AppRole> roleRepository;

        public CheckUserQueryRequestHandler(IStoreRepository<AppUser> userRepository, IStoreRepository<AppRole> roleRepository)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
        }

        public async Task<CheckUserResponseDto> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = new CheckUserResponseDto();
            var user = await this.userRepository.GetByFilterAsync(x => x.Username == request.Username && x.Password == request.Password);
            if (user==null)
            {
                dto.IsExist = false;
            }
            else
            {
                dto.Username = user.Username;
                dto.Id = user.AppUserID;
                dto.IsExist = true;
                var role = await this.roleRepository.GetByFilterAsync(x => x.AppRoleID == user.AppRoleID);
                dto.Role = role.Definition;
            }
            
            
            return dto;
        }
    }
}
