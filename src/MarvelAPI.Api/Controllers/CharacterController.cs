using AutoMapper;
using MarvelAPI.Api.ViewModels;
using MarvelAPI.Api.ViewModels.Utils;
using MarvelAPI.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelAPI.Api.Controllers
{
    [Route("v1/public/characters")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly IMapper _mapper;
        public CharacterController(ICharacterRepository characterRepository, IMapper mapper)
        {
            _characterRepository = characterRepository;
            _mapper = mapper;
        }
        [HttpGet()]
        public async Task<string> ObterTodos()
        {
            try
            {
                var characters = await _characterRepository.ObterTodosComDetalhes();

                if (!characters.Any())
                    return JsonConvert.SerializeObject(PopularErrorViewModel(EHttpStatusCode.NotFound, MessageConstants.PersonagensNaoLocalizados, string.Empty), Formatting.Indented);

                return JsonConvert.SerializeObject(_mapper.Map<IEnumerable<CharacterViewModel>>(characters), Formatting.Indented);
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(PopularErrorViewModel(EHttpStatusCode.BadRequest, ex.Message, string.Empty), Formatting.Indented);
            }

        }
        private ErrorViewModel PopularErrorViewModel(EHttpStatusCode statusCode, string message, string userInput)
        {
            return new ErrorViewModel() { StatusCode = (int)statusCode, Message = message, UserInput = userInput };
        }
    }
}
