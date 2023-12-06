using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;

namespace Revisao.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class JogoMegaSenaController : ControllerBase
	{

		private readonly IRegistroJogoService _registroJogoService;
		private readonly IMapper _mapper;

		public JogoMegaSenaController(IRegistroJogoService registroJogoService, IMapper mapper)
		{
			_registroJogoService = registroJogoService;
			_mapper = mapper;
		}

		[HttpGet(Name = "ObterTodos")]
        public IActionResult Get()
        {
            return Ok(_registroJogoService.ObterTodos() ?? new List<RegistroJogoViewModel>());
        }


        [HttpPost(Name = "RegistrarNovoJogo")]
		public async Task<IActionResult> RegistrarNovoJogo(NovoRegistroJogoViewModel registroJogoViewModel)
		{
			return Ok(_registroJogoService.RegistrarJogo(registroJogoViewModel));
		}
	}
}
