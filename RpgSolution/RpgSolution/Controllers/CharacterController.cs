using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RpgSolution.Models;

namespace RpgSolution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character
            {
                Id = 2,
                Name = "Emir",
                Class = RpgClass.Cleric
            }
        };

        public IActionResult Get()
        {
            return Ok(knight);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(characters);
        }

        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(characters);
        }
    }
}