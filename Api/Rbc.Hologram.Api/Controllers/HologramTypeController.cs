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
    [Route("api/hologramtype")]
    [ApiController]
    [Authorize]

    public class HologramTypeController : ControllerBase, IHologramTypeContract
    {
        private IHologramTypeContract htContract { get; set; }
        public HologramTypeController(IHologramTypeContract htContract)
        {
            this.htContract = htContract;
        }

        [Route("")]
        [HttpGet]
        public IEnumerable<HologramTypeDto> GetAll()
        {
            return htContract.GetAll();
        }
    }
}