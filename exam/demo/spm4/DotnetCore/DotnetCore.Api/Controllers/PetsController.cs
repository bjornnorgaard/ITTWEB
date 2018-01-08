using System.Linq;
using AutoMapper;
using DotnetCore.Api.Filters;
using DotnetCore.Api.Models;
using DotnetCore.Data;
using DotnetCore.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore.Api.Controllers
{
    [Route("api/pets")]
    public class PetsController : Controller
    {
        private readonly DotnetContext _context;
        private readonly IMapper _mapper;

        public PetsController(DotnetContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var pets = _context.Pets.Where(p => p.Id > 0);
            return Ok(pets);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var pet = _context.Pets.FirstOrDefault(p => p.Id == id);
            if (pet == null) return NotFound();
            var petGet = _mapper.Map<PetGet>(pet);
            return Ok(petGet);
        }

        [HttpPost, ValidateModel]
        public IActionResult Post([FromBody]PetPost petPost)
        {
            var pet = _mapper.Map<Pet>(petPost);
            _context.Pets.Add(pet);
            _context.SaveChanges();
            return Ok();
        }
    }
}
