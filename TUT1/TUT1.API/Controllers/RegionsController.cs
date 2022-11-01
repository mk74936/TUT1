using Microsoft.AspNetCore.Mvc;
using TUT1.API.Models.Domain;
using TUT1.API.Repositories;

namespace TUT1.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        public RegionsController(IRegionRepository regionRepository)
        {
            this.RegionRepository = regionRepository;
        }

        public IRegionRepository RegionRepository { get; }

        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions=RegionRepository.GetAll();
            return Ok(regions);
        }
    } 
}
