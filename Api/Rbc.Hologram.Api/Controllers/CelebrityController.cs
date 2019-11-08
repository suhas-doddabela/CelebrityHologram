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
    [Route("api/celebrity")]
    [ApiController]
    [Authorize]
    public class CelebrityController : ControllerBase, ICelebrityContract
    {
        private ICelebrityContract cContract { get; set; }
        public CelebrityController(ICelebrityContract cContract)
        {
            this.cContract = cContract;
        }

        [Route("{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            cContract.Delete(id);
        }

        [Route("{id}")]
        [HttpGet]
        public CelebrityDto Get(int id)
        {
            return cContract.Get(id);
        }

        [Route("")]
        [HttpPost]
        public int Post(CelebrityDto actionDto)
        {
            return cContract.Post(actionDto);
        }

        [Route("{id}")]
        [HttpPut]
        public CelebrityDto Put(int id, CelebrityDto actiondto)
        {
            return cContract.Put(actiondto.CelebrityId, actiondto);
        }
    }
}