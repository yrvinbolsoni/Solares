using Application.Interface;
using Domain.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Solares.Controllers
{
    [Route("[controller]Aluno")]
    [ApiController]
    public class AlunoController : Controller
    {
        private readonly IApplicationServiceAluno _applicationServiceAluno;

        public AlunoController(IApplicationServiceAluno  ApplicationServiceAluno)
        {
            _applicationServiceAluno = ApplicationServiceAluno;
        }


        [HttpGet("GetAll")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult<IEnumerable<string>> GetAllAlunos()
        {
            try
            {
                return Ok(_applicationServiceAluno.GetAll());

            }
            catch (Exception ex)
            {
                return BadRequest($"Algo deu errado {ex.Message}");
            }

        }


        [HttpGet("GetAllPag")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult<IEnumerable<string>> GetAllPag(int skip = 0 , int take = 10)
        {
            try
            {
                return Ok(_applicationServiceAluno.GetAllPag(skip , take));

            }
            catch (Exception ex)
            {
                return BadRequest($"Algo deu errado {ex.Message}");
            }

        }



        [HttpGet("{Id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult<string> GetById(int Id)
        {
            try
            {
                var aluno = _applicationServiceAluno.GetById(Id);
                return aluno.Id > 0 ? Ok(aluno) : NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest($"Algo deu errado {ex.Message}");
            }

        }


        [HttpPost("Add")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult Post([FromBody] AlunoDTO alunoDTO)
        {
            try
            {
                if (alunoDTO == null)
                    return NotFound();

                if (alunoDTO.Id > 0)
                    return BadRequest($"esperado que o id seja 0 ");

                    _applicationServiceAluno.Add(alunoDTO);
                return Ok("Aluno Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                return BadRequest($"Algo deu errado {ex.Message}");
            }


        }



        [HttpPut("Update")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult Put([FromBody] AlunoDTO alunoDTO)
        {
            try
            {
                if (alunoDTO == null)
                    return NotFound();

                _applicationServiceAluno.Update(alunoDTO);
                return Ok("Aluno Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Algo deu errado {ex.Message}");
            }
        }


        [HttpDelete("Delete")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult Delete([FromBody] AlunoDTO alunoDTO)
        {
            try
            {
                if (alunoDTO == null)
                    return NotFound();

                _applicationServiceAluno.Remove(alunoDTO);

                return Ok("Aluno Removido com sucesso!");
            }

            catch (Exception ex)
            {

                return BadRequest($"Algo deu errado {ex.Message}");
            }

        }

    }
}
