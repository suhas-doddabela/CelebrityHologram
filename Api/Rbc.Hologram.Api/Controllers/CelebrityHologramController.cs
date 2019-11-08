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
    [Route("api/celebrityhologram")]
    [ApiController]
    [Authorize]
    public class CelebrityHologramController : ControllerBase, ICelebrityHologramContract
    {
        private ICelebrityHologramContract cContract { get; set; }
        public CelebrityHologramController(ICelebrityHologramContract cContract)
        {
            this.cContract = cContract;
        }

        [Route("remove")]
        [HttpPost]
        public CelebrityHologramInsertResponse Delete(CelebrityHologramDeleteRequest request)
        {
            return cContract.Delete(request);
        }

        [Route("add")]
        [HttpPost]
        public CelebrityHologramInsertResponse Insert(CelebrityHologramInsertRequest request)
        {
            return cContract.Insert(request);
        }

        [Route("search")]
        [HttpPost]
        public List<CelebrityHologramSearchResponse> Search(CelebrityHologramSearchRequest request)
        {
            return cContract.Search(request);
        }
    }
}