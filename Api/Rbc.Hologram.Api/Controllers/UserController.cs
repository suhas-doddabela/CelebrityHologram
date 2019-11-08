using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Interfaces.Contracts;

namespace Rbc.Hologram.Api.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase, IUserContract
    {
        private IUserContract uContract { get; set; }
        public UserController(IUserContract uContract)
        {
            this.uContract = uContract;
        }

        [Route("authenticate")]
        [HttpPost]
        public UserAuthenticationResponse Authenticate(UserAuthenticationRequest request)
        {
            return uContract.Authenticate(request);
        }

        [Route("{id}")]
        [HttpGet]
        [Authorize]
        public UserDto Get(int id)
        {
            return uContract.Get(id);
        }

        [Route("")]
        [HttpPost]
        public int Post(UserDto actionDto)
        {
            return uContract.Post(actionDto);
        }

        [Route("Search")]
        [HttpPost]
        [Authorize]
        public List<UserDto> Search(UserSearchRequest request)
        {
            return uContract.Search(request);
        }
    }
}