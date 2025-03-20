using Event__Project.Domains;
using Event__Project.Interfaces;
using Event__Project.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Event__Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposUsuariosController : ControllerBase
    {
        private readonly ITiposUsuarioRepository _tiposUsuariosRepository;

        public TiposUsuariosController(ITiposUsuarioRepository tiposUsuariosRepository)
        {
            _tiposUsuariosRepository = tiposUsuariosRepository;
        }
        //cadastrar
        [HttpPost]
        public IActionResult Post(TiposUsuario tiposUsuarios)
        {
            try
            {
                _tiposUsuariosRepository.Cadastrar(tiposUsuarios);
                return StatusCode(201, tiposUsuarios);
            }
            catch (Exception error)
            {

                return BadRequest(error.Message);
            }
        }
        //deletar
        [HttpDelete("{id}")]
        public IActionResult DeleteById(Guid id)
        {
            try
            {
                _tiposUsuariosRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }
        //listar
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<TiposUsuario> listaDosUsuarios = _tiposUsuariosRepository.Listar();
                return Ok(listaDosUsuarios);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        //buscar por id 
        [HttpGet("BuscarPorId/{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                TiposUsuario tiposUsuariosBuscado = _tiposUsuariosRepository.BuscarPorId(id);
                return Ok(tiposUsuariosBuscado);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        //atualizar 
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, TiposUsuario tiposUsuarios)
        {
            try
            {
                _tiposUsuariosRepository.Atualizar(id, tiposUsuarios);
                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
