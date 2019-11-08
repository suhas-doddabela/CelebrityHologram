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
    [Route("api/celebritygroup")]
    [ApiController]
    [Authorize]
    public class CelebrityGroupController : ControllerBase, ICelebrityGroupContract
    {
        private ICelebrityGroupContract cContract { get; set; }
        public CelebrityGroupController(ICelebrityGroupContract cContract)
        {
            this.cContract = cContract;
        }

        [Route("{id}")]
        [HttpGet]
        public CelebrityGroupDto Get(int id)
        {
            return cContract.Get(id);
        }

        [Route("")]
        [HttpGet]
        public IEnumerable<CelebrityGroupDto> Get()
        {
            return cContract.Get();
        }


        [Route("")]
        [HttpPost]
        public int Post(CelebrityGroupDto actionDto)
        {
            return cContract.Post(actionDto);
        }

        [Route("{id}")]
        [HttpPut]
        public CelebrityGroupDto Put(int id, CelebrityGroupDto actiondto)
        {
            return cContract.Put(id, actiondto);
        }
    }
}