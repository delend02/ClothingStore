using Microsoft.AspNetCore.Mvc;
using СlothingStore.API.Database.Repository;
using СlothingStore.API.Models.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace СlothingStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository UserRepository;

        public UserController(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await UserRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] long id)
        {
            return Ok(await UserRepository.GetByID(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserDTO user)
        {
            await UserRepository.Create(user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] long id)
        {
            await UserRepository.Delete(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UserDTO user)
        {
            await UserRepository.Update(user);
            return Ok();
        }
    }
}
