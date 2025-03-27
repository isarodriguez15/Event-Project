using Event__Project.Domains;
using Event__Project.Interfaces;
using Event__Project.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Event__Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PresencaEventosController : ControllerBase
    {
        private readonly IPresencaEventosRepository _presencaRepository;

        public PresencaEventosController(IPresencaEventosRepository presencaRepository)
        {
            _presencaRepository = presencaRepository;
        }
        /// <summary>
        /// Endpoint para deletar a presença
        /// </summary>
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _presencaRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public IActionResult Post(PresencaEventos presencaEventos)
        {
            try
            {
                _presencaRepository.Inscrever(presencaEventos);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint para buscar por Id a presença
        /// </summary>
        [HttpGet("BuscarPorId/{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                PresencaEventos novaPresenca = _presencaRepository.BuscarPorId(id);
                return Ok(novaPresenca);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint para atualizar as presenças
        /// </summary>
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, PresencaEventos presenca)
        {
            try
            {
                _presencaRepository.Atualizar(id, presenca);
                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        /// <summary>
        /// Endpoint para fazer uma lista das presenças
        /// </summary>
        [HttpGet("ListarPresencas")]
        public IActionResult Get()
        {
            try
            {
                List<PresencaEventos> listaPresencas = _presencaRepository.Listar();
                return Ok(listaPresencas);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        /// <summary>
        /// Endpoint para fazer uma lista das minhas presenças
        /// </summary>
        [HttpGet("ListarMinhasPresencas/{id}")]
        public IActionResult GetByMe(Guid id)
        {
            try
            {
                List<PresencaEventos> listaMinhasPresencas = _presencaRepository.ListarMinhasPresencas(id);
                return Ok(listaMinhasPresencas);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}