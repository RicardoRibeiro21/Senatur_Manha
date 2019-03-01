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
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository UsuarioRepository { get; set; }

        public UsuariosController()
        {
            UsuarioRepository = new UsuarioRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(UsuarioRepository.listaUsuarios());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult FazerLogin(Usuarios usuario)
        {            
            try
            {
                Usuarios usuarioBuscado = UsuarioRepository.BuscarPorEmailSenha(usuario.Email, usuario.Senha);
                return Ok(usuarioBuscado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
        }
    }
    }
}