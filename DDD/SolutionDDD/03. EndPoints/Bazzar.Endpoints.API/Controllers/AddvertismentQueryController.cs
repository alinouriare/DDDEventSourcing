using Bazzar.Core.Domain.Advertisements.Data;
using Bazzar.Core.Domain.Advertisements.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bazzar.Endpoints.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddvertismentQueryController : ControllerBase
    {
        private readonly IAdvertisementQueryService advertisementQueryService;

        public AddvertismentQueryController(IAdvertisementQueryService advertisementQueryService)
        {
            this.advertisementQueryService = advertisementQueryService;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] GetActiveAdvertisement request)
        {
            return new OkObjectResult(advertisementQueryService.Query(request));
        }

        //[HttpGet]
        //public IActionResult Get([FromQuery]GetActiveAdvertisementList request)
        //{
        //    return new OkObjectResult(advertisementQueryService.Query(request));
        //}
    }
}
