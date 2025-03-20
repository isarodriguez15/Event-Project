using Event__Project.Domains;
using Event__Project.Interfaces;
using Event__Project.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Event__Project.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposEventosController : ControllerBase
    {
        private readonly ITipoEventosRepository _tiposEventosRepository;
        public TiposEventosController(ITipoEventosRepository tiposEventosRepository)
        {
            _tiposEventosRepository = tiposEventosRepository;
        }
        //cadastrar
        [HttpPost]
        public IActionResult Post(TipoEventos tiposEventos)
        {
            try
            {
                _tiposEventosRepository.Cadastrar(tiposEventos);

                return Created();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        //deletar
        [HttpDelete("{id}")]
        public IActionResult DeleteById(Guid id)
        {
            try
            {
                _tiposEventosRepository.Deletar(id);
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
                List<TipoEventos> listaDeEventos = _tiposEventosRepository.Listar();
                return Ok(listaDeEventos);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        //BuscarPorId 
        [HttpGet("BuscarPorId/{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                TipoEventos tiposEventosBuscado = _tiposEventosRepository.BuscarPorId(id);
                return Ok(tiposEventosBuscado);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


        [HttpPut("{id}")]
        public IActionResult Put(Guid id, TipoEventos tiposEventos)
        {
            try
            {
                _tiposEventosRepository.Atualizar(id, tiposEventos);

                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

    }
}
