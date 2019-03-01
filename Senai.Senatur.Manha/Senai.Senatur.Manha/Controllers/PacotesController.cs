using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.Manha.Domains;
using Senai.Senatur.Manha.Interfaces;
using Senai.Senatur.Manha.Repositories;

namespace Senai.Senatur.Manha.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PacotesController : ControllerBase
    {
        private IPacoteRepository PacoteRepository { get; set; }

        public PacotesController()
        {
            PacoteRepository = new PacoteRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(PacoteRepository.listaPacotes());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Pacotes pacote)
        {
            try
            {
                PacoteRepository.Cadastrar(pacote);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Put(Pacotes pacote)
        {
            try
            {
                PacoteRepository.Alterar(pacote);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult GetById(int Id)
        {
            try
            {
                PacoteRepository.BuscarPorId(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}