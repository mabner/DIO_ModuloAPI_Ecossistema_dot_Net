using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrilhaApiDesafio.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UsuarioController : ControllerBase
	{
		/*
		* Defines the method used in the URL to access
		* the resource. E.g. DataHora/ObterDataHoraAtual
		*/
		[HttpGet("ObterDataHoraAtual")]
		public IActionResult ObterDataHora()
		{
			var obj = new
			{
				Data = DateTime.Now.ToLongDateString(),
				Hora = DateTime.Now.ToShortTimeString()
			};
			return Ok(obj);
		}

		[HttpGet("Apresentar/{name}")]
		public IActionResult Apresentar(string name)
		{
			var message = $"Olá {name}, seja bem vindo!";
			return Ok(new { message });
		}
	}
}
