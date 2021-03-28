using AutoMapper;
using MarvelAPI.Api.ViewModels;
using MarvelAPI.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        public async Task<string> Get()
        {
            try
            {
                var characters = _mapper.Map<IEnumerable<CharacterViewModel>>(await _characterRepository.ObterTodosComDetalhes());
                return JsonConvert.SerializeObject(characters);
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject("");
            }
        }
    }
}
