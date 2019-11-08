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
    [Route("api/celebrityindustry")]
    [ApiController]
    [Authorize]
    public class CelebrityIndustryController : ControllerBase, ICelebrityIndustryContract
    {
        private ICelebrityIndustryContract cContract { get; set; }
        public CelebrityIndustryController(ICelebrityIndustryContract cContract)
        {
            this.cContract = cContract;
        }

        [Route("{id}")]
        [HttpGet]
        public CelebrityIndustryDto Get(int id)
        {
            return cContract.Get(id);
        }

        [Route("")]
        [HttpGet]
        public IEnumerable<CelebrityIndustryDto> Get()
        {
            return cContract.Get();
        }

        [Route("")]
        [HttpPost]
        public int Post(CelebrityIndustryDto actionDto)
        {
            return cContract.Post(actionDto);
        }

        [Route("{id}")]
        [HttpPut]
        public CelebrityIndustryDto Put(int id, CelebrityIndustryDto actiondto)
        {
            return cContract.Put(actiondto.CelebrityIndustryId, actiondto);
        }
    }
}