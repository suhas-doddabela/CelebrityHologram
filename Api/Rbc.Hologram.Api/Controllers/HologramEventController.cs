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
    [Route("api/hologramevent")]
    [ApiController]
    [Authorize]
    public class HologramEventController : ControllerBase, IHologramEventContract
    {
        private IHologramEventContract htContract { get; set; }
        public HologramEventController(IHologramEventContract htContract)
        {
            this.htContract = htContract;
        }

        [Route("{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            htContract.Delete(id);
        }

        [Route("{id}")]
        [HttpGet]
        public HologramEventDto Get(int id)
        {
            return htContract.Get(id);
        }

        [Route("")]
        [HttpPost]
        public int Post(HologramEventDto actionDto)
        {
            return htContract.Post(actionDto);
        }

        [Route("{id}")]
        [HttpPut]
        public HologramEventDto Put(int id, HologramEventDto actiondto)
        {
            return htContract.Put(actiondto.HologramEventId, actiondto);
        }
    }
}