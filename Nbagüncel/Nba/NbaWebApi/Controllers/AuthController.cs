using DataAccessLayer.CQRS.Commands;
using DataAccessLayer.CQRS.Queries;
using DataAccessLayer.Infrastructure.Tools;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace NbaWebApi.Controllers
{
    
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    
    public class AuthController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterUserCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> SignIn(CheckUserQueryRequest request)
        {
            var userDto = await this.mediator.Send(request);
            if (userDto.IsExist)
            {
                var token = JwtTokenGenerator.GenareteToken(userDto);
                return Created("", token);
            }
            return BadRequest("Incorrect Username or Password");
        }
    }
}
